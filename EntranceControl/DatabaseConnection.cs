using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EntranceControl
{
    class DatabaseConnection
    {
        public SqlConnection cnn;
        string connectionString, Output;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        public DatabaseConnection()
        {
            try {
                connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True;
                    AttachDbFilename = C:\Users\Alex\Documents\Visual Studio 2015\Projects\EntranceControl\EntranceControl\GateDB.mdf";
                cnn = new SqlConnection(connectionString);
                dataAdapter = new SqlDataAdapter();
                cnn.Open();
            } catch (Exception err) {
                MessageBox.Show("خطا در ارتباط با دیتابیس:\n" + err.ToString(), "خطا");
            }
        }

        ~DatabaseConnection()
        {
            try {
                cnn.Close();
            } catch (Exception err) {
                MessageBox.Show("خطا در بستن دیتابیس:\n" + err.ToString(), "خطا");
            }
        }

        public static byte[] Mat2Bytes(Mat mat)
        {
            byte[] bytes = new byte[mat.NumberOfChannels * mat.Cols * mat.Rows];

            for (int i = 0; i < mat.Rows; i++)
                for (int j = 0; j < mat.Cols; j++)
                    bytes[i] = 0;
            // --------------------------------------------------------- Convert Error
            
            return bytes;
        }

        public static Mat Bytes2Mat(byte[] bytes)
        {            
            Mat TempMat = new Mat();
            //TempMat.put(0,0,bytes);
            // --------------------------------------------------------- Convert Error
            return TempMat;
        }

        public void Select_Report() {
            command = new SqlCommand("SELECT LPNumber, Date, Time, Valid, OwnerID, LPImage, VehicleImage FROM Report LIMIT 10", cnn);
        }

        public void Insert_Owner(string NationalCode, string Name, string Surname, bool Gender, string Description, Mat OwnerImageMat)
        {
            byte[] OwnerImage = Mat2Bytes(OwnerImageMat);

            String query = "INSERT INTO Owner(NationalCode,Name,Surname,Gender,Description,OwnerImage)" +
                " VALUES (@NationalCode,@Name,@Surname,@Gender,@Description,@OwnerImage)";

            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                command.Parameters.AddWithValue("@NationalCode", NationalCode);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Surname", Surname);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@OwnerImage", OwnerImage);

                int result = command.ExecuteNonQuery();

                if (result < 0)
                    MessageBox.Show("Error Accured!");
                else
                    MessageBox.Show("Inserted Successfully!\nName: ");

            }
        }

        public void Insert_Report(string LPNumber, string OwnerID, bool Valid, string Date, string Time, Mat LPImageMat, Mat VehicleImageMat) {
            command = new SqlCommand("INSERT INTO Report (LPNumber, Date, Time, Valid, OwnerID, LPImage, VehicleImage) Values ", cnn);
            byte[] LPImage = Mat2Bytes(LPImageMat);
            byte[] VehicleImage = Mat2Bytes(VehicleImageMat);

            String query = "INSERT INTO Report(LPNumber, OwnerID, Valid, Date, Time, LPImageMat, VehicleImageMat)" +
                " VALUES (@LPNumber,@OwnerID,@Valid,@Date,@Time,@LPImage,@VehicleImage)";

            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                command.Parameters.AddWithValue("@LPNumber", LPNumber);
                command.Parameters.AddWithValue("@OwnerID", OwnerID);
                command.Parameters.AddWithValue("@Valid", Valid);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Time", Time);
                command.Parameters.AddWithValue("@LPImage", LPImage);
                command.Parameters.AddWithValue("@VehicleImage", VehicleImage);

                cnn.Open();
                int result = command.ExecuteNonQuery();

                if (result < 0)
                    MessageBox.Show("Error Accured!");
                else
                    MessageBox.Show("Inserted Successfully!\nName: ");

            }
        }

        public void Insert_ValidList(string LPNumber, string OwnerID, string VehicleType, string VehicleColor, Mat VehicleImageMat) {
            byte[] VehicleImage = Mat2Bytes(VehicleImageMat);

            String query = "INSERT INTO ValidList(LPNumber,OwnerID,VehicleType,VehicleColor,VehicleImage)" +
                " VALUES (@LPNumber,@OwnerID,@VehicleType,@VehicleColor,@VehicleImage)";

            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                command.Parameters.AddWithValue("@LPNumber", LPNumber);
                command.Parameters.AddWithValue("@OwnerID", OwnerID);
                command.Parameters.AddWithValue("@VehicleType", VehicleType);
                command.Parameters.AddWithValue("@VehicleColor", VehicleColor);
                command.Parameters.AddWithValue("@VehicleImage", VehicleImage);

                int result = command.ExecuteNonQuery();

                if (result < 0)
                    MessageBox.Show("Error Occured!");
                else
                    MessageBox.Show("Inserted Successfully!\nName: ");

            }
        }

        public void Delete_Owner(string NationalCode) {
            command = new SqlCommand("DELETE FROM ValidList WHERE LPNumber = " + NationalCode, cnn);
        }

        public void Delete_Report(string LPNumber) {
            command = new SqlCommand("DELETE FROM Report WHERE LPNumber = " + LPNumber, cnn);
        }

        public void Delete_ValidList(string LPNumber) {
            command = new SqlCommand("DELETE FROM ValidList WHERE LPNumber = " + LPNumber, cnn);
        }

        public void Update_Owner() {
            command = new SqlCommand("UPDATE Report SET ... WHERE LPNumber = ", cnn);
        }

        public void Update_Report() {
            command = new SqlCommand("UPDATE Report SET ... WHERE LPNumber = ", cnn);
        }

        public void Update_ValidList() {
            command = new SqlCommand("UPDATE ValidList SET ... WHERE LPNumber = ", cnn);
        }
    }
}
