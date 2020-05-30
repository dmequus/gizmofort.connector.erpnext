using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure
{
    public class Salary_structureService : SubServiceBase<ERPSalary_structure>
    {
        public Salary_structureService(ERPNextClient client)
            : base(DocType.Salary_structure, client) { }

        protected override ERPSalary_structure fromERPObject(ERPObject obj)
        {
            return new ERPSalary_structure(obj);
        }
    }
}