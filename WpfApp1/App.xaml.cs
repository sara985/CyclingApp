﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Exceptions;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("My Suites"); 
            try
            {
                Reservation res = new Reservation(
                    new RoomID(1, 3),
                    "sarah",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2));

                hotel.MakeReservation(res);


                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "sarah",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 4)
                ));
            }
            catch (ReservationConflictException ex)
            {
                Console.WriteLine(ex.Message);
            }
            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("sarah");

            base.OnStartup(e);
        }
    }
}