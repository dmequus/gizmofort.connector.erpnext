using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure_assignment
{
    public class Salary_structure_assignmentService : SubServiceBase<ERPSalary_structure_assignment>
    {
        public Salary_structure_assignmentService(ERPNextClient client)
            : base(DocType.Salary_structure_assignment, client) { }

        protected override ERPSalary_structure_assignment fromERPObject(ERPObject obj)
        {
            return new ERPSalary_structure_assignment(obj);
        }
    }
}