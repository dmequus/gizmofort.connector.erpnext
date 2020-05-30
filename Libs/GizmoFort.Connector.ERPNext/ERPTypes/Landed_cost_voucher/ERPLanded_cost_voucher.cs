using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_voucher
{
    public class ERPLanded_cost_voucher : ERPNextObjectBase
    {
        public ERPLanded_cost_voucher() : this(new ERPObject(DocType.Landed_cost_voucher)) { }
        public ERPLanded_cost_voucher(ERPObject obj) : base(obj) { }

        public static ERPLanded_cost_voucher Create(string namingseries, string company, string purchasereceipts, string items, string taxes, double totaltaxesandcharges, Distributechargesbasedon distributechargesbasedon)

        {
            ERPLanded_cost_voucher obj = new ERPLanded_cost_voucher();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.purchase_receipts = purchasereceipts;
            obj.items = items;
            obj.taxes = taxes;
            obj.total_taxes_and_charges = totaltaxesandcharges;
            obj.distribute_charges_based_on = distributechargesbasedon;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string purchase_receipts
        {
            get { return data.purchase_receipts; }
            set { data.purchase_receipts = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        public double total_taxes_and_charges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        public Distributechargesbasedon distribute_charges_based_on
        {
            get { return parseEnum<Distributechargesbasedon>(data.distribute_charges_based_on); }
            set { data.distribute_charges_based_on = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string landed_cost_help
        {
            get { return data.landed_cost_help; }
            set { data.landed_cost_help = value; }
        }


    }

    //Enums go here
    public enum Distributechargesbasedon
    {
        [Description("Qty")]
        Qty,
        [Description("Amount")]
        Amount,
    }


}