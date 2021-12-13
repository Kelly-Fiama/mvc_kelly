using E_Jogos.Models;
using System.Collections.Generic;

namespace E_Jogos.Interface
{

    /// <summary>
    /// responsável por determinar quais métodos uma classe terá
    /// é o contrato da classe
    /// </summary>
    public interface IEquipe
    {
        //CREATE
        void Create(Equipe novaEquipe);

        //READ ALL
        List<Equipe> ReadAll();

        //UPDATE
        void Update(Equipe equipe);

        //DELETE
        void Delete(int idEquipe);
    }
}
