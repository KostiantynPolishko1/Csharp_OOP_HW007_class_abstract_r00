namespace Fungi
{
    namespace Kingdom
    {
        public abstract class Fungus
        {
            protected string Kingdom { get; set; }
            protected string Section { get; set; }
            protected string Class { get; set; }
            protected string Order { get; set; }
            protected string Family { get; set; }
            protected string Genus { get; set; }
            protected string Type { get; set; }
            protected string _Name { get; set; }
            public abstract string[] Hierarchys { get; set; }

            public static readonly string[] Points;
            static Fungus()
            {
                Points = new string[] { "Kingdom", "Section", "Class", "Order", "Family", "Genus", "Type" };
            }

            protected Fungus(in string? _Name)
            {
                this._Name = _Name ?? string.Empty;
                this.Kingdom = _Name is not null ? "Fungi" : string.Empty;
            }

            public abstract string GetDataObj();

            public virtual void GetInfo() 
            {
                if (this._Name == string.Empty)
                {
                    Console.WriteLine($"{this.GetType().Name} is null");
                    return;
                }

                Console.WriteLine($"Hierarchy of {this._Name}");

                for (int i = 0; i < Hierarchys.Length; i++)
                {
                    for (int j = 0; j < i + 1; j++) { Console.Write("\t"); }
                    Console.WriteLine($"{Points[i]} -> {this.Hierarchys[i]}");
                }
            }
        }
    }
}