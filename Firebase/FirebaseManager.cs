using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
public class FirebaseManager
{
    // Firebase database URL
    private const string FirebaseUrl = "https://class-connect-c22a8-default-rtdb.firebaseio.com/";

    // Firebase configuration
    public IFirebaseConfig config;
    public IFirebaseClient client;

    public FirebaseManager()
    {
        // Initialize Firebase configuration
        config = new FirebaseConfig
        {
            AuthSecret = "fS4oR0o8fvJT1flYE87YvxHN7JxUsSyRDgslNuNH",
            BasePath = FirebaseUrl
        };

        // Initialize Firebase client
        client = new FireSharp.FirebaseClient(config);
    }

    // Method to retrieve data from Firebase
    public async Task<List<ClassConnectUser>> RetrieveClassConnectUsers()
    {
        try
        {
            // Retrieve data from the "ClassConnectUsers" node
            FirebaseResponse response = await client.GetAsync("ClassConnectUsers");

            // Convert Firebase response to a list of ClassConnectUser objects
            List<ClassConnectUser> users = response.ResultAs<List<ClassConnectUser>>();

            return users;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error retrieving data from Firebase: " + ex.Message);
            return null;
        }
    }
    public void InsertUsersData()
    {

    }
}

// Define a class to represent ClassConnectUser data structure
public class ClassConnectUser
{
    public string Name { get; set; }
    public int Age { get; set; }
    // Add more properties as needed
}
