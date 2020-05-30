using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill
{
    public class Employee_skillService : SubServiceBase<ERPEmployee_skill>
    {
        public Employee_skillService(ERPNextClient client)
            : base(DocType.Employee_skill, client) { }

        protected override ERPEmployee_skill fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_skill(obj);
        }
    }
}