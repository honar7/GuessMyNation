using Golrang.Framework.Domain;

namespace GuessMyNation.Core.Domain.Nation
{
    // value object
    public class NationItem: BaseEntity
    {
        public NationItem()
        {
            
        }
        public Nation nation { get; set; }
        public long NationId { get; set; }
        public string Path { get; set; }     
        public int? AnswerCode { get; set; }
        public int? Point { get; set; }
    }


    public class NationItemAnswer : BaseEntity
    {
        public NationItemAnswer()
        {
        }      
        public long NationId { get; set; }      
        public long AnswerCode { get; set; }
        public int? Point { get; set; }
    }

}
