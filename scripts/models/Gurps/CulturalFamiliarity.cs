using System;
public class CulturalFamiliarity
{
    public String description { get; set; }
    public int cost { get; set; }

    private CulturalFamiliarity(){}

    public class Builder
    {
        public CulturalFamiliarity _cF = new CulturalFamiliarity();
        public Builder setDescription(String description)
        {
            _cF.description = description;
            return this;
        }

        public Builder setCost(int cost)
        {
            _cF.cost = cost;
            return this;
        }

        public CulturalFamiliarity build()
        {
            return _cF;
        }
    }
    }