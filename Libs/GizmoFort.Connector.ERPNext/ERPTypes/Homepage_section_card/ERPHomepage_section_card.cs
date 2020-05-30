using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section_card
{
    public class ERPHomepage_section_card : ERPNextObjectBase
    {
        public ERPHomepage_section_card() : this(new ERPObject(DocType.Homepage_section_card)) { }
        public ERPHomepage_section_card(ERPObject obj) : base(obj) { }

        public static ERPHomepage_section_card Create(string title, string subtitle, string image, string content, string route)

        {
            ERPHomepage_section_card obj = new ERPHomepage_section_card();
            obj.title = title;
            obj.subtitle = subtitle;
            obj.image = image;
            obj.content = content;
            obj.route = route;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string subtitle
        {
            get { return data.subtitle; }
            set { data.subtitle = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }


    }

    //Enums go here

}