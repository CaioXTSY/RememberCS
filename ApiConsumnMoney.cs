using System;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

string url = "https://economia.awesomeapi.com.br/json/last/USD-BRL";
using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync(url);
    if (response.IsSuccessStatusCode)
    {
        string responseBody = await response.Content.ReadAsStringAsync();
        var cotationData = JsonSerializer.Deserialize<JsonElement>(responseBody);
        var usdToBrl = cotationData.GetProperty("USDBRL");
        decimal bidPrice = Convert.ToDecimal(usdToBrl.GetProperty("bid").GetString(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor que deseja converter:");
        string amountToConvert = Console.ReadLine();
        decimal amountToConvertDecimal;
        if (decimal.TryParse(amountToConvert, NumberStyles.Any, CultureInfo.InvariantCulture, out amountToConvertDecimal))
        {
            decimal convertedValue = (amountToConvertDecimal * bidPrice);
            string formattedValue = convertedValue.ToString("C", new CultureInfo("pt-BR"));
            Console.WriteLine($"{amountToConvertDecimal} USD é igual a {formattedValue}");
        }
        else
        {
            Console.WriteLine("Valor digitado não é um número válido.");
        }
    }
    else
    {
        Console.WriteLine("Não foi possível obter a cotação.");
    }
}
