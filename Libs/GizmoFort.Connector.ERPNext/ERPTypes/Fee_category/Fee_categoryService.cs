using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_category
{
    public class Fee_categoryService : SubServiceBase<ERPFee_category>
    {
        public Fee_categoryService(ERPNextClient client)
            : base(DocType.Fee_category, client) { }

        protected override ERPFee_category fromERPObject(ERPObject obj)
        {
            return new ERPFee_category(obj);
        }
    }
}