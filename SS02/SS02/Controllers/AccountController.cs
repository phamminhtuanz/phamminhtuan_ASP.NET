using Microsoft.AspNetCore.Mvc;
using SS02.Models;

namespace SS02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Test",
                    Email = "Test@gmail.com",
                    Phone = "098887776",
                    Address = "Hưng Yên",
                    Avatar = Url.Content("~/Images/Avatar/avatar.jpg"),
                    Gender = 1,
                    Bio = "Handsome",
                    Birthday = new DateTime(2003/10/04)
                },
                new Account()
                {
                    Id = 1,
                    Name = "Test",
                    Email = "Test@gmail.com",
                    Phone = "098887776",
                    Address = "Hưng Yên",
                    Avatar = Url.Content("~/Images/Avatar/avatar.jpg"),
                    Gender = 1,
                    Bio = "Handsome",
                    Birthday = new DateTime(2003/10/04)
                }
            };
            ViewBag.Accounts = accounts;
            return View();
        }
            public IActionResult Profile()
            {
                Account account = new Account()
                {
                    Id = 1,
                    Name = "Tuấn",
                    Email = "tuan@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/avatar.jpg"),
                    Gender = 1,
                    Bio = "Chuối",
                    BirthDay = new DateTime(2003, 3, 8)
                };
                ViewBag.account = account;
                return View();
            }
        }
    }
