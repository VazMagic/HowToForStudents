using HowTo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HowTo.Processes
{
    public static class TexFiletInputOutput
    {
        private static List<PersonsModel> customers;

        public static List<PersonsModel> GetGuardiansData(string file)
        {
            customers = new List<PersonsModel>();
            string line = string.Empty;

            try
            {
                //Check if the file exists
                if (File.Exists(file))
                {
                    //Create a Stream Reader
                    using (StreamReader rdr = new StreamReader(file))
                    {
                        //Read the data in the file
                        while ((line = rdr.ReadLine()) != null)
                        {
                            //Add data to the Customers Model
                            customers.Add(new PersonsModel()
                            {
                                Person = line
                            });
                        }
                    }
                }
                else
                {
                    throw new Exception("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customers;
        }

        public static bool ExportDataToTextFile(List<PersonsModel> data, string file)
        {
            try
            {
                //We want to 
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        writer.WriteLine(d.Person.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
