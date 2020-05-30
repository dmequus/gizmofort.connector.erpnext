using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Upload_attendance
{
    public class ERPUpload_attendance : ERPNextObjectBase
    {
        public ERPUpload_attendance() : this(new ERPObject(DocType.Upload_attendance)) { }
        public ERPUpload_attendance(ERPObject obj) : base(obj) { }

        public static ERPUpload_attendance Create(string attfrdate, string atttodate, string uploadhtml, string importlog)

        {
            ERPUpload_attendance obj = new ERPUpload_attendance();
            obj.att_fr_date = attfrdate;
            obj.att_to_date = atttodate;
            obj.upload_html = uploadhtml;
            obj.import_log = importlog;
            return obj;
        }

        public string att_fr_date
        {
            get { return data.att_fr_date; }
            set
            {
                data.att_fr_date = value;
                data.name = value;
            }

        }

        public string att_to_date
        {
            get { return data.att_to_date; }
            set { data.att_to_date = value; }
        }

        public string upload_html
        {
            get { return data.upload_html; }
            set { data.upload_html = value; }
        }

        public string import_log
        {
            get { return data.import_log; }
            set { data.import_log = value; }
        }


    }

    //Enums go here

}