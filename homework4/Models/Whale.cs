namespace homework4.Models
{
    public class Whale : Animal
    {

        public Whale(string _type, string _location) : base(_type, _location)
        {

        }

        public override string getFact()
        {
            return ("The Blue Whale is the largest animal in world as well as the loudest animal in the world. " +
                 "It can live 80 - 90 years. It's tongue weighs as much as an elephant.");

        }

        public override string getDetails()
        {
            return getDetails() + "between 10 000 and 25 000.";
        }
    }
}