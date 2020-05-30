using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Interest
{
    public class ERPInterest : ERPNextObjectBase
    {
        public ERPInterest() : this(new ERPObject(DocType.Interest)) { }
        public ERPInterest(ERPObject obj) : base(obj) { }

        public static ERPInterest Create(string interest)

        {
            ERPInterest obj = new ERPInterest();
            obj.interest = interest;
            return obj;
        }

        public string interest
        {
            get { return data.interest; }
            set
            {
                data.interest = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}