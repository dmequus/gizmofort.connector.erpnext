using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry_redemption
{
    public class ERPLoyalty_point_entry_redemption : ERPNextObjectBase
    {
        public ERPLoyalty_point_entry_redemption() : this(new ERPObject(DocType.Loyalty_point_entry_redemption)) { }
        public ERPLoyalty_point_entry_redemption(ERPObject obj) : base(obj) { }

        public static ERPLoyalty_point_entry_redemption Create(string salesinvoice, string redemptiondate, int redeemedpoints)

        {
            ERPLoyalty_point_entry_redemption obj = new ERPLoyalty_point_entry_redemption();
            obj.sales_invoice = salesinvoice;
            obj.redemption_date = redemptiondate;
            obj.redeemed_points = redeemedpoints;
            return obj;
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set
            {
                data.sales_invoice = value;
                data.name = value;
            }

        }

        public string redemption_date
        {
            get { return data.redemption_date; }
            set { data.redemption_date = value; }
        }

        private int _redeemed_points = 0;
        public int redeemed_points
        {
            get { return data._redeemed_points; }
            set { data._redeemed_points = value; }
        }


    }

    //Enums go here

}