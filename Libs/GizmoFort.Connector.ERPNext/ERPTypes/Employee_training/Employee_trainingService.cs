using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_training
{
    public class Employee_trainingService : SubServiceBase<ERPEmployee_training>
    {
        public Employee_trainingService(ERPNextClient client)
            : base(DocType.Employee_training, client) { }

        protected override ERPEmployee_training fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_training(obj);
        }
    }
}