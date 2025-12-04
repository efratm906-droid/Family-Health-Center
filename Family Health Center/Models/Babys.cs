namespace Family_Health_Center.Models
{
    public class Babys // תינוקות
    {
        public int babyId { get; set; } // ת.ז. של התינוק
        public string FullName { get; set; } // שם מלא 
        public string IdCode { get; set; } // קוד מזהה של התינוק 
        public double weight { get; set; } // משקל
        public double height { get; set; } // גובה
        public string apotropuss { get; set; } // אפוטרופוס
        public DateTime birthdate { get; set; } // תאריך לידה
    }
}
