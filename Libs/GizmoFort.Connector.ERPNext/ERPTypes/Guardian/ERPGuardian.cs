using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian
{
    public class ERPGuardian : ERPNextObjectBase
    {
        public ERPGuardian() : this(new ERPObject(DocType.Guardian)) { }
        public ERPGuardian(ERPObject obj) : base(obj) { }

        public static ERPGuardian Create(string guardianname, string emailaddress, string mobilenumber, string alternatenumber, string dateofbirth, string user, string education, string occupation, string designation, string workaddress, string image, string students, string interests)

        {
            ERPGuardian obj = new ERPGuardian();
            obj.guardian_name = guardianname;
            obj.email_address = emailaddress;
            obj.mobile_number = mobilenumber;
            obj.alternate_number = alternatenumber;
            obj.date_of_birth = dateofbirth;
            obj.user = user;
            obj.education = education;
            obj.occupation = occupation;
            obj.designation = designation;
            obj.work_address = workaddress;
            obj.image = image;
            obj.students = students;
            obj.interests = interests;
            return obj;
        }

        public string guardian_name
        {
            get { return data.guardian_name; }
            set
            {
                data.guardian_name = value;
                data.name = value;
            }

        }

        public string email_address
        {
            get { return data.email_address; }
            set { data.email_address = value; }
        }

        public string mobile_number
        {
            get { return data.mobile_number; }
            set { data.mobile_number = value; }
        }

        public string alternate_number
        {
            get { return data.alternate_number; }
            set { data.alternate_number = value; }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string education
        {
            get { return data.education; }
            set { data.education = value; }
        }

        public string occupation
        {
            get { return data.occupation; }
            set { data.occupation = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string work_address
        {
            get { return data.work_address; }
            set { data.work_address = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string students
        {
            get { return data.students; }
            set { data.students = value; }
        }

        public string interests
        {
            get { return data.interests; }
            set { data.interests = value; }
        }


    }

    //Enums go here

}