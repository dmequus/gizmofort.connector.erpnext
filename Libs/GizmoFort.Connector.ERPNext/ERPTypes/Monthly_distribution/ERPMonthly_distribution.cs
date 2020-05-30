using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution
{
    public class ERPMonthly_distribution : ERPNextObjectBase
    {
        public ERPMonthly_distribution() : this(new ERPObject(DocType.Monthly_distribution)) { }
        public ERPMonthly_distribution(ERPObject obj) : base(obj) { }

        public static ERPMonthly_distribution Create(string distributionid, string fiscalyear, string percentages)

        {
            ERPMonthly_distribution obj = new ERPMonthly_distribution();
            obj.distribution_id = distributionid;
            obj.fiscal_year = fiscalyear;
            obj.percentages = percentages;
            return obj;
        }

        public string distribution_id
        {
            get { return data.distribution_id; }
            set
            {
                data.distribution_id = value;
                data.name = value;
            }

        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public string percentages
        {
            get { return data.percentages; }
            set { data.percentages = value; }
        }


    }

    //Enums go here

}