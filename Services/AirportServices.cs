using AirPortApi.Models;
using AirPortApi.Repositories;

namespace AirPortApi.Services
{
    public class AirportServices
    {
        private readonly AirPortRepositories _airportRepositories;

        public AirportServices(AirPortRepositories airportRepositories)
        {
            _airportRepositories = airportRepositories;
        }

        public List<AirportsModel> GetAirports()
        {
            return _airportRepositories.GetAirports();
        }

        public List<AirportsModel> GetAirportsModels()
        {
            return _airportRepositories.GetAirports();
        }

        public AirportsModel? GetAirportById(int id)
        {
            return _airportRepositories.GetAirportById(id);
        }

        public AirportsModel CreateAirport(AirportsModel airport)
        {
            return _airportRepositories.CreateAirport(airport); // Retorna el aeropuerto creado
        }

        public bool UpdateAirport(AirportsModel airport)
        {
            return _airportRepositories.UpdateAirport(airport);
        }

        public bool DeleteAirport(int id)
        {
            return _airportRepositories.DeleteAirport(id);
        }
    }
}