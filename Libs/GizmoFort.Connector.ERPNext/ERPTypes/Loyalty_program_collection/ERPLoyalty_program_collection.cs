using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program_collection
{
    public class ERPLoyalty_program_collection : ERPNextObjectBase
    {
        public ERPLoyalty_program_collection() : this(new ERPObject(DocType.Loyalty_program_collection)) { }
        public ERPLoyalty_program_collection(ERPObject obj) : base(obj) { }

        public static ERPLoyalty_program_collection Create(string tiername, double minspent, double collectionfactor)

        {
            ERPLoyalty_program_collection obj = new ERPLoyalty_program_collection();
            obj.tier_name = tiername;
            obj.min_spent = minspent;
            obj.collection_factor = collectionfactor;
            return obj;
        }

        public string tier_name
        {
            get { return data.tier_name; }
            set
            {
                data.tier_name = value;
                data.name = value;
            }

        }

        private double _min_spent = 0.0;
        public double min_spent
        {
            get { return data._min_spent; }
            set { data._min_spent = value; }
        }

        private double _collection_factor = 0.0;
        public double collection_factor
        {
            get { return data._collection_factor; }
            set { data._collection_factor = value; }
        }


    }

    //Enums go here

}