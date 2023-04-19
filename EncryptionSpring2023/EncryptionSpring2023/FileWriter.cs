using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// This is the template pattern; Modified by Tamer Ayoub 4/4/2023
namespace EncryptionSpring2023
{
    // in abstract, all the classes have to use all the methods implemented here
    // in any type of class, it is not good practice to call child methods from this class; other way around
    abstract class FileWriter
    {
        // this class will have a method append, but
        // sometimes it will be apending to an encrypted file
        // and sometimes not

        protected string path = "C:\\oop414\\AdvancedOOPtamer\\EncryptionSpring2023";

        // Step 1: Defer this to when we actually write the program later Or we could give default method
        // we are it sure now how or even if the file needs to be decrypted
        // this method is abstract because we want to make sure our subclasses inherit
        protected abstract void DecryptFile();

        // this would be step 2 , because you have to decrypt a file before appending to it 
        // this method is protected so our sub classes can inherit it
        protected virtual void AppendFile(string data)
        {
            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        // step 3 we need to potentially reencrypt the file -- but not necessarily 

        // protected means it can only be accesses by sub classes or this class, no other unrelated classes and access it,
        // but if the child classes decides to instead call it public later down to the road, then it will become available 
        protected abstract void EncryptFile();

        public void Append(string data)
        {
            // this is where we define a() b() c() d() ect. some of these may be abstract, some can be virtual, and some
            // can be virtual, and some can be just plain old methods that will never change 
            this.DecryptFile();
            this.AppendFile(data);
            this.EncryptFile();
        }



    }
}
