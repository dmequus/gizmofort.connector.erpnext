using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_program
{
    public class Fee_schedule_programService : SubServiceBase<ERPFee_schedule_program>
    {
        public Fee_schedule_programService(ERPNextClient client)
            : base(DocType.Fee_schedule_program, client) { }

        protected override ERPFee_schedule_program fromERPObject(ERPObject obj)
        {
            return new ERPFee_schedule_program(obj);
        }
    }
}