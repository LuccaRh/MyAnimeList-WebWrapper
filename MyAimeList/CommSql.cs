using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeList
{
    public class CommSql
    {
        public bool Cadastrar(AnimeObject anime)
        {
            using var connection = new BdConnection().AbrirConexao();
            string query = @"INSERT INTO MyAnimeList.dbo.Animes (Titulo, Score, Rank, Popularidade, Membros) 
                             VALUES (@titulo, @score, @rank, @popularidade, @membros);";
            connection.Execute(query, anime);
            return true;
        }
    }
}
