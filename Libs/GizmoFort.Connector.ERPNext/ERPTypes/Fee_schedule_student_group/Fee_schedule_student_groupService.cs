using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_student_group
{
    public class Fee_schedule_student_groupService : SubServiceBase<ERPFee_schedule_student_group>
    {
        public Fee_schedule_student_groupService(ERPNextClient client)
            : base(DocType.Fee_schedule_student_group, client) { }

        protected override ERPFee_schedule_student_group fromERPObject(ERPObject obj)
        {
            return new ERPFee_schedule_student_group(obj);
        }
    }
}