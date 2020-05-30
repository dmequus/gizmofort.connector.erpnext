using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_sub_category
{
    public class Employee_tax_exemption_sub_categoryService : SubServiceBase<ERPEmployee_tax_exemption_sub_category>
    {
        public Employee_tax_exemption_sub_categoryService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_sub_category, client) { }

        protected override ERPEmployee_tax_exemption_sub_category fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_sub_category(obj);
        }
    }
}