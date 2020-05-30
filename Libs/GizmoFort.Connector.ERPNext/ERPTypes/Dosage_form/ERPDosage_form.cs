using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Dosage_form
{
    public class ERPDosage_form : ERPNextObjectBase
    {
        public ERPDosage_form() : this(new ERPObject(DocType.Dosage_form)) { }
        public ERPDosage_form(ERPObject obj) : base(obj) { }

        public static ERPDosage_form Create(string dosageform)

        {
            ERPDosage_form obj = new ERPDosage_form();
            obj.dosage_form = dosageform;
            return obj;
        }

        public string dosage_form
        {
            get { return data.dosage_form; }
            set
            {
                data.dosage_form = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}