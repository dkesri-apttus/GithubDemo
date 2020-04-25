﻿using System;
using System.Collections.Generic;
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

        public int Divide(int a, int b) {
            if(b == 0) {
                throw new Exception("Invalid second parameter");
            }

            return a / b;
        }
    }
}
