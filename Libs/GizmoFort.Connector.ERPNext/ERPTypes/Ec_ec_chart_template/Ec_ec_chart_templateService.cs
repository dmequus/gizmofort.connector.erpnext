using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ec_ec_chart_template
{
    public class Ec_ec_chart_templateService : SubServiceBase<ERPEc_ec_chart_template>
    {
        public Ec_ec_chart_templateService(ERPNextClient client)
            : base(DocType.Ec_ec_chart_template, client) { }

        protected override ERPEc_ec_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPEc_ec_chart_template(obj);
        }
    }
}