// Language:       C#
// Web site:       http://www.ecma-international.org/publications/standards/Ecma-334.htm
// Last tested on: Linux Mint 17.3
// Requires:       apt-get install mono-gmcs

using System;
class FizzBuzz {
    static void Main() {
        for (int n = 1; n <= 100; n ++) {
            if (n % 15 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(n);
            }
        }
    }
}
