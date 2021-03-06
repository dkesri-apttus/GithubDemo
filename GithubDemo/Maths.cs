﻿using System;
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
        /// Method summary
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Divide(float a, float b) {
            if(b == 0) {
                throw new Exception("Second parameter must not be zero");
            }
            return a / b;
        }
    }
}
