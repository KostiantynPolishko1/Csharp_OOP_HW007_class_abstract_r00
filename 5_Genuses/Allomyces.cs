using Fungi.Family;

namespace Fungi
{
    namespace Genus
    {
        public abstract class Allomyces : Blastocladiaceae
        {
            protected Allomyces(in string? _Name) : base(_Name) 
            {
                this.Genus = _Name is not null ? "Allomyces" : string.Empty;
            }
        }
    }
}
