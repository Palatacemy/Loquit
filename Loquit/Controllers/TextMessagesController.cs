using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loquit.Data;
using Loquit.Data.Entities.MessageTypes;
using Loquit.Services.Abstractions.MessageTypesAbstractions;
using Loquit.Services.DTOs.MessageTypesDTOs;

namespace Loquit.Web.Controllers
{
    public class TextMessagesController : Controller
    {
        private readonly ITextMessageService _textMessageService;

        public TextMessagesController(ITextMessageService textMessageService)
        {
            _textMessageService = textMessageService;
        }

        // GET: TextMessages
        public async Task<IActionResult> Index()
        {
            return View(await _textMessageService.GetTextMessagesAsync());
        }

        // GET: TextMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textMessage = await _textMessageService.GetTextMessageByIdAsync(id.Value);
            if (textMessage == null)
            {
                return NotFound();
            }

            return View(textMessage);
        }

        // GET: TextMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TextMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,TimeOfSending,SenderIdInChat,Id")] TextMessageDTO textMessage)
        {
            if (ModelState.IsValid)
            {
                await _textMessageService.AddTextMessageAsync(textMessage);
                return RedirectToAction(nameof(Index));
            }
            return View(textMessage);
        }

        // GET: TextMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textMessage = await _textMessageService.GetTextMessageByIdAsync(id.Value);
            if (textMessage == null)
            {
                return NotFound();
            }
            return View(textMessage);
        }

        // POST: TextMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Text,TimeOfSending,SenderIdInChat,Id")] TextMessageDTO textMessage)
        {
            if (id != textMessage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _textMessageService.UpdateTextMessageAsync(textMessage);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await TextMessageExists(textMessage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(textMessage);
        }

        // GET: TextMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var textMessage = await _textMessageService.GetTextMessageByIdAsync(id.Value);
            if (textMessage == null)
            {
                return NotFound();
            }

            return View(textMessage);
        }

        // POST: TextMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var textMessage = await _textMessageService.GetTextMessageByIdAsync(id);
            if (textMessage != null)
            {
                await _textMessageService.DeleteTextMessageByIdAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> TextMessageExists(int id)
        {
            var textMessage = await _textMessageService.GetTextMessageByIdAsync(id);
            return textMessage != null;
        }
    }
}
