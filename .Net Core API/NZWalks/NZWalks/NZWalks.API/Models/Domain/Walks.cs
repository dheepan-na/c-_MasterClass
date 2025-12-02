namespace NZWalks.API.Models.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LengthInKM {  get; set; }

        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }

        public Guid RegionId { get; set; }

        //Navigation properties. Below we will create a navigation or relationship properties. Which will allow Entity framework core to create a 1-1 relationship between those tables.
        public Difficulty Difficulty { get; set; }

        public Regions Regions { get; set; }


    }
}
