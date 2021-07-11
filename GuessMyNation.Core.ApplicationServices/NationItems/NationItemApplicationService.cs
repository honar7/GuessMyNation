using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Core.Domain.NationItems;
using System.Collections.Generic;

namespace GuessMyNation.Core.ApplicationServices.NationItems
{

    public class NationItemApplicationService
    {
        private readonly NationItemRepository _nationItemRepository;

        public NationItemApplicationService(NationItemRepository nationItemRepository)
        {
            _nationItemRepository = nationItemRepository;
        }

        public List<NationItem> GetRandomly(int number)
        {
            return _nationItemRepository.GetRandomly(number);
        }

        public List<NationItem> GetFixFiveRandomly()
        {
            return _nationItemRepository.GetRandomly(5);
        }
    }
}
