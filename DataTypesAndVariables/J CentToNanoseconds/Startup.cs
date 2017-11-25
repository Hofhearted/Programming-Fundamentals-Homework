﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace J_CentToNanoseconds
{
    class Startup
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short) (centuries * 100);
            int days =(int) (years * 365.2422);
            int hours = (int) (days * 24);
            long minutes = (long) (hours * 60);
            ulong seconds = (ulong) (minutes * 60);
            ulong milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
