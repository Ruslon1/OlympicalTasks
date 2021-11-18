namespace TaskA
{
    class Guest : Person
    {
        private bool _isSingle;

        public bool IsSingle => _isSingle;

        public Guest()
        {
            Init();
            DefinePair();
        }

        private void DefinePair()
        {
            Random random = new Random();
            _isSingle = Convert.ToBoolean(random.Next(2) - 1);
        }

        private void Init()
        {
            Random random = new();
            Name = Names[random.Next(Names.Length)];
        }

    }
}