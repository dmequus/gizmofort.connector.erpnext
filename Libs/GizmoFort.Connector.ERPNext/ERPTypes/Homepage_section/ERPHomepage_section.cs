using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section
{
    public class ERPHomepage_section : ERPNextObjectBase
    {
        public ERPHomepage_section() : this(new ERPObject(DocType.Homepage_section)) { }
        public ERPHomepage_section(ERPObject obj) : base(obj) { }

        public static ERPHomepage_section Create(Sectionbasedon sectionbasedon, string sectioncards, Noofcolumns noofcolumns, string sectionhtml, int sectionorder)

        {
            ERPHomepage_section obj = new ERPHomepage_section();
            obj.section_based_on = sectionbasedon;
            obj.section_cards = sectioncards;
            obj.no_of_columns = noofcolumns;
            obj.section_html = sectionhtml;
            obj.section_order = sectionorder;
            return obj;
        }

        public Sectionbasedon section_based_on
        {
            get { return parseEnum<Sectionbasedon>(data.section_based_on); }
            set { data.section_based_on = value.ToString(); }
        }

        public string section_cards
        {
            get { return data.section_cards; }
            set { data.section_cards = value; }
        }

        public Noofcolumns no_of_columns
        {
            get { return parseEnum<Noofcolumns>(data.no_of_columns); }
            set { data.no_of_columns = value.ToString(); }
        }

        public string section_html
        {
            get { return data.section_html; }
            set { data.section_html = value; }
        }

        public int section_order
        {
            get { return data.section_order; }
            set { data.section_order = value; }
        }


    }

    //Enums go here
    public enum Sectionbasedon
    {
        [Description("Cards")]
        Cards,
        [Description("Custom HTML")]
        CustomHTML,
    }

    public enum Noofcolumns
    {
        [Description("1")]
        num1,
        [Description("2")]
        num2,
        [Description("3")]
        num3,
        [Description("4")]
        num4,
        [Description("6")]
        num6,
    }


}