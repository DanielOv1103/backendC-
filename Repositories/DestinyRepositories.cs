using DestinysApi.Models;

namespace DestinysApi.Repositories{
    public class DestinyRepositories{
        public List<DestinysModels> GetDestinyModels(){
            var destinyModels = new List<DestinysModels>{
                new DestinysModels{ Id = 1, Name = "Londres", Code = "LD" },
                new DestinysModels{ Id = 2, Name = "Paris", Code = "PR" },
                new DestinysModels{ Id = 3, Name = "Amsterdam", Code = "AM" },
                new DestinysModels{ Id = 4, Name = "Rome", Code = "RO" },
                new DestinysModels{ Id = 5, Name = "Berlin", Code = "BE" },
                new DestinysModels{ Id = 6, Name = "Madrid", Code = "MA" },
                new DestinysModels{ Id = 7, Name = "Barcelona", Code = "BC" },
                new DestinysModels{ Id = 8, Name = "Stockholm", Code = "ST" },
                new DestinysModels{ Id = 9, Name = "Oslo", Code = "OS" },
                new DestinysModels{ Id = 10, Name = "Copenhagen", Code = "CO" },
            };
            return destinyModels;
        }
    }
}