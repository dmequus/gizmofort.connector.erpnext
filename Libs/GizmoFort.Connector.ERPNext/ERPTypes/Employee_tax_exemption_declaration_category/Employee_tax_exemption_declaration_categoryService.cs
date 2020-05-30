using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration_category
{
    public class Employee_tax_exemption_declaration_categoryService : SubServiceBase<ERPEmployee_tax_exemption_declaration_category>
    {
        public Employee_tax_exemption_declaration_categoryService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_declaration_category, client) { }

        protected override ERPEmployee_tax_exemption_declaration_category fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_declaration_category(obj);
        }
    }
}