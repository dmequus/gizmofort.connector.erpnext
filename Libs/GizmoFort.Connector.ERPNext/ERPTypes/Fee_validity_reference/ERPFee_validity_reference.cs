using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity_reference
{
    public class ERPFee_validity_reference : ERPNextObjectBase
    {
        public ERPFee_validity_reference() : this(new ERPObject(DocType.Fee_validity_reference)) { }
        public ERPFee_validity_reference(ERPObject obj) : base(obj) { }

        public static ERPFee_validity_reference Create(string appointment)

        {
            ERPFee_validity_reference obj = new ERPFee_validity_reference();
            obj.appointment = appointment;
            return obj;
        }

        public string appointment
        {
            get { return data.appointment; }
            set
            {
                data.appointment = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}