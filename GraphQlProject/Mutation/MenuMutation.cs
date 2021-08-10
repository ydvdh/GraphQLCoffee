using GraphQL;
using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenus", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu"}), 
                resolve: context => 
                { 
                    return menuService.AddMenu(context.GetArgument<Menu>("menu")); 
                });
        }
    }
}
