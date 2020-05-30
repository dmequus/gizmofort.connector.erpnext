using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Print_heading
{
    public class ERPPrint_heading : ERPNextObjectBase
    {
        public ERPPrint_heading() : this(new ERPObject(DocType.Print_heading)) { }
        public ERPPrint_heading(ERPObject obj) : base(obj) { }

        public static ERPPrint_heading Create(string printheading, string description)

        {
            ERPPrint_heading obj = new ERPPrint_heading();
            obj.print_heading = printheading;
            obj.description = description;
            return obj;
        }

        public string print_heading
        {
            get { return data.print_heading; }
            set
            {
                data.print_heading = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}