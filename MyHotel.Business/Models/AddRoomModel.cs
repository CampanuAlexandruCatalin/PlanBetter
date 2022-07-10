namespace PlanBetter.Business.Models
{
    public sealed class AddRoomModel
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int Price { get; set; }
        public string Facilities { get; set; }
        public string Status { get; set; }
    }
}
