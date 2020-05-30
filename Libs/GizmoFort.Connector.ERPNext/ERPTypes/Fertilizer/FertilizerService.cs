using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer
{
    public class FertilizerService : SubServiceBase<ERPFertilizer>
    {
        public FertilizerService(ERPNextClient client)
            : base(DocType.Fertilizer, client) { }

        protected override ERPFertilizer fromERPObject(ERPObject obj)
        {
            return new ERPFertilizer(obj);
        }
    }
}