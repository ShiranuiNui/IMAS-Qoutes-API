using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IMAS_QOTD_API.Model;
using IMAS_QOTD_API.Repository.Interface;
namespace IMAS_QOTD_API.Repository
{
    class MockQuotesRepositry : IReadOnlyRepository<Qoute>
    {
        public Qoute Get(int id) => new Qoute
        {
            QouteString = "ツンツンしてるつもりはないですけど…",
            Speaker = "風野 灯織",
            Production = "283"
        };
        /* fixformat ignore:start */
        public IEnumerable<Qoute> GetAll() => new List<Qoute>
        {
            new Qoute
            {
                QouteString = "ツンツンしてるつもりはないですけど…",
                Speaker = "風野 灯織",
                Production = "283"
            }
        };
        /* fixformat ignore:end */

        public Task<IEnumerable<Qoute>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Qoute> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}