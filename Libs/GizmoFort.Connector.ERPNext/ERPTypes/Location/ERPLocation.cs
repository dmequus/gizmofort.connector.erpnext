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

        public long is_container
        {
            get { return data.is_container; }
            set { data.is_container = value; }
        }

        public long is_group
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        public double latitude
        {
            get { return data.latitude; }
            set { data.latitude = value; }
        }

        public double longitude
        {
            get { return data.longitude; }
            set { data.longitude = value; }
        }

        public double area
        {
            get { return data.area; }
            set { data.area = value; }
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


    }

    //Enums go here

}