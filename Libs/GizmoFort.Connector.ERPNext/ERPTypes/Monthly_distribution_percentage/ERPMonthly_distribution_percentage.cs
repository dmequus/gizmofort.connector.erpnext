using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution_percentage
{
    public class ERPMonthly_distribution_percentage : ERPNextObjectBase
    {
        public ERPMonthly_distribution_percentage() : this(new ERPObject(DocType.Monthly_distribution_percentage)) { }
        public ERPMonthly_distribution_percentage(ERPObject obj) : base(obj) { }

        public static ERPMonthly_distribution_percentage Create(string month, double percentageallocation)

        {
            ERPMonthly_distribution_percentage obj = new ERPMonthly_distribution_percentage();
            obj.month = month;
            obj.percentage_allocation = percentageallocation;
            return obj;
        }

        public string month
        {
            get { return data.month; }
            set
            {
                data.month = value;
                data.name = value;
            }

        }

        public double percentage_allocation
        {
            get { return data.percentage_allocation; }
            set { data.percentage_allocation = value; }
        }


    }

    //Enums go here

}