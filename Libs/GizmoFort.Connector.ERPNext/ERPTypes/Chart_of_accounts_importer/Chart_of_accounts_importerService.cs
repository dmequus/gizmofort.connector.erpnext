using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Chart_of_accounts_importer
{
    public class Chart_of_accounts_importerService : SubServiceBase<ERPChart_of_accounts_importer>
    {
        public Chart_of_accounts_importerService(ERPNextClient client)
            : base(DocType.Chart_of_accounts_importer, client) { }

        protected override ERPChart_of_accounts_importer fromERPObject(ERPObject obj)
        {
            return new ERPChart_of_accounts_importer(obj);
        }
    }
}