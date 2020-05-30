using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Additional_salary
{
    public class Additional_salaryService : SubServiceBase<ERPAdditional_salary>
    {
        public Additional_salaryService(ERPNextClient client)
            : base(DocType.Additional_salary, client) { }

        protected override ERPAdditional_salary fromERPObject(ERPObject obj)
        {
            return new ERPAdditional_salary(obj);
        }
    }
}