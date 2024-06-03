using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat2.String_1
{
    /*
     Given two strings, 
    a and b, return the result of putting them together in the order abba, 
    e.g. "Hi" and "Bye" returns "HiByeByeHi".

    makeAbba("Hi", "Bye") → "HiByeByeHi"
    makeAbba("Yo", "Alice") → "YoAliceAliceYo"
    makeAbba("What", "Up") → "WhatUpUpWhat"
     */
    public class MakeAbba
    {
        public string makeAbba(string a, string b)
        {
            return a + b + b + a;
        }
        public static void Main33(string[] arg)
        {
            MakeAbba makeAbba = new MakeAbba();
            Console.WriteLine(makeAbba.makeAbba("Hi", "Bye"));
            Console.WriteLine(makeAbba.makeAbba("Yo", "Alice"));
            Console.WriteLine(makeAbba.makeAbba("Moha", "m"));
        }
    }
}
