using System;
public class Encumbrance
{
    public int basic_lift { get; set; }
    public int basic_move { get; set; }
    public int dodge { get; set; }

    private Encumbrance() { }

    public class Builder
    {
        private Encumbrance _en = new Encumbrance();

        public Builder setBasicLift(int basic_lift)
        {
            _en.basic_lift = basic_lift;
            return this;
        }

        public Builder setBasicMove(int basic_move)
        {
            _en.basic_move = basic_move;
            return this;
        }

        public Builder setDodge(int dodge)
        {
            _en.dodge = dodge;
            return this;
        }
    }

}
