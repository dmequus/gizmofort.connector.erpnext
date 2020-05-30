using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Taxable_salary_slab
{
    public class Taxable_salary_slabService : SubServiceBase<ERPTaxable_salary_slab>
    {
        public Taxable_salary_slabService(ERPNextClient client)
            : base(DocType.Taxable_salary_slab, client) { }

        protected override ERPTaxable_salary_slab fromERPObject(ERPObject obj)
        {
            return new ERPTaxable_salary_slab(obj);
        }
    }
}