using Fungi.Kingdom;

namespace Fungi
{
    namespace Section
    {
        public abstract class Blastocladiomycota : Fungus
        {
            protected Blastocladiomycota(in string? _Name) : base(_Name)
            {
                this.Section = _Name is not null ? "Blastocladiomycota" : string.Empty;
            }
        }
    }
}
