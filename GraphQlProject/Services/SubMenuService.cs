using GraphQLCoffee.Data;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLCoffee.Services
{
    public class SubMenuService : ISubMenu
    {
        private readonly GraphQLDbContext _dbcontext;

        public SubMenuService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<SubMenu> GetSubMenus()
        {
            return _dbcontext.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenusById(int menuId)
        {
            return _dbcontext.SubMenus.Where(m=>m.MenuId == menuId).ToList();
        }
        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _dbcontext.SubMenus.Add(subMenu);
            _dbcontext.SaveChanges();
            return subMenu;
        }
    }
}
