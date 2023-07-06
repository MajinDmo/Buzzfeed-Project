namespace BuzzfeedProject2;
using System.Data.SqlClient;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //this is to test if our push/pull works
            //Step 1: connection to the database
            SqlConnection connection = new
                SqlConnection(@"Data Source=minecraft.lfgpgh.com;Initial Catalog=Buzzfeed2;User ID=academy_student;Password=baseball");
            SqlCommand command = new SqlCommand();

        connection.Open();

        //Step 2: Show the user a list of available quizzes they can take(ask for which quiz they want to take)
            string b = "SELECT * FROM Quizzes;";
        command = new
            SqlCommand(b, connection);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["QuizTitle"]);
            //unable to display server's database in our server explorer; currently running dbeaver instead, since that gives us access to all pertinent information
        }



    }
}
