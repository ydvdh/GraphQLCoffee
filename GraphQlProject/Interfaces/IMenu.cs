using GraphQLCoffee.Models;
using System.Collections.Generic;

namespace GraphQLCoffee.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
