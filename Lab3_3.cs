using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RestfulServiceClient
{
    static HttpClient client = new HttpClient();

    public static async Task<string> Encrypt(string plaintext)
    {
        try
        {
            var myURI = "https://venus.sod.asu.edu/WSRepository/Services/EncryptionRest/Service.svc/Encrypt?text=" + plaintext;

            HttpResponseMessage response = await client.GetAsync(myURI);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            // Console.WriteLine(responseBody);
            return responseBody;
        }

        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            return "Your message here";
        }

    }

    public static async Task<string> Decrypt(string ciphertext)
    {
        try
        {
            var myURI = "https://venus.sod.asu.edu/WSRepository/Services/EncryptionRest/Service.svc/Decrypt?text=" + ciphertext;

            HttpResponseMessage response = await client.GetAsync(myURI);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            // Console.WriteLine(responseBody);
            return responseBody;
        }

        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            return "Your message here";
        }

    }


    // public static async Task<string> Fred()
    // {
    //     // Call asynchronous network methods in a try/catch block to handle exceptions.
    //     try
    //     {
    //         var myURI = "https://venus.sod.asu.edu/WSRepository/Services/EncryptionRest/Service.svc/Encrypt?text=" + "plaintext";

    //         HttpResponseMessage response = await client.GetAsync(myURI);
    //         response.EnsureSuccessStatusCode();
    //         string responseBody = await response.Content.ReadAsStringAsync();
    //         // Above three lines can be replaced with new helper method below
    //         // string responseBody = await client.GetStringAsync(uri);
    //         Console.WriteLine(responseBody);
    //         return responseBody;
    //     }

    //     catch (HttpRequestException e)
    //     {
    //         Console.WriteLine("\nException Caught!");
    //         Console.WriteLine("Message :{0} ", e.Message);
    //         return "Your message here";
    //     }

    // }
}