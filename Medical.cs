using System;
using System.Collections.Generic;

using System.Threading.Tasks;

using ConsoleAppBook;
using SampleFrameWorksApp;

namespace SampleFrameWorksApp
{

    class Collecting
    {

        public string Diseases { get; set; }
        public string Symptoms { get; set; }

        public string Description { get; set; }

    }

}
    namespace UILayer
    {

        class UIComponent
        {
            private static BookRepository repo;
            public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MEDICAL RESEARCH CENTER~~~~~~~~~~~~~~~~~~~" +
                "\nTO ADD NEW DISEASES------------------------>PRESS 1\n" +
            
               
                "\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";



            public static void Run()
            {
                //int size = Utilities.GetNumber("Enter the no of diseases");
               // repo = new BookRepository(size);
                bool processing = true;
                do
                {
                    string choice = Utilities.Prompt(menu);
                    processing = processMenu(choice);
                } while (processing);
                Console.WriteLine("Thanks for Using our Application!");
            }

            private static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "1":
                        AddingDiseases();
                        break;
                case "2":
                    FindDiseases();
                    break;
                case "3":
                    PaitentDesiases();
                    break;


                default:
                        return false;
                }
                return true;
            }
        private static void AddingDiseases()
        {
            try
            {
                string Des = Utilities.Prompt("Enter the Diseases");
                string Sym = Utilities.Prompt("Enter the symptoms");
                string Descript = Utilities.Prompt("Enter the Description");







                Collecting col = new Collecting { Diseases = Des, Symptoms = Sym, Description=Descript };
               // string[]  = new string[0];


                Console.WriteLine("diseases added,  " + Des + "  and  " + Sym + "and" +Descript);

                Utilities.Prompt("Press Enter to clear the Screen");
                Console.Clear();
            }catch(Exception)
            {
                throw new Exception("enter only in string type");
            }

            }
        
        
           
            private static void FindDiseases()
            {
                string Title = Utilities.Prompt("enter the diseases to search");
                
            }


        private static void PaitentDesiases()
        {
            string Title = Utilities.Prompt("enter the paitent name");

        }
    }

        internal class BookRepository
        {
            private int size;

            public BookRepository(int size)
            {
                this.size = size;
            }
        }
    }

    class Medical
    {
        static void Main(string[] args)
        {
            UILayer.UIComponent.Run();
        }
    }

