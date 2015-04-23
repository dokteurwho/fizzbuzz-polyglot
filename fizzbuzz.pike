#!/usr/local/bin/pike

// Language: Pike
// Web site: http://pike.lysator.liu.se/
// Linux Mint 17: Install from source:
//     http://pike.lysator.liu.se/pub/pike/latest-stable/Pike-v7.8.866.tar.gz

int main() {
    for (int i = 1; i <= 100; i ++) {
        if      (i % 15 == 0) { write("FizzBuzz\n"); }
        else if (i %  3 == 0) { write("Fizz\n"); }
        else if (i %  5 == 0) { write("Buzz\n"); }
        else                  { write(i + "\n"); }
    }
    return 0;
}
