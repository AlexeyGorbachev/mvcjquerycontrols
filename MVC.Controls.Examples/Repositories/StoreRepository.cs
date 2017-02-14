using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Controls.Examples.Models;

namespace MVC.Controls.Examples.Repositories
{
    public class StoreRepository
    {
        public List<Store> ListAll()
        {
            List<Store> result = new List<Store>();
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                Store s = new Store();
                s.Name = "Store " + i.ToString();
                s.StoreId = i;
                s.Address = "Add " + i.ToString();
                s.Created = new DateTime(2011, r.Next(2, 11), r.Next(5, 20));
                result.Add(s);
            }

            return result;
        }

        public List<Store> GetByProductId(int productId)
        {
            List<Store> result = new List<Store>();

            for (int i = 0; i < 4; i++)
            {
                Store s = new Store();
                s.Name = "Prod Store " + i.ToString();
                s.StoreId = i;
                result.Add(s);
            }

            return result;
        }
    }
}
