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

        public double min_spent
        {
            get { return data.min_spent; }
            set { data.min_spent = value; }
        }

        public double collection_factor
        {
            get { return data.collection_factor; }
            set { data.collection_factor = value; }
        }


    }

    //Enums go here

}