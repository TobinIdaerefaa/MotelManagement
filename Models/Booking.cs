using System;

namespace MotelManagement.Models
{
    public class Booking:BaseEntity
    {
        public string ClientId { get; set; }
        public int RoomId { get; set; }
        public int InvoiceId { get; set; }
        public int Occupants { get; set; }
    }
}
