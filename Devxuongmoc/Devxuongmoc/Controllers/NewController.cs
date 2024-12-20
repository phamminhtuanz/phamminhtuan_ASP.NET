﻿using Devxuongmoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
    public class NewController : Controller
    {
        private readonly XuongMocContext _context;
        public NewController(XuongMocContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.News
         .Select(n => new News
         {
             Id = n.Id,
             Title = string.IsNullOrEmpty(n.Title) ? "Tiêu đề không có" : n.Title,
             Image = string.IsNullOrEmpty(n.Image) ? "/images/default.jpg" : n.Image,
             UpdatedDate = n.UpdatedDate ?? DateTime.Now
         })
         .ToListAsync();

            return View(data);
        }
    }
}
