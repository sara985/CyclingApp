using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{ FloorNumber}{ RoomNumber}";
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID && 
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator == (RoomID id1, RoomID id2)
        {
            if (id1 is null && id2 is null)
            {
                return true;
            }
            return id1 is not null && id1.Equals(id2);
        }

        public static bool operator !=(RoomID id1, RoomID id2)
        {
            return !(id1 == id2);
        }


    }
}
