using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace lab5_updated
{
    //creates objects based on the specified string
    class Factory
    {
        
        //constructor that takes in filepath and listbox object 
        //updates the listbox with modules from file in an ascending order
        public Factory(string filePath, System.Windows.Forms.ListBox box)
        {
            FileInfo fi = new FileInfo(filePath);
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            box.Items.Clear();
           


            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader(fs))
            {
                string line;

                while ((line = r.ReadLine()) != null)
                {

                    box.Items.Add(line);

                }

                box.Sorted = true; //sort the list in ascending order
                Debug.WriteLine(box.Items);



            }


        }


      //use reflection to create an instance of the class passed as string and execute it's compute() method 
        public void createModule(string moduleName)
        {
            
            Debug.WriteLine(moduleName);

    
            Type t = Type.GetType("lab5_updated." + moduleName);
            ConstructorInfo c = t.GetConstructor(Type.EmptyTypes);
            object module = c.Invoke(null);
            Debug.WriteLine(Type.GetType(module.ToString()));
    




        }

    }
}
