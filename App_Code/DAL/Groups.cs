using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class Groups
    {
        public int RowNumb { get; set; }
        public int IdGroup { get; set; }
        public int Course { get; set; }
        public string CodeGroup { get; set; }
        public int IdDirection { get; set; }
        public string CodeDirection { get; set; }
        public Groups()
        {
            RowNumb = 0;
            IdGroup = 0;
            Course = 0;
            CodeGroup = string.Empty;
            IdDirection = 0;
            CodeDirection = string.Empty;
        }
        public static Groups Map(DataRow dataRow)
        {
            Groups result = new Groups();
            result.IdGroup = (int)dataRow["IdGroup"];
            result.Course = (int)dataRow["Course"];
            result.CodeGroup = dataRow["CodeGroup"].ToString();
            result.CodeDirection = dataRow["CodeDirection"].ToString();
            result.IdDirection = (int)dataRow["IdDirection"];
            return result;
        }

        public static Groups Map(DataRow dataRow, int index)
        {
            Groups result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}