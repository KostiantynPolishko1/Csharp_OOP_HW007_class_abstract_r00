using Fungi.Kingdom;

namespace Fungi
{
    namespace Section
    {
        public abstract class Blastocladiomycota : Fungus
        {
            protected Blastocladiomycota(in string? Name) : base(Name)
            {
                Section = Name is not null ? "Blastocladiomycota" : string.Empty;

            }
        }
    }
}
