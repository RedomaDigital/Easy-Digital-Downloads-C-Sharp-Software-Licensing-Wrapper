using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EDDSoftwareLicensing
{
    public class Licensing
    {
        private string DomainUrl { get; set; }
        private string LicenseKey { get; set; }
        private string ItemName { get; set;  }

        protected void GetLicensing()
        {
            // code copylefted from EasyDigitalDownloads.com
            // http://docs.easydigitaldownloads.com/article/1037-software-licensing-api---example-using-c-sharp

            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create("https://<domain.com>/edd-sl");
            
            // Set the Method property of the request to POST.
            request.Method = "POST";
            
            // Create POST data and convert it to a byte array. Do not include the URL if you do URL verification in the EDD SL settings
            string postData = "edd_action=check_license&license=<license key>&item_name=<item name>&url=<domain.com>";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            
            // Get the response.
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            
            // Read the content. This is the response from the Software Licensing API
            string responseFromServer = reader.ReadToEnd();
            
            // Display the content
            Console.WriteLine(responseFromServer);
            
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
        }

        public void ValidateLicensing()
        {

        }

        public void Activate()
        {

        }

        public void DeActivate()
        {

        }

    }
}
