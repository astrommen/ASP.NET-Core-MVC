# ASP.NET-Core-MVC
Following along the MS ASP.NET tutorial
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio-code

## To trust certificate in linux
   ## clear any existing https certs
   dotnet dev-certs https --clean

   ## generate a https cert
   dotnet dev-certs https -v

   ## go into directory housing the cert
   cd ~/.dotnet/corefx/cryptography/x509stores/my

   ## convert cert to pfx
   openssl pkcs12 -in CERTNAME.pfx -nokeys -out localhost.crt -nodes

   ## trust this cert
   nano localhost.crt
   sudo cp localhost.crt /usr/local/share/ca-certificates
   sudo update-ca-certificates

   Select Ctrl+F5 to run without the debugger.

   ## When creating the db context class, came across  "The type or namespace name '<DBCONTEXT>'  could not be found"
   first try restarting VSCode
   next try .NetCLI command "dotnet add package EntityFramework --version 4.2.0", apparently it misses the .dll install and reg in MvcMovie.csproj