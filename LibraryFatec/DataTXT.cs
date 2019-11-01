using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFatec
{
    class DataTXT
    {
        private static string _fileUser = "usuario.txt";
        private static string _fileLivros = "livros.txt";
        private static string _fileLivrosAlugados = "livrosAlugados.txt";
        private static string _fileClientes = "clientes.txt";

        public static List<string> ReadFileUser()
        {
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileUser);

            foreach (string line in archive)
            {
                dados.Add(line.ToString());
            }

            return dados;
        }

        public static List<string> ReadFileLivros()
        {
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivros);

            foreach (string line in archive)
            {
                dados.Add(line.ToString());
            }

            return dados;
        }

        public static List<string> ReadFileClientes()
        {
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileClientes);

            foreach (string line in archive)
            {
                dados.Add(line.ToString());
            }

            return dados;
        }

        public static List<string> ReadFileLivrosAlugados()
        {
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivrosAlugados);

            foreach (string line in archive)
            {
                dados.Add(line.ToString());
            }

            return dados;
        }

        public static int QtdLivrosAlugadosCliente(int codigo)
        {
            int qtd = 0;
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivrosAlugados);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codigoCliente = Convert.ToInt32(array[2]);
                if (codigoCliente == codigo && array[6] == "")
                    qtd++;
            }
            return qtd;
        }

        public static int QtdLivrosAlugadosCodigo(int codigo)
        {
            int qtd = 0;
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivrosAlugados);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');

                int codigoTitulo = Convert.ToInt32(array[1]);
                if (codigoTitulo == codigo && array[6] == "")
                    qtd++;
            }
            return qtd;
        }

        public static int QtdLivrosTotalCodigo(int codigo)
        {
            int qtd = 0;
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivros);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codigoTitulo = Convert.ToInt32(array[1]);
                if (codigoTitulo == codigo)
                    qtd++;
            }
            return qtd;
        }

        public static string NomeCliente(int codigo)
        {
            string result = "";
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileClientes);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codigoCliente = Convert.ToInt32(array[0]);
                if (codigoCliente == codigo)
                    result = array[1].ToString();
            }

            return result;
        }

        public static string NomeLivro(int codigo)
        {
            string result = "";
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivros);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codigoLivro = Convert.ToInt32(array[0]);
                if (codigoLivro == codigo)
                    result = array[2].ToString();
            }

            return result;
        }

        public static bool InserirLinhaAluguel(string linhaAluguel)
        {
            StreamWriter file = File.AppendText(_fileLivrosAlugados);
            file.WriteLine(linhaAluguel);
            file.Close();
            return true;
        }

        public static bool VerificarLivroEmAluguel(int codigo)
        {
            bool valor = false;
            var dados = new List<string>();
            string[] archive = File.ReadAllLines(_fileLivrosAlugados);

            foreach (string line in archive)
                dados.Add(line.ToString());

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');

                int codigoTitulo = Convert.ToInt32(array[0]);
                if (codigoTitulo == codigo && array[6] == "")
                    valor = true;
            }
            return valor;
        }

        public static bool InserirLinhaDevolucao(string linhaAtual, string linhaNova)
        {
            string conteudoTxt, novoConteudoTxt;
            conteudoTxt = File.ReadAllText(_fileLivrosAlugados);
            novoConteudoTxt = conteudoTxt.Replace(linhaAtual, linhaNova);
            File.WriteAllText(_fileLivrosAlugados, novoConteudoTxt);
            return true;
        }
    }
}
