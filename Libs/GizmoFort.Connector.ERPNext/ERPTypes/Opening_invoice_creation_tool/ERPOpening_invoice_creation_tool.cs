using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool
{
    public class ERPOpening_invoice_creation_tool : ERPNextObjectBase
    {
        public ERPOpening_invoice_creation_tool() : this(new ERPObject(DocType.Opening_invoice_creation_tool)) { }
        public ERPOpening_invoice_creation_tool(ERPObject obj) : base(obj) { }

        public static ERPOpening_invoice_creation_tool Create(string company, Invoicetype invoicetype, string invoices)

        {
            ERPOpening_invoice_creation_tool obj = new ERPOpening_invoice_creation_tool();
            obj.company = company;
            obj.invoice_type = invoicetype;
            obj.invoices = invoices;
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

        public Invoicetype invoice_type
        {
            get { return parseEnum<Invoicetype>(data.invoice_type); }
            set { data.invoice_type = value.ToString(); }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
        }

        private int _create_missing_party = 0;
        public int create_missing_party
        {
            get { return data._create_missing_party; }
            set { data._create_missing_party = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }


    }

    //Enums go here
    public enum Invoicetype
    {
        [Description("Sales")]
        Sales,
        [Description("Purchase")]
        Purchase,
    }


}