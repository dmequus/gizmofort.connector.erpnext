using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_customer_group
{
    public class ERPPos_customer_group : ERPNextObjectBase
    {
        public ERPPos_customer_group() : this(new ERPObject(DocType.Pos_customer_group)) { }
        public ERPPos_customer_group(ERPObject obj) : base(obj) { }

        public static ERPPos_customer_group Create(string customergroup)

        {
            ERPPos_customer_group obj = new ERPPos_customer_group();
            obj.customer_group = customergroup;
            return obj;
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set
            {
                data.customer_group = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}