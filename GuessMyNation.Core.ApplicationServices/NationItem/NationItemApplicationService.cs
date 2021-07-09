using GuessMyNation.Core.Domain.NationItems;
using System.Collections.Generic;
using GuessMyNation.Core.Domain.Nation;

namespace GuessMyNation.Core.ApplicationServices.NationItem
{

    public class NationItemApplicationService
    {
        private readonly NationItemRepository _nationItemRepository;

        public NationItemApplicationService(NationItemRepository nationItemRepository)
        {
            _nationItemRepository = nationItemRepository;
        }
        //public List<NationItem> GetRandomly(int number)        
        //{
        //    return _nationItemRepository.GetRandomly(number);
        //}

    }
}
