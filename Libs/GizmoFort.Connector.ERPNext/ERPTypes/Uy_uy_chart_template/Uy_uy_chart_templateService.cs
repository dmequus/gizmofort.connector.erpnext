using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Uy_uy_chart_template
{
    public class Uy_uy_chart_templateService : SubServiceBase<ERPUy_uy_chart_template>
    {
        public Uy_uy_chart_templateService(ERPNextClient client)
            : base(DocType.Uy_uy_chart_template, client) { }

        protected override ERPUy_uy_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPUy_uy_chart_template(obj);
        }
    }
}