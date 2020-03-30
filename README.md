# IdentityServer4.Study
 Identity Server 4 Sample

### The first picture
We have an IdentityServer, Client, Api, Client.
The client calls IdentityServer for getting token then the Client use this token to call API.
I use a reference token type in these projects.
When using reference tokens - IdentityServer will store the contents of the token in a data store and will only issue a unique identifier for this token back to the client. The API receiving this reference must then open a back-channel communication to IdentityServer to validate the token.
![alt text](https://identityserver4.readthedocs.io/en/3.1.0/_images/reference_tokens.png)
See [here](https://identityserver4.readthedocs.io/en/latest/) for more information about IdentityServer4
### Introduction
We have 3 projects in this repository
##### IdentityServer: [\Server\IdentityServer.sln](https://github.com/nkmnhan/IdentityServer4.Study/tree/master/Server)
This is an identity server base on IdentityServer4 and uses SQL Server to store configuration and identity users
##### Client: [\Client\Client.sln](https://github.com/nkmnhan/IdentityServer4.Study/tree/master/Client)
This is an MVC project play a role as a client
##### Api: [\Api\Api.sln](https://github.com/nkmnhan/IdentityServer4.Study/tree/master/Api)
This is an API project provides API for client

### Before run
##### Prerequisite:
- You must have SQL SERVER installed on your computer.

Check connection to SQL SERVER in `appsetting.json` IdentityServer project:
```
"ConnectionStrings": {
    "IdentityUserConnection": "Data Source=.;database=IdentityUsers;trusted_connection=yes;",
    "IdentityConfigConnection": "Data Source=.;database=IdentityConfig;trusted_connection=yes;"
  }
```
