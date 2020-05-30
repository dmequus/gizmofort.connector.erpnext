using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Lead_source
{
    public class ERPLead_source : ERPNextObjectBase
    {
        public ERPLead_source() : this(new ERPObject(DocType.Lead_source)) { }
        public ERPLead_source(ERPObject obj) : base(obj) { }

        public static ERPLead_source Create(string sourcename, string details)

        {
            ERPLead_source obj = new ERPLead_source();
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