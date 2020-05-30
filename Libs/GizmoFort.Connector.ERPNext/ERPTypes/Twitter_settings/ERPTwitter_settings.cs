using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Twitter_settings
{
    public class ERPTwitter_settings : ERPNextObjectBase
    {
        public ERPTwitter_settings() : this(new ERPObject(DocType.Twitter_settings)) { }
        public ERPTwitter_settings(ERPObject obj) : base(obj) { }

        public static ERPTwitter_settings Create(string consumerkey, string consumersecret)

        {
            ERPTwitter_settings obj = new ERPTwitter_settings();
            obj.consumer_key = consumerkey;
            obj.consumer_secret = consumersecret;
            return obj;
        }

        public string consumer_key
        {
            get { return data.consumer_key; }
            set
            {
                data.consumer_key = value;
                data.name = value;
            }

        }

        public string consumer_secret
        {
            get { return data.consumer_secret; }
            set { data.consumer_secret = value; }
        }

        public string account_name
        {
            get { return data.account_name; }
            set { data.account_name = value; }
        }

        public string profile_pic
        {
            get { return data.profile_pic; }
            set { data.profile_pic = value; }
        }

        public Sessionstatus session_status
        {
            get { return parseEnum<Sessionstatus>(data.session_status); }
            set { data.session_status = value.ToString(); }
        }

        public string access_token
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        public string access_token_secret
        {
            get { return data.access_token_secret; }
            set { data.access_token_secret = value; }
        }


    }

    //Enums go here
    public enum Sessionstatus
    {
        [Description("Expired")]
        Expired,
        [Description("Active")]
        Active,
    }


}