using DestinysApi.Models;
using DestinysApi.Repositories;

namespace DestinysApi.Services
{
    public class DestinyServices
    {
        private readonly DestinyRepositories _destinyRepositories;

        public DestinyServices(DestinyRepositories destinyRepositories)
        {
            _destinyRepositories = destinyRepositories;
        }

        public List<DestinysModels> GetDestinies()
        {
            return _destinyRepositories.GetDestinies();
        }

        public DestinysModels? GetDestinyById(int id)
        {
            return _destinyRepositories.GetDestinyById(id);
        }

        public DestinysModels CreateDestiny(DestinysModels destiny)
        {
            return _destinyRepositories.CreateDestiny(destiny);
        }

        public bool UpdateDestiny(DestinysModels destiny)
        {
            return _destinyRepositories.UpdateDestiny(destiny);
        }

        public bool DeleteDestiny(int id)
        {
            return _destinyRepositories.DeleteDestiny(id);
        }
    }
}
