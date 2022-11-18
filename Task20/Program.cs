Console.WriteLine("Введите координаты тички ХA");
            int xa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты тички YA");
            int ya = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты тички ХB");
            int xb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты тички YB");
            int yb = Convert.ToInt32(Console.ReadLine());

            double Quarter(int xa, int ya, int xb, int yb)
            {
                double xc = (xa - xb) * (xa - xb);
                double yc = (ya - yb) * (ya - yb);
                double result = Math.Sqrt(xc + yc);
                return result;
            }
            double res = Quarter(xa, ya, xb, yb);
            double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
            Console.WriteLine(resRound);