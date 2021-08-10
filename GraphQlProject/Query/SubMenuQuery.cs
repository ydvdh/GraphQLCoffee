using GraphQL;
using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(); });
            Field<SubMenuType>("submenusById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),

                resolve: context =>
                {
                    return subMenuService.GetSubMenusById(context.GetArgument<int>("id"));
                });
        }
    }
}
