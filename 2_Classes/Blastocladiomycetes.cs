using Fungi.Section;

namespace Fungi
{
    namespace Class
    {
        public abstract class Blastocladiomycetes : Blastocladiomycota
        {
            protected Blastocladiomycetes(in string? _Name) : base(_Name)
            {
                this.Class = _Name is not null ? "Blastocladiomycetes" : string.Empty;
            }
        }
    }
}
