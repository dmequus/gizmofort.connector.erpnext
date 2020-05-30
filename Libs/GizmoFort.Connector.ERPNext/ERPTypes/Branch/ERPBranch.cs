using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Branch
{
    public class ERPBranch : ERPNextObjectBase
    {
        public ERPBranch() : this(new ERPObject(DocType.Branch)) { }
        public ERPBranch(ERPObject obj) : base(obj) { }

        public static ERPBranch Create(string branch)

        {
            ERPBranch obj = new ERPBranch();
            obj.branch = branch;
            return obj;
        }

        public string branch
        {
            get { return data.branch; }
            set
            {
                data.branch = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}