using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_type
{
    public class Shift_typeService : SubServiceBase<ERPShift_type>
    {
        public Shift_typeService(ERPNextClient client)
            : base(DocType.Shift_type, client) { }

        protected override ERPShift_type fromERPObject(ERPObject obj)
        {
            return new ERPShift_type(obj);
        }
    }
}