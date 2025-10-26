using System;

public class GurpsInformation
{
    public String name { get; set; }
    public String player { get; set; }
    public int point_total { get; set; }
    public int unspent_points { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
    public int size_modifier { get; set; }
    public int age { get; set; }
    public String appearance { get; set; }

    private GurpsInformation() { }

    public class Builder
    {
        private GurpsInformation _gurpsInfo = new GurpsInformation();

        public Builder setName(string name)
        {
            _gurpsInfo.name = name;
            return this;
        }

        public Builder setPlayer(string player)
        {
            _gurpsInfo.player = player;
            return this;
        }

        public Builder setPointTotal(int point_total)
        {
            _gurpsInfo.point_total = point_total;
            return this;
        }
        public Builder setUnspentPoints(int unspent_points)
        {
            _gurpsInfo.unspent_points = unspent_points;
            return this;
        }
        public Builder setHeight(int height)
        {
            _gurpsInfo.height = height;
            return this;
        }
        public Builder setWeight(int weight)
        {
            _gurpsInfo.weight = weight;
            return this;
        }
        public Builder setSizeModifier(int sizeModifier)
        {
            _gurpsInfo.size_modifier = sizeModifier;
            return this;
        }
        public Builder setAge(int age)
        {
            _gurpsInfo.age = age;
            return this;
        }
        public Builder setAppearance(String appearance)
        {
            _gurpsInfo.appearance = appearance;
            return this;
        }

        public GurpsInformation build()
        {
            return _gurpsInfo;
        }


    }

}