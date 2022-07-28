namespace CleanArchitecture.Commun
{
    public abstract class EntiteBase
    {
        public int Id  { get; set; } 

        public EntiteBase()
        {
            Id = Guid.NewGuid().GetHashCode();
        }
    }
}
