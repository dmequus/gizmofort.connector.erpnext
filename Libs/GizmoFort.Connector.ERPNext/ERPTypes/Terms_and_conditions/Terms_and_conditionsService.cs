using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Terms_and_conditions
{
    public class Terms_and_conditionsService : SubServiceBase<ERPTerms_and_conditions>
    {
        public Terms_and_conditionsService(ERPNextClient client)
            : base(DocType.Terms_and_conditions, client) { }

        protected override ERPTerms_and_conditions fromERPObject(ERPObject obj)
        {
            return new ERPTerms_and_conditions(obj);
        }
    }
}