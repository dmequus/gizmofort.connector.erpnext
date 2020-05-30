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

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
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