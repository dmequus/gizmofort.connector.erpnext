using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ro_ro_chart_template
{
    public class Ro_ro_chart_templateService : SubServiceBase<ERPRo_ro_chart_template>
    {
        public Ro_ro_chart_templateService(ERPNextClient client)
            : base(DocType.Ro_ro_chart_template, client) { }

        protected override ERPRo_ro_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPRo_ro_chart_template(obj);
        }
    }
}