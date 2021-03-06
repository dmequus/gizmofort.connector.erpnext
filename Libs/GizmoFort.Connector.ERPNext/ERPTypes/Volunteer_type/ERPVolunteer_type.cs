using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_type
{
    public class ERPVolunteer_type : ERPNextObjectBase
    {
        public ERPVolunteer_type() : this(new ERPObject(DocType.Volunteer_type)) { }
        public ERPVolunteer_type(ERPObject obj) : base(obj) { }

        public static ERPVolunteer_type Create(double amount)

        {
            ERPVolunteer_type obj = new ERPVolunteer_type();
            obj.amount = amount;
            return obj;
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}