using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure
{
    public class ERPQuality_procedure : ERPNextObjectBase
    {
        public ERPQuality_procedure() : this(new ERPObject(DocType.Quality_procedure)) { }
        public ERPQuality_procedure(ERPObject obj) : base(obj) { }

        public static ERPQuality_procedure Create(string qualityprocedurename)

        {
            ERPQuality_procedure obj = new ERPQuality_procedure();
            obj.quality_procedure_name = qualityprocedurename;
            return obj;
        }

        public string quality_procedure_name
        {
            get { return data.quality_procedure_name; }
            set
            {
                data.quality_procedure_name = value;
                data.name = value;
            }

        }

        public string parent_quality_procedure
        {
            get { return data.parent_quality_procedure; }
            set { data.parent_quality_procedure = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public int lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        public int rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string processes
        {
            get { return data.processes; }
            set { data.processes = value; }
        }


    }

    //Enums go here

}