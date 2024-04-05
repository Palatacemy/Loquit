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
using Loquit.Services.Services.ChatTypesServices;

namespace Loquit.Web.Controllers
{
    public class GroupChatsController : Controller
    {
        private readonly IGroupChatService _groupChatService;

        public GroupChatsController(IGroupChatService groupChatService)
        {
            _groupChatService = groupChatService;
        }

        // GET: GroupChats
        public async Task<IActionResult> Index()
        {
            return View(await _groupChatService.GetGroupChatsAsync());
        }

        // GET: GroupChats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupChat = await _groupChatService.GetGroupChatByIdAsync(id.Value);
            if (groupChat == null)
            {
                return NotFound();
            }

            return View(groupChat);
        }

        // GET: GroupChats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupChats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] GroupChatDTO groupChat)
        {
            if (ModelState.IsValid)
            {
                await _groupChatService.AddGroupChatAsync(groupChat);
                return RedirectToAction(nameof(Index));
            }
            return View(groupChat);
        }

        // GET: GroupChats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupChat = await _groupChatService.GetGroupChatByIdAsync(id.Value);
            if (groupChat == null)
            {
                return NotFound();
            }
            return View(groupChat);
        }

        // POST: GroupChats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] GroupChatDTO groupChat)
        {
            if (id != groupChat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _groupChatService.UpdateGroupChatAsync(groupChat);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await GroupChatExists(groupChat.Id))
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
            return View(groupChat);
        }

        // GET: GroupChats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupChat = await _groupChatService.GetGroupChatByIdAsync(id.Value);
            if (groupChat == null)
            {
                return NotFound();
            }

            return View(groupChat);
        }

        // POST: GroupChats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupChat = await _groupChatService.GetGroupChatByIdAsync(id);
            if (groupChat != null)
            {
                await _groupChatService.DeleteGroupChatByIdAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> GroupChatExists(int id)
        {
            var groupChat = await _groupChatService.GetGroupChatByIdAsync(id);
            return groupChat != null;
        }
    }
}
