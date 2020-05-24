using System;
using System.Text;

namespace GithubDemo {
    public class Maths {
        public int Add(int a, int b) {
            return a + b;
        }

        public int Subtract(int a, int b) {
            return a - b;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        /// <summary>
        /// Divides a number by another one
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Divide(int a, int b) {
            return a / b;
        }
    }
}
