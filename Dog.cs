namespace wctc.edu
{

    public class Dog : Pet, Talkable
    {
        private bool _friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            base.GetName();

            _friendly = friendly;
        }

          public bool isFriendly() {return _friendly;}

         public string Talk()
        {
            return "Woof!";
        }

         public override string ToString()
        {
            return "Dog: " + base.GetName() + "| Friendly: " + _friendly;
        }  

    }
}