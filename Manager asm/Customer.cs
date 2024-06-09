using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    internal class Customer
    {
        private int CustomerID;
        private string name;
        private string email;
        private string phonenum;
        private string address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Customer(int CustomerID, string name, string email, string phonenum, string address)
        {
            this.CustomerID = CustomerID;
            this.name = name;
            this.email = email;
            this.phonenum = phonenum;
            this.address = address;
        }

        public Customer(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        public string Name { get { return name; } }
        public string Email { get { return email; } }
        public string Phonenum { get { return phonenum; } }
        public string Address { get { return address; } }
        public string RequestReservation(DateTime datetime, int pax, string type)
        {
            string status = "";
            if (datetime == null || pax == 0 || string.IsNullOrEmpty(type))
            {
                status = "Please select all reservation options before submitting.";
                return status;
            }

            // Extract Date and Time components from the DateTime parameter
            DateTime date = datetime.Date;
            TimeSpan time = datetime.TimeOfDay;

            // First, check if there is an existing reservation for the same date and time
            string checkQuery = "SELECT COUNT(*) FROM Reservation WHERE Date = @Date AND Time = @Time";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
            {
                checkCommand.Parameters.AddWithValue("@Date", date);
                checkCommand.Parameters.AddWithValue("@Time", time);
                con.Open();
                int existingCount = (int)checkCommand.ExecuteScalar();
                con.Close();

                if (existingCount > 0)
                {
                    status = "There is already a reservation at the selected date and time. Please choose a different time.";
                    return status;
                }
            }

            // If no existing reservation, proceed with inserting a new reservation
            string query = "INSERT INTO Reservation (CustomerID, Date, Time, Pax, Type, Status) " +
                           "VALUES (@CustomerID, @Date, @Time, @Pax, @Type, @Status)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Pax", pax);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Status", "Pending");

                con.Open();
                int rowsAffected = command.ExecuteNonQuery();
                con.Close();

                status = rowsAffected > 0 ? "Reservation submitted successfully." : "Failed to submit reservation.";
            }

            return status;
        }

        public string SubmitFeedbackReservation(string atmosphere, string cleanliness, string music, string ease, string flexibility, string comments)
        {
            // Validation check
            string status = "";
            if (string.IsNullOrWhiteSpace(atmosphere) || string.IsNullOrWhiteSpace(cleanliness) || string.IsNullOrWhiteSpace(ease) || string.IsNullOrWhiteSpace(flexibility) || string.IsNullOrWhiteSpace(music))
            {
                status = "Please select all rating options before submitting.";
                return status;
            }

            string query = "INSERT INTO FeedbackReservation (CustomerID, Atmosphere, Cleanliness, Music, EaseofReservation, Flexibility, Comments) " +
                           "VALUES (@CustomerID, @Atmosphere, @Cleanliness, @Music, @Ease, @Flexibility, @Comments)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                command.Parameters.AddWithValue("@Atmosphere", atmosphere);
                command.Parameters.AddWithValue("@Cleanliness", cleanliness);
                command.Parameters.AddWithValue("@Music", music);
                command.Parameters.AddWithValue("@Ease", ease);
                command.Parameters.AddWithValue("@Flexibility", flexibility);
                command.Parameters.AddWithValue("@Comments", comments);

                con.Open();
                int rowsAffected = command.ExecuteNonQuery();
                con.Close();

                status = rowsAffected > 0 ? "Feedback submitted successfully." : "Failed to submit feedback.";
            }

            return status;
        }

        public string SubmitFeedbackFood(int feedbackFoodID, string food, string staff, string price, string portion, string menu, string comments)
        {
            string status = "";

            // Validation check
            if (string.IsNullOrWhiteSpace(food) || string.IsNullOrWhiteSpace(staff) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(portion) || string.IsNullOrWhiteSpace(menu))
            {
                status = "Please select all rating options before submitting.";
                return status;
            }

            string query = "INSERT INTO FeedbackFood (CustomerID, FeedbackFoodID, FoodQuality, Staff, Price, PortionSize, MenuVariety, Comments) VALUES (@CustomerID, @FeedbackFoodID, @FoodQuality, @Staff, @Price, @PortionSize, @MenuVariety, @Comments)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                cmd.Parameters.AddWithValue("@FeedbackFoodID", feedbackFoodID);
                cmd.Parameters.AddWithValue("@FoodQuality", food);
                cmd.Parameters.AddWithValue("@Staff", staff);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PortionSize", portion);
                cmd.Parameters.AddWithValue("@MenuVariety", menu);
                cmd.Parameters.AddWithValue("@Comments", comments);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                status = i != 0 ? "Feedback submitted successfully." : "Unable to submit feedback.";
            }
            return status;
        }


        public void GetReservation(DataGridView dataReserve)
        {
            dataReserve.Columns.Clear(); // Clear any existing columns in the DataGridView

            // Set the DataGridView column headers
            dataReserve.Columns.Add("ReservationID", "Reservation ID");
            dataReserve.Columns.Add("Date", "Date");
            dataReserve.Columns.Add("Time", "Time");
            dataReserve.Columns.Add("Pax", "Pax");
            dataReserve.Columns.Add("Type", "Type");
            dataReserve.Columns.Add("Status", "Status");

            string query = "SELECT ReservationID, Date, Time, Pax, Type, Status FROM Reservation WHERE CustomerID = @CustomerID";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataReserve.Rows.Clear(); // Clear any existing rows in the DataGridView
                        while (reader.Read())
                        {
                            int reservationId = reader.GetInt32(0);
                            DateTime date = reader.GetDateTime(1);
                            TimeSpan time = reader.GetTimeSpan(2);
                            int pax = reader.GetInt32(3);
                            string type = reader.GetString(4);
                            string status = reader.GetString(5);
                            dataReserve.Rows.Add(reservationId, date, time, pax, type, status);
                        }
                    }
                    else
                    {
                        dataReserve.Rows.Clear(); // Clear any existing rows in the DataGridView
                        dataReserve.Rows.Add("No reservations found.");
                    }
                }
                con.Close();
            }
        }

        public void viewProfile()
        {
            string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = this.CustomerID;
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    this.name = rd.GetString(2);
                    this.email = rd.GetString(3);
                    this.phonenum = rd.GetString(4);
                    this.address = rd.GetString(5);
                }
                con.Close();
            }
        }
        public void ViewLogin(User o1)
        {
            using (SqlCommand cmd = new SqlCommand("select Username, Password from Users where Username = @a", con))
            {
                cmd.Parameters.AddWithValue("@a", o1.username);
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    o1.username = rd.GetString(0);
                    o1.password = rd.GetString(1);
                }
                con.Close();
            }
        }



        public string UpdateProfile(string em, string num, string add)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET Email = @e, Phonenum = @p, Address = @add WHERE CustomerID = @CustomerID", con);
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", num);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@CustomerID", this.CustomerID); 

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successful.";
            }
            else
            {
                status = "Unable to update.";
            }

            con.Close();
            return status;
        }
    }
}
