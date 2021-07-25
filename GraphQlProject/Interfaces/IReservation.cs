using GraphQLCoffee.Models;
using System.Collections.Generic;

namespace GraphQLCoffee.Interfaces
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
