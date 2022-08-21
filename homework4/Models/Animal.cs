namespace homework4.Models
{
    public abstract class Animal //base class , also an abstract class
    {   //class members
        private string mtype;
        private string mlocation;


        //construction of members
        public Animal(string _type, string _location)
        {
            mtype = _type;
            mlocation = _location;

        }

        public abstract string getFact(); //an abstract method
        public virtual string getDetails() // a virtual method
        {
            return mtype + " which you can find in " + mlocation + " is now at a population of approximately ";
        }

        //encapsulation of properties
        public string Type
        {
            get { return mtype; }
            set { mtype = value; }
        }
        public string Location
        {
            get { return mlocation; }
            set { mlocation = value; }
        }


    }
}