namespace Umbraco
{
    public class ApiCall
    {
        public string value { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
    }


    public class ApiClient
    {
        public static async Task<ApiCall?> GetApiResponseAsync()
        {
            var client = new HttpClient();

            try
            {
                var result = await client.GetFromJsonAsync<ApiCall>("https://api.chucknorris.io/jokes/random");
                return result;
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
            
        } 
    }
}
