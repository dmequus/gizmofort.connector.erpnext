using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab
{
    public class ERPIncome_tax_slab : ERPNextObjectBase
    {
        public ERPIncome_tax_slab() : this(new ERPObject(DocType.Income_tax_slab)) { }
        public ERPIncome_tax_slab(ERPObject obj) : base(obj) { }

        public static ERPIncome_tax_slab Create(string effectivefrom, string slabs)

        {
            ERPIncome_tax_slab obj = new ERPIncome_tax_slab();
            obj.effective_from = effectivefrom;
            obj.slabs = slabs;
            return obj;
        }

        public string effective_from
        {
            get { return data.effective_from; }
            set
            {
                data.effective_from = value;
                data.name = value;
            }

        }

        public string slabs
        {
            get { return data.slabs; }
            set { data.slabs = value; }
        }

        private int _allow_tax_exemption = 0;
        public int allow_tax_exemption
        {
            get { return data._allow_tax_exemption; }
            set { data._allow_tax_exemption = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        private double _standard_tax_exemption_amount = 0.0;
        public double standard_tax_exemption_amount
        {
            get { return data._standard_tax_exemption_amount; }
            set { data._standard_tax_exemption_amount = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string other_taxes_and_charges
        {
            get { return data.other_taxes_and_charges; }
            set { data.other_taxes_and_charges = value; }
        }


    }

    //Enums go here

}