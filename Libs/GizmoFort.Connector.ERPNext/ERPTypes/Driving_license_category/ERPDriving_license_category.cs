using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Driving_license_category
{
    public class ERPDriving_license_category : ERPNextObjectBase
    {
        public ERPDriving_license_category() : this(new ERPObject(DocType.Driving_license_category)) { }
        public ERPDriving_license_category(ERPObject obj) : base(obj) { }

        public static ERPDriving_license_category Create()

        {
            ERPDriving_license_category obj = new ERPDriving_license_category();
            return obj;
        }

        public string keyDELclass
        {
            get { return data.keyDELclass; }
            set
            {
                data.keyDELclass = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string issuing_date
        {
            get { return data.issuing_date; }
            set { data.issuing_date = value; }
        }

        public string expiry_date
        {
            get { return data.expiry_date; }
            set { data.expiry_date = value; }
        }


    }

    //Enums go here

}