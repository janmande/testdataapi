using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTAPITestDataAPI.Models
{
  public class ACTAPIShoppingListRepository
  {
    private static List<ShoppingList> _shoppingLists = new List<ShoppingList>();
    public ACTAPIShoppingListRepository()
    {
      ShoppingList list1 = new ShoppingList() { ShoppingListId = Guid.NewGuid(), UserID = Guid.NewGuid() };
      list1.Items = new List<ShoppingListItem>();
      list1.Items.Add(new ShoppingListItem() { ProductName = "Tomatoes", Price = 29.9M, Quantity = 2 });
      list1.Items.Add(new ShoppingListItem() { ProductName = "Lime", Price = 6.9M, Quantity = 3 });

      ShoppingList list2 = new ShoppingList() { ShoppingListId = Guid.NewGuid(), UserID = Guid.NewGuid() };
      list2.Items = new List<ShoppingListItem>();
      list2.Items.Add(new ShoppingListItem() { ProductName = "Banabas", Price = 34.9M, Quantity = 5 });
      list2.Items.Add(new ShoppingListItem() { ProductName = "Lime", Price = 6.9M, Quantity = 3 });

      _shoppingLists.Add( list1);

      _shoppingLists.Add( list2);
    }

    public List<ShoppingList> GetAll()
    {
      return _shoppingLists;
    }

    public ShoppingList GetById(Guid id)
    {
      return (from l in _shoppingLists
              where l.ShoppingListId == id
							select l).FirstOrDefault();
    }

    public void AddShoppingList(ShoppingList newlist)
    {
      _shoppingLists.Add(newlist);
    }

    public void RemoveShoppingList(Guid id)
    {
			var list = (from l in _shoppingLists
			 where l.ShoppingListId == id
									select l).FirstOrDefault();

			if(list != null)
				_shoppingLists.Remove(list);
    }

  }
}
