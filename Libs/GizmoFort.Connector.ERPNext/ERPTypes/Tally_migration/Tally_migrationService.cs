using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tally_migration
{
    public class Tally_migrationService : SubServiceBase<ERPTally_migration>
    {
        public Tally_migrationService(ERPNextClient client)
            : base(DocType.Tally_migration, client) { }

        protected override ERPTally_migration fromERPObject(ERPObject obj)
        {
            return new ERPTally_migration(obj);
        }
    }
}