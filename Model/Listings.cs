using RealEstateAPI.Interfaces;

namespace RealEstateAPI.Model
{
    public class Listings : IListings
    {
        private Listing _listing;
        private List<Listing> _listListing = new List<Listing>();

        public Listings(Listing listing)
        {
            _listing = listing;
            _listListing.Add(_listing);
        }

        public void addListing(Listing newItem) {
            _listListing.Add(newItem);
        }

        public List<Listing> getListing() {
            return _listListing;
        }

        public void removeListing(string idToRemove)
        {
            _listListing.RemoveAll(p => p.Id == idToRemove);
        }

    }
}
