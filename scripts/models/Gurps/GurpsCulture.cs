using System;
using System.Collections.Generic;
public class GurpsCulture
{
    public TechLevel tech_level { get; set; }
    public CulturalFamiliarity[] cultural_familiarity { get; set; }
    private GurpsCulture() { }

    public class Builder()
    {
        private GurpsCulture _gc = new GurpsCulture();
        public Builder setTechLevel(TechLevel techLevel)
        {
            _gc.tech_level = techLevel;
            return this;
        }

        public Builder setCulturalFamiliarty(CulturalFamiliarity[] culturalFamiliarities)
        {
            _gc.cultural_familiarity = culturalFamiliarities;
            return this;
        }

        public Builder addToCulturalFamiliartiy(CulturalFamiliarity culturalFamiliarity)
        {
            if (_gc.cultural_familiarity.Length < 1)
            {
                _gc.cultural_familiarity = [culturalFamiliarity];
            }
            else
            {
                List<CulturalFamiliarity> list = [.. _gc.cultural_familiarity, culturalFamiliarity];
                _gc.cultural_familiarity = [.. list];
            }
            return this;
        }

        //may need to add a remove function
    }
    }

//make a function that adds to the array, like .Add and/or function that
//just assigns the array to an already existing one, they are set to
//arrays and not lists, so its not mutable, will need to make the algorithm
//to transfer the list to a new list, then add the new object and 
//remove old version from memory.
