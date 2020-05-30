using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Detected_disease
{
    public class ERPDetected_disease : ERPNextObjectBase
    {
        public ERPDetected_disease() : this(new ERPObject(DocType.Detected_disease)) { }
        public ERPDetected_disease(ERPObject obj) : base(obj) { }

        public static ERPDetected_disease Create(string disease, string startdate, long taskscreated)

        {
            ERPDetected_disease obj = new ERPDetected_disease();
            obj.disease = disease;
            obj.start_date = startdate;
            obj.tasks_created = taskscreated;
            return obj;
        }

        public string disease
        {
            get { return data.disease; }
            set
            {
                data.disease = value;
                data.name = value;
            }

        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public long tasks_created
        {
            get { return data.tasks_created; }
            set { data.tasks_created = value; }
        }


    }

    //Enums go here

}