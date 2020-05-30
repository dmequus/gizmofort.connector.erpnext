using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Serial_no
{
    public class Serial_noService : SubServiceBase<ERPSerial_no>
    {
        public Serial_noService(ERPNextClient client)
            : base(DocType.Serial_no, client) { }

        protected override ERPSerial_no fromERPObject(ERPObject obj)
        {
            return new ERPSerial_no(obj);
        }
    }
}