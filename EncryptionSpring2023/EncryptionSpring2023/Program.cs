using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EncryptionSpring2023;

public class Program
{
    public void Main(string[] args)
    {
        FileWriter fw = new DESWriter("C:/oop414/AdvancedOOPtamer/EncryptionSpring2023");
        fw.Append("All work and no play makes jack a dull boy");

        fw = new UnencryptedWriter("C:/oop414/AdvancedOOPtamer/EncryptionSpring2023");
        fw.Append("All work and no play makes Janice a dull girl");
    }
}