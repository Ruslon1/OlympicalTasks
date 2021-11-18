namespace TaskA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wedding wedding = new Wedding();
            List<Guest> guests = new();

            Console.Write("Введите кол-во гостей(от 1 до 20): ");

            int guestAmount = Convert.ToInt32(Console.ReadLine());

            if (guestAmount < 1 || guestAmount > 20)
            {
                Console.WriteLine("Проверьте правильность ввода");
                return;
            }

            for (int i = 0; i < guestAmount; i++)
                guests.Add(new Guest());


            wedding.AddGuest(guests);
            wedding.CheckGuestAmount();
            wedding.ShowGuests();

            Console.WriteLine("Коичество потраченных денег - " + wedding.CalculateTotalCheck());
        }
    }
}