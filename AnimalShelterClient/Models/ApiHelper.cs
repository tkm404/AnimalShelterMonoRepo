using System.Threading.Tasks;
using RestSharp;

namespace AnimalShelterClient.Models
{
  public class ApiHelper
  {
    
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:8492");
      RestRequest request = new RestRequest($"api/animals", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:8492");
      RestRequest request = new RestRequest($"api/animals/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

  }
}