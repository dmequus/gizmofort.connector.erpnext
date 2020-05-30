using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_field
{
    public class Pos_fieldService : SubServiceBase<ERPPos_field>
    {
        public Pos_fieldService(ERPNextClient client)
            : base(DocType.Pos_field, client) { }

        protected override ERPPos_field fromERPObject(ERPObject obj)
        {
            return new ERPPos_field(obj);
        }
    }
}