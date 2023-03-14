using Microsoft.AspNetCore.Mvc;
using Mission09_parkersm.Models;

namespace Mission09_parkersm.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket b)
        {
            basket = b;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}