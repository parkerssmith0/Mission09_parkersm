using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_parkersm.Models
{
    public class EFCheckoutRepository : ICheckoutRepository
    {
        private BookstoreContext context;

        public EFCheckoutRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Checkout> checkouts => context.Checkouts
            .Include(x => x.Lines)
            .ThenInclude(x => x.Books);

        public void SaveCheckout(Checkout checkout)
        {
            context.AttachRange(checkout.Lines.Select(x => x.Books));

            if (checkout.CheckoutId == 0)
            {
                context.Checkouts.Add(checkout);
            }

            context.SaveChanges();
        }
    }
}
