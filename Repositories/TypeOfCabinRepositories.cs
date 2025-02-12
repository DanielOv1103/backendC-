using TypeOfCabinApi.Models;

namespace TypeOfCabinApi.Respositories {
    public class TypeOfCabinRepositories{
        public List<TypeOfCabin> GetTypeOfCabins(){
            var typeCabinModels = new List<TypeOfCabin>{
                new TypeOfCabin { Id = 1, Name = "Economica"},
                new TypeOfCabin { Id = 2, Name = "Premium Economica"},
                new TypeOfCabin { Id = 3, Name = "Business"},
                new TypeOfCabin { Id = 4, Name = "Premium Business"},
                new TypeOfCabin { Id = 5, Name = "Primera Clase"},
            };
            return typeCabinModels;
        }
    }
}