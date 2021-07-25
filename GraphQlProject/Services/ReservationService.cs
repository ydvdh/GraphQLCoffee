using GraphQLCoffee.Data;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLCoffee.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQLDbContext _dbcontext;

        public ReservationService(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Reservation> GetReservations()
        {
            return _dbcontext.Reservations.ToList();
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbcontext.Reservations.Add(reservation);
            _dbcontext.SaveChanges();
            return reservation;
        }
    }
}
