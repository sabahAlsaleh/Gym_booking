namespace Gym_booking.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        string Name { get; set; }
        DateTime StartTime { get; set; }
        TimeSpan Duration { get; set; }
        DateTime EndTime { get { return StartTime + Duration; } }
        String Description { get; set; }

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } = new List<ApplicationUserGymClass>();

    }
}
