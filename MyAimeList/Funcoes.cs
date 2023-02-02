using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyAnimeList
{
    public class Funcoes
    {
        public void Listagem(List<string> links, List<AnimeObject> lista)
        {
            CommSql commSql= new CommSql();
            foreach (var link in links)
            {
                AnimeObject anime = new AnimeObject();
                var weblink = new HtmlWeb();
                var linkdoc = weblink.Load(link);
                string titulo = linkdoc.DocumentNode.SelectSingleNode("//h1[@class='title-name h1_bold_none']").InnerText;
                Console.Write(titulo + " ");
                anime.titulo = titulo;

                string scoreString = linkdoc.DocumentNode.SelectSingleNode("//div[@data-title='score']").InnerText;
                scoreString = Regex.Replace(scoreString, "[.]", ",");
                float score = float.Parse(scoreString);
                Console.Write(score + " ");
                anime.score = score;

                var nodeRank = linkdoc.DocumentNode.SelectSingleNode("//span[@class='numbers ranked']").Descendants("strong");
                string rankString = string.Empty;
                int rank = 0;
                foreach (var node in nodeRank)
                {
                    rankString = node.InnerText;
                    rankString = Regex.Replace(rankString, "[#]", string.Empty);
                    rank = int.Parse(rankString);
                }
                Console.Write(rank + " ");
                anime.rank = rank;

                var nodePopularidade = linkdoc.DocumentNode.SelectSingleNode("//span[@class='numbers popularity']").Descendants("strong");
                string popularidadeString = string.Empty;
                int popularidade = 0;
                foreach (var node in nodePopularidade)
                {
                    popularidadeString = node.InnerText;
                    popularidadeString = Regex.Replace(popularidadeString, "[#]", string.Empty);
                    popularidade = Int32.Parse(popularidadeString);
                }
                Console.Write(popularidade + " ");
                anime.popularidade = popularidade;

                var nodeMembros = linkdoc.DocumentNode.SelectSingleNode("//span[@class='numbers members']").Descendants("strong");
                string membrosString = string.Empty;
                int membros = 0;
                foreach (var node in nodeMembros)
                {
                    membrosString = node.InnerText;
                    membrosString = Regex.Replace(membrosString, "[,]", string.Empty);
                    membros = Int32.Parse(membrosString);
                }
                Console.Write(membros);
                anime.membros = membros;
                Console.WriteLine();
                lista.Add(anime);
                commSql.Cadastrar(anime);
            }
        }
    }
}
