using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using Newtonsoft.Json;

namespace WalletDeveloper.Library.Proxy
{
    public class NetworkClient
    {
        public async Task<string> PostAsync(string path, object payload = null, int timeout = Configs.REST_REQUEST_TIMEOUT,
            List<KeyValuePair<string, string>> headers = null)
        {
            try
            {
                var httpClient = new HttpClient();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
                    }
                }
                httpClient.Timeout = TimeSpan.FromMinutes(timeout);

                string json = JsonConvert.SerializeObject(payload);
                var requestBody = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(path, requestBody);

                var httpStatusCode = (int)response.StatusCode;
                if (httpStatusCode == 200 || httpStatusCode == 201 || httpStatusCode == 202)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*public async Task<string> PostAsync(string path, object payload = null,
            int timeout = 240,
            object headers = null, object cookies = null)
        {
            try
            {
                var result = await new Url(path)
                    .WithTimeout(timeout)
                    .WithCookies(cookies ?? new { })
                    .WithHeaders(headers ?? new { })
                    .PostJsonAsync(payload ?? new object());

                if (result.IsSuccessStatusCode)
                {

                    return await result.Content.ReadAsStringAsync();
                }
                else
                {
                    return await result.Content.ReadAsStringAsync();
                }
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == HttpStatusCode.InternalServerError)
                    throw ex;

                throw ex;
            }
            catch (TaskCanceledException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }*/

        /*public async Task<string> GetAsync(string path, object queryParams = null, object headers = null, object cookies = null)
        {
            try
            {
                return await new Url(path)
                    .SetQueryParams(queryParams ?? new { })
                    .WithCookies(cookies ?? new { })
                    .WithTimeout(Configs.REST_REQUEST_TIMEOUT)
                    .WithHeaders(headers ?? new { })
                    .GetAsync().ReceiveString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
