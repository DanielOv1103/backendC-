using AirlineApi.Models;
using AirlineApi.Repositories;

namespace AirlineApi.Services{
    public class AirlinesServices{
        private readonly AirlinesRepositories _airlinesRepositories;

        public AirlinesServices(AirlinesRepositories airlinesRepositories){
            _airlinesRepositories = airlinesRepositories;
        }

        public List<AirlinesModel> GetAirlines(){
            return _airlinesRepositories.GetAirlines();
        }

        public List<AirlinesModel> GetAirlinesModels(){
            return _airlinesRepositories.GetAirlines();
        }

        public AirlinesModel? GetAirlineById(int id){
            return _airlinesRepositories.GetAirlineById(id);
        }

        public AirlinesModel CreateAirline(AirlinesModel airline){
            return _airlinesRepositories.CreateAirline(airline);
        }

        public bool UpdateAirline(AirlinesModel airline){
            return _airlinesRepositories.UpdateAirline(airline);
        }

        public bool DeleteAirline(int id){
            return _airlinesRepositories.DeleteAirline(id);
        }
    }
}