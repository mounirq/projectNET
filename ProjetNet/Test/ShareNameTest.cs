﻿using System;
using ProjetNet.Models;

namespace ProjetNet.Test
{
    class ShareNameTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*    Test Get ShareName   *");
            Console.WriteLine("***************************");
            var ShareName = new ShareTools();
            Console.WriteLine(ShareTools.GetShareName("AC FP"));
            Console.WriteLine("**************Get ShareName****************");
            Console.ReadKey(true);
        }
    }
}
