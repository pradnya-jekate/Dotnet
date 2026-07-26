namespace Encapsulation.Models
{
    class Student
    {
        private string name = "";

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}