using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapper
{
    public class Cash_flow_mapperService : SubServiceBase<ERPCash_flow_mapper>
    {
        public Cash_flow_mapperService(ERPNextClient client)
            : base(DocType.Cash_flow_mapper, client) { }

        protected override ERPCash_flow_mapper fromERPObject(ERPObject obj)
        {
            return new ERPCash_flow_mapper(obj);
        }
    }
}