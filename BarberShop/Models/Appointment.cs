using System;

namespace BarberShop.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int ServiceId { get; set; }
    }
}