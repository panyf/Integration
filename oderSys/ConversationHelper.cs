using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConversationAPI
{   
    public class ConversationHelper
    {
        private readonly string _Server; //protect the url address
        private readonly NetworkCredential _NetCredential; //protect the credential information

        /// <summary>
        /// constructor pass value of workSpaceID, userID, password
        /// </summary>
        /// <param name="workSpaceId">watson api workspace id</param>
        /// <param name="userId">watson api user id</param>
        /// <param name="password">watson api password id</param>
        public ConversationHelper(string workSpaceId, string userId, string password)
        {
            _Server = string.Format("https://gateway.watsonplatform.net/conversation/api/v1/workspaces/{0}/message?version={1}", workSpaceId, DateTime.Today.ToString("yyyy-MM-dd"));
            _NetCredential = new NetworkCredential(userId, password);
        }

        /// <summary>
        /// async method GetResponse post the value to the web and get return value
        /// </summary>
        /// <param name="input">what user input in the txtbox </param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async  Task<string> GetResponse(string input, string context = null)
        {
            string req = null;
            if (string.IsNullOrEmpty(context)) req = "{\"input\": {\"text\": \"" + input + "\"}, \"alternate_intents\": true}";
            else req = "{\"input\": {\"text\": \"" + input + "\"}, \"alternate_intents\": true}, \"context\": \"" + context + "\"";
            var handler = new HttpClientHandler();
            handler.Credentials = _NetCredential;
            //post and when finished release the resource
            using (var client = new HttpClient(handler))
            {
                var cont = new HttpRequestMessage();
                cont.Content = new StringContent(req.ToString(), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(_Server, cont.Content);//post to the web
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
