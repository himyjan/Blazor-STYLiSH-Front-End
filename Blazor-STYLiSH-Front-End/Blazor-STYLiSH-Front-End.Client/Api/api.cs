using System.Net.Http.Json;
using STYLiSH.Model;

namespace STYLiSH.Api
{
  public class apiService
  {
    private static string hostname = "https://api.appworks-school.tw/api/1.0";
    private readonly HttpClient httpClient;

    public apiService(HttpClient httpClient)
    {
      httpClient.BaseAddress = new Uri("https://api.appworks-school.tw");
      this.httpClient = httpClient;
    }

    public async Task<ProductsSearch?> getProducts(string category, int paging)
    {
      try
      {
        HttpResponseMessage response = await httpClient.GetAsync($"{hostname}/products/{category}?paging={paging}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ProductsSearch>();
      }
      catch (HttpRequestException ex)
      {
        // Handle the exception here
        Console.WriteLine($"An error occurred: {ex.Message}");
        return null;
      }
    }
  }
}