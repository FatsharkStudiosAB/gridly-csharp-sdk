# Com.Gridly - the C# library for the Gridly API

Gridly API documentation

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3.31.0
- SDK version: 1.2.8
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.Gridly.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BranchApi(Configuration.Default);
            var createBranch = new CreateBranch(); // CreateBranch | 
            var gridId = "gridId_example";  // string | gridId (optional) 
            var branchId = "branchId_example";  // string | branchId (optional) 

            try
            {
                // create
                Branch result = apiInstance.Create(createBranch, gridId, branchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Create: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.gridly.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BranchApi* | [**Create**](docs/BranchApi.md#create) | **POST** /v1/branches | create
*BranchApi* | [**Delete**](docs/BranchApi.md#delete) | **DELETE** /v1/branches/{branchId} | delete
*BranchApi* | [**Get**](docs/BranchApi.md#get) | **GET** /v1/branches/{branchId} | get
*BranchApi* | [**List**](docs/BranchApi.md#list) | **GET** /v1/branches | list
*BranchApi* | [**Merge**](docs/BranchApi.md#merge) | **POST** /v1/branches/{branchId}/merge | merge
*DatabaseApi* | [**Create**](docs/DatabaseApi.md#create) | **POST** /v1/databases | create
*DatabaseApi* | [**Delete**](docs/DatabaseApi.md#delete) | **DELETE** /v1/databases/{dbId} | delete
*DatabaseApi* | [**Duplicate**](docs/DatabaseApi.md#duplicate) | **POST** /v1/databases/{dbId}/duplicate | duplicate
*DatabaseApi* | [**Get**](docs/DatabaseApi.md#get) | **GET** /v1/databases/{dbId} | get
*DatabaseApi* | [**List**](docs/DatabaseApi.md#list) | **GET** /v1/databases | list
*DatabaseApi* | [**Update**](docs/DatabaseApi.md#update) | **PUT** /v1/databases/{dbId} | update
*GridApi* | [**Create**](docs/GridApi.md#create) | **POST** /v1/grids | create
*GridApi* | [**Delete**](docs/GridApi.md#delete) | **DELETE** /v1/grids/{gridId} | delete
*GridApi* | [**Get**](docs/GridApi.md#get) | **GET** /v1/grids/{gridId} | get
*GridApi* | [**List**](docs/GridApi.md#list) | **GET** /v1/grids | list
*GridApi* | [**ListTemplateGrids**](docs/GridApi.md#listtemplategrids) | **GET** /v1/template-grids | listTemplateGrids
*GridApi* | [**Update**](docs/GridApi.md#update) | **PATCH** /v1/grids/{gridId} | update
*ProjectApi* | [**Create**](docs/ProjectApi.md#create) | **POST** /v1/projects | create
*ProjectApi* | [**Delete**](docs/ProjectApi.md#delete) | **DELETE** /v1/projects/{projectId} | delete
*ProjectApi* | [**FindOne**](docs/ProjectApi.md#findone) | **GET** /v1/projects/{projectId} | findOne
*ProjectApi* | [**List**](docs/ProjectApi.md#list) | **GET** /v1/projects | list
*ProjectApi* | [**Update**](docs/ProjectApi.md#update) | **PUT** /v1/projects/{projectId} | update
*RecordApi* | [**Create**](docs/RecordApi.md#create) | **POST** /v1/views/{viewId}/records | create
*RecordApi* | [**Delete**](docs/RecordApi.md#delete) | **DELETE** /v1/views/{viewId}/records | delete
*RecordApi* | [**Fetch**](docs/RecordApi.md#fetch) | **GET** /v1/views/{viewId}/records | fetch
*RecordApi* | [**Update**](docs/RecordApi.md#update) | **PATCH** /v1/views/{viewId}/records | update
*RecordApi* | [**UpdateRecord**](docs/RecordApi.md#updaterecord) | **PATCH** /v1/views/{viewId}/records/{id} | updateRecord
*TaskApi* | [**Get**](docs/TaskApi.md#get) | **GET** /v1/tasks/{taskId} | get
*ViewApi* | [**Create**](docs/ViewApi.md#create) | **POST** /v1/views | create
*ViewApi* | [**Export**](docs/ViewApi.md#export) | **GET** /v1/views/{viewId}/export | export
*ViewApi* | [**Get**](docs/ViewApi.md#get) | **GET** /v1/views/{viewId} | get
*ViewApi* | [**ImportView**](docs/ViewApi.md#importview) | **POST** /v1/views/{viewId}/import | importView
*ViewApi* | [**List**](docs/ViewApi.md#list) | **GET** /v1/views | list
*ViewApi* | [**Merge**](docs/ViewApi.md#merge) | **POST** /v1/views/{viewId}/merge | merge
*ViewColumnApi* | [**Add**](docs/ViewColumnApi.md#add) | **POST** /v1/views/{viewId}/columns/{columnId}/add | add
*ViewColumnApi* | [**Create**](docs/ViewColumnApi.md#create) | **POST** /v1/views/{viewId}/columns | create
*ViewColumnApi* | [**Delete**](docs/ViewColumnApi.md#delete) | **DELETE** /v1/views/{viewId}/columns/{columnId} | delete
*ViewColumnApi* | [**Get**](docs/ViewColumnApi.md#get) | **GET** /v1/views/{viewId}/columns/{columnId} | get
*ViewColumnApi* | [**Remove**](docs/ViewColumnApi.md#remove) | **POST** /v1/views/{viewId}/columns/{columnId}/remove | remove
*ViewColumnApi* | [**Update**](docs/ViewColumnApi.md#update) | **PATCH** /v1/views/{viewId}/columns/{columnId} | update
*ViewDependencyApi* | [**Create**](docs/ViewDependencyApi.md#create) | **POST** /v1/views/{viewId}/dependencies | create
*ViewDependencyApi* | [**Delete**](docs/ViewDependencyApi.md#delete) | **DELETE** /v1/views/{viewId}/dependencies | delete
*ViewDependencyApi* | [**DeleteById**](docs/ViewDependencyApi.md#deletebyid) | **DELETE** /v1/views/{viewId}/dependencies/{dependencyId} | deleteById
*ViewDependencyApi* | [**Get**](docs/ViewDependencyApi.md#get) | **GET** /v1/views/{viewId}/dependencies/{dependencyId} | get
*ViewDependencyApi* | [**List**](docs/ViewDependencyApi.md#list) | **GET** /v1/views/{viewId}/dependencies | list
*ViewDependencyApi* | [**Update**](docs/ViewDependencyApi.md#update) | **PUT** /v1/views/{viewId}/dependencies/{dependencyId} | update
*ViewFileApi* | [**Delete**](docs/ViewFileApi.md#delete) | **DELETE** /v1/views/{viewId}/files | delete
*ViewFileApi* | [**Download**](docs/ViewFileApi.md#download) | **GET** /v1/views/{viewId}/files/{fileId} | download
*ViewFileApi* | [**Upload**](docs/ViewFileApi.md#upload) | **POST** /v1/views/{viewId}/files | upload
*ViewFileApi* | [**UploadZip**](docs/ViewFileApi.md#uploadzip) | **POST** /v1/views/{viewId}/files/zip | uploadZip


## Documentation for Models

 - [Model.AddViewColumn](docs/AddViewColumn.md)
 - [Model.Branch](docs/Branch.md)
 - [Model.Cell](docs/Cell.md)
 - [Model.ColumnReference](docs/ColumnReference.md)
 - [Model.CreateBranch](docs/CreateBranch.md)
 - [Model.CreateColumn](docs/CreateColumn.md)
 - [Model.CreateDatabase](docs/CreateDatabase.md)
 - [Model.CreateDependency](docs/CreateDependency.md)
 - [Model.CreateGrid](docs/CreateGrid.md)
 - [Model.CreateProject](docs/CreateProject.md)
 - [Model.CreateView](docs/CreateView.md)
 - [Model.Database](docs/Database.md)
 - [Model.DeleteDependency](docs/DeleteDependency.md)
 - [Model.DeleteFile](docs/DeleteFile.md)
 - [Model.DeleteRecord](docs/DeleteRecord.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.ExportFileHeader](docs/ExportFileHeader.md)
 - [Model.FetchFileOption](docs/FetchFileOption.md)
 - [Model.Grid](docs/Grid.md)
 - [Model.Group](docs/Group.md)
 - [Model.NumberFormat](docs/NumberFormat.md)
 - [Model.Privilege](docs/Privilege.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectDetail](docs/ProjectDetail.md)
 - [Model.Record](docs/Record.md)
 - [Model.RecordIdentifierWrapper](docs/RecordIdentifierWrapper.md)
 - [Model.Reference](docs/Reference.md)
 - [Model.ReferencedColumn](docs/ReferencedColumn.md)
 - [Model.ReferencedGrid](docs/ReferencedGrid.md)
 - [Model.Role](docs/Role.md)
 - [Model.SetCell](docs/SetCell.md)
 - [Model.SetRecord](docs/SetRecord.md)
 - [Model.Task](docs/Task.md)
 - [Model.UpdateColumn](docs/UpdateColumn.md)
 - [Model.UpdateDatabase](docs/UpdateDatabase.md)
 - [Model.UpdateDependency](docs/UpdateDependency.md)
 - [Model.UpdateGrid](docs/UpdateGrid.md)
 - [Model.UpdateProject](docs/UpdateProject.md)
 - [Model.UploadZipRequest](docs/UploadZipRequest.md)
 - [Model.UploadedFile](docs/UploadedFile.md)
 - [Model.View](docs/View.md)
 - [Model.ViewColumn](docs/ViewColumn.md)


## Documentation for Authorization


### ApiKey

- **Type**: API key

- **API key parameter name**: Authorization
- **Location**: HTTP header

