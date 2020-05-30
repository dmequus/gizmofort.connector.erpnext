using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure_process
{
    public class ERPQuality_procedure_process : ERPNextObjectBase
    {
        public ERPQuality_procedure_process() : this(new ERPObject(DocType.Quality_procedure_process)) { }
        public ERPQuality_procedure_process(ERPObject obj) : base(obj) { }

        public static ERPQuality_procedure_process Create()

        {
            ERPQuality_procedure_process obj = new ERPQuality_procedure_process();
            return obj;
        }

        public string process_description
        {
            get { return data.process_description; }
            set
            {
                data.process_description = value;
                data.name = value;
            }

        }

        public string procedure
        {
            get { return data.procedure; }
            set { data.procedure = value; }
        }


    }

    //Enums go here

}