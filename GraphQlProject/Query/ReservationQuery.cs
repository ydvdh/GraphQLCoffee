using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context => { return reservationService.GetReservations(); });

        }
    }
}
