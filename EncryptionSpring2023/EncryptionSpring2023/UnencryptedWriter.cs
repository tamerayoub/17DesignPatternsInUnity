using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSpring2023
{
    public class UnencryptedWriter : FileWriter
    {

        public UnencryptedWriter(string aPath)
        {
            this.path = aPath;
        }

        // only child classes can use protected methods, other unrelated classes cannot

        // Step 1 - we dont need to do anything
        protected override void DecryptFile()
        {
            // file is already decrypted, dont need to decrypt
            // but we DO NEED to make this method
        }

        // step 2: we dont need to do anything because we inherit it

        // step 3: we dont need to do anything,but we need to make method because it was abstract
        protected override void EncryptFile()
        {
            // file is already decrypted, dont need to decrypt
            // but we DO NEED to make this method
        }

    }
}
