using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using FlickrClone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FlickrClone.Controllers
{
    public class PhotosController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public PhotosController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var photos = _db.Photos.ToList();
            return View(photos);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(string Name, IFormFile Data)
        {
            byte[] photoArray = new byte[0];

            if (Data != null)
            {
                using (Stream fileStream = Data.OpenReadStream())
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    photoArray = memoryStream.ToArray();
                }
            }

            Photo newPhoto = new Photo(Name, photoArray);

            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            newPhoto.User = currentUser;

            _db.Photos.Add(newPhoto);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
