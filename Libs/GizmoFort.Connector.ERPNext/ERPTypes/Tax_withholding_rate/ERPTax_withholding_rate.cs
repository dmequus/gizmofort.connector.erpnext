using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_rate
{
    public class ERPTax_withholding_rate : ERPNextObjectBase
    {
        public ERPTax_withholding_rate() : this(new ERPObject(DocType.Tax_withholding_rate)) { }
        public ERPTax_withholding_rate(ERPObject obj) : base(obj) { }

        public static ERPTax_withholding_rate Create(string fiscalyear, double taxwithholdingrate, double singlethreshold, double cumulativethreshold)

        {
            ERPTax_withholding_rate obj = new ERPTax_withholding_rate();
            obj.fiscal_year = fiscalyear;
            obj.tax_withholding_rate = taxwithholdingrate;
            obj.single_threshold = singlethreshold;
            obj.cumulative_threshold = cumulativethreshold;
            return obj;
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set
            {
                data.fiscal_year = value;
                data.name = value;
            }

        }

        public double tax_withholding_rate
        {
            get { return data.tax_withholding_rate; }
            set { data.tax_withholding_rate = value; }
        }

        public double single_threshold
        {
            get { return data.single_threshold; }
            set { data.single_threshold = value; }
        }

        public double cumulative_threshold
        {
            get { return data.cumulative_threshold; }
            set { data.cumulative_threshold = value; }
        }


    }

    //Enums go here

}