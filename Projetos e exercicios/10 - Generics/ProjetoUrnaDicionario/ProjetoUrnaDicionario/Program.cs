namespace Projeto {
    public class Program {
        public static void Main() {
            string path = @"C:\Users\altai\OneDrive\Documentos\C#\Projetos\CSharp\Projetos e exercicios\10 - Generics\ProjetoUrnaDicionario\ProjetoUrnaDicionario\FileUrnas.csv";
            ManipularArquivo();

            string[] linhas = File.ReadAllLines(path);

            Dictionary<string, int> votos = new();

            for (int line = 0; line < linhas.Length; line++) {
                string[] dicionario = linhas[line].Split(",");

                string dicionarioKey = dicionario[0];
                string stringDicionarioValue = dicionario[1];

                int dicionarioValue = int.Parse(stringDicionarioValue);

                if (votos.ContainsKey(dicionario[0])) {
                    int variavelAuxiliar = votos[dicionario[0]];

                    int novoValor = variavelAuxiliar + dicionarioValue;

                    try {
                        votos[dicionario[0]] = novoValor;
                    }
                    catch(Exception e) {
                        Console.WriteLine("Ocorreu um erro: " + e.Message);
                    }
                }
                else {
                    votos.Add(dicionarioKey, dicionarioValue);
                }
            }

            foreach (var voto in votos) {
                Console.WriteLine(voto.Key + ": " + voto.Value);
            }
        }

        public static void ManipularArquivo() {
            string path = @"C:\Users\altai\OneDrive\Documentos\C#\Projetos\CSharp\Projetos e exercicios\10 - Generics\ProjetoUrnaDicionario\ProjetoUrnaDicionario\FileUrnas.csv";
            if (!File.Exists(path)) {
                FileStream fs = new(path, FileMode.Create);
                fs.Close();

                using (StreamWriter sw = File.AppendText(path)) {
                    sw.Write("Alex Blue,15\r\nMaria Green,22\r\nBob Brown,21\r\nAlex Blue,30\r\nBob Brown,15\r\nMaria Green,27\r\nMaria Green,22\r\nBob Brown,25\r\nAlex Blue,31");
                }
            }
        }
    }
}