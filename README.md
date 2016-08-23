The auto generated db file will be under C:\Users\userName.

You can change the connectionString in App.config to use another db:

  <connectionStrings>
    <add name="SchoolContext" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|EFConsole1.mdf;Initial Catalog=EFConsole1;Integrated Security=SSPI;" providerName="System.Data.SqlClient"/>
  </connectionStrings>
