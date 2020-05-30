using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool_item
{
    public class ERPOpening_invoice_creation_tool_item : ERPNextObjectBase
    {
        public ERPOpening_invoice_creation_tool_item() : this(new ERPObject(DocType.Opening_invoice_creation_tool_item)) { }
        public ERPOpening_invoice_creation_tool_item(ERPObject obj) : base(obj) { }

        public static ERPOpening_invoice_creation_tool_item Create(string party, double outstandingamount)

        {
            ERPOpening_invoice_creation_tool_item obj = new ERPOpening_invoice_creation_tool_item();
            obj.party = party;
            obj.outstanding_amount = outstandingamount;
            return obj;
        }

        public string party
        {
            get { return data.party; }
            set
            {
                data.party = value;
                data.name = value;
            }

        }

        public double outstanding_amount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        public string party_type
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        public string temporary_opening_account
        {
            get { return data.temporary_opening_account; }
            set { data.temporary_opening_account = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }


    }

    //Enums go here

}