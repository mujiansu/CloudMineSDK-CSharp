## Starting a New Project

### Xamarin or Visual Studio

(This assumes you already have cloned the SDK from the CloudMine repository.)

1. Rick click on packages in the project folder feom within the solution explorer
2. Click 'Add Packages'
3. Search for CloudMine in the search helper and click 'Add Package'. Also add the Json.Net package for defining your serializable classes.

CloudMine's .NET SDK begins with configuring your application object which holds the application ID and the API key needed by the subsequent services to make REST calls to the CloudMine platform. 

4. Configure application ID and API key variables

```csharp
// Find this in your developer console
private const string appID = "de45fca...";
// Find this in your developer console
private const string apiKey = "856d34a...";
```

5. Instantiate a CMApplication object where needed

```csharp
// This will initialize your credentials
CMApplication app = new CMApplication (appID, apiKey);
```

6. Configure the REST wrapper which translates service calls to the proper CloudMine format. 

```csharp
// This will initialize your REST wrappers
IRestWrapper api = new PCLRestWrapper ();
```

7. Leverage any of the services for CloudMine operations and enjoy developing without worrying about the backend!

```csharp
IAppObjectService appService = new CMAppObjectService (app, api);
IUserService userService = new CMUserService (app, api);
IPushNotificationService pushService = new CMPushNotificationService (app, api);
IAccessListService aclService = new CMAccessListService (app, api);
```

Intellisense and MonoDoc are enabled for documentation of individual service methods as well as examples linked further in this documentation.


## Additional Resources

### Source Code
* [Github](https://github.com/cloudmine/cloudmine-csharp)

### Sample Apps

If you are familiar with the Xamarin Tasky tutorial apps then check out the CloudMine SDK sample apps in the repository. We have replaced the local database layer with a service that directly works with the CloudMine SDK as a reference for working with CloudMine.

* [Github](https://github.com/cloudmine/cloudmine-csharp/tree/master/samples)

When working with the sample apps checkout the `TodoService` in the Tasky.Core project within the solution. There you will find the proper place to put application ID and API key values.

### Documentation

Beyond the links provided below, check out the Gihub repository for the SDK and looks at the NUnit integration tests. They provide many examples of how to leverage SDK and CloudMine features.

* [Tutorials](https://cloudmine.io/docs/#/code_examples)
* [Full API documentation](https://cloudmine.io/docs/)
* [CloudMine Dashboard](https://compass.cloudmine.io/)

### Contact
* Sales: [sales@cloudmine.me](mailto:sales@cloudmine.me)
* Engineering support: [support@cloudmineinc.com](support@cloudmineinc.com)
* Twitter: [@CloudMine](http://twitter.com/@CloudMine)
