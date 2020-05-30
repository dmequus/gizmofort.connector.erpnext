using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Content_activity
{
    public class ERPContent_activity : ERPNextObjectBase
    {
        public ERPContent_activity() : this(new ERPObject(DocType.Content_activity)) { }
        public ERPContent_activity(ERPObject obj) : base(obj) { }

        public static ERPContent_activity Create(string content, string contenttype, string lastactivity)

        {
            ERPContent_activity obj = new ERPContent_activity();
            obj.content = content;
            obj.content_type = contenttype;
            obj.last_activity = lastactivity;
            return obj;
        }

        public string content
        {
            get { return data.content; }
            set
            {
                data.content = value;
                data.name = value;
            }

        }

        public string content_type
        {
            get { return data.content_type; }
            set { data.content_type = value; }
        }

        public string last_activity
        {
            get { return data.last_activity; }
            set { data.last_activity = value; }
        }


    }

    //Enums go here

}