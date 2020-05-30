using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_settings
{
    public class ERPDelivery_settings : ERPNextObjectBase
    {
        public ERPDelivery_settings() : this(new ERPObject(DocType.Delivery_settings)) { }
        public ERPDelivery_settings(ERPObject obj) : base(obj) { }

        public static ERPDelivery_settings Create(string dispatchtemplate, string dispatchattachment, int sendwithattachment, int stopdelay)

        {
            ERPDelivery_settings obj = new ERPDelivery_settings();
            obj.dispatch_template = dispatchtemplate;
            obj.dispatch_attachment = dispatchattachment;
            obj.send_with_attachment = sendwithattachment;
            obj.stop_delay = stopdelay;
            return obj;
        }

        public string dispatch_template
        {
            get { return data.dispatch_template; }
            set
            {
                data.dispatch_template = value;
                data.name = value;
            }

        }

        public string dispatch_attachment
        {
            get { return data.dispatch_attachment; }
            set { data.dispatch_attachment = value; }
        }

        private int _send_with_attachment = 0;
        public int send_with_attachment
        {
            get { return data._send_with_attachment; }
            set { data._send_with_attachment = value; }
        }

        private int _stop_delay = 0;
        public int stop_delay
        {
            get { return data._stop_delay; }
            set { data._stop_delay = value; }
        }


    }

    //Enums go here

}