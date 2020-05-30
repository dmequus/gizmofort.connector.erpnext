using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program
{
    public class Loyalty_programService : SubServiceBase<ERPLoyalty_program>
    {
        public Loyalty_programService(ERPNextClient client)
            : base(DocType.Loyalty_program, client) { }

        protected override ERPLoyalty_program fromERPObject(ERPObject obj)
        {
            return new ERPLoyalty_program(obj);
        }
    }
}