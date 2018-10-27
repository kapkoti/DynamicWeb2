using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DynamicWeb.Dal
{
    public class CategoryDal : CheckNull
    {
        public string Categoryname { get; set; }

        SqlParameter[] arrproc;
        clsDataUtility dUT = new clsDataUtility();

        public int AddCategory(string cat_name)
        {
            string spName = "sp_insert_tbl_web_menu";
            clsDataUtility dUT = new clsDataUtility();
            arrproc = new SqlParameter[1];
            arrproc[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 100);
            arrproc[0].Value = CheckNullString(cat_name);
                      
          
            int result = 0;
            DataTable dt = new DataTable();
            dt = dUT.getDataTableproc(spName, arrproc);
            if (dt.Rows.Count > 0)
            {
                result = Convert.ToInt32(dt.Rows[0]["id"]);
            }
            return result;
        }


        public DataTable ShowCategory()
        {
            string spName = "sp_category";
            clsDataUtility dUT = new clsDataUtility();
            DataTable dt;
            dt = dUT.getDataTable(spName);
            return dt;
        }



    }
}