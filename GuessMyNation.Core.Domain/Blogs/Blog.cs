using Golrang.Framework.Domain;

namespace GuessMyNation.Core.Domain.Blogs
{
    public class Blog: BaseEntity
    {
        public string Name { get; set; }
        public string EnName { get; set; }
        public string Desciption { get; set; }
    }
}
