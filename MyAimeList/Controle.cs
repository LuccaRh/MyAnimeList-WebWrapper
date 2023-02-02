using HtmlAgilityPack;
using MyAnimeList;


int top = 100;
List<AnimeObject> lista = new List<AnimeObject> { new AnimeObject() };
for (int i = 0; i<top; i += 50)
{
    var url = "https://myanimelist.net/topanime.php?limit=" + i;
    var web = new HtmlWeb();
    var doc = web.Load(url);
    var nodes = doc.DocumentNode.SelectNodes("//h3[@class='hoverinfo_trigger fl-l fs14 fw-b anime_ranking_h3']");
    List<string> links = new List<string>();
    foreach (var node in nodes)
    {
        links.Add(node.FirstChild.GetAttributeValue("href", node.Name));
    }
    Funcoes func = new Funcoes();
    func.Listagem(links, lista);
}