using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MLDemo
{
    public class WebClient2
    {
        public static string ClassifyEmail(string email)
        {
            WebClient WC = new WebClient();
            WC.Headers["Content-type"] = "application/json";

            MemoryStream MS = new MemoryStream();
            DataContractJsonSerializer JSrz = new DataContractJsonSerializer(typeof(string));

            JSrz.WriteObject(MS, email);
            byte[] res1 = WC.UploadData("http://localhost:5000/todo/api/v1.0/classifyemail", "POST", MS.ToArray());
            string encodedString = System.Text.Encoding.ASCII.GetString(res1);
            return encodedString;
        }

        public static string[] AddTestSet(List<KeyValuePair<string, string>> data)
        {
            WebClient WC = new WebClient();
            WC.Headers["Content-type"] = "application/json";

            MemoryStream MS = new MemoryStream();
            DataContractJsonSerializer JSrz = new DataContractJsonSerializer(typeof(List<KeyValuePair<string, string>>));

            JSrz.WriteObject(MS, data);
            byte[] res1 = WC.UploadData("http://localhost:5000/todo/api/v1.0/sentiments", "POST", MS.ToArray());
            string encodedString = System.Text.Encoding.ASCII.GetString(res1);
            encodedString = encodedString.Replace("{", "");
            encodedString = encodedString.Replace("}", "");
            string[] sentiments = encodedString.Split(new char[] { ',' });
            return sentiments;
        }

        public static void AddTraining(List<KeyValuePair<string, string>> data)
        {
            WebClient WC = new WebClient();
            WC.Headers["Content-type"] = "application/json";

            MemoryStream MS = new MemoryStream();
            DataContractJsonSerializer JSrz = new DataContractJsonSerializer(typeof(List<KeyValuePair<string, string>>));

            JSrz.WriteObject(MS, data);
            byte[] res1 = WC.UploadData("http://localhost:5000/todo/api/v1.0/trainingset", "POST", MS.ToArray());
        }

        public static void GetTweets()
        {
            try
            {                
                {
                    WebRequest request = WebRequest.Create("http://localhost:5000/todo/api/v1.0/tweets");
                    request.ContentType = "application/json";
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string result = reader.ReadToEnd();
                    var detail = JsonConvert.DeserializeObject(result, typeof(Dictionary<string,string>));
                    response.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static void GetFeature()
        {
            try
            {
                {
                    WebRequest request = WebRequest.Create("http://localhost:5000/todo/api/v1.0/features");
                    request.ContentType = "application/json";
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string result = reader.ReadToEnd();
                    var detail = JsonConvert.DeserializeObject(result, typeof(Dictionary<string, string>));
                    response.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static void GetBuildtrainset()
        {
            try
            {
                {
                    WebRequest request = WebRequest.Create("http://localhost:5000/todo/api/v1.0/buildtrainset");
                    request.ContentType = "application/json";
                    WebResponse response = request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string result = reader.ReadToEnd();
                    var detail = JsonConvert.DeserializeObject(result, typeof(Dictionary<string, string>));
                    response.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
