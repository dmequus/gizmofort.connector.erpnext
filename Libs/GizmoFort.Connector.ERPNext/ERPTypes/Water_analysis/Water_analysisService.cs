using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Water_analysis
{
    public class Water_analysisService : SubServiceBase<ERPWater_analysis>
    {
        public Water_analysisService(ERPNextClient client)
            : base(DocType.Water_analysis, client) { }

        protected override ERPWater_analysis fromERPObject(ERPObject obj)
        {
            return new ERPWater_analysis(obj);
        }
    }
}