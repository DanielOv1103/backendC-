using TypeTravelApi.Models;
using TypeTravelApi.Repositories;

namespace TypeTravelApi.Services{
    public class TypeTravelRepositories{
        private readonly TypeTravelRepositories _typeTravelRepositories;

        public TypeTravelRepositories(TypeTravelRepositories typeTravelRepositories){
            _typeTravelRepositories = typeTravelRepositories;
        }

        public List<TypeTravel> GetTypeTravels(){
            return _typeTravelRepositories.GetTypeTravels();
        }
    }
}