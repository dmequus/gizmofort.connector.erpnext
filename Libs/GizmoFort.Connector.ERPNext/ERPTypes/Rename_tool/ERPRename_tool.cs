using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Rename_tool
{
    public class ERPRename_tool : ERPNextObjectBase
    {
        public ERPRename_tool() : this(new ERPObject(DocType.Rename_tool)) { }
        public ERPRename_tool(ERPObject obj) : base(obj) { }

        public static ERPRename_tool Create(string selectdoctype, string filetorename, string renamelog)

        {
            ERPRename_tool obj = new ERPRename_tool();
            obj.select_doctype = selectdoctype;
            obj.file_to_rename = filetorename;
            obj.rename_log = renamelog;
            return obj;
        }

        public string select_doctype
        {
            get { return data.select_doctype; }
            set
            {
                data.select_doctype = value;
                data.name = value;
            }

        }

        public string file_to_rename
        {
            get { return data.file_to_rename; }
            set { data.file_to_rename = value; }
        }

        public string rename_log
        {
            get { return data.rename_log; }
            set { data.rename_log = value; }
        }


    }

    //Enums go here

}