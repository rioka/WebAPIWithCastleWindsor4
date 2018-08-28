# WebAPIWithCastleWindsor4
Sample OWIN WebAPI project using Castle Windsor 4.x

## Create an OWIN WebAPI project from scratch
* Create an empty project, no references

## Add references
* Install required packages  
  ```
  install-package Microsoft.AspNet.WebApi.Core
  install-package Microsoft.Owin.Host.SystemWeb
  install-package Microsoft.Owin.Security.OAuth
  install-package Microsoft.AspNet.WebApi.Owin
  ```
## Add files and folders
* Add the following folders
  * `App_Start`  
  * `Controllers`
* Add the following files
  * `.\Startup.cs`
  * `.\App_Start\Startup.Auth.cs`
  * `.\App_Start\WebApiConfig.cs`

## Add code
* Create a `Controllers` folder
* Create file `.\Controllers\ValuesController.cs`
* Add code to
  * `.\App_Start\WebApiConfig.cs`
  * `Startup.cs`

Now you have a working OWIN Web API application

## Add a dependency 
* Add a `Services` folder
* Add `.\Services\IValueProvider.cs`
* Add `.\Services\ValueProvider.cs`
* Add `IValueProvider` as a constructor dependency to `ValuesController`

Site will stop working

