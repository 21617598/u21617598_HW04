namespace homework4.Models
{
    public class Seal : Animal
    {

        public Seal(string _type, string _location) : base(_type, _location)
        {

        }

        public override string getFact()
        {
            return ("The monk seal can live for 25 - 30 years. Like most of us, it loves taking naps. " +
                 "It is actually cousins with bears. It often gets eels stuck up its nose.");

        }

        public override string getDetails()
        {
            return getDetails() + " one thousand-five hundred-and seventy.";
        }
    }
}