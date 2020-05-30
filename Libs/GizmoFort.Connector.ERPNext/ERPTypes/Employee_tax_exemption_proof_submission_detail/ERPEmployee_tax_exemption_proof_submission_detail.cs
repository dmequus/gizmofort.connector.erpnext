using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission_detail
{
    public class ERPEmployee_tax_exemption_proof_submission_detail : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_proof_submission_detail() : this(new ERPObject(DocType.Employee_tax_exemption_proof_submission_detail)) { }
        public ERPEmployee_tax_exemption_proof_submission_detail(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_proof_submission_detail Create(string exemptionsubcategory, string exemptioncategory, double maxamount, string typeofproof, double amount)

        {
            ERPEmployee_tax_exemption_proof_submission_detail obj = new ERPEmployee_tax_exemption_proof_submission_detail();
            obj.exemption_sub_category = exemptionsubcategory;
            obj.exemption_category = exemptioncategory;
            obj.max_amount = maxamount;
            obj.type_of_proof = typeofproof;
            obj.amount = amount;
            return obj;
        }

        public string exemption_sub_category
        {
            get { return data.exemption_sub_category; }
            set
            {
                data.exemption_sub_category = value;
                data.name = value;
            }

        }

        public string exemption_category
        {
            get { return data.exemption_category; }
            set { data.exemption_category = value; }
        }

        public double max_amount
        {
            get { return data.max_amount; }
            set { data.max_amount = value; }
        }

        public string type_of_proof
        {
            get { return data.type_of_proof; }
            set { data.type_of_proof = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}