using Fungi.Class;

namespace Fungi
{
    namespace Order
    {
        public abstract class Blastocladiales : Blastocladiomycetes
        {
            protected Blastocladiales(in string? _Name) : base(_Name)
            {
                this.Order = _Name is not null ? "Blastocladiales" : string.Empty;
            }
        }
    }
}
