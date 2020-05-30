using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Complaint
{
    public class ERPComplaint : ERPNextObjectBase
    {
        public ERPComplaint() : this(new ERPObject(DocType.Complaint)) { }
        public ERPComplaint(ERPObject obj) : base(obj) { }

        public static ERPComplaint Create(string complaints)

        {
            ERPComplaint obj = new ERPComplaint();
            obj.complaints = complaints;
            return obj;
        }

        public string complaints
        {
            get { return data.complaints; }
            set
            {
                data.complaints = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}