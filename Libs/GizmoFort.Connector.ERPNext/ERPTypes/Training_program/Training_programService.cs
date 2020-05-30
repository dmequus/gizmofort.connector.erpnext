using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_program
{
    public class Training_programService : SubServiceBase<ERPTraining_program>
    {
        public Training_programService(ERPNextClient client)
            : base(DocType.Training_program, client) { }

        protected override ERPTraining_program fromERPObject(ERPObject obj)
        {
            return new ERPTraining_program(obj);
        }
    }
}