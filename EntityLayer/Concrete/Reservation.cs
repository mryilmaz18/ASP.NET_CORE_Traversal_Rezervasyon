﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Reservation
    {
        public int ReservationID { get; set; }
        public int AppKullaniciId { get; set; }
        public AppKullanici AppKullanici { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
