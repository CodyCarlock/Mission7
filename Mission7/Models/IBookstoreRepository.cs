using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public interface IBookstoreRepository
    {
        //class set up specifically for querying information. Replaces a list
        IQueryable<Books> Books { get; }
    }
}
