using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip
{
    public class Salary_slipService : SubServiceBase<ERPSalary_slip>
    {
        public Salary_slipService(ERPNextClient client)
            : base(DocType.Salary_slip, client) { }

        protected override ERPSalary_slip fromERPObject(ERPObject obj)
        {
            return new ERPSalary_slip(obj);
        }
    }
}