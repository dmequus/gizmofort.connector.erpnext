using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_skill
{
    public class ERPVolunteer_skill : ERPNextObjectBase
    {
        public ERPVolunteer_skill() : this(new ERPObject(DocType.Volunteer_skill)) { }
        public ERPVolunteer_skill(ERPObject obj) : base(obj) { }

        public static ERPVolunteer_skill Create(string volunteerskill)

        {
            ERPVolunteer_skill obj = new ERPVolunteer_skill();
            obj.volunteer_skill = volunteerskill;
            return obj;
        }

        public string volunteer_skill
        {
            get { return data.volunteer_skill; }
            set
            {
                data.volunteer_skill = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}