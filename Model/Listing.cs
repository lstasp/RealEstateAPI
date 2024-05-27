using System.Diagnostics.CodeAnalysis;

namespace RealEstateAPI.Model
{
    public class Listing
    {
        private string id;
        private string title;
        private string description;

        public Listing() { 
        }

        public Listing(string id, string title, decimal price, string description)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
        }

        [SetsRequiredMembers]
        public Listing(decimal price)
        {
            Price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public required decimal? Price { get => this.Price; set => Price = value; }
        public string Description { get => description; set => description = value; }



    }
}
