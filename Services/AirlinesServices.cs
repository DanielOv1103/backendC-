using AirlineApi.Models;
using AirlineApi.Repositories;

namespace AirPortApi.Services{
    public class AirlinesServices{
        private readonly AirlinesRepositories _airlinesRepositories;

        public AirlinesServices(AirlinesRepositories airlinesRepositories){
            _airlinesRepositories = airlinesRepositories;
        }

        public List<AirlinesModel> GetAirlines(){
            return _airlinesRepositories.GetAirlines();
        }
    }
}