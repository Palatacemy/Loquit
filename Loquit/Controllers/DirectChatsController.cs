using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loquit.Data;
using Loquit.Data.Entities.ChatTypes;
using Loquit.Services.Abstractions.ChatTypesAbstractions;
using Loquit.Services.DTOs.ChatTypesDTOs;

namespace Loquit.Web.Controllers
{
    public class DirectChatsController : Controller
    {
        private readonly IDirectChatService _directChatService;

        public DirectChatsController(IDirectChatService directChatService)
        {
            _directChatService = directChatService;
        }

        // GET: DirectChats
        public async Task<IActionResult> Index()
        {
            return View(await _directChatService.GetDirectChatsAsync());
        }

        // GET: DirectChats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directChat = await _directChatService.GetDirectChatByIdAsync(id.Value);
            if (directChat == null)
            {
                return NotFound();
            }

            return View(directChat);
        }

        // GET: DirectChats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DirectChats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] DirectChatDTO directChat)
        {
            if (ModelState.IsValid)
            {
                await _directChatService.AddDirectChatAsync(directChat);
                return RedirectToAction(nameof(Index));
            }
            return View(directChat);
        }

        // GET: DirectChats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directChat = await _directChatService.GetDirectChatByIdAsync(id.Value);
            if (directChat == null)
            {
                return NotFound();
            }
            return View(directChat);
        }

        // POST: DirectChats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] DirectChatDTO directChat)
        {
            if (id != directChat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _directChatService.UpdateDirectChatAsync(directChat);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await DirectChatExists(directChat.Id))
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
            return View(directChat);
        }

        // GET: DirectChats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directChat = await _directChatService.GetDirectChatByIdAsync(id.Value);
            if (directChat == null)
            {
                return NotFound();
            }

            return View(directChat);
        }

        // POST: DirectChats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var directChat = await _directChatService.GetDirectChatByIdAsync(id);
            if (directChat != null)
            {
                await _directChatService.DeleteDirectChatByIdAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> DirectChatExists(int id)
        {
            var directChat = await _directChatService.GetDirectChatByIdAsync(id);
            return directChat != null;
        }
    }
}
