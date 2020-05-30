using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity
{
    public class ERPSensitivity : ERPNextObjectBase
    {
        public ERPSensitivity() : this(new ERPObject(DocType.Sensitivity)) { }
        public ERPSensitivity(ERPObject obj) : base(obj) { }

        public static ERPSensitivity Create(string sensitivity)

        {
            ERPSensitivity obj = new ERPSensitivity();
            obj.sensitivity = sensitivity;
            return obj;
        }

        public string sensitivity
        {
            get { return data.sensitivity; }
            set
            {
                data.sensitivity = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}