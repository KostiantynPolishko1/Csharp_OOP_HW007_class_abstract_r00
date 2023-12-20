using Fungi.Section;

namespace Fungi
{
    namespace Type
    {
        public sealed class AllomycesArbusculus : Blastocladiomycota
        {
            public AllomycesArbusculus() : this(null) { }
            public AllomycesArbusculus(in string? Name) : base(Name) { }

            public override string ToString()
            {
                return $"{this.Kingdom}\n\t-> {this.Section}";
            }
            public sealed override void GetInfo()
            {
                Console.WriteLine($"Hierarchy of {Name}\n\t{ToString()}");
            }
        }
    }
}
