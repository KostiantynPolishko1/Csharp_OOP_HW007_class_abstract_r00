namespace Fungi
{
    namespace Kingdom
    {
        public abstract class Fungus
        {
            protected string Kingdom { get; set; }
            protected string Section { get; set; }
            protected string Name { get; set; }

            protected Fungus(in string? Name)
            {
                this.Name = Name ?? "non";
                Kingdom = Name is not null ? "fungi" : string.Empty;
            }

            public abstract void GetInfo();
        }
    }
}