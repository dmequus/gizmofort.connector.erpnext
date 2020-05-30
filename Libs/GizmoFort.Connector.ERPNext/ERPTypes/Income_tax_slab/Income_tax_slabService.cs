using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab
{
    public class Income_tax_slabService : SubServiceBase<ERPIncome_tax_slab>
    {
        public Income_tax_slabService(ERPNextClient client)
            : base(DocType.Income_tax_slab, client) { }

        protected override ERPIncome_tax_slab fromERPObject(ERPObject obj)
        {
            return new ERPIncome_tax_slab(obj);
        }
    }
}