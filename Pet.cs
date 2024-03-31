namespace wctc.edu
{
    public abstract class Pet
    {
        private string _name;

        protected Pet(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        
    }

}