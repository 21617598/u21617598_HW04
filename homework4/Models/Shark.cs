namespace homework4.Models
{
    public class Shark : Animal
    {

        public Shark(string _type, string _location) : base(_type, _location)
        {

        }

        public override string getFact()
        {
            return ("The hammerhead shark's wide set eyes allow it to have a 360 degree view. Their hammer-shaped heads help them hunt. " +
                 "If you tickle the hammerhead's belly, it can't move");

        }

        public override string getDetails()
        {
            return getDetails() + "80% less and said to be decreasing.";
        }
    }
}