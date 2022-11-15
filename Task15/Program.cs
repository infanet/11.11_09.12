Console.WriteLine("Введи цифру и я тебе скажу является ли он выходным");
            int num = Convert.ToInt32(Console.ReadLine());
            bool Weekends(int num)
            {
                bool n = true;
                if (num == 1) n = false;
                if (num == 2) n = false;
                if (num == 3) n = false;
                if (num == 4) n = false;
                if (num == 5) n = false;
                if (num == 6) n = true;
                if (num == 7) n = true;
                return n;
            }
            bool Week(int num)
            {
                return num > 7 || num <= 0;
            }
            Console.WriteLine(Week(num) ? "Такого дня недели нет" : Weekends(num) ? "Да" : "Нет");