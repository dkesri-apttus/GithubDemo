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
        /// Divides a number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Divide(float a, float b) {
            return a / b;
        }
    }
}
