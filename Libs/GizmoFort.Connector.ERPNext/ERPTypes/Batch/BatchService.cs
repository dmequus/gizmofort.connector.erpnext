using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Batch
{
    public class BatchService : SubServiceBase<ERPBatch>
    {
        public BatchService(ERPNextClient client)
            : base(DocType.Batch, client) { }

        protected override ERPBatch fromERPObject(ERPObject obj)
        {
            return new ERPBatch(obj);
        }
    }
}