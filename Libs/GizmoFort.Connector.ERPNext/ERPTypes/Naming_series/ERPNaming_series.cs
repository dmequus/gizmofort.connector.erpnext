using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Naming_series
{
    public class ERPNaming_series : ERPNextObjectBase
    {
        public ERPNaming_series() : this(new ERPObject(DocType.Naming_series)) { }
        public ERPNaming_series(ERPObject obj) : base(obj) { }

        public static ERPNaming_series Create(string selectdocforseries, string helphtml, string setoptions, long usermustalwaysselect, string prefix, int currentvalue)

        {
            ERPNaming_series obj = new ERPNaming_series();
            obj.select_doc_for_series = selectdocforseries;
            obj.help_html = helphtml;
            obj.set_options = setoptions;
            obj.user_must_always_select = usermustalwaysselect;
            obj.prefix = prefix;
            obj.current_value = currentvalue;
            return obj;
        }

        public string select_doc_for_series
        {
            get { return data.select_doc_for_series; }
            set
            {
                data.select_doc_for_series = value;
                data.name = value;
            }

        }

        public string help_html
        {
            get { return data.help_html; }
            set { data.help_html = value; }
        }

        public string set_options
        {
            get { return data.set_options; }
            set { data.set_options = value; }
        }

        public long user_must_always_select
        {
            get { return data.user_must_always_select; }
            set { data.user_must_always_select = value; }
        }

        public string prefix
        {
            get { return data.prefix; }
            set { data.prefix = value; }
        }

        public int current_value
        {
            get { return data.current_value; }
            set { data.current_value = value; }
        }


    }

    //Enums go here

}