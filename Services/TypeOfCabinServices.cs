using TypeOfCabinApi.Models;
using TypeOfCabinApi.Respositories;

namespace TypeOfCabinApi.Services{
    public class TypeOfCabinModel{
        private readonly  TypeOfCabinRepositories _typeOfCabinRepositories;

        public TypeOfCabinModel(TypeOfCabinRepositories typeOfCabinRepositories){
            _typeOfCabinRepositories = typeOfCabinRepositories;
        }

        public List<TypeOfCabin> GetTypeOfCabinModels(){
            return _typeOfCabinRepositories.GetTypeOfCabins();
        }
    }
}