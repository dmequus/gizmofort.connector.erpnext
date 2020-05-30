using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Certified_consultant
{
    public class ERPCertified_consultant : ERPNextObjectBase
    {
        public ERPCertified_consultant() : this(new ERPObject(DocType.Certified_consultant)) { }
        public ERPCertified_consultant(ERPObject obj) : base(obj) { }

        public static ERPCertified_consultant Create(string nameofconsultant, string country, string email, string phone, string websiteurl, string address, string image, string certificationapplication, string fromdate, string todate, string introduction, string details, string discussid, string githubid, int showinwebsite)

        {
            ERPCertified_consultant obj = new ERPCertified_consultant();
            obj.name_of_consultant = nameofconsultant;
            obj.country = country;
            obj.email = email;
            obj.phone = phone;
            obj.website_url = websiteurl;
            obj.address = address;
            obj.image = image;
            obj.certification_application = certificationapplication;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.introduction = introduction;
            obj.details = details;
            obj.discuss_id = discussid;
            obj.github_id = githubid;
            obj.show_in_website = showinwebsite;
            return obj;
        }

        public string name_of_consultant
        {
            get { return data.name_of_consultant; }
            set
            {
                data.name_of_consultant = value;
                data.name = value;
            }

        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        public string website_url
        {
            get { return data.website_url; }
            set { data.website_url = value; }
        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string certification_application
        {
            get { return data.certification_application; }
            set { data.certification_application = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        public string details
        {
            get { return data.details; }
            set { data.details = value; }
        }

        public string discuss_id
        {
            get { return data.discuss_id; }
            set { data.discuss_id = value; }
        }

        public string github_id
        {
            get { return data.github_id; }
            set { data.github_id = value; }
        }

        private int _show_in_website = 0;
        public int show_in_website
        {
            get { return data._show_in_website; }
            set { data._show_in_website = value; }
        }


    }

    //Enums go here

}