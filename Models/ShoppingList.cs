using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTAPITestDataAPI.Models
{
  public class ShoppingList
  {
    [Key]
    public Guid ShoppingListId { get; set; }
    public Guid UserID { get; set; }
    public List<ShoppingListItem> Items { get; set; }
  }
}
