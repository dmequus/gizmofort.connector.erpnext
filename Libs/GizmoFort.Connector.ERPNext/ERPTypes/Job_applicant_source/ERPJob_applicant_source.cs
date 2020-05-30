using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant_source
{
    public class ERPJob_applicant_source : ERPNextObjectBase
    {
        public ERPJob_applicant_source() : this(new ERPObject(DocType.Job_applicant_source)) { }
        public ERPJob_applicant_source(ERPObject obj) : base(obj) { }

        public static ERPJob_applicant_source Create(string sourcename, string details)

        {
            ERPJob_applicant_source obj = new ERPJob_applicant_source();
            obj.source_name = sourcename;
            obj.details = details;
            return obj;
        }

        public string source_name
        {
            get { return data.source_name; }
            set
            {
                data.source_name = value;
                data.name = value;
            }

        }

        public string details
        {
            get { return data.details; }
            set { data.details = value; }
        }


    }

    //Enums go here

}