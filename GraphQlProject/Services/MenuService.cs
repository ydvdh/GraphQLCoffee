using GraphQLCoffee.Data;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLCoffee.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQLDbContext _dbcontext;

        public MenuService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Menu> GetMenus()
        {
            return _dbcontext.Menus.ToList();
        }
        public Menu AddMenu(Menu menu)
        {
            _dbcontext.Add(menu);
            _dbcontext.SaveChanges();
            return menu;
        }
    }
}
