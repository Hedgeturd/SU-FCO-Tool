﻿namespace SonicUnleashedFCOConv {
    class Program {
        static void Main(string[] args) {
            if(args.Length == 0) {
                Console.WriteLine("SonicUnleashedFCOConv v1.0\nUsage: SonicUnleashedFCOConv <.fco/.xml file>");
                return;
            }
            else {
                string file = Path.GetDirectoryName(args[0]) + "\\" + Path.GetFileName(args[0]);

                if(File.Exists(file)) {
                    if (file.EndsWith(".fco")) {
                        Common.TempCheck();
                        FCO.FCOtoXML(args[0]);
                    }
                    if (file.EndsWith(".xml")) {
                        Common.TempCheck();
                        XML.XMLtoFCO(args[0]);
                    }
                }
                else {
                    Console.WriteLine($"Can't find file {file}, aborting");
                    return;
                }
            }
        }
    }
}