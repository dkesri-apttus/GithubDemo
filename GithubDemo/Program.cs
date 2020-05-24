using System;

namespace GithubDemo {
    class Program {
        static void Main(string[] args) {
            Maths math = new Maths();
            int a = 10;
            int b = 5;

            var sum = math.Add(a, b);
            var diff = math.Subtract(a, b);
            var multiplication = math.Multiply(a, b);            
        }
    }
}
