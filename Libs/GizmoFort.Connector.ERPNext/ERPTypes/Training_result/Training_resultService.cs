using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_result
{
    public class Training_resultService : SubServiceBase<ERPTraining_result>
    {
        public Training_resultService(ERPNextClient client)
            : base(DocType.Training_result, client) { }

        protected override ERPTraining_result fromERPObject(ERPObject obj)
        {
            return new ERPTraining_result(obj);
        }
    }
}