using AirlineApi.Models;

namespace AirlineApi.Repositories{
    public class AirlinesRepositories{
        public List<AirlinesModel> GetAirlines(){
            var airlines = new List<AirlinesModel>{
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
            return airlines;
        }
    }
}