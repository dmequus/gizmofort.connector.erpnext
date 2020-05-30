using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Article
{
    public class ERPArticle : ERPNextObjectBase
    {
        public ERPArticle() : this(new ERPObject(DocType.Article)) { }
        public ERPArticle(ERPObject obj) : base(obj) { }

        public static ERPArticle Create()

        {
            ERPArticle obj = new ERPArticle();
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

        public string author
        {
            get { return data.author; }
            set { data.author = value; }
        }

        public string content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        public string publish_date
        {
            get { return data.publish_date; }
            set { data.publish_date = value; }
        }


    }

    //Enums go here

}