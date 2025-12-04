namespace Family_Health_Center.Models
{
    public class Appointment // תור לרופא
    {
        public int AppointmentId { get; set; } // קוד התור
        public int IdCode { get; set; } // קוד מזהה של התינוק
        public int NursesId { get; set; } // קוד מזהה של האחות
        public DateTime AppointmentDate { get; set; } // תאריך התור
    }
}
