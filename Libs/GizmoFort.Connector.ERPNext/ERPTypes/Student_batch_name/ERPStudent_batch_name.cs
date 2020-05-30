using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Student_batch_name
{
    public class ERPStudent_batch_name : ERPNextObjectBase
    {
        public ERPStudent_batch_name() : this(new ERPObject(DocType.Student_batch_name)) { }
        public ERPStudent_batch_name(ERPObject obj) : base(obj) { }

        public static ERPStudent_batch_name Create(string batchname)

        {
            ERPStudent_batch_name obj = new ERPStudent_batch_name();
            obj.batch_name = batchname;
            return obj;
        }

        public string batch_name
        {
            get { return data.batch_name; }
            set
            {
                data.batch_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}