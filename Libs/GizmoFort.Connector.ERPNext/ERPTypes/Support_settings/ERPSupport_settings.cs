using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Support_settings
{
    public class ERPSupport_settings : ERPNextObjectBase
    {
        public ERPSupport_settings() : this(new ERPObject(DocType.Support_settings)) { }
        public ERPSupport_settings(ERPObject obj) : base(obj) { }

        public static ERPSupport_settings Create()

        {
            ERPSupport_settings obj = new ERPSupport_settings();
            return obj;
        }

        public int close_issue_after_days
        {
            get { return data.close_issue_after_days; }
            set { data.close_issue_after_days = value; }
        }

        public string get_started_sections
        {
            get { return data.get_started_sections; }
            set { data.get_started_sections = value; }
        }

        public long show_latest_forum_posts
        {
            get { return data.show_latest_forum_posts; }
            set { data.show_latest_forum_posts = value; }
        }

        public string forum_url
        {
            get { return data.forum_url; }
            set { data.forum_url = value; }
        }

        public string get_latest_query
        {
            get { return data.get_latest_query; }
            set { data.get_latest_query = value; }
        }

        public string response_key_list
        {
            get { return data.response_key_list; }
            set { data.response_key_list = value; }
        }

        public string post_title_key
        {
            get { return data.post_title_key; }
            set { data.post_title_key = value; }
        }

        public string post_description_key
        {
            get { return data.post_description_key; }
            set { data.post_description_key = value; }
        }

        public string post_route_key
        {
            get { return data.post_route_key; }
            set { data.post_route_key = value; }
        }

        public string post_route_string
        {
            get { return data.post_route_string; }
            set { data.post_route_string = value; }
        }

        public string search_apis
        {
            get { return data.search_apis; }
            set { data.search_apis = value; }
        }

        public long track_service_level_agreement
        {
            get { return data.track_service_level_agreement; }
            set { data.track_service_level_agreement = value; }
        }

        public long allow_resetting_service_level_agreement
        {
            get { return data.allow_resetting_service_level_agreement; }
            set { data.allow_resetting_service_level_agreement = value; }
        }


    }

    //Enums go here

}