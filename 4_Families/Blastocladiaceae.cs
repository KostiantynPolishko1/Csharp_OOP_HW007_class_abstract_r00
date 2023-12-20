using Fungi.Order;

namespace Fungi
{
    namespace Family
    {
        public abstract class Blastocladiaceae : Blastocladiales
        {
            protected Blastocladiaceae(in string? _Name) : base(_Name) 
            { 
                this.Family = _Name is not null ? "Blastocladiaceae" : string.Empty;
            }
        }
    }
}
