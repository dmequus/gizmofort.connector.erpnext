using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Campaign_email_schedule
{
    public class ERPCampaign_email_schedule : ERPNextObjectBase
    {
        public ERPCampaign_email_schedule() : this(new ERPObject(DocType.Campaign_email_schedule)) { }
        public ERPCampaign_email_schedule(ERPObject obj) : base(obj) { }

        public static ERPCampaign_email_schedule Create(int sendafterdays, string emailtemplate)

        {
            ERPCampaign_email_schedule obj = new ERPCampaign_email_schedule();
            obj.send_after_days = sendafterdays;
            obj.email_template = emailtemplate;
            return obj;
        }

        public int send_after_days
        {
            get { return data.send_after_days; }
            set { data.send_after_days = value; }
        }

        public string email_template
        {
            get { return data.email_template; }
            set { data.email_template = value; }
        }


    }

    //Enums go here

}