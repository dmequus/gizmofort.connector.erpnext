using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_grade
{
    public class Employee_gradeService : SubServiceBase<ERPEmployee_grade>
    {
        public Employee_gradeService(ERPNextClient client)
            : base(DocType.Employee_grade, client) { }

        protected override ERPEmployee_grade fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_grade(obj);
        }
    }
}