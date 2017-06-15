using ACTAPITestDataAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACTAPITestDataAPI.Controllers
{
    public class ShoppingListController : ApiController
    {
    private static ACTAPIShoppingListRepository repo = new ACTAPIShoppingListRepository();
        // GET: api/ShoppingList
        public IEnumerable<ShoppingList> Get()
        {
					return repo.GetAll();
        }

        // GET: api/ShoppingList/5
        public ShoppingList Get(string id)
        {
            return repo.GetById(new Guid(id));
        }

        // POST: api/ShoppingList
        public void Post([FromBody]ShoppingList value)
        {
					repo.AddShoppingList(value);
        }

        // PUT: api/ShoppingList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShoppingList/5
        public void Delete(string id)
        {
					repo.RemoveShoppingList(new Guid(id));
		}
    }
}
