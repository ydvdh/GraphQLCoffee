using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;

namespace GraphQLCoffee.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m=>m.Id);
            Field(m=>m.Name);
            Field(m=>m.ImageUrl);

            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenusById(context.Source.Id); });
        }
    }
}
