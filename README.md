# AuthenticatedApp

A sample ASP.NET 6 Wep API and Blazor Solution for Azure B2C Authentication.

The sample consists of 3 parts:
* A simple ASP.NET 6 API with a protected controller returning sample data.
* A simple ASP.NET Blazor Application with a protected page, which connects to the protected API.
* A simple model which is shared between the two solutions. 


A prerequisite is to have an Azure B2C tenant already setup for the application to connect to. You will then need to add the following properties into the appsettings.json files (or however you chose to host the configuration for the app).


## AppSettings

**API Project**
Add the following settings into your configuration (appsettings.json or whatever you choose)

    "AzureAdB2C": {
        "Instance": "https://tenantid.b2clogin.com",
        "Domain": "tenantid.onmicrosoft.com",
        "TenantId": "11111111-1111-1111-1111-111111111111",
        "ClientId": "22222222-2222-2222-2222-222222222222",
        "SignedOutCallbackPath": "/signout/B2C_1_susi_reset_v2",
        "SignUpSignInPolicyId": "B2C_1_SignUp_SignIn_V2" 
      }

Refer to the Azure B2C documentation on how to setup and configure the Tenant. Important is that you create 'Sign up Sign In' policies, as these are referenced in the Well Known URLs for the OAuth.

**Blazor Project**

     "AzureAdB2C": {
        "Authority": "https://tenantid.b2clogin.com/tenantid.onmicrosoft.com/B2C_1_SignUp_SignIn_V2",
        "ClientId": "fb1dcc49-e0a3-48e4-93c5-4fc746c9b7bf",
        "ValidateAuthority": false,
        "ResponseType": "code id_token token"
      },
      "APIRoot": "https://localhost:7210/api/"
      "APIScope": "https://tenantid.onmicrosoft.com/22222222-2222-2222-2222-222222222222/scope_name"


**Notes**:

*Authority*:  The SignUpSignIn matches the ones specified in the API Project

*ClientId*: This doesn't have to match the one in the API. If not, you will need to create a Client for the Blazor App

*APIRoot*: This is the URL Blazor will connect to for the API. Depending on your environment, this should be changed. 

*APIScope*: This required for the Blazor App - See [Here](https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/additional-scenarios?view=aspnetcore-5.0#custom-authorizationmessagehandler-class-1) and [Here](https://docs.microsoft.com/en-us/azure/active-directory-b2c/access-tokens) for more information. 
