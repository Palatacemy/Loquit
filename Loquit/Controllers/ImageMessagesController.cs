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
    public class ImageMessagesController : Controller
    {
        private readonly IImageMessageService _imageMessageService;

        public ImageMessagesController(IImageMessageService imageMessageService)
        {
            _imageMessageService = imageMessageService;
        }

        // GET: ImageMessages
        public async Task<IActionResult> Index()
        {
            return View(await _imageMessageService.GetImageMessagesAsync());
        }

        // GET: ImageMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageMessage = await _imageMessageService.GetImageMessageByIdAsync(id.Value);
            if (imageMessage == null)
            {
                return NotFound();
            }

            return View(imageMessage);
        }

        // GET: ImageMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImageMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PictureUrl,TimeOfSending,SenderIdInChat,Id")] ImageMessageDTO imageMessage)
        {
            if (ModelState.IsValid)
            {
                await _imageMessageService.AddImageMessageAsync(imageMessage);
                return RedirectToAction(nameof(Index));
            }
            return View(imageMessage);
        }

        // GET: ImageMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageMessage = await _imageMessageService.GetImageMessageByIdAsync(id.Value);
            if (imageMessage == null)
            {
                return NotFound();
            }
            return View(imageMessage);
        }

        // POST: ImageMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PictureUrl,TimeOfSending,SenderIdInChat,Id")] ImageMessageDTO imageMessage)
        {
            if (id != imageMessage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _imageMessageService.UpdateImageMessageAsync(imageMessage);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ImageMessageExists(imageMessage.Id))
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
            return View(imageMessage);
        }

        // GET: ImageMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageMessage = await _imageMessageService.GetImageMessageByIdAsync(id.Value);
            if (imageMessage == null)
            {
                return NotFound();
            }

            return View(imageMessage);
        }

        // POST: ImageMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imageMessage = await _imageMessageService.GetImageMessageByIdAsync(id);
            if (imageMessage != null)
            {
                await _imageMessageService.DeleteImageMessageByIdAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ImageMessageExists(int id)
        {
            var imageMessage = await _imageMessageService.GetImageMessageByIdAsync(id);
            return imageMessage != null;
        }
    }
}
