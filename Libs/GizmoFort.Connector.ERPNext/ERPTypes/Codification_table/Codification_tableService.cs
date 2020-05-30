using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Codification_table
{
    public class Codification_tableService : SubServiceBase<ERPCodification_table>
    {
        public Codification_tableService(ERPNextClient client)
            : base(DocType.Codification_table, client) { }

        protected override ERPCodification_table fromERPObject(ERPObject obj)
        {
            return new ERPCodification_table(obj);
        }
    }
}