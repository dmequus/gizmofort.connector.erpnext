using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Disease
{
    public class DiseaseService : SubServiceBase<ERPDisease>
    {
        public DiseaseService(ERPNextClient client)
            : base(DocType.Disease, client) { }

        protected override ERPDisease fromERPObject(ERPObject obj)
        {
            return new ERPDisease(obj);
        }
    }
}