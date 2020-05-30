using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapper
{
    public class ERPCash_flow_mapper : ERPNextObjectBase
    {
        public ERPCash_flow_mapper() : this(new ERPObject(DocType.Cash_flow_mapper)) { }
        public ERPCash_flow_mapper(ERPObject obj) : base(obj) { }

        public static ERPCash_flow_mapper Create(string sectionname, string sectionheader, string sectionleader, string sectionsubtotal, string sectionfooter, string accounts, int position)

        {
            ERPCash_flow_mapper obj = new ERPCash_flow_mapper();
            obj.section_name = sectionname;
            obj.section_header = sectionheader;
            obj.section_leader = sectionleader;
            obj.section_subtotal = sectionsubtotal;
            obj.section_footer = sectionfooter;
            obj.accounts = accounts;
            obj.position = position;
            return obj;
        }

        public string section_name
        {
            get { return data.section_name; }
            set
            {
                data.section_name = value;
                data.name = value;
            }

        }

        public string section_header
        {
            get { return data.section_header; }
            set { data.section_header = value; }
        }

        public string section_leader
        {
            get { return data.section_leader; }
            set { data.section_leader = value; }
        }

        public string section_subtotal
        {
            get { return data.section_subtotal; }
            set { data.section_subtotal = value; }
        }

        public string section_footer
        {
            get { return data.section_footer; }
            set { data.section_footer = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        private int _position = 0;
        public int position
        {
            get { return data._position; }
            set { data._position = value; }
        }


    }

    //Enums go here

}