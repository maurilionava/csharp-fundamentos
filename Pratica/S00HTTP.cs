public class HTTPClientTeste
{
    public void Teste()
    {
        try
        {
            var url = "https://www.macoratti.net/dados/";
            var arquivo = "poesia.txt";
            url = Path.Combine(url, arquivo);
            
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("requisição processada com sucesso");
            }
            else
            {
                throw new HttpRequestException($"erro: {(int)response.StatusCode}");
            }
        }
        catch (HttpRequestException e)
        {
            System.Console.WriteLine($"tratamento de exceção");
            System.Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"erro genérico: {e.Message}");
        }
        finally
        {
            System.Console.WriteLine("processamento finalizado");
        }
    }
}