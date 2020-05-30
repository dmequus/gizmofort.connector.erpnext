using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Website_filter_field
{
    public class ERPWebsite_filter_field : ERPNextObjectBase
    {
        public ERPWebsite_filter_field() : this(new ERPObject(DocType.Website_filter_field)) { }
        public ERPWebsite_filter_field(ERPObject obj) : base(obj) { }

        public static ERPWebsite_filter_field Create(string fieldname)

        {
            ERPWebsite_filter_field obj = new ERPWebsite_filter_field();
            obj.fieldname = fieldname;
            return obj;
        }

        public string fieldname
        {
            get { return data.fieldname; }
            set
            {
                data.fieldname = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}