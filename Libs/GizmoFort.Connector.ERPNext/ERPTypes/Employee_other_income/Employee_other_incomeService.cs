using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_other_income
{
    public class Employee_other_incomeService : SubServiceBase<ERPEmployee_other_income>
    {
        public Employee_other_incomeService(ERPNextClient client)
            : base(DocType.Employee_other_income, client) { }

        protected override ERPEmployee_other_income fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_other_income(obj);
        }
    }
}