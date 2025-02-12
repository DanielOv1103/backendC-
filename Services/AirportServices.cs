using AirPortApi.Models;
using AirPortApi.Repositories;

namespace AirPortApi.Services{
    public class AirportServices{
        private readonly AirPortRepositories _airportRepositories;

        public AirportServices(AirPortRepositories airportRepositories){
            _airportRepositories = airportRepositories;
        }

        public List<AirportsModel> GetAirports(){
            return _airportRepositories.GetAirports();
        }

        public AirportsModel GetAirportById(int id){
            return _airportRepositories.GetAirportById(id);
        }
        
        public void CreateAirport(AirportsModel airport) => _airportRepositories.CreateAirport(airport);

        public void UpdateAirport(AirportsModel airport) => _airportRepositories.UpdateAirport(airport);

        public void DeleteAirport(int id) => _airportRepositories.DeleteAirport(id);
    }
}