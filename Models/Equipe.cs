using E_Jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{   
    //: Herança -> EjogosBase
    public class Equipe : EjogosBase, IEquipe
    {
        private const string path = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        //

        public int IdEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }


        //

        private string Prepare(Equipe a)
        {
            return $"{a.IdEquipe};{a.Nome};{a.Imagem}";
        }


        public void Create(Equipe novaEquipe)
        {
            // recebe um objeto de equipe
            string[] equipeCadastro = { Prepare(novaEquipe)};


            // grava no csv
            File.AppendAllLines(path, equipeCadastro);
        }

        //


        public void Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }

        //

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe> ();

            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(";")[0]);
                equipe.Nome = item.Split(";")[1];
                equipe.Imagem = item.Split(";")[2];

                equipes.Add(equipe);
            }

            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
