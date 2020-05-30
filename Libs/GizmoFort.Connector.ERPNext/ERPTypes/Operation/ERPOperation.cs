using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Operation
{
    public class ERPOperation : ERPNextObjectBase
    {
        public ERPOperation() : this(new ERPObject(DocType.Operation)) { }
        public ERPOperation(ERPObject obj) : base(obj) { }

        public static ERPOperation Create(string workstation, string description)

        {
            ERPOperation obj = new ERPOperation();
            obj.workstation = workstation;
            obj.description = description;
            return obj;
        }

        public string workstation
        {
            get { return data.workstation; }
            set
            {
                data.workstation = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}