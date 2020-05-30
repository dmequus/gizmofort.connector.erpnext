using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration
{
    public class Employee_tax_exemption_declarationService : SubServiceBase<ERPEmployee_tax_exemption_declaration>
    {
        public Employee_tax_exemption_declarationService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_declaration, client) { }

        protected override ERPEmployee_tax_exemption_declaration fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_declaration(obj);
        }
    }
}