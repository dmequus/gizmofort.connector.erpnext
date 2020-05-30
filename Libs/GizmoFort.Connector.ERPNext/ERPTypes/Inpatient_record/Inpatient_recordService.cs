using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_record
{
    public class Inpatient_recordService : SubServiceBase<ERPInpatient_record>
    {
        public Inpatient_recordService(ERPNextClient client)
            : base(DocType.Inpatient_record, client) { }

        protected override ERPInpatient_record fromERPObject(ERPObject obj)
        {
            return new ERPInpatient_record(obj);
        }
    }
}