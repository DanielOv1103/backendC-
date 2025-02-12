using DestinysApi.Models;
using DestinysApi.Repositories;

namespace DestinysApi.Services{
    public class DestinysServices{
        private readonly DestinyRepositories _destinysRepositories;

        public DestinysServices(DestinyRepositories destinysRepositories){
            _destinysRepositories = destinysRepositories;
        }

        public List<DestinysModels> GetDestinys(){
            return _destinysRepositories.GetDestinyModels();
        }
    }
}
