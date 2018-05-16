using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScifiStarNameGenerator;

namespace ScifiStarNameGeneratorExample {
    class Program {
        static void Main(string[] args) {
            StarNameGenerator generator = new StarNameGenerator();

            Console.WriteLine("-- Generating 20 names with following format: V,C,V,C,FA");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("V,C,V,C,FA")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with following format: C,V,C,V,FA");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("C,V,C,V,FA")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with following format: VD,CD,V,C");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("VD,CD,V,C")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with following format: CD,VD,C,V");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("CD,VD,C,V")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with following format: V,C,V,C");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("V,C,V,C")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with following format: C,V,C,V");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName("C,V,C,V")));
            }

            Console.WriteLine("\n\n\n-- Generating 20 names with prefix Greek letter names (i.e Alpha, Epsilon, etc): (format) GLN, ,C,V,C,V");
            for (int i = 0; i < 20; i++) {
                if (i % 5 == 0) {
                    Console.Write("\n\n");
                }

                Console.Write(string.Format("{0}, ", generator.GenerateName()));
            }

            Console.WriteLine("\n");
        }
    }
}
