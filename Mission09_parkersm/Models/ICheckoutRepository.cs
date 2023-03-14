using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_parkersm.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> checkouts { get; }

        void SaveCheckout(Checkout checkout);
    }
}
