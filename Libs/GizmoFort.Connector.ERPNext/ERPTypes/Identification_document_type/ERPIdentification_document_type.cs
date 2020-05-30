using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Identification_document_type
{
    public class ERPIdentification_document_type : ERPNextObjectBase
    {
        public ERPIdentification_document_type() : this(new ERPObject(DocType.Identification_document_type)) { }
        public ERPIdentification_document_type(ERPObject obj) : base(obj) { }

        public static ERPIdentification_document_type Create(string identificationdocumenttype)

        {
            ERPIdentification_document_type obj = new ERPIdentification_document_type();
            obj.identification_document_type = identificationdocumenttype;
            return obj;
        }

        public string identification_document_type
        {
            get { return data.identification_document_type; }
            set
            {
                data.identification_document_type = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}