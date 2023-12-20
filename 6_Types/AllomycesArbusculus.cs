using Fungi.Genus;

namespace Fungi
{
    namespace Type
    {
        public sealed class AllomycesArbusculus : Allomyces
        {
            //DATA OBJECT
            private int? FoundYear { get; set; }
            private int? VegatativeTime { get; set; }
            private string LiveArea;
            public string _LiveArea
            {
                get { return LiveArea; }
                set 
                {
                    LiveArea = this._Name is not null? value : string.Empty ; 
                }
            }
            public override string[] Hierarchys { get; set; }

            public AllomycesArbusculus() : this("_AllomycesArbusculus") { }
            public AllomycesArbusculus(in string? _Name) : base(_Name) 
            {
                this.Type = _Name is not null ? this.GetType().Name : string.Empty;
                this.Hierarchys = new string[] { this.Kingdom, this.Section, this.Class, this.Order, this.Family, this.Genus, this.Type };

                if (this._Name != string.Empty)
                {
                    this.FoundYear = 1911;
                    this.VegatativeTime = 36;
                    this._LiveArea = "water";
                }
            }

            public override string GetDataObj()
            {
                return $"DATA OBJ: {this.FoundYear.GetValueOrDefault()} | {this.VegatativeTime.GetValueOrDefault()} | {this.LiveArea}";
            }

            public sealed override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine(GetDataObj());
            }
        }
    }
}
