namespace HeroesWorkshop.Domain
{
    public sealed class Country : BaseEntity
    {
        public string Name { get; set; }
        
        public string NameEng { get; set; }
        
        public string Code { get; set; }
    }
}