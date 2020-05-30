using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_analysis
{
    public class Linked_soil_analysisService : SubServiceBase<ERPLinked_soil_analysis>
    {
        public Linked_soil_analysisService(ERPNextClient client)
            : base(DocType.Linked_soil_analysis, client) { }

        protected override ERPLinked_soil_analysis fromERPObject(ERPObject obj)
        {
            return new ERPLinked_soil_analysis(obj);
        }
    }
}