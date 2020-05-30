using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Datev_settings
{
    public class ERPDatev_settings : ERPNextObjectBase
    {
        public ERPDatev_settings() : this(new ERPObject(DocType.Datev_settings)) { }
        public ERPDatev_settings(ERPObject obj) : base(obj) { }

        public static ERPDatev_settings Create(string client, string clientnumber, string consultantnumber)

        {
            ERPDatev_settings obj = new ERPDatev_settings();
            obj.client = client;
            obj.client_number = clientnumber;
            obj.consultant_number = consultantnumber;
            return obj;
        }

        public string client
        {
            get { return data.client; }
            set
            {
                data.client = value;
                data.name = value;
            }

        }

        public string client_number
        {
            get { return data.client_number; }
            set { data.client_number = value; }
        }

        public string consultant_number
        {
            get { return data.consultant_number; }
            set { data.consultant_number = value; }
        }

        public string consultant
        {
            get { return data.consultant; }
            set { data.consultant = value; }
        }


    }

    //Enums go here

}