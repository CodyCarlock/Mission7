using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchases> Purchases { get; }
        public void SavePurchase(Purchases purchase);
    }
}
