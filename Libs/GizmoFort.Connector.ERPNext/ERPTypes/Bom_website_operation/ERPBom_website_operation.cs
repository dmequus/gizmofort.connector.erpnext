using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_operation
{
    public class ERPBom_website_operation : ERPNextObjectBase
    {
        public ERPBom_website_operation() : this(new ERPObject(DocType.Bom_website_operation)) { }
        public ERPBom_website_operation(ERPObject obj) : base(obj) { }

        public static ERPBom_website_operation Create(string operation, string workstation, double timeinmins, string websiteimage, string thumbnail)

        {
            ERPBom_website_operation obj = new ERPBom_website_operation();
            obj.operation = operation;
            obj.workstation = workstation;
            obj.time_in_mins = timeinmins;
            obj.website_image = websiteimage;
            obj.thumbnail = thumbnail;
            return obj;
        }

        public string operation
        {
            get { return data.operation; }
            set
            {
                data.operation = value;
                data.name = value;
            }

        }

        public string workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        private double _time_in_mins = 0.0;
        public double time_in_mins
        {
            get { return data._time_in_mins; }
            set { data._time_in_mins = value; }
        }

        public string website_image
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }

        public string thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = value; }
        }


    }

    //Enums go here

}