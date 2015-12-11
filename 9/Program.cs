using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{

    class Program
    {

        static void Main(string[] args)
        {
            string Root = "D:\\";
            string Root2 = "D:\\test\\";
            string FinalDirectory;
            string FinalFile;
            string[] fileList;
            string cont;


            bool end = true;
            do
            {
                string directoryName;
                System.Console.WriteLine("Enter a directory name: ");
                directoryName = System.Console.ReadLine();
                FinalDirectory = Root + directoryName;
                if (Directory.Exists(FinalDirectory))
                {
                    System.Console.WriteLine("would you like to continue? If not, type 'end'");

                    cont = System.Console.ReadLine();
                    if (cont == "end")
                    {
                        end = false;
                    }
                    else if (cont == "n")
                    {
                        end = true;
                    }
                    fileList = Directory.GetFiles(FinalDirectory);
                    for (int i = 0; i < fileList.Length; i++)
                    {
                        System.Console.WriteLine(fileList[i]);
                    }

                    string FileName;
                    System.Console.WriteLine("Enter a File name: ");
                    FileName = System.Console.ReadLine();
                    FinalFile = Root2 + FileName;
                    if (File.Exists(FinalFile))
                    {
                        System.Console.WriteLine("would you like to continue? If not, type 'end'");

                        cont = System.Console.ReadLine();
                        if (cont == "end")
                        {
                            end = false;
                        }
                        else if (cont == "n")
                        {
                            end = true;
                        }


                        System.Console.WriteLine(File.GetCreationTime(FinalFile));




                    }
                    else
                    {
                        System.Console.WriteLine("The file with that name does not exist");
                    }

                }
                else
                {
                    System.Console.WriteLine("The directory with that name does not exist");
                }
                System.Console.WriteLine("would you like to continue? If not, type 'end'");

                cont = System.Console.ReadLine();
                if (cont == "end")
                {
                    end = false;
                }
                else if (cont == "n")
                {
                    end = true;
                }




            }
            while (end == true);

            System.Console.WriteLine("the program is done now");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");
            System.Console.WriteLine("byeeeeeeee");


        }
    }
}