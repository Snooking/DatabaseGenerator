using System.IO;

namespace DatabaseGenerator
{
    internal class FileWriter
    {
        public void WriteToFile(string path, string value)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(value);
            }
        }
    }
}
