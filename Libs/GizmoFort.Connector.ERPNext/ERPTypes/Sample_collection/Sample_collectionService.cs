using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sample_collection
{
    public class Sample_collectionService : SubServiceBase<ERPSample_collection>
    {
        public Sample_collectionService(ERPNextClient client)
            : base(DocType.Sample_collection, client) { }

        protected override ERPSample_collection fromERPObject(ERPObject obj)
        {
            return new ERPSample_collection(obj);
        }
    }
}