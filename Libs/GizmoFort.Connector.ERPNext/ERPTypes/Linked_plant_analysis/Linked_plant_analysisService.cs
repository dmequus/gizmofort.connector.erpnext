using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_plant_analysis
{
    public class Linked_plant_analysisService : SubServiceBase<ERPLinked_plant_analysis>
    {
        public Linked_plant_analysisService(ERPNextClient client)
            : base(DocType.Linked_plant_analysis, client) { }

        protected override ERPLinked_plant_analysis fromERPObject(ERPObject obj)
        {
            return new ERPLinked_plant_analysis(obj);
        }
    }
}