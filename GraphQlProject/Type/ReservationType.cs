using GraphQL.Types;
using GraphQLCoffee.Models;

namespace GraphQLCoffee.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Phone);
            Field(m=> m.TotalPeople);
            Field(m=> m.Email);
            Field(m=> m.Date);
            Field(m=> m.Time);
        }
    }
}
