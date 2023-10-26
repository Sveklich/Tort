namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Заказ тортов");
                Console.WriteLine("Выберите параметр");
                Console.WriteLine("-----------------");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Завершить заказ");
                Console.WriteLine("Цена: " + Order.itogCost);
                Console.WriteLine("Ваш торт: " + Order.itogName);
                int pos = Menu.Show(3, 9);
                Order order = new Order();
                order.Or(pos);
                if (pos == 9)
                {
                    ConsoleKeyInfo key;
                    Console.WriteLine("Благодарим за заказ! Если хотите сделать ещё один, нажмите Escape");
                    do
                    {
                        key = Console.ReadKey();
                    } while (key.Key != ConsoleKey.Escape);
                    Console.Clear();
                }
            }
        }
    }
}