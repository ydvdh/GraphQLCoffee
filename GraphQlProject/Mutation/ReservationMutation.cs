using GraphQL;
using GraphQL.Types;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using GraphQLCoffee.Type;

namespace GraphQLCoffee.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("createReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
               resolve: context =>
               {
                   return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
               });
        }
    }
}
