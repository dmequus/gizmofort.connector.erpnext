using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_detail
{
    public class Salary_detailService : SubServiceBase<ERPSalary_detail>
    {
        public Salary_detailService(ERPNextClient client)
            : base(DocType.Salary_detail, client) { }

        protected override ERPSalary_detail fromERPObject(ERPObject obj)
        {
            return new ERPSalary_detail(obj);
        }
    }
}