namespace ExercicioPropostoDictionary;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a file full path: ");
        string filePath = Console.ReadLine();
        Dictionary<string, int> candidatos = new Dictionary<string, int>();
        
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] splittedLine = line.Split(",");
                string nome = splittedLine[0];
                int votos = int.Parse(splittedLine[1]);

                if (!candidatos.TryAdd(nome, votos))
                {
                    candidatos[nome] += votos;
                }
            }

            foreach (var candidato in candidatos.Keys)
            {
                Console.WriteLine($"{candidato}: {candidatos[candidato]}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}