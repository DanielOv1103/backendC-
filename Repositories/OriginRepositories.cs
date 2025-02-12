using OriginApi.Models;
using OriginApi.Services;

namespace OriginApi.Repositories{
    public class OriginRepositories{
        public List<OriginModels> GetOriginModels(){
            var originModels = new List<OriginModels>{
                new OriginModels { Id = 1, Name = "United States", Code = "US" },
                new OriginModels { Id = 2, Name = "Canada", Code = "CA" },
                new OriginModels { Id = 3, Name = "Mexico", Code = "MX" },
                new OriginModels { Id = 4, Name = "Brazil", Code = "BR" },
                new OriginModels { Id = 5, Name = "Argentina", Code = "AR" },
                new OriginModels { Id = 6, Name = "Chile", Code = "CL" },
                new OriginModels { Id = 7, Name = "Peru", Code = "PE" },
                new OriginModels { Id = 8, Name = "Colombia", Code = "CO" },
                new OriginModels { Id = 9, Name = "Venezuela", Code = "VE" },
                new OriginModels { Id = 10, Name = "Ecuador", Code = "EC" },
            };
            return originModels;
        }
    }
}