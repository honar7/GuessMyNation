using GuessMyNation.Core.Domain.Nation;
using System.Collections.Generic;

namespace GuessMyNation.Core.ApplicationServices.Nations
{
    public class NationApplicationService
    {
        private readonly NationRepository _nationRepository;

        public NationApplicationService(NationRepository nationRepository)
        {
            _nationRepository = nationRepository;
        }

        public void Add(Nation nation)
        {
            _nationRepository.Add(nation);
        }

        public Nation Get(int nationId)
        {
            return _nationRepository.Get(nationId);
        }

        public List<Nation> Get()
        {
            return _nationRepository.Get();
        }

        public void Remove(int nationId)
        {
            _nationRepository.Remove(nationId);
        }
    }
}
