using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry
{
    public class ERPLoyalty_point_entry : ERPNextObjectBase
    {
        public ERPLoyalty_point_entry() : this(new ERPObject(DocType.Loyalty_point_entry)) { }
        public ERPLoyalty_point_entry(ERPObject obj) : base(obj) { }

        public static ERPLoyalty_point_entry Create(string customer, string loyaltyprogram, string loyaltyprogramtier, string salesinvoice, string redeemagainst, int loyaltypoints, double purchaseamount, string expirydate, string postingdate, string company)

        {
            ERPLoyalty_point_entry obj = new ERPLoyalty_point_entry();
            obj.customer = customer;
            obj.loyalty_program = loyaltyprogram;
            obj.loyalty_program_tier = loyaltyprogramtier;
            obj.sales_invoice = salesinvoice;
            obj.redeem_against = redeemagainst;
            obj.loyalty_points = loyaltypoints;
            obj.purchase_amount = purchaseamount;
            obj.expiry_date = expirydate;
            obj.posting_date = postingdate;
            obj.company = company;
            return obj;
        }

        public string customer
        {
            get { return data.customer; }
            set
            {
                data.customer = value;
                data.name = value;
            }

        }

        public string loyalty_program
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        public string loyalty_program_tier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = value; }
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        public string redeem_against
        {
            get { return data.redeem_against; }
            set { data.redeem_against = value; }
        }

        private int _loyalty_points = 0;
        public int loyalty_points
        {
            get { return data._loyalty_points; }
            set { data._loyalty_points = value; }
        }

        private double _purchase_amount = 0.0;
        public double purchase_amount
        {
            get { return data._purchase_amount; }
            set { data._purchase_amount = value; }
        }

        public string expiry_date
        {
            get { return data.expiry_date; }
            set { data.expiry_date = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }


    }

    //Enums go here

}