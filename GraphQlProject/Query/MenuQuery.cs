using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => { return menuService.GetMenus(); });
        }
    }
}
