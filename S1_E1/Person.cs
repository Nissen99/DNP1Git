namespace S1_E1
{
    public class Person
    {
        public string Name { get; set; }

        public string introduce()
        {
            return "Hello, I am " + Name;
        } 
    }
}