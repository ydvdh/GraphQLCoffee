﻿using GraphQL.Types;
using GraphQLCoffee.Models;

namespace GraphQLCoffee.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m=>m.Id);
            Field(m=>m.Name);
            Field(m=>m.Description);
            Field(m=>m.ImageUrl);
            Field(m=>m.Price);
        }
    }
}
