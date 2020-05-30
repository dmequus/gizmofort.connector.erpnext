using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration_category
{
    public class ERPEmployee_tax_exemption_declaration_category : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_declaration_category() : this(new ERPObject(DocType.Employee_tax_exemption_declaration_category)) { }
        public ERPEmployee_tax_exemption_declaration_category(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_declaration_category Create(string exemptionsubcategory, string exemptioncategory, double maxamount, double amount)

        {
            ERPEmployee_tax_exemption_declaration_category obj = new ERPEmployee_tax_exemption_declaration_category();
            obj.exemption_sub_category = exemptionsubcategory;
            obj.exemption_category = exemptioncategory;
            obj.max_amount = maxamount;
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

        private double _max_amount = 0.0;
        public double max_amount
        {
            get { return data._max_amount; }
            set { data._max_amount = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}