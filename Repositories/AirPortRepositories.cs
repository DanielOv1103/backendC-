using AirPortApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AirPortApi.Repositories
{
    public class AirPortRepositories
    {
        private readonly List<AirportsModel> _airports;

        public AirPortRepositories()
        {
            _airports = new List<AirportsModel>
            {
                new AirportsModel{ Id = 1, Name = "JFK", City = "New York", Country = "USA" },
                new AirportsModel{ Id = 2, Name = "LAX", City = "Los Angeles", Country = "USA" },
                new AirportsModel{ Id = 3, Name = "ORD", City = "Chicago", Country = "USA" },
                new AirportsModel{ Id = 4, Name = "ATL", City = "Atlanta", Country = "USA" },
                new AirportsModel{ Id = 5, Name = "LHR", City = "London", Country = "UK" },
                new AirportsModel{ Id = 6, Name = "CDG", City = "Paris", Country = "France" },
                new AirportsModel{ Id = 7, Name = "AMS", City = "Amsterdam", Country = "Netherlands" },
                new AirportsModel{ Id = 8, Name = "FCO", City = "Rome", Country = "Italy" },
                new AirportsModel{ Id = 9, Name = "SFO", City = "San Francisco", Country = "USA" },
                new AirportsModel{ Id = 10, Name = "LIM", City = "Lima", Country = "Peru" }
            };
        }

        public List<AirportsModel> GetAirports() => _airports;

        public AirportsModel? GetAirportById(int id) => _airports.FirstOrDefault(x => x.Id == id);

        public AirportsModel CreateAirport(AirportsModel airport)
        {
            // Si _airports está vacío, establecer el ID en 1, de lo contrario, obtener el máximo valor de Id y sumarle 1
            int newId = (_airports.Count > 0) ? _airports.Max(x => x.Id) + 1 : 1;

            airport.Id = newId;
            _airports.Add(airport);
            return airport;
        }

        public bool UpdateAirport(AirportsModel airport)
        {
            var airportToUpdate = _airports.FirstOrDefault(x => x.Id == airport.Id);
            if (airportToUpdate == null)
            {
                return false;
            }

            airportToUpdate.Name = airport.Name;
            airportToUpdate.City = airport.City;
            airportToUpdate.Country = airport.Country;
            return true;
        }

        public bool DeleteAirport(int id)
        {
            var airportToDelete = _airports.FirstOrDefault(x => x.Id == id);
            if (airportToDelete == null)
            {
                return false;
            }

            _airports.Remove(airportToDelete);
            return true;
        }
    }
}
