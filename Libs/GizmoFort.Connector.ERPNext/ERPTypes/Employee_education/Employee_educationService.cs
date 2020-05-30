using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_education
{
    public class Employee_educationService : SubServiceBase<ERPEmployee_education>
    {
        public Employee_educationService(ERPNextClient client)
            : base(DocType.Employee_education, client) { }

        protected override ERPEmployee_education fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_education(obj);
        }
    }
}