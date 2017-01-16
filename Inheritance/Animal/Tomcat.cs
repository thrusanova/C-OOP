namespace Animal
{
    public class Tomcat:Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            
        }
        public override string Gender => base.Gender = "Male";
        public override string produceSound()
        {
            return "Give me one million b***h";
        }
    }
}
