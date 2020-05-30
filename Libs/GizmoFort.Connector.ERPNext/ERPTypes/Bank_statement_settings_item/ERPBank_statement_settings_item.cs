using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_settings_item
{
    public class ERPBank_statement_settings_item : ERPNextObjectBase
    {
        public ERPBank_statement_settings_item() : this(new ERPObject(DocType.Bank_statement_settings_item)) { }
        public ERPBank_statement_settings_item(ERPObject obj) : base(obj) { }

        public static ERPBank_statement_settings_item Create(string mappedheader, string stmtheader)

        {
            ERPBank_statement_settings_item obj = new ERPBank_statement_settings_item();
            obj.mapped_header = mappedheader;
            obj.stmt_header = stmtheader;
            return obj;
        }

        public string mapped_header
        {
            get { return data.mapped_header; }
            set
            {
                data.mapped_header = value;
                data.name = value;
            }

        }

        public string stmt_header
        {
            get { return data.stmt_header; }
            set { data.stmt_header = value; }
        }


    }

    //Enums go here

}