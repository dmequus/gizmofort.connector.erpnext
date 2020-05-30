using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application_detail
{
    public class Employee_benefit_application_detailService : SubServiceBase<ERPEmployee_benefit_application_detail>
    {
        public Employee_benefit_application_detailService(ERPNextClient client)
            : base(DocType.Employee_benefit_application_detail, client) { }

        protected override ERPEmployee_benefit_application_detail fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_benefit_application_detail(obj);
        }
    }
}