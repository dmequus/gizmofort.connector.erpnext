using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Closed_document
{
    public class ERPClosed_document : ERPNextObjectBase
    {
        public ERPClosed_document() : this(new ERPObject(DocType.Closed_document)) { }
        public ERPClosed_document(ERPObject obj) : base(obj) { }

        public static ERPClosed_document Create(string documenttype, int closed)

        {
            ERPClosed_document obj = new ERPClosed_document();
            obj.document_type = documenttype;
            obj.closed = closed;
            return obj;
        }

        public string document_type
        {
            get { return data.document_type; }
            set
            {
                data.document_type = value;
                data.name = value;
            }

        }

        private int _closed = 0;
        public int closed
        {
            get { return data._closed; }
            set { data._closed = value; }
        }


    }

    //Enums go here

}