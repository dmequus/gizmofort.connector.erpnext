using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Donor_type
{
    public class ERPDonor_type : ERPNextObjectBase
    {
        public ERPDonor_type() : this(new ERPObject(DocType.Donor_type)) { }
        public ERPDonor_type(ERPObject obj) : base(obj) { }

        public static ERPDonor_type Create(string donortype)

        {
            ERPDonor_type obj = new ERPDonor_type();
            obj.donor_type = donortype;
            return obj;
        }

        public string donor_type
        {
            get { return data.donor_type; }
            set
            {
                data.donor_type = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}