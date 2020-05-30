using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_relation
{
    public class Patient_relationService : SubServiceBase<ERPPatient_relation>
    {
        public Patient_relationService(ERPNextClient client)
            : base(DocType.Patient_relation, client) { }

        protected override ERPPatient_relation fromERPObject(ERPObject obj)
        {
            return new ERPPatient_relation(obj);
        }
    }
}