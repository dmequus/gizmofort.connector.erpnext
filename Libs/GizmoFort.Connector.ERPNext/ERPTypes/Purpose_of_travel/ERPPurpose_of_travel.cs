using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purpose_of_travel
{
    public class ERPPurpose_of_travel : ERPNextObjectBase
    {
        public ERPPurpose_of_travel() : this(new ERPObject(DocType.Purpose_of_travel)) { }
        public ERPPurpose_of_travel(ERPObject obj) : base(obj) { }

        public static ERPPurpose_of_travel Create(string purposeoftravel)

        {
            ERPPurpose_of_travel obj = new ERPPurpose_of_travel();
            obj.purpose_of_travel = purposeoftravel;
            return obj;
        }

        public string purpose_of_travel
        {
            get { return data.purpose_of_travel; }
            set
            {
                data.purpose_of_travel = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}