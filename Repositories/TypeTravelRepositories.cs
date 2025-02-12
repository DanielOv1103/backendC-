using TypeTravelApi.Models;

namespace TypeTravelApi.Repositories{
    public class TypeTravelRepositories{
        public List<TypeTravel> GetTypeTravel(){
            var typeTravel = new List<TypeTravel>{
                new TypeTravel{ Id = 1, Name = "Ida y Vuelta"},
                new TypeTravel{ Id = 2, Name = "Ida"},
                new TypeTravel{ Id = 3, Name = "Vuelta"},
            };
            return typeTravel;
        }
    }
}  