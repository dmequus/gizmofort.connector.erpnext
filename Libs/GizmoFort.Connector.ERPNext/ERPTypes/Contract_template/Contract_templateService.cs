using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_template
{
    public class Contract_templateService : SubServiceBase<ERPContract_template>
    {
        public Contract_templateService(ERPNextClient client)
            : base(DocType.Contract_template, client) { }

        protected override ERPContract_template fromERPObject(ERPObject obj)
        {
            return new ERPContract_template(obj);
        }
    }
}