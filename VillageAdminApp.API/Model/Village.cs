namespace VillageAdminApp.API.Model
{
    public class Village : Base
    {
        public int Id { get; set; }

        public string? VillageName { get; set; }

        public int TotalPopulation { get; set;}

        public Taluk Taluk { get; set; }

        public District District { get; set; }

        public State State { get; set; }

    }
}
