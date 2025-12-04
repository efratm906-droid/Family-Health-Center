namespace Family_Health_Center.Models
{
    public class Nurses // אחיות רפואיות
    {
        public int NursesId { get; set; } // קוד מזהה של האחות
        public string name { get; set; } // שם אחות
        public int IdCode { get; set; } // קוד מזהה של התינוק  
        public string phounNumber {  get; set; } // מספר טלפון של האחות
    }
}
