using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Chapter_member
{
    public class ERPChapter_member : ERPNextObjectBase
    {
        public ERPChapter_member() : this(new ERPObject(DocType.Chapter_member)) { }
        public ERPChapter_member(ERPObject obj) : base(obj) { }

        public static ERPChapter_member Create(string user, string introduction, string websiteurl, long enabled, string leavereason)

        {
            ERPChapter_member obj = new ERPChapter_member();
            obj.user = user;
            obj.introduction = introduction;
            obj.website_url = websiteurl;
            obj.enabled = enabled;
            obj.leave_reason = leavereason;
            return obj;
        }

        public string user
        {
            get { return data.user; }
            set
            {
                data.user = value;
                data.name = value;
            }

        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string website_url
        {
            get { return data.website_url; }
            set { data.website_url = value; }
        }

        public long enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        public string leave_reason
        {
            get { return data.leave_reason; }
            set { data.leave_reason = value; }
        }


    }

    //Enums go here

}