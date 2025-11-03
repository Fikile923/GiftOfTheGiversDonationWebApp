# GiftOfTheGiversDonationWebApp
# GOG Relief — Gift of the Givers Donation Web App

## Run locally
1. Clone repo
2. Set connection string in GOGRelief.Web/appsettings.json (DefaultConnection)
3. Run migrations:
   dotnet ef database update --project GOGRelief.Data --startup-project GOGRelief.Web
4. Run:
   cd GOGRelief.Web
   dotnet run

## Tests
dotnet test

## Deploy
- Push to Azure Repos/GitHub
- Configure Azure Pipeline (azure-pipelines.yml)
- Configure Azure App Service and connection strings
