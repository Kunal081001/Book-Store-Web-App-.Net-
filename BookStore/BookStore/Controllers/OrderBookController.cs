
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.DTO;
using Microsoft.AspNetCore.Authorization;

namespace BookStore.Controllers
{
    
    public class OrderBookController : Controller
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ReceiptBook()
        {
            return View();
        }
    }

   
}

