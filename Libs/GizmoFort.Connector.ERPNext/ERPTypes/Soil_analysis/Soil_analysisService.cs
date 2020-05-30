using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_analysis
{
    public class Soil_analysisService : SubServiceBase<ERPSoil_analysis>
    {
        public Soil_analysisService(ERPNextClient client)
            : base(DocType.Soil_analysis, client) { }

        protected override ERPSoil_analysis fromERPObject(ERPObject obj)
        {
            return new ERPSoil_analysis(obj);
        }
    }
}