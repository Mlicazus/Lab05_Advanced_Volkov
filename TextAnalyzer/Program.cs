string menuChoice;
do
{
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
    menuChoice = Console.ReadLine();
    switch (menuChoice)
    {
        case "1":
            System.Console.Write("Ваше предложение: ");
            string sentence1 = System.Console.ReadLine();
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string consonants = "бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            string space = " ";
            int vowelsCount = 0;
            int consonantsCount = 0;
            int spaceCount = 0;
            foreach (char symbol in sentence1)
            {
                if (vowels.Contains(symbol))
                {
                    vowelsCount++;
                    continue;
                }
                if (consonants.Contains(symbol))
                {
                    consonantsCount++;
                    continue;
                }
                if (space.Contains(symbol))
                {
                    spaceCount++;
                    continue;
                }
            }
            System.Console.WriteLine($"Кол-во символов: {sentence1.Length}");
            System.Console.WriteLine($"Кол-во гласных: {vowelsCount}");
            System.Console.WriteLine($"Кол-во согласных: {consonantsCount}");
            System.Console.WriteLine($"Кол-во пробелов: {spaceCount}");
            break;
        case "2":
            System.Console.Write("Ваше предложение: ");
            string sentence2 = System.Console.ReadLine();
            string capital = "АЕЁИОУЫЭЮЯБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            bool flag = false;
            int index = -1;
            for (int i = 0; i < sentence2.Length; i++)
            {
                if (capital.Contains(sentence2[i]))
                {
                    index = i;
                    break;
                }

            }
            if (index != -1)
            {
                System.Console.WriteLine($"Позиция первой заглавной буквы: {index}");
            }
            else
            {
                System.Console.WriteLine("Заглавных букв нет");
            }
            break;
        case "0":
            Console.WriteLine("До свидания!");
            break;
        default:
            Console.WriteLine("Такого пункта нет, попробуйте снова.");
            break;
    }
} while (menuChoice != "0");