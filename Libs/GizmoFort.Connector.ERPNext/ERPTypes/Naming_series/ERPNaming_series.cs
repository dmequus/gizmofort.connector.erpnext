using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Naming_series
{
    public class ERPNaming_series : ERPNextObjectBase
    {
        public ERPNaming_series() : this(new ERPObject(DocType.Naming_series)) { }
        public ERPNaming_series(ERPObject obj) : base(obj) { }

        public static ERPNaming_series Create(string selectdocforseries, string helphtml, string setoptions, int usermustalwaysselect, string prefix, int currentvalue)

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

        private int _user_must_always_select = 0;
        public int user_must_always_select
        {
            get { return data._user_must_always_select; }
            set { data._user_must_always_select = value; }
        }

        public string prefix
        {
            get { return data.prefix; }
            set { data.prefix = value; }
        }

        private int _current_value = 0;
        public int current_value
        {
            get { return data._current_value; }
            set { data._current_value = value; }
        }


    }

    //Enums go here

}