using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_component
{
    public class ERPFee_component : ERPNextObjectBase
    {
        public ERPFee_component() : this(new ERPObject(DocType.Fee_component)) { }
        public ERPFee_component(ERPObject obj) : base(obj) { }

        public static ERPFee_component Create(string feescategory, string description, double amount)

        {
            ERPFee_component obj = new ERPFee_component();
            obj.fees_category = feescategory;
            obj.description = description;
            obj.amount = amount;
            return obj;
        }

        public string fees_category
        {
            get { return data.fees_category; }
            set
            {
                data.fees_category = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
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