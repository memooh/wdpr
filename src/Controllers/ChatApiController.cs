using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

[Route("api/Chat")]
[ApiController]
public class ChatApiController : Controller 
{
    private readonly KliniekContext _context;
    private readonly UserManager<Gebruiker> _userManager;

    public ChatApiController(KliniekContext context, UserManager<Gebruiker> userManager)
    {
        _context = context;
        _userManager = userManager;

    }

    // [HttpGet("{ChatId}")]
    // public async Task<ActionResult<List<MessageViewModel>>> GetBerichten (int ChatId)
    // {
    //     List<Bericht> Berichten = await _context.Berichten.Where(b => b.Chat.Id == ChatId).OrderBy(b => b.Datum).ToListAsync();
    //     _context.Berichten.Include(b => b.Verzender);

    //     List<MessageViewModel> messageViewModels = new List<MessageViewModel>();
    //     foreach (var item in Berichten)
    //     {
    //         messageViewModels.Add(new MessageViewModel(item));
    //     }

    //     return messageViewModels;
    // }

    [HttpGet("{ChatId}")]
    public async Task<ActionResult<List<MessageViewModel>>> GetBerichten (int ChatId)
    {
        List<Bericht> Berichten = await _context.Berichten
                                                          .Include(b => b.Deelname)
                                                          .ThenInclude(b => b.Chat)
                                                          .Include(b => b.Deelname)
                                                          .ThenInclude(b => b.Client)                                                          
                                                          .Where(b => b.Deelname.Chat.Id == ChatId)
                                                          .OrderByDescending(b => b.Datum)
                                                          .ToListAsync();
                                                          
        List<MessageViewModel> messageViewModels = new List<MessageViewModel>();
        foreach (var item in Berichten)
        {
            messageViewModels.Add(new MessageViewModel(item, await _userManager.GetUserAsync(HttpContext.User)));
        }

        return messageViewModels;
    }

    [Route("Bericht")]
    [HttpPost]
    public async Task SetBericht (MessageModel messageModel)
    {
        Chat BerichtChat = await _context.Chats.Include(c => c.Deelnames).SingleAsync(c => c.Id == messageModel.ChatId);
        Gebruiker User = await _userManager.GetUserAsync(HttpContext.User);
        Deelname d = await _context.Deelnames.Include(d => d.Client).SingleAsync(d => d.Client.Id == User.Id && d.Chat.Id == messageModel.ChatId);
        _context.Berichten.Add(
            new Bericht {
                Chat = BerichtChat, 
                Beschrijving = messageModel.Bericht,
                Datum = new DateTime(),
                Deelname = d
                }
            );

        await _context.SaveChangesAsync();
    }

    [Route("Melding")]
    [HttpPost]
    public async Task Melding (MeldingModel meldingModel) 
    {
        Bericht BerichtChat = await _context.Berichten.Include(b => b.Deelname).ThenInclude(d => d.Client).SingleAsync(c => c.Id == meldingModel.BerichtId);
        _context.Meldingen.Add(
            new Melding {
                Beschrijving = "[" + BerichtChat.Deelname.Client.Email + "] is gerapporteerd voor = " +  meldingModel.Bericht,
                Datum = new DateTime(),
                Bericht = BerichtChat
                }
        );

        await _context.SaveChangesAsync();
    }

    [Route("Geblokkeerd")]
    public async Task<ActionResult<List<string>>> GetGeblokkeerde (int ChatId)
    {
        Chat chat = await _context.Chats.Include(c => c.Deelnames).ThenInclude(d => d.Client).SingleAsync(c => c.Id == ChatId);
        
        List<string> GeblokkeerdeNamen = new List<string>();

         foreach (var item in chat.Deelnames)
         {
             if(item.Geblokkeerd) {
                GeblokkeerdeNamen.Add(item.Client.Email);
             }
         }                                                   

        return GeblokkeerdeNamen;
    }
}