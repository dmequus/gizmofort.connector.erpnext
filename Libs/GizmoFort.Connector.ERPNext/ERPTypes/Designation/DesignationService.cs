using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Designation
{
    public class DesignationService : SubServiceBase<ERPDesignation>
    {
        public DesignationService(ERPNextClient client)
            : base(DocType.Designation, client) { }

        protected override ERPDesignation fromERPObject(ERPObject obj)
        {
            return new ERPDesignation(obj);
        }
    }
}