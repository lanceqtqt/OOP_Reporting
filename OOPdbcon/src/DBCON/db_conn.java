package DBCON;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class db_conn {

    static Connection _connection;
    static String Driver = "com.mysql.cj.jdbc.Driver";
    static String URL = "jdbc:mysql://localhost:3306/OOP_db";
    static String uname = "root";
    static String pass = "";

    // Method to get the connection, establishing it if not already connected
    public static Connection getConnection() throws Exception {
        if (_connection == null || _connection.isClosed()) {
            Class.forName(Driver);
            _connection = DriverManager.getConnection(URL, uname, pass);
            System.out.println("Connection established successfully.");
        }
        return _connection;
    }

    // Method to display records
    public static void DisplayRecords() {
        Statement stmt = null;
        ResultSet rs = null;

        try {
            // Ensure connection is established
            Connection conn = getConnection();

            // Create a statement and execute the query
            stmt = conn.createStatement();
            String query = "SELECT * FROM students_info";  // Ensure 'student_info' exists and has a 'firstname' column
            rs = stmt.executeQuery(query);

            // Print each firstname from the result set
            while (rs.next()) {
            	int id = rs.getInt("id");
            	System.out.println("ID: " +id);
                String firstname = rs.getString("firstname");
                System.out.println("Firstname: " + firstname);
                String middlename = rs.getString("middlename");
                System.out.println("Middlename: " + middlename);
                System.out.println("----------------------");
            }

        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            // Clean up resources
            try {
                if (rs != null) rs.close();
                if (stmt != null) stmt.close();
                if (_connection != null) _connection.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    public static void main(String[] args) {
        DisplayRecords();
    }
}
