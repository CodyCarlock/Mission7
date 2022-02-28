using Microsoft.AspNetCore.Http;
using Mission7.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class SessionBasket : Basket
    {
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Books book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("Basket", this);
        }

        public override void RemoveItem(Books book)
        {
            base.RemoveItem(book);
            Session.SetJson("Basket", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }



    }
}
