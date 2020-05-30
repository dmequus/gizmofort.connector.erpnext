using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Linkedin_settings
{
    public class ERPLinkedin_settings : ERPNextObjectBase
    {
        public ERPLinkedin_settings() : this(new ERPObject(DocType.Linkedin_settings)) { }
        public ERPLinkedin_settings(ERPObject obj) : base(obj) { }

        public static ERPLinkedin_settings Create(string consumerkey, string consumersecret, string companyid)

        {
            ERPLinkedin_settings obj = new ERPLinkedin_settings();
            obj.consumer_key = consumerkey;
            obj.consumer_secret = consumersecret;
            obj.company_id = companyid;
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

        public string company_id
        {
            get { return data.company_id; }
            set { data.company_id = value; }
        }

        public string account_name
        {
            get { return data.account_name; }
            set { data.account_name = value; }
        }

        public string access_token
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        public string person_urn
        {
            get { return data.person_urn; }
            set { data.person_urn = value; }
        }

        public Sessionstatus session_status
        {
            get { return parseEnum<Sessionstatus>(data.session_status); }
            set { data.session_status = value.ToString(); }
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