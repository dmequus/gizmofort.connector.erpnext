using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_customer_group
{
    public class Pos_customer_groupService : SubServiceBase<ERPPos_customer_group>
    {
        public Pos_customer_groupService(ERPNextClient client)
            : base(DocType.Pos_customer_group, client) { }

        protected override ERPPos_customer_group fromERPObject(ERPObject obj)
        {
            return new ERPPos_customer_group(obj);
        }
    }
}