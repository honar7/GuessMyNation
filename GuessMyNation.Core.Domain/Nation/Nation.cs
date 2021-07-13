using Golrang.Framework.Domain;

namespace GuessMyNation.Core.Domain.Nation
{
    public class Nation : BaseEntity
    {
        public Nation()
        {

        }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
