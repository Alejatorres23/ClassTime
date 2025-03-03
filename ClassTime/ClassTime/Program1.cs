using ClassTime;

        try
        {
            var t1 = new Time();
            var t2 = new Time(14);
            var t3 = new Time(9, 34);
            var t4 = new Time(19, 45, 56);
            var t5 = new Time(23, 3, 45, 678);

            var times = new[] { t1, t2, t3, t4, t5 };

            foreach (var time in times)
            {
                Console.WriteLine($"Time: {time}");
                Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds(),15:N0}");
                Console.WriteLine($"\tSeconds     : {time.ToSeconds(),15:N0}");
                Console.WriteLine($"\tMinutes     : {time.ToMinutes(),15:N0}");
                Console.WriteLine($"\tAdd         : {time.Add(t3)}");
                Console.WriteLine($"\tIs other day: {time.IsOtherDay(t4)}");
                Console.WriteLine();
            }

            Console.WriteLine($"t1 + t3 = {t1.Add(t3)}, IsOtherDay: {t1.IsOtherDay(t3)}");
            Console.WriteLine($"t1 + t4 = {t1.Add(t4)}, IsOtherDay: {t1.IsOtherDay(t4)}");
            Console.WriteLine($"t2 + t3 = {t2.Add(t3)}, IsOtherDay: {t2.IsOtherDay(t3)}");
            Console.WriteLine($"t2 + t4 = {t2.Add(t4)}, IsOtherDay: {t2.IsOtherDay(t4)}");
            Console.WriteLine($"t3 + t3 = {t3.Add(t3)}, IsOtherDay: {t3.IsOtherDay(t3)}");
            Console.WriteLine($"t3 + t4 = {t3.Add(t4)}, IsOtherDay: {t3.IsOtherDay(t4)}");
            Console.WriteLine($"t4 + t3 = {t4.Add(t3)}, IsOtherDay: {t4.IsOtherDay(t3)}");
            Console.WriteLine($"t4 + t4 = {t4.Add(t4)}, IsOtherDay: {t4.IsOtherDay(t4)}");
            Console.WriteLine($"t5 + t3 = {t5.Add(t3)}, IsOtherDay: {t5.IsOtherDay(t3)}");
            Console.WriteLine($"t5 + t4 = {t5.Add(t4)}, IsOtherDay: {t5.IsOtherDay(t4)}");

            var t6 = new Time(45, -7, 90, -87); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
 