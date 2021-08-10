using GraphQL.Types;
using GraphQLCoffee.Models;

namespace GraphQLCoffee.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m=>m.Id);
            Field(m=>m.Name);
            Field(m=>m.ImageUrl);
        }
    }
}
