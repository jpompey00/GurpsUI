using System;

public class GurpsDefense
{
    public int parry { get; set; }
    public int block { get; set; }
    private GurpsDefense() { }

    public class Builder
    {
        private GurpsDefense _gd = new GurpsDefense();
        public Builder setParry(int parry)
        {
            _gd.parry = parry;
            return this;
        }

        public Builder setBlock(int block)
        {
            _gd.block = block;
            return this;
        }

        public GurpsDefense build()
        {
            return _gd;
        }
    }
    }
