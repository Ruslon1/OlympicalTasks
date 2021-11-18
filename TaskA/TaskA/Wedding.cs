namespace TaskA
{
    class Wedding
    {
        private List<Guest> _guests = new();
        private int _guestAmount;


        public void AddGuest(IEnumerable<Guest> guests)
        {
            _guests = (List<Guest>)guests;

            _guestAmount = _guests.Count;

            foreach (var guest in guests)
            {
                if (guest.IsSingle == false)
                    _guestAmount++;
            }
        }

        public void ShowGuests()
        {
            foreach (var guest in _guests)
            {
                if (guest.IsSingle == false)
                    Console.WriteLine($"{guest.Name} +one");
                else
                    Console.WriteLine(guest.Name);
            }
        }

        public int CalculateTotalCheck() => _guestAmount * 100;

        public void CheckGuestAmount()
        {
            if (_guestAmount <= 13)
                AddMannequins(13 - _guestAmount);
        }

        private void AddMannequins(int count)
        {
            for (int i = 0; i < count; i++)
                _guests.Add(new Guest());
        }
    }
}