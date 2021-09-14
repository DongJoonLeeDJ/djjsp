using System;

namespace HelloWorld {
    class Program {
        static void Main (string[] args) {
            // for(int i = 10; i>0; i--)
            // {
            //     Console.WriteLine($"{i} is i");
            // }

            string start = "1";
             Console.WriteLine ("input");
            string input_s = Console.ReadLine();
            int.TryParse (input_s, out int input);
            Console.WriteLine ("start");

            for (int i = 0; i < input; i++) {
                Console.WriteLine ($"{i+1}번째 : {start}");

                string end = "";
                char number = start[0];
                int count = 0;
                for (int j = 0; j < start.Length; j++) {
                    if (start[j] != number) {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    } else {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }

            //1                         = 1
            //1이 1개                   = 11
            //1이 2개                   = 12
            //1이 1개, 2가 1개          = 1121
            //1이 2개 2가 1개 1이 1개   = 122111
            //1이 1개 2가 2개 1이 3개   = 112213
            
            Console.WriteLine ("End");
        }
    }
}