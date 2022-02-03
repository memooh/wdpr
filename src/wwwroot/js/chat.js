"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
var messageContentHolder = document.getElementById("messageContent");
var link = '/api/Chat/';
var list = document.getElementById('myList');

connection.on("ReceiveMessage", function (user, message) {
    var Sender = document.getElementById("currentSender").value;

    const obj = {verzender: user, beschrijving: message, isVerzender: Sender == "true" ? true : false};

    document.getElementById("currentSender").value = "false";
    messageContentHolder.append(GenerateMessageBlob(obj));
});

connection.start().then(() => {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("currentUser").value;
    var message = document.getElementById("messageInput").value;
    var Sender = document.getElementById("currentSender").value;
    var ChatId = document.getElementById("currentSelected").value;
    
    document.getElementById("currentSender").value = "true";

    fetch(link + "Bericht", { 
        method: "post", 
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            ChatId: ChatId,
            Bericht: message
            }),
        })

        var objDiv = document.getElementById("messageContent");
        objDiv.scrollTop = objDiv.scrollHeight;
        
        document.getElementById("messageInput").value = '';

        connection.invoke("SendMessage", user, message, document.getElementById("currentSelected").value.toString()).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();
});

list.addEventListener('click', function(evt){
    connection.onclose(connection.invoke("RemoveFromGroup", document.getElementById("currentSelected").value));
    var chatInput = document.getElementById("chatInput");
    var messageInput = document.getElementById("messageInput");

    if(evt.target.getAttribute("data-user-is-blocked") == "True") {
        messageInput.disabled = true;
        messageInput.value = "Helaas, je bent geblokkeerd!";
        document.getElementById("sendButton").style.display = "none";
    } else {
        messageInput.disabled = false;
        messageInput.value = "";
        document.getElementById("sendButton").style.display = "block";
    }

    chatInput.style.display = 'flex';
    document.getElementById("currentSelected").value = evt.target.getAttribute("data-chat-link-id");
    connection.invoke("AddToGroup", document.getElementById("currentSelected").value)

    GetMessages(evt);

    if(document.getElementById("IsBehandelaar").value == "True") {
        fetch(link + "Geblokkeerd?" + new URLSearchParams({ChatId: evt.target.getAttribute("data-chat-link-id")}))
            .then(data => data.json())
            .then(data => {
                if(data.length) {
                    document.getElementById("block-alert").innerHTML = "De volgende gebruikers zijn geblokkeerd van de chat: " + data.toString();
                    document.getElementById("block-alert").style.display = "block";
                }
            });
    }
});

async function GetMessages(Element) {
    var ChatId = Element.target.getAttribute("data-chat-link-id");

    fetch(link + ChatId)
    .then(data => data.json())
    .then(data => UpdateMessages(data));
}

function UpdateMessages(data) {
    while (messageContentHolder.firstChild) {
        messageContentHolder.removeChild(messageContentHolder.lastChild);
    }

    data.forEach(obj => {
       messageContentHolder.append(GenerateMessageBlob(obj));
    });

    var elements = document.getElementsByClassName("report");

    for (var i = 0; i < elements.length; i++) {
        elements[i].addEventListener('click', (evt) => {
            var reportedMessage = document.getElementById("reportedMessage");
            reportedMessage.value = evt.target.getAttribute("data-report-id");

            document.getElementById("confirmReport").addEventListener('click', () => {
            if(document.getElementById("meldingInput").value != '') {
                fetch(link + "Melding", { 
                    method: "post", 
                    headers: {
                      'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        BerichtId: evt.target.getAttribute("data-report-id"),
                        Bericht: document.getElementById("meldingInput").value
                        }),
                    });
                }
            });

            document.getElementById("meldingInput").value = '';
        }, false);
    }

    var objDiv = document.getElementById("messageContent");
    objDiv.scrollTop = objDiv.scrollHeight;
}

function GenerateMessageBlob(obj) {
    var div = document.createElement("div");
    div.className = "card-outline w-100 h-25";
    
    var leftOrRight = obj.isVerzender ? "right" : "left";

    var innerHTML = 
        `<p class="text-${leftOrRight}"> ${obj.isVerzender ? 'U' : obj.verzender}
        <div class="card d-inline-block float-${leftOrRight}" style="background-color: ${obj.isVerzender ? 'white' : 'lightgray'};">`;
    if(!obj.isVerzender) {
        innerHTML += 
        `<a class="report" onclick="javascript:void(0);"data-toggle="modal" data-target="#exampleModal">
        <i class="fas fa-bug" data-report-id="${obj.berichtId}" style="position: absolute;left: 88%;bottom: 83%;font-size: 20px; cursor: pointer;">Meld</i>
        </a>`;
        console.log(innerHTML);
    }

    innerHTML += `    
            <div class="card-body">
                ${obj.beschrijving}
            </div>
        </div>`;

    div.innerHTML = innerHTML;

    return div;
}