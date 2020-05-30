using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Project_update
{
    public class ERPProject_update : ERPNextObjectBase
    {
        public ERPProject_update() : this(new ERPObject(DocType.Project_update)) { }
        public ERPProject_update(ERPObject obj) : base(obj) { }

        public static ERPProject_update Create(string namingseries, string project, long sent, string date, string time, string users, string amendedfrom)

        {
            ERPProject_update obj = new ERPProject_update();
            obj.naming_series = namingseries;
            obj.project = project;
            obj.sent = sent;
            obj.date = date;
            obj.time = time;
            obj.users = users;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public long sent
        {
            get { return data.sent; }
            set { data.sent = value; }
        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string time
        {
            get { return data.time; }
            set { data.time = value; }
        }

        public string users
        {
            get { return data.users; }
            set { data.users = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}