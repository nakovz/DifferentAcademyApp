using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame;
using System.Data.SqlClient;
using System.Data;

namespace DifferentAcademyWinForm {
    public class DbPerson {

        public static void AddNewUser(MyPerson person) {
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using (var command = new SqlCommand("spPerson_InsertNew", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", person.FirstName);
                    command.Parameters.AddWithValue("@lastName", person.LastName);
                    command.Parameters.AddWithValue("@email", person.Email);
                    command.Parameters.AddWithValue("@password", person.UserPassword);
                    command.Parameters.AddWithValue("@phone", person.Phone);
                    command.Parameters.AddWithValue("@dob", person.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", person.Gender);
                    command.Parameters.AddWithValue("@accountType", person.AccountType);
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteUserById(string id) {
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using (var command = new SqlCommand("spPerson_DeleteById", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public static List<MyPerson> GetPersonByEmail(string email) {
            List<MyPerson> peopleByEmail = new List<MyPerson>();
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using(var command = new SqlCommand("spPerson_GetByEmail",connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", email);
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            peopleByEmail.Add(ConvertDbReaderToPersonType(reader));
                        }
                    }
                }
            }
            return peopleByEmail;
        }

        internal static void UpdateUserInfo(MyPerson person) {
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using (var command = new SqlCommand("spPerson_UpdateUserInfo", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", person.FirstName);
                    command.Parameters.AddWithValue("@lastName", person.LastName);
                    command.Parameters.AddWithValue("@password", person.UserPassword);
                    command.Parameters.AddWithValue("@phone", person.Phone);
                    command.Parameters.AddWithValue("@dob", person.DateOfBirth);
                    command.Parameters.AddWithValue("@gender", person.Gender);
                    command.Parameters.AddWithValue("@id", person.PersonId);
                    command.Parameters.AddWithValue("@accType", person.AccountType);
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetUsersWithEmailLike(string email) {
            var tbl = new DataTable();
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using (var command = new SqlCommand("spPerson_GetUsersWithEmailLike", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", $"%{ email.Trim() }%");
                    using (var adapter = new SqlDataAdapter(command)) {
                        adapter.Fill(tbl);
                    }
                }
            }
            return tbl;
        }

        public static List<MyPerson> GetPersonByEmailAndPassword(string email, string password) {
            List<MyPerson> peopleByEmail = new List<MyPerson>();
            using (var connection = new SqlConnection(DbHelper.CnnVal("DiffrentAcademyStore"))) {
                connection.Open();
                using (var command = new SqlCommand("spPerson_GetByEmailAndPassword", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@userPassword", password);
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            peopleByEmail.Add(ConvertDbReaderToPersonType(reader));
                        }
                    }
                }
            }
            return peopleByEmail;
        }
        private static MyPerson ConvertDbReaderToPersonType(SqlDataReader reader) {
            var user = new MyPerson {
                PersonId = Convert.ToInt32(reader["id"]),
                Email = reader["email"].ToString(),
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString(),
                Gender = reader["gender"].ToString(),
                UserPassword = reader["userPassword"].ToString(),
                DateOfBirth = reader["dob"].GetType() == typeof(DBNull) ? DateTime.MinValue : (DateTime)reader["dob"],
                Phone = reader["phone"].ToString(),
                AccountType=Convert.ToInt16(reader["accountType"])
            };
            return user;
        }
    }
}
