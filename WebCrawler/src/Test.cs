﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.src
{
    public class Test
    {
        public static void Main(string[] args)
        {
            string keyword;
            string text;

            Console.WriteLine("Enter the whole text");
            text = Console.ReadLine();
            Console.WriteLine("Enter the keyword to be searched");
            keyword = Console.ReadLine();

            BoyerMoore BM = new BoyerMoore(keyword);
            int idx_found = BM.Search(text);
            if (idx_found != -1)
            {
                Console.WriteLine("Keyword found at index: {0}", idx_found);
            }
            else
            {
                Console.WriteLine("Keyword not found in text");
            }

            KMP K = new KMP(keyword);
            idx_found = K.Search(text);
            if (idx_found != -1)
            {
                Console.WriteLine("Keyword found at index: {0}", idx_found);
            }
            else
            {
                Console.WriteLine("Keyword not found in text");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
