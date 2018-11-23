using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Homework09.Lib;

namespace Homework09 {
    class Program {
        private string filePath = @"product.csv";
        static void Main (string[] args) {
            var call = new POSHomework09 ();
            var r = call.GetAllProducts ().ToList();
            
           
        }
    }
}