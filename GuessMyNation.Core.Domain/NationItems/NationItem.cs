using Golrang.Framework.Domain;

namespace GuessMyNation.Core.Domain.Nation
{
    // value object
    public class NationItem: BaseEntity
    {
        public Nation nation { get; set; }
        public byte[] Photo { get; set; }
        public int? AnswerCode { get; set; }
        public int? Point { get; set; }
    }
}
