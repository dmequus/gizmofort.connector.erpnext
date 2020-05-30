using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Location
{
    public class ERPLocation : ERPNextObjectBase
    {
        public ERPLocation() : this(new ERPObject(DocType.Location)) { }
        public ERPLocation(ERPObject obj) : base(obj) { }

        public static ERPLocation Create(string locationname)

        {
            ERPLocation obj = new ERPLocation();
            obj.location_name = locationname;
            return obj;
        }

        public string location_name
        {
            get { return data.location_name; }
            set
            {
                data.location_name = value;
                data.name = value;
            }

        }

        public string parent_location
        {
            get { return data.parent_location; }
            set { data.parent_location = value; }
        }

        private int _is_container = 0;
        public int is_container
        {
            get { return data._is_container; }
            set { data._is_container = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        private double _latitude = 0.0;
        public double latitude
        {
            get { return data._latitude; }
            set { data._latitude = value; }
        }

        private double _longitude = 0.0;
        public double longitude
        {
            get { return data._longitude; }
            set { data._longitude = value; }
        }

        private double _area = 0.0;
        public double area
        {
            get { return data._area; }
            set { data._area = value; }
        }

        public string area_uom
        {
            get { return data.area_uom; }
            set { data.area_uom = value; }
        }

        public string location
        {
            get { return data.location; }
            set { data.location = value; }
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


    }

    //Enums go here

}