using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_category_account
{
    public class Asset_category_accountService : SubServiceBase<ERPAsset_category_account>
    {
        public Asset_category_accountService(ERPNextClient client)
            : base(DocType.Asset_category_account, client) { }

        protected override ERPAsset_category_account fromERPObject(ERPObject obj)
        {
            return new ERPAsset_category_account(obj);
        }
    }
}