using System;
public class GurpsAdvantagesAndDisadvantages
{
    public String description { get; set; }
    public int cost { get; set; }

    private GurpsAdvantagesAndDisadvantages() { }

    public class Builder
    {
        private GurpsAdvantagesAndDisadvantages _gad = new GurpsAdvantagesAndDisadvantages();

        public Builder setDescription(String description)
        {
            _gad.description = description;
            return this;
        }

        public Builder setCost(int cost)
        {
            _gad.cost = cost;
            return this;
        }

        public GurpsAdvantagesAndDisadvantages build()
        {
            return _gad;
        }
    }
}
