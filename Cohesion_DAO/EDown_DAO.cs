using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Cohesion_DTO;

namespace Cohesion_DAO
{
    public class EDown_DAO : IDisposable
    {
        SqlConnection conn = null;
        readonly string DB = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public void Dispose()
        {
            if (conn != null || conn.State == ConnectionState.Open)
                conn.Close();
        }
        public EDown_DAO()
        {
            conn = new SqlConnection(DB);
        }

        public List<EQUIP_DOWN_DTO> SelectEDownSearch(string from, string to)
        {
            List<EQUIP_DOWN_DTO> list = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "Select EQUIPMENT_CODE, DT_DATE, DT_START_TIME, DT_END_TIME, DT_TIME, DT_CODE, DT_COMMENT, DT_USER_ID, ACTION_COMMENT, CONFIRM_TIME, CONFIRM_USER_ID from EQUIP_DOWN_HIS";

                
                cmd.CommandText = sql.ToString();
                cmd.Connection = conn;
                conn.Open();
                list = Helper.DataReaderMapToList<EQUIP_DOWN_DTO>(cmd.ExecuteReader());
            }

            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public List<EQUIP_DOWN_DTO> SelectEDown()
        {
            List<EQUIP_DOWN_DTO> list = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "Select EQUIPMENT_CODE, DT_DATE, DT_START_TIME, DT_END_TIME, DT_TIME, DT_CODE, DT_COMMENT, DT_USER_ID, ACTION_COMMENT, CONFIRM_TIME, CONFIRM_USER_ID from EQUIP_DOWN_HIS";

                cmd.CommandText = sql.ToString();
                cmd.Connection = conn;
                conn.Open();
                list = Helper.DataReaderMapToList<EQUIP_DOWN_DTO>(cmd.ExecuteReader());
            }

            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public List<EQUIP_DOWN_DTO> SelectEDown1(string from , string to)
        {
            List<EQUIP_DOWN_DTO> list = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "Select EQUIPMENT_CODE, DT_DATE, DT_START_TIME, DT_END_TIME, DT_TIME, DT_CODE, DT_COMMENT, DT_USER_ID, ACTION_COMMENT, CONFIRM_TIME, CONFIRM_USER_ID from EQUIP_DOWN_HIS" +
                            "  where Convert(datetime , DT_START_TIME,3)   >= @from  and Convert(datetime , DT_START_TIME,3)  <= @to";


                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                cmd.CommandText = sql.ToString();
                cmd.Connection = conn;
                conn.Open();
                list = Helper.DataReaderMapToList<EQUIP_DOWN_DTO>(cmd.ExecuteReader());
            }

            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }


        public bool InsertEDown(EQUIP_DOWN_DTO dto)
        {
            try
            {
                conn.Open();
                string sql = @"insert into EQUIP_DOWN_HIS(EQUIPMENT_CODE, DT_DATE, DT_START_TIME, DT_END_TIME, DT_TIME, DT_CODE, DT_COMMENT, DT_USER_ID, ACTION_COMMENT, CONFIRM_TIME, CONFIRM_USER_ID)
values (@EQUIPMENT_CODE, @DT_DATE, @DT_START_TIME, @DT_END_TIME, @DT_CODE, @DT_COMMENT, @DT_USER_ID, @ACTION_COMMENT, @CONFIRM_TIME, @CONFIRM_USER_ID";
                SqlCommand cmd = Helper.UpsertCmdValue<EQUIP_DOWN_DTO>(dto, sql, conn);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }


}
