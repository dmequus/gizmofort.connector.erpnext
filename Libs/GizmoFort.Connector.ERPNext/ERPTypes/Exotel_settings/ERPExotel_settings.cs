using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Exotel_settings
{
    public class ERPExotel_settings : ERPNextObjectBase
    {
        public ERPExotel_settings() : this(new ERPObject(DocType.Exotel_settings)) { }
        public ERPExotel_settings(ERPObject obj) : base(obj) { }

        public static ERPExotel_settings Create()

        {
            ERPExotel_settings obj = new ERPExotel_settings();
            return obj;
        }

        private int _enabled = 0;
        public int enabled
        {
            get { return data._enabled; }
            set { data._enabled = value; }
        }

        public string account_sid
        {
            get { return data.account_sid; }
            set { data.account_sid = value; }
        }

        public string api_token
        {
            get { return data.api_token; }
            set { data.api_token = value; }
        }

        public string api_key
        {
            get { return data.api_key; }
            set { data.api_key = value; }
        }


    }

    //Enums go here

}