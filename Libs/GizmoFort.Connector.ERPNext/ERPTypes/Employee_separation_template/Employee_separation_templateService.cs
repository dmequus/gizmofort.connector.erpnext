using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_separation_template
{
    public class Employee_separation_templateService : SubServiceBase<ERPEmployee_separation_template>
    {
        public Employee_separation_templateService(ERPNextClient client)
            : base(DocType.Employee_separation_template, client) { }

        protected override ERPEmployee_separation_template fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_separation_template(obj);
        }
    }
}