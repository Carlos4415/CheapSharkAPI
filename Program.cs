// Este programa realiza uma requisição à API CheapShark para obter uma lista de promoções de jogos disponíveis.
// Ele utiliza o endpoint https://www.cheapshark.com/api/1.0/deals para buscar os dados e exibe as promoções 
// na tela de forma organizada, incluindo informações como título do jogo, preço original, preço com desconto e percentual de economia.


using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposta);
}