using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian_interest
{
    public class ERPGuardian_interest : ERPNextObjectBase
    {
        public ERPGuardian_interest() : this(new ERPObject(DocType.Guardian_interest)) { }
        public ERPGuardian_interest(ERPObject obj) : base(obj) { }

        public static ERPGuardian_interest Create(string interest)

        {
            ERPGuardian_interest obj = new ERPGuardian_interest();
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