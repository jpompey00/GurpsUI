using System;
public class GurpsArmorAndPossesions
{
    public String item { get; set; }
    public String location { get; set; }
    public int cost { get; set; }
    public int weight { get; set; }


    private GurpsArmorAndPossesions() { }
    public class Builder
    {
        private GurpsArmorAndPossesions _gap = new GurpsArmorAndPossesions();

        public Builder setItem(String item)
        {
            _gap.item = item;
            return this;
        }

        public Builder setLocation(String location)
        {
            _gap.location = location;
            return this;
        }

        public Builder setCost(int cost)
        {
            _gap.cost = cost;
            return this;
        }

        public Builder setWeight(int weight)
        {
            _gap.weight = weight;
            return this;
        }

        public GurpsArmorAndPossesions build()
        {
            return _gap;
        }
    }
}


