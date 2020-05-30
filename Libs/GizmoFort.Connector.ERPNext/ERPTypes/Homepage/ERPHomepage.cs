using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage
{
    public class ERPHomepage : ERPNextObjectBase
    {
        public ERPHomepage() : this(new ERPObject(DocType.Homepage)) { }
        public ERPHomepage(ERPObject obj) : base(obj) { }

        public static ERPHomepage Create(string company, Herosectionbasedon herosectionbasedon, string title, string tagline, string description, string heroimage, string slideshow, string herosection, string productsurl, string products)

        {
            ERPHomepage obj = new ERPHomepage();
            obj.company = company;
            obj.hero_section_based_on = herosectionbasedon;
            obj.title = title;
            obj.tag_line = tagline;
            obj.description = description;
            obj.hero_image = heroimage;
            obj.slideshow = slideshow;
            obj.hero_section = herosection;
            obj.products_url = productsurl;
            obj.products = products;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public Herosectionbasedon hero_section_based_on
        {
            get { return parseEnum<Herosectionbasedon>(data.hero_section_based_on); }
            set { data.hero_section_based_on = value.ToString(); }
        }

        public string title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        public string tag_line
        {
            get { return data.tag_line; }
            set { data.tag_line = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string hero_image
        {
            get { return data.hero_image; }
            set { data.hero_image = value; }
        }

        public string slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = value; }
        }

        public string hero_section
        {
            get { return data.hero_section; }
            set { data.hero_section = value; }
        }

        public string products_url
        {
            get { return data.products_url; }
            set { data.products_url = value; }
        }

        public string products
        {
            get { return data.products; }
            set { data.products = value; }
        }


    }

    //Enums go here
    public enum Herosectionbasedon
    {
        [Description("Default")]
        Default,
        [Description("Slideshow")]
        Slideshow,
        [Description("Homepage Section")]
        HomepageSection,
    }


}