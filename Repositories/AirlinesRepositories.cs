using AirlineApi.Models;

namespace AirlineApi.Repositories{
    public class AirlinesRepositories{

        private readonly List<AirlinesModel> _airlines;

        public AirlinesRepositories()
        {
             _airlines = new List<AirlinesModel>{
                new AirlinesModel{ Id = 1, Name = "American Airlines", Code = "AA" },
                new AirlinesModel{ Id = 2, Name = "Delta Airlines", Code = "DL" },
                new AirlinesModel{ Id = 3, Name = "Emirates", Code = "EM" },
                new AirlinesModel{ Id = 4, Name = "British Airways", Code = "BA" },
                new AirlinesModel{ Id = 5, Name = "United Airlines", Code = "UA" },
                new AirlinesModel{ Id = 6, Name = "Air France", Code = "AF" },
                new AirlinesModel{ Id = 7, Name = "Japan Airlines", Code = "JA" },
                new AirlinesModel{ Id = 8, Name = "Cathay Pacific", Code = "CP" },
                new AirlinesModel{ Id = 9, Name = "Singapore Airlines", Code = "SI" },
                new AirlinesModel{ Id = 10, Name = "Qatar Airways", Code = "QA" },
            };
        }

        public List<AirlinesModel> GetAirlines() => _airlines;

        public AirlinesModel? GetAirlineById(int id) => _airlines.FirstOrDefault(x => x.Id == id);

        public AirlinesModel CreateAirline(AirlinesModel airline)
        {
            int newId = (_airlines.Count > 0) ? _airlines.Max(x => x.Id).GetValueOrDefault() + 1 : 1;
            airline.Id = newId;
            _airlines.Add(airline);
            return airline;
        }

        public bool UpdateAirline(AirlinesModel airline)
        {
            var airlineToUpdate = _airlines.FirstOrDefault(x => x.Id == airline.Id);
            if (airlineToUpdate == null)
            {
                return false;
            }

            airlineToUpdate.Name = airline.Name;
            airlineToUpdate.Code = airline.Code;
            return true;
        }

        public bool DeleteAirline(int id)
        {
            var airlineToDelete = _airlines.FirstOrDefault(x => x.Id == id);
            if (airlineToDelete == null)
            {
                return false;
            }

            _airlines.Remove(airlineToDelete);
            return true;
        }

    }
}