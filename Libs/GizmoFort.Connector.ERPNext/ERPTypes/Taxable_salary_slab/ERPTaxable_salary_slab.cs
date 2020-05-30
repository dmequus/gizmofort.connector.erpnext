using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Taxable_salary_slab
{
    public class ERPTaxable_salary_slab : ERPNextObjectBase
    {
        public ERPTaxable_salary_slab() : this(new ERPObject(DocType.Taxable_salary_slab)) { }
        public ERPTaxable_salary_slab(ERPObject obj) : base(obj) { }

        public static ERPTaxable_salary_slab Create(double fromamount, double toamount, double percentdeduction, string condition, string html6)

        {
            ERPTaxable_salary_slab obj = new ERPTaxable_salary_slab();
            obj.from_amount = fromamount;
            obj.to_amount = toamount;
            obj.percent_deduction = percentdeduction;
            obj.condition = condition;
            obj.html_6 = html6;
            return obj;
        }

        private double _from_amount = 0.0;
        public double from_amount
        {
            get { return data._from_amount; }
            set { data._from_amount = value; }
        }

        private double _to_amount = 0.0;
        public double to_amount
        {
            get { return data._to_amount; }
            set { data._to_amount = value; }
        }

        private double _percent_deduction = 0.0;
        public double percent_deduction
        {
            get { return data._percent_deduction; }
            set { data._percent_deduction = value; }
        }

        public string condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        public string html_6
        {
            get { return data.html_6; }
            set { data.html_6 = value; }
        }


    }

    //Enums go here

}