using GraphQL;
using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenus", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
               resolve: context =>
               {
                   return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
               });
        }
    }
}
