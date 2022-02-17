using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{

    //impliments the template
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext Context { get; set; }

        //load context file, use to do in controller. This loads the dataset. We put the database in an envelope and then hand off the envelope. 
        public EFBookstoreRepository(BookstoreContext temp)
        {
            Context = temp;
        }
        public IQueryable<Books> Books => Context.Books;
    }
}
