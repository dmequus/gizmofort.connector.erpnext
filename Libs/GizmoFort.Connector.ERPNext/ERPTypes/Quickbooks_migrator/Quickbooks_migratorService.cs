using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quickbooks_migrator
{
    public class Quickbooks_migratorService : SubServiceBase<ERPQuickbooks_migrator>
    {
        public Quickbooks_migratorService(ERPNextClient client)
            : base(DocType.Quickbooks_migrator, client) { }

        protected override ERPQuickbooks_migrator fromERPObject(ERPObject obj)
        {
            return new ERPQuickbooks_migrator(obj);
        }
    }
}