using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using MathApp.Models;
using Firebase.Auth;
namespace MathApp.Controllers;

public class AuthController : Controller
{
    FirebaseAuthProvider auth;

    public AuthController()
    {
        auth = new FirebaseAuthProvider(new FirebaseConfig(Environment.GetEnvironmentVariable("FirebaseMathApp")));
    }
}



