using System;

  class Program
  {
    static void Main(string[] args)
    {
      // Step 1: Basic Output

      Console.WriteLine("Alexa Cacchiola");
      Console.WriteLine("IT-1050 - lab 1");

      /*
      // step 2: Use Comments

      Name: Alexa Cacchiola
      Title: IT-1050 - Lab 1
      */

      // Step 3: Declare and Use Variables

      int favoriteNumber = 58;
      string favoriteLanguage = "JavaScript";
      double programsWritten = 3;
      bool hasProgrammingExperience = true;

      Console.WriteLine("58: " + favoriteNumber);
      Console.WriteLine("JavaScript: " + favoriteLanguage);
      Console.WriteLine("3: " + programsWritten);
      Console.WriteLine("true: " + hasProgrammingExperience);

      // Step 5: Use Constants

      const string schoolName = "Cuyahoga Community College";
      Console.WriteLine("Cuyahoga Community College: " + schoolName);
    }
  }