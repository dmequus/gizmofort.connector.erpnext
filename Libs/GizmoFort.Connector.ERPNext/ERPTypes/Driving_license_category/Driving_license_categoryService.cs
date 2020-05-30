using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Driving_license_category
{
    public class Driving_license_categoryService : SubServiceBase<ERPDriving_license_category>
    {
        public Driving_license_categoryService(ERPNextClient client)
            : base(DocType.Driving_license_category, client) { }

        protected override ERPDriving_license_category fromERPObject(ERPObject obj)
        {
            return new ERPDriving_license_category(obj);
        }
    }
}