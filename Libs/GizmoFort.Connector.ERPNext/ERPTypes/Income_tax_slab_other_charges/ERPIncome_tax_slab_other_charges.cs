using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab_other_charges
{
    public class ERPIncome_tax_slab_other_charges : ERPNextObjectBase
    {
        public ERPIncome_tax_slab_other_charges() : this(new ERPObject(DocType.Income_tax_slab_other_charges)) { }
        public ERPIncome_tax_slab_other_charges(ERPObject obj) : base(obj) { }

        public static ERPIncome_tax_slab_other_charges Create(string description, double percent)

        {
            ERPIncome_tax_slab_other_charges obj = new ERPIncome_tax_slab_other_charges();
            obj.description = description;
            obj.percent = percent;
            return obj;
        }

        public string description
        {
            get { return data.description; }
            set
            {
                data.description = value;
                data.name = value;
            }

        }

        private double _percent = 0.0;
        public double percent
        {
            get { return data._percent; }
            set { data._percent = value; }
        }

        private double _min_taxable_income = 0.0;
        public double min_taxable_income
        {
            get { return data._min_taxable_income; }
            set { data._min_taxable_income = value; }
        }

        private double _max_taxable_income = 0.0;
        public double max_taxable_income
        {
            get { return data._max_taxable_income; }
            set { data._max_taxable_income = value; }
        }


    }

    //Enums go here

}