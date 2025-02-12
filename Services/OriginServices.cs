using OriginApi.Models;
using OriginApi.Repositories;

namespace OriginApi.Services{
    public class OriginModel{
        private readonly OriginRepositories _originRepositories;

        public OriginModel(OriginRepositories originRepositories){
            _originRepositories = originRepositories;
        }

        public List<OriginModels> GetOriginModels(){
            return _originRepositories.GetOriginModels();
        }
    }
}