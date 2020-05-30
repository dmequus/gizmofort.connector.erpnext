using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab_other_charges
{
    public class Income_tax_slab_other_chargesService : SubServiceBase<ERPIncome_tax_slab_other_charges>
    {
        public Income_tax_slab_other_chargesService(ERPNextClient client)
            : base(DocType.Income_tax_slab_other_charges, client) { }

        protected override ERPIncome_tax_slab_other_charges fromERPObject(ERPObject obj)
        {
            return new ERPIncome_tax_slab_other_charges(obj);
        }
    }
}