using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Chapter
{
    public class ERPChapter : ERPNextObjectBase
    {
        public ERPChapter() : this(new ERPObject(DocType.Chapter)) { }
        public ERPChapter(ERPObject obj) : base(obj) { }

        public static ERPChapter Create(string chapterhead, string region, string introduction, string meetupembedhtml, string address, string route, int published, string members)

        {
            ERPChapter obj = new ERPChapter();
            obj.chapter_head = chapterhead;
            obj.region = region;
            obj.introduction = introduction;
            obj.meetup_embed_html = meetupembedhtml;
            obj.address = address;
            obj.route = route;
            obj.published = published;
            obj.members = members;
            return obj;
        }

        public string chapter_head
        {
            get { return data.chapter_head; }
            set
            {
                data.chapter_head = value;
                data.name = value;
            }

        }

        public string region
        {
            get { return data.region; }
            set { data.region = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string meetup_embed_html
        {
            get { return data.meetup_embed_html; }
            set { data.meetup_embed_html = value; }
        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        private int _published = 0;
        public int published
        {
            get { return data._published; }
            set { data._published = value; }
        }

        public string members
        {
            get { return data.members; }
            set { data.members = value; }
        }


    }

    //Enums go here

}