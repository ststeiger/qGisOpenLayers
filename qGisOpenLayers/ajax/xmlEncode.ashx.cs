
namespace qGisOpenLayers.ajax
{


    /// <summary>
    /// Zusammenfassungsbeschreibung für xmlEncode
    /// </summary>
    public class xmlEncode : System.Web.IHttpHandler
    {


        public void ProcessRequest(System.Web.HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string input = "Hello Wörld äöü ÄÖÜäöüàéèâêû'áéóñ";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < input.Length; ++i)
            {
                sb.AppendFormat("&#{0};", (int)input[i]);
            }

            context.Response.Write(sb.ToString());
            sb.Length = 0;
            sb = null;
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }


}
