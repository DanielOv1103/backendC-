using DestinysApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DestinysApi.Repositories
{
    public class DestinyRepositories
    {
        private readonly List<DestinysModels> _destinies;

        public DestinyRepositories()
        {
            _destinies = new List<DestinysModels>
            {
                new DestinysModels{ Id = 1, Name = "Londres", Code = "LD" },
                new DestinysModels{ Id = 2, Name = "Paris", Code = "PR" },
                new DestinysModels{ Id = 3, Name = "Amsterdam", Code = "AM" },
                new DestinysModels{ Id = 4, Name = "Rome", Code = "RO" },
                new DestinysModels{ Id = 5, Name = "Berlin", Code = "BE" },
                new DestinysModels{ Id = 6, Name = "Madrid", Code = "MA" },
                new DestinysModels{ Id = 7, Name = "Barcelona", Code = "BC" },
                new DestinysModels{ Id = 8, Name = "Stockholm", Code = "ST" },
                new DestinysModels{ Id = 9, Name = "Oslo", Code = "OS" },
                new DestinysModels{ Id = 10, Name = "Copenhagen", Code = "CO" }
            };
        }

        public List<DestinysModels> GetDestinies() => _destinies;

        public DestinysModels? GetDestinyById(int id) => _destinies.FirstOrDefault(x => x.Id == id);

        public DestinysModels CreateDestiny(DestinysModels destiny)
        {
            int newId = (_destinies.Count > 0) ? _destinies.Max(x => x.Id) + 1 : 1;
            destiny.Id = newId;
            _destinies.Add(destiny);
            return destiny;
        }

        public bool UpdateDestiny(DestinysModels destiny)
        {
            var destinyToUpdate = _destinies.FirstOrDefault(x => x.Id == destiny.Id);
            if (destinyToUpdate == null)
            {
                return false;
            }

            destinyToUpdate.Name = destiny.Name;
            destinyToUpdate.Code = destiny.Code;
            return true;
        }

        public bool DeleteDestiny(int id)
        {
            var destinyToDelete = _destinies.FirstOrDefault(x => x.Id == id);
            if (destinyToDelete == null)
            {
                return false;
            }

            _destinies.Remove(destinyToDelete);
            return true;
        }
    }
}
