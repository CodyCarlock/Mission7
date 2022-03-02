using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookstoreContext context;
        public EFPurchaseRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchases> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x=>x.Book);

        public void SavePurchase(Purchases purchase)
        {
            context.AttachRange(purchase.Lines.Select(x=>x.Book));
            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase); 
            }

            context.SaveChanges();
        }
    }
}
