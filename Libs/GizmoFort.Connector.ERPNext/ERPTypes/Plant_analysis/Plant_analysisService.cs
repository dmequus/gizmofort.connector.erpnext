using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis
{
    public class Plant_analysisService : SubServiceBase<ERPPlant_analysis>
    {
        public Plant_analysisService(ERPNextClient client)
            : base(DocType.Plant_analysis, client) { }

        protected override ERPPlant_analysis fromERPObject(ERPObject obj)
        {
            return new ERPPlant_analysis(obj);
        }
    }
}