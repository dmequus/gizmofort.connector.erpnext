using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Social_media_post
{
    public class ERPSocial_media_post : ERPNextObjectBase
    {
        public ERPSocial_media_post() : this(new ERPObject(DocType.Social_media_post)) { }
        public ERPSocial_media_post(ERPObject obj) : base(obj) { }

        public static ERPSocial_media_post Create()

        {
            ERPSocial_media_post obj = new ERPSocial_media_post();
            return obj;
        }

        public string text
        {
            get { return data.text; }
            set
            {
                data.text = value;
                data.name = value;
            }

        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        private int _twitter = 0;
        public int twitter
        {
            get { return data._twitter; }
            set { data._twitter = value; }
        }

        private int _linkedin = 0;
        public int linkedin
        {
            get { return data._linkedin; }
            set { data._linkedin = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public Poststatus post_status
        {
            get { return parseEnum<Poststatus>(data.post_status); }
            set { data.post_status = value.ToString(); }
        }

        public string twitter_post_id
        {
            get { return data.twitter_post_id; }
            set { data.twitter_post_id = value; }
        }

        public string linkedin_post_id
        {
            get { return data.linkedin_post_id; }
            set { data.linkedin_post_id = value; }
        }

        public string campaign_name
        {
            get { return data.campaign_name; }
            set { data.campaign_name = value; }
        }

        public string tweet_preview
        {
            get { return data.tweet_preview; }
            set { data.tweet_preview = value; }
        }

        public string linkedin_post
        {
            get { return data.linkedin_post; }
            set { data.linkedin_post = value; }
        }

        public string scheduled_time
        {
            get { return data.scheduled_time; }
            set { data.scheduled_time = value; }
        }


    }

    //Enums go here
    public enum Poststatus
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("Posted")]
        Posted,
        [Description("Error")]
        Error,
    }


}