using System.Threading.Tasks;
using Flurl.Http;
using Wellness.Model;

namespace Wellness.WinUI
{
    class APIService
    {
        private string _route = null;
        public static string _username { get; set; }
        public static string _password { get; set; }
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _route}";
            //var result =await $"{ Properties.Settings.Default.APIUrl}/{ _route}".GetJsonAsync<T>();

            if(search!=null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(_username, _password).GetJsonAsync<T>();
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _route}/{id}";
            return await url.WithBasicAuth(_username,_password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _route}";
            return await url.WithBasicAuth(_username, _password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id,object request)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _route}/{id}";
            var result = await url.WithBasicAuth(_username, _password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
