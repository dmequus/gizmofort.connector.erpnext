using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Department_approver
{
    public class ERPDepartment_approver : ERPNextObjectBase
    {
        public ERPDepartment_approver() : this(new ERPObject(DocType.Department_approver)) { }
        public ERPDepartment_approver(ERPObject obj) : base(obj) { }

        public static ERPDepartment_approver Create(string approver)

        {
            ERPDepartment_approver obj = new ERPDepartment_approver();
            obj.approver = approver;
            return obj;
        }

        public string approver
        {
            get { return data.approver; }
            set
            {
                data.approver = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}