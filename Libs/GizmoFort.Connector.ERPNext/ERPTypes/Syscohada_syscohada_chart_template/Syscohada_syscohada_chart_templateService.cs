using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Syscohada_syscohada_chart_template
{
    public class Syscohada_syscohada_chart_templateService : SubServiceBase<ERPSyscohada_syscohada_chart_template>
    {
        public Syscohada_syscohada_chart_templateService(ERPNextClient client)
            : base(DocType.Syscohada_syscohada_chart_template, client) { }

        protected override ERPSyscohada_syscohada_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPSyscohada_syscohada_chart_template(obj);
        }
    }
}