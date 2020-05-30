using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Campaign
{
    public class ERPCampaign : ERPNextObjectBase
    {
        public ERPCampaign() : this(new ERPObject(DocType.Campaign)) { }
        public ERPCampaign(ERPObject obj) : base(obj) { }

        public static ERPCampaign Create(string campaignname)

        {
            ERPCampaign obj = new ERPCampaign();
            obj.campaign_name = campaignname;
            return obj;
        }

        public string campaign_name
        {
            get { return data.campaign_name; }
            set
            {
                data.campaign_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string campaign_schedules
        {
            get { return data.campaign_schedules; }
            set { data.campaign_schedules = value; }
        }


    }

    //Enums go here

}