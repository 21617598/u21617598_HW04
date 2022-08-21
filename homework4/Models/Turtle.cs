namespace homework4.Models
{
    public class Turtle : Animal
    {

        public Turtle(string _type, string _location) : base(_type, _location)
        {

        }

        public override string getFact()
        {
            return ("The hawksbill sea turtle ,like all sea turtles, has three hearts. And a sea turtle, can't actually retract into its shell. " +
                 "It can ,although, hold its breath for up to 5 hours. And they eat jellyfish.");

        }

        public override string getDetails()
        {
            return getDetails() + "between 83 000 and 57 000";
        }
    }
}