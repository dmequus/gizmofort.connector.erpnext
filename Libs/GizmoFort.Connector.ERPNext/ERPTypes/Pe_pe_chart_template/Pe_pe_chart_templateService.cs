using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pe_pe_chart_template
{
    public class Pe_pe_chart_templateService : SubServiceBase<ERPPe_pe_chart_template>
    {
        public Pe_pe_chart_templateService(ERPNextClient client)
            : base(DocType.Pe_pe_chart_template, client) { }

        protected override ERPPe_pe_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPPe_pe_chart_template(obj);
        }
    }
}