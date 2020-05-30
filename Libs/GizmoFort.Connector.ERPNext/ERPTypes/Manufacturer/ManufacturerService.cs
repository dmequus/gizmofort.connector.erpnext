using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturer
{
    public class ManufacturerService : SubServiceBase<ERPManufacturer>
    {
        public ManufacturerService(ERPNextClient client)
            : base(DocType.Manufacturer, client) { }

        protected override ERPManufacturer fromERPObject(ERPObject obj)
        {
            return new ERPManufacturer(obj);
        }
    }
}