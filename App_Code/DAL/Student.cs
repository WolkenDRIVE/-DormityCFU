using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class Student
    {
        public int RowNumb { get; set; }
        public int IdStudent { get; set; }
        public int IdGroup { get; set; }
        public int IdRoom { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Documents { get; set; }
        public DateTime? DateOfRegistr { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumb { get; set; }
        public string HAdderss { get; set; }
        public string Direction { get; set; }
        public int Course { get; set; }
        public int IdDormitory { get; set; }
        public int NumbRoom { get; set; }
        public Student()
        {
            RowNumb = 0;
            IdStudent = 0;
            IdGroup = 0;
            IdRoom = 0;
            SecondName = string.Empty;
            FirstName = string.Empty;
            Surname = string.Empty;
            Documents = string.Empty;
            DateOfRegistr = null;
            DateOfBirth = null;
            PhoneNumb = string.Empty;
            HAdderss = string.Empty;
            NumbRoom = 0;
            Direction = string.Empty;
            IdDormitory = 0;
            Course = 0;
        }
        public static Student Map(DataRow dataRow)
        {
            Student result = new Student();
            result.IdStudent = (int)dataRow["IdStudent"];
            result.IdGroup = (int)dataRow["IdGroup"];
            result.IdRoom = (int)dataRow["IdRoom"];
            result.SecondName = dataRow["SecondName"].ToString();
            result.FirstName = dataRow["FirstName"].ToString();
            result.Surname = dataRow["Surname"].ToString();
            result.Documents = dataRow["Documents"].ToString();
            result.DateOfRegistr = dataRow["DateOfRegistr"] != DBNull.Value ? (DateTime?)dataRow["DateOfRegistr"] : null;
            result.DateOfBirth = dataRow["DateOfBirth"] != DBNull.Value ? (DateTime?)dataRow["DateOfBirth"] : null;
            result.PhoneNumb = dataRow["PhoneNumb"].ToString();
            result.HAdderss = dataRow["HAdderss"].ToString();
            result.Course = (int)dataRow["Course"];
            result.IdDormitory = (int)dataRow["IdDormitory"];
            result.Direction = dataRow["Direction"].ToString();
            result.NumbRoom = (int)dataRow["NumbRoom"];
            return result;
        }

        public static Student Map(DataRow dataRow, int index)
        {
            Student result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }

    }
}