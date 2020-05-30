using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sms_log
{
    public class ERPSms_log : ERPNextObjectBase
    {
        public ERPSms_log() : this(new ERPObject(DocType.Sms_log)) { }
        public ERPSms_log(ERPObject obj) : base(obj) { }

        public static ERPSms_log Create(string sendername, string senton, string message, int noofrequestedsms, string requestednumbers, int noofsentsms, string sentto)

        {
            ERPSms_log obj = new ERPSms_log();
            obj.sender_name = sendername;
            obj.sent_on = senton;
            obj.message = message;
            obj.no_of_requested_sms = noofrequestedsms;
            obj.requested_numbers = requestednumbers;
            obj.no_of_sent_sms = noofsentsms;
            obj.sent_to = sentto;
            return obj;
        }

        public string sender_name
        {
            get { return data.sender_name; }
            set
            {
                data.sender_name = value;
                data.name = value;
            }

        }

        public string sent_on
        {
            get { return data.sent_on; }
            set { data.sent_on = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        public int no_of_requested_sms
        {
            get { return data.no_of_requested_sms; }
            set { data.no_of_requested_sms = value; }
        }

        public string requested_numbers
        {
            get { return data.requested_numbers; }
            set { data.requested_numbers = value; }
        }

        public int no_of_sent_sms
        {
            get { return data.no_of_sent_sms; }
            set { data.no_of_sent_sms = value; }
        }

        public string sent_to
        {
            get { return data.sent_to; }
            set { data.sent_to = value; }
        }


    }

    //Enums go here

}