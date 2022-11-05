using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class Dormitory
    {
        public int RowNumb { get; set; }
        public int IdDormitory { get; set; }
        public string PhoneNumbD { get; set; }
        public string Adress { get; set; }
        public string NameDormitory { get; set; }
        public int NumbOfRooms { get; set; }
        public Dormitory()
        {
            RowNumb = 0;
            IdDormitory = 0;
            PhoneNumbD = string.Empty;
            Adress = string.Empty;
            NameDormitory = string.Empty;
            NumbOfRooms = 0;
        }
        public static Dormitory Map(DataRow dataRow)
        {
            Dormitory result = new Dormitory();
            result.IdDormitory = (int)dataRow["IdDormitory"];
            result.PhoneNumbD = dataRow["PhoneNumbD"].ToString();
            result.Adress = dataRow["Adress"].ToString();
            result.NameDormitory = dataRow["NameDormitory"].ToString();
            result.NumbOfRooms = (int)dataRow["NumbOfRooms"];
            return result;
        }

        public static Dormitory Map(DataRow dataRow, int index)
        {
            Dormitory result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}