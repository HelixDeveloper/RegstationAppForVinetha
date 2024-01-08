namespace RegstationApp.Models
{
    public class RegistrationModel
    {
        public int RegistrationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Hobbies { get; set; } 
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
    }

}
