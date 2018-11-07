using System.IO;

namespace DatabaseGenerator
{
    internal class FileWriter
    {
        private const string Path = "";

        public FileWriter(string insertions)
        {
            using (StreamWriter writer = new StreamWriter(Path, true))
            {
                writer.Write(insertions);
            }
        }
    }
}
