using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_request_costing
{
    public class ERPTravel_request_costing : ERPNextObjectBase
    {
        public ERPTravel_request_costing() : this(new ERPObject(DocType.Travel_request_costing)) { }
        public ERPTravel_request_costing(ERPObject obj) : base(obj) { }

        public static ERPTravel_request_costing Create(string expensetype, double sponsoredamount, double fundedamount, double totalamount, string comments)

        {
            ERPTravel_request_costing obj = new ERPTravel_request_costing();
            obj.expense_type = expensetype;
            obj.sponsored_amount = sponsoredamount;
            obj.funded_amount = fundedamount;
            obj.total_amount = totalamount;
            obj.comments = comments;
            return obj;
        }

        public string expense_type
        {
            get { return data.expense_type; }
            set
            {
                data.expense_type = value;
                data.name = value;
            }

        }

        public double sponsored_amount
        {
            get { return data.sponsored_amount; }
            set { data.sponsored_amount = value; }
        }

        public double funded_amount
        {
            get { return data.funded_amount; }
            set { data.funded_amount = value; }
        }

        public double total_amount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }

        public string comments
        {
            get { return data.comments; }
            set { data.comments = value; }
        }


    }

    //Enums go here

}