using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_country
{
    public class ERPShipping_rule_country : ERPNextObjectBase
    {
        public ERPShipping_rule_country() : this(new ERPObject(DocType.Shipping_rule_country)) { }
        public ERPShipping_rule_country(ERPObject obj) : base(obj) { }

        public static ERPShipping_rule_country Create(string country)

        {
            ERPShipping_rule_country obj = new ERPShipping_rule_country();
            obj.country = country;
            return obj;
        }

        public string country
        {
            get { return data.country; }
            set
            {
                data.country = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}