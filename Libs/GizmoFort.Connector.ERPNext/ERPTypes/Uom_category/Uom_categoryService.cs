using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_category
{
    public class Uom_categoryService : SubServiceBase<ERPUom_category>
    {
        public Uom_categoryService(ERPNextClient client)
            : base(DocType.Uom_category, client) { }

        protected override ERPUom_category fromERPObject(ERPObject obj)
        {
            return new ERPUom_category(obj);
        }
    }
}