namespace doubly_linked_list
{
    public class Program
    {

        public static void Main()
        {
            LinkedList list = new LinkedList();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                list.print();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Создать новый список");
                Console.WriteLine("2 - Добавить элемент в конец списка");
                Console.WriteLine("3 - Добавить элемент в произвольное место в списке");
                Console.WriteLine("4 - Удалить элемент из списка");
                Console.WriteLine("0 - Выход");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        list.createNew();
                        break;
                    case '2':
                        addToEnd(list);
                        break;
                    case '3':
                        addToId(list);
                        break;
                    case '4':
                        deleteById(list);
                        break;
                    case '0':
                        isRunning = false;
                        break;
                }

                Console.WriteLine("Нажмите любую кнопку чтобы продолжить...");
                Console.ReadKey();
            }
        }

        public static void addToEnd(LinkedList list)
        {
            Console.WriteLine("Введите значение нового элемента: ");
            int value = Convert.ToInt32(Console.ReadLine());

            list.addToEnd(value);

            Console.WriteLine("Новый элемент был добавлен успешно!");
        }

        public static void addToId(LinkedList list)
        {
            Console.Write("Введите ID нового элемента: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение для нового элемента: ");
            int value = Convert.ToInt32(Console.ReadLine());

            bool result = list.addToId(id, value);

            if (result is false)
                Console.WriteLine("Ошибка: уже существует элемент с данным id!");
            else
                Console.WriteLine("Элемент был добавлен успешно!");
        }

        public static void deleteById(LinkedList list)
        {
            Console.Write("Введите ID элемента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            list.deleteById(id);

            Console.WriteLine("Элемент был успешно удалён из списка");
        }
    }
}