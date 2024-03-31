namespace wctc.edu
{

    public class Teacher : Person, Talkable
    {
        private int _age;

        public Teacher(int age, string name) : base(name)
        {
            _age = age;
        }


        public int GetAge(){return _age;}

        public void SetAge(int age){_age = age;}

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}    