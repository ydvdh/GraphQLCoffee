using GraphQLCoffee.Models;
using System.Collections.Generic;

namespace GraphQLCoffee.Interfaces
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenusById(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
