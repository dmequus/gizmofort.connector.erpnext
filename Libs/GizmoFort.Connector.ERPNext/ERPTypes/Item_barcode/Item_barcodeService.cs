using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_barcode
{
    public class Item_barcodeService : SubServiceBase<ERPItem_barcode>
    {
        public Item_barcodeService(ERPNextClient client)
            : base(DocType.Item_barcode, client) { }

        protected override ERPItem_barcode fromERPObject(ERPObject obj)
        {
            return new ERPItem_barcode(obj);
        }
    }
}