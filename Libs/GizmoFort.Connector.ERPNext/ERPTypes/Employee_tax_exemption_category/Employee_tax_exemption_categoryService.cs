using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_category
{
    public class Employee_tax_exemption_categoryService : SubServiceBase<ERPEmployee_tax_exemption_category>
    {
        public Employee_tax_exemption_categoryService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_category, client) { }

        protected override ERPEmployee_tax_exemption_category fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_category(obj);
        }
    }
}