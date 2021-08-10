﻿using GraphQL.Types;

namespace GraphQLCoffee.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery", resolve: context => new { });
            Field<ReservationQuery>("reservationQuery", resolve: context => new { });
            Field<SubMenuQuery>("subMenuQuery", resolve: context => new { });
        }
    }
}
