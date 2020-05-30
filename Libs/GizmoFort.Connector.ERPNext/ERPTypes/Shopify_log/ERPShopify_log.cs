using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shopify_log
{
    public class ERPShopify_log : ERPNextObjectBase
    {
        public ERPShopify_log() : this(new ERPObject(DocType.Shopify_log)) { }
        public ERPShopify_log(ERPObject obj) : base(obj) { }

        public static ERPShopify_log Create(string title, string status, string method, string message, string traceback, string requestdata)

        {
            ERPShopify_log obj = new ERPShopify_log();
            obj.title = title;
            obj.status = status;
            obj.method = method;
            obj.message = message;
            obj.traceback = traceback;
            obj.request_data = requestdata;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        public string method
        {
            get { return data.method; }
            set { data.method = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        public string traceback
        {
            get { return data.traceback; }
            set { data.traceback = value; }
        }

        public string request_data
        {
            get { return data.request_data; }
            set { data.request_data = value; }
        }


    }

    //Enums go here

}