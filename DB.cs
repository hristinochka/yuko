using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    class DB
    {
        private static SqlConnection getConnection()
        {
            return new SqlConnection(@"Server = LAPTOP-R2AMPCEP; Database = Diploma; Trusted_Connection = True");
            //return new SqlConnection(@"Server=ZEVS; Database = Diploma; Trusted_Connection=True");
        }
        //ДЛЯ УЧЕТНОЙ ЗАПИСИ EMPLOYEE
        public static List<List<string>> loadDataFromEquipmentEmployee()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_equip, NameType, NameEquip, brandequip, workplace, inventorynumber, NameApp FROM Equipment JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN Applying ON Applying.id_applying=Equipment.id_applying JOIN TypeOfEquipment ON TypeOfEquipment.id_type=Equipment.id_type", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_equip"].ToString());
                result[result.Count - 1].Add(reader["NameType"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["brandequip"].ToString());
                result[result.Count - 1].Add(reader["workplace"].ToString());
                result[result.Count - 1].Add(reader["inventorynumber"].ToString());
                result[result.Count - 1].Add(reader["NameApp"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<List<string>> loadDataFromApplicationsEmployee()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_applic, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM Applications JOIN Equipment ON Applications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=Applications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=Applications.id_app JOIN Users on Users.id_user=Applications.id_user WHERE Applications.id_app = '1' or Applications.id_app = '2'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_applic"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToApplicationsEmployee(string id_equip, string id_job, string id_user, string applicationdate)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Applications VALUES(@id_equip, @id_job, @id_user, @applicationdate)", connection);
            command.Parameters.AddWithValue("@id_equip", id_equip);
            command.Parameters.AddWithValue("@id_job", id_job);
            command.Parameters.AddWithValue("@id_user", id_user);
            command.Parameters.AddWithValue("@applicationdate", applicationdate);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromArchiveApplicationsEmployee()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_archive, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM ArchiveApplications JOIN Equipment ON ArchiveApplications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=ArchiveApplications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=ArchiveApplications.id_app JOIN Users on Users.id_user=ArchiveApplications.id_user", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_archive"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }

        public static List<string> loadDataFromPositionEmployee()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NamePos FROM Position", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NamePos"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<string> loadDataFromApplicationStatusEmployee()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NameAJ FROM ApplicationStatus", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NameAJ"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<List<string>> loadDataWithFilter()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_archive, NameEquip, datestart, dateend FROM Applications JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip WHERE datestart=@datestart and dateend=@dateend", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_archive"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["@datestart"].ToString());
                result[result.Count - 1].Add(reader["@dateend"].ToString());
            }
            connection.Close();
            return result;
        }
        //ДЛЯ УЧЕТНОЙ ЗАПИСИ MASTER
        public static List<List<string>> loadDataFromEquipmentMaster()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_equip, NameType, NameEquip, brandequip, workplace, inventorynumber, NameApp FROM Equipment JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN Applying ON Applying.id_applying=Equipment.id_applying JOIN TypeOfEquipment ON TypeOfEquipment.id_type=Equipment.id_type", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_equip"].ToString());
                result[result.Count - 1].Add(reader["NameType"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["brandequip"].ToString());
                result[result.Count - 1].Add(reader["workplace"].ToString());
                result[result.Count - 1].Add(reader["inventorynumber"].ToString());
                result[result.Count - 1].Add(reader["NameApp"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<string> loadDataFromTypeOfEquipmentMaster()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NameType FROM TypeOfEquipment", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NameType"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<string> loadDataFromNameOfEquipmentMaster()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NameEquip FROM NameOfEquipment", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NameEquip"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<string> loadDataFromApplyingMaster()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NameApp FROM Applying", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NameApp"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToEquipmentMaster(string NameType, string NameEquip, string brandequip, string workplace, string inventorynumber, string NameApp)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Equipments VALUES(@NameType, @NameEquip, @brandequip, @workplace, @inventorynumber, @NameApp)", connection);
            command.Parameters.AddWithValue("@NameType", NameType);
            command.Parameters.AddWithValue("@NameEquip", NameEquip);
            command.Parameters.AddWithValue("@brandequip", brandequip);
            command.Parameters.AddWithValue("@workplace", workplace);
            command.Parameters.AddWithValue("@inventorynumber", inventorynumber);
            command.Parameters.AddWithValue("@NameApp", NameApp);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void deleteDataFromEquipmentMaster(string id_equip)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Equipment WHERE id_equip = @id_equip", connection);
            command.Parameters.AddWithValue("@id_equip", id_equip);
            connection.Open();
            command.ExecuteNonQuery();
        }
        public static List<List<string>> loadDataFromApplicationsMaster()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_applic, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM Applications JOIN Equipment ON Applications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=Applications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=Applications.id_app JOIN Users on Users.id_user=Applications.id_user WHERE Applications.id_app = '1' or Applications.id_app = '2'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_applic"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<string> loadDataFromJobStatusMaster()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT NameSJ FROM JobStatus", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["NameSJ"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToApplicationsMaster(string id_app, DateTime datestart, DateTime dateend)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Applications VALUES(@id_app, @datestart, @dateend)", connection);
            command.Parameters.AddWithValue("@id_app", id_app);
            command.Parameters.AddWithValue("@datestart", datestart);
            command.Parameters.AddWithValue("@dateend", dateend);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromArchiveApplicationsMaster()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_archive, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM ArchiveApplications JOIN Equipment ON ArchiveApplications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=ArchiveApplications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=ArchiveApplications.id_app JOIN Users on Users.id_user=ArchiveApplications.id_user", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_archive"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }
        //ДЛЯ УЧЕТНОЙ ЗАПИСИ ADMIN
        public static List<List<string>> loadDataFromTypeOfEquipmentAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_type, NameType FROM TypeOfEquipment", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_type"].ToString());
                result[result.Count - 1].Add(reader["NameType"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToTypeOfEquipmentAdmin(string NameType)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO TypeOfEquipment VALUES(@NameType)", connection);
            command.Parameters.AddWithValue("@NameType", NameType);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromNameOfEquipmentAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_nameofequip, NameEquip FROM NameOfEquipment", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_nameofequip"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToNameOfEquipmentAdmin(string NameEquip)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO NameOfEquipment VALUES(@NameEquip)", connection);
            command.Parameters.AddWithValue("@NameEquip", NameEquip);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromApplyingAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_applying, NameApp FROM Applying", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_applying"].ToString());
                result[result.Count - 1].Add(reader["NameApp"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToApplyingAdmin(string NameApp)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Applying VALUES(@NameApp)", connection);
            command.Parameters.AddWithValue("@NameApp", NameApp);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromUsersAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_user, fullname, NamePos FROM Users JOIN Position ON Users.id_pos=Position.id_pos", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_user"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["NamePos"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToUsersAdmin(string NameApp, string NamePos)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Users VALUES(@NameApp, @NamePos)", connection);
            command.Parameters.AddWithValue("@NameApp", NameApp);
            command.Parameters.AddWithValue("@NamePos", NamePos);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<string> loadDataFromPositionAdmin()
        {
            List<string> result = new List<string>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT fullname FROM Users", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader["fullname"].ToString());
            }
            connection.Close();
            return result;
        }
        public static List<List<string>> loadDataFromApplicationsAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_applic, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM Applications JOIN Equipment ON Applications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=Applications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=Applications.id_app JOIN Users on Users.id_user=Applications.id_user WHERE Applications.id_app = '1' or Applications.id_app = '2'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_applic"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }
        public static void addDataToApplicationsAdmin(DateTime datestart, DateTime dateend)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Applications VALUES(@datestart, @dateend)", connection);
            command.Parameters.AddWithValue("@datestart", datestart);
            command.Parameters.AddWithValue("@dateend", dateend);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<List<string>> loadDataFromArchiveApplicationsAdmin()
        {
            List<List<string>> result = new List<List<string>>();
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand("SELECT id_archive, NameEquip, NameSJ, NameAJ, fullname, applicationdate, datestart, dateend FROM ArchiveApplications JOIN Equipment ON ArchiveApplications.id_equip=Equipment.id_equip JOIN NameOfEquipment ON Equipment.id_nameofequip=NameOfEquipment.id_nameofequip JOIN JobStatus ON JobStatus.id_job=ArchiveApplications.id_job JOIN ApplicationStatus ON ApplicationStatus.id_app=ArchiveApplications.id_app JOIN Users on Users.id_user=ArchiveApplications.id_user", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new List<string>());
                result[result.Count - 1].Add(reader["id_archive"].ToString());
                result[result.Count - 1].Add(reader["NameEquip"].ToString());
                result[result.Count - 1].Add(reader["NameSJ"].ToString());
                result[result.Count - 1].Add(reader["NameAJ"].ToString());
                result[result.Count - 1].Add(reader["fullname"].ToString());
                result[result.Count - 1].Add(reader["applicationdate"].ToString());
                result[result.Count - 1].Add(reader["datestart"].ToString());
                result[result.Count - 1].Add(reader["dateend"].ToString());
            }
            connection.Close();
            return result;
        }
    }
}
