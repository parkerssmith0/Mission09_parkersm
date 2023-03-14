using Microsoft.AspNetCore.Mvc;
using Mission09_parkersm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_parkersm.Controllers
{
    public class CheckoutInfoController : Controller
    {
        private ICheckoutRepository repo { get; set; }
        private Basket basket { get; set; }
        public CheckoutInfoController (ICheckoutRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult CheckoutInfo()
        {
            return View(new Checkout());
        }
        [HttpPost]
        public IActionResult CheckoutInfo(Checkout checkout)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty");
            }
            if (ModelState.IsValid)
            {
                checkout.Lines = basket.Items.ToArray();
                repo.SaveCheckout(checkout);
                basket.ClearBasket();

                return RedirectToPage("/ConfirmationPage");
            }
            else
            {
                return View();
            }
        }
    }
}
