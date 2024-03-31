
namespace wctc.edu
{
    public class Cat : Pet, Talkable
    {
       private int _miceKilled;
        public Cat(int miceKilled, string name) : base(name)
        {
            _miceKilled = miceKilled;
        }

        public int GetMousesKilled()
        {
            return _miceKilled;
        }

        public void AddMouse()
        {
            _miceKilled++;
        }

        public override string ToString()
        {
            return "Cat: " + base.GetName() + "| Mice Killed " + _miceKilled;
        }  

      
       
        public string Talk()
        {
            return "Meow!";
        }
    }
}
