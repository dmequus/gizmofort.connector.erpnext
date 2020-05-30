using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Support_search_source
{
    public class ERPSupport_search_source : ERPNextObjectBase
    {
        public ERPSupport_search_source() : this(new ERPObject(DocType.Support_search_source)) { }
        public ERPSupport_search_source(ERPObject obj) : base(obj) { }

        public static ERPSupport_search_source Create(string sourcename, Sourcetype sourcetype, string baseurl, string queryroute, string searchtermparamname, string responseresultkeypath, string postroute, string postroutekeylist, string posttitlekey, string postdescriptionkey, string sourcedoctype, string resulttitlefield, string resultpreviewfield, string resultroutefield)

        {
            ERPSupport_search_source obj = new ERPSupport_search_source();
            obj.source_name = sourcename;
            obj.source_type = sourcetype;
            obj.base_url = baseurl;
            obj.query_route = queryroute;
            obj.search_term_param_name = searchtermparamname;
            obj.response_result_key_path = responseresultkeypath;
            obj.post_route = postroute;
            obj.post_route_key_list = postroutekeylist;
            obj.post_title_key = posttitlekey;
            obj.post_description_key = postdescriptionkey;
            obj.source_doctype = sourcedoctype;
            obj.result_title_field = resulttitlefield;
            obj.result_preview_field = resultpreviewfield;
            obj.result_route_field = resultroutefield;
            return obj;
        }

        public string source_name
        {
            get { return data.source_name; }
            set
            {
                data.source_name = value;
                data.name = value;
            }

        }

        public Sourcetype source_type
        {
            get { return parseEnum<Sourcetype>(data.source_type); }
            set { data.source_type = value.ToString(); }
        }

        public string base_url
        {
            get { return data.base_url; }
            set { data.base_url = value; }
        }

        public string query_route
        {
            get { return data.query_route; }
            set { data.query_route = value; }
        }

        public string search_term_param_name
        {
            get { return data.search_term_param_name; }
            set { data.search_term_param_name = value; }
        }

        public string response_result_key_path
        {
            get { return data.response_result_key_path; }
            set { data.response_result_key_path = value; }
        }

        public string post_route
        {
            get { return data.post_route; }
            set { data.post_route = value; }
        }

        public string post_route_key_list
        {
            get { return data.post_route_key_list; }
            set { data.post_route_key_list = value; }
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

        public string source_doctype
        {
            get { return data.source_doctype; }
            set { data.source_doctype = value; }
        }

        public string result_title_field
        {
            get { return data.result_title_field; }
            set { data.result_title_field = value; }
        }

        public string result_preview_field
        {
            get { return data.result_preview_field; }
            set { data.result_preview_field = value; }
        }

        public string result_route_field
        {
            get { return data.result_route_field; }
            set { data.result_route_field = value; }
        }


    }

    //Enums go here
    public enum Sourcetype
    {
        [Description("API")]
        API,
        [Description("Link")]
        Link,
    }


}