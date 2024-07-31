namespace BlocoFinally
{
    internal class Program
    {
        public static void Main()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }

                Console.WriteLine("Closed");
            }
        }
    }
}
