# GitHub Copilot Custom Instructions for Az-PowerShell

## Project Overview
Az-PowerShell is a set of cmdlets for managing Azure resources directly from PowerShell. It provides a comprehensive and consistent interface for interacting with Azure services, enabling automation and scripting of cloud operations.

The user will primarily work with the `Az.DataTransfer` module, which is used for managing data transfer pipelines and connections within Azure Data Transfer services.

## User's Role
The user is a developer working on the `Az.DataTransfer` module, focusing on enhancing functionality, fixing bugs, updating docs, and ensuring the module meets the needs of Azure users.

## Project Structure
- **src/DataTransfer**: Root directory for the DataTransfer module.
- **src/DataTransfer/DataTransfer.Autorest**: Contains the AutoRest-generated code for the `Az.DataTransfer` module.
- **src/DataTransfer/DataTransfer.Autorest/custom**: Contains custom PowerShell scripts that extend or modify the generated cmdlets.
- **src/DataTransfer/DataTransfer.Autorest/README.md**: Documentation for the `Az.DataTransfer` module, used by autorest to generate the module.

## API Specification
The API specification for the `Az.DataTransfer` module is defined here: https://github.com/Azure/azure-rest-api-specs/blob/main/specification/azuredatatransfer/resource-manager/Microsoft.AzureDataTransfer/stable/2025-05-21/azuredatatransfer.json 

## How to Run Autorest and test
To regenerate the `Az.DataTransfer` module using AutoRest, follow these steps:
1. Run autorest in the `src/DataTransfer/DataTransfer.Autorest` directory:
```bash
autorest
```

2. After running AutoRest, the module will be generated in the same directory.

3. Build the module using:
```powershell
pwsh .\build-module.ps1
```

4. Run the module using:
```powershell
pwsh .\run-module.ps1
```

5. Test the module using:
```powershell
pwsh .\test-module.ps1 -Live
``` 

In case of issues, run:
```powershell
autorest --reset
```

## Updating Docs
To update the documentation for the `Az.DataTransfer` module, follow these steps:

Update the docs by updating the examples in the `src/DataTransfer/DataTransfer.Autorest/examples` directory. Next time, the examples will be included in the generated module documentation.

Do NOT touch the `src/DataTransfer/DataTransfer/help` directory directly. The help files are generated from the examples and cmdlet definitions in the `src/DataTransfer/DataTransfer.Autorest/examples` directory.

Do NOT touch the `src/DataTransfer/DataTransfer.Autorest/docs` directory directly. The doc files are auto-generated.

## Testing
The tests reside in the `src/DataTransfer/DataTransfer.Autorest/tests` directory. To run the tests, use the following command:

```powershell
pwsh .\test-module.ps1 -Live
```

There are Record and Playback modes as well.

- While creating tests, use the test directory.
- Make sure tests are idempotent
- Cleanup any resources inside the test itself if possible
- Do not ever try to delete the pipeline, we do not have permissions
- Do not try to create Recording files, they are created in Record mode while running tests
- Check resources defined in `env.json` for naming conventions and use them in tests

## Other instructions
- Always check that we are using Microsoft.AzureDataTransfer as the resource provider (in comments, cmdlets, docs etc.). If not, print a warning message in the chat.
- Remove any references to ResourceGroups, Pipelines etc from the comments/Docs/code. Use generic terms like "ResourceGroup01", "Pipeline01" etc.
- Always add tests for `-AsJob`, `-NoWait` and similar parameters in the cmdlets.
- Make sure the test resources are cleaned up after the tests run.
- Make sure the resources in tests are created in a consistent manner, using the same naming conventions as defined in `env.json`.

# Cmdlet Best Practices

## Output Type

Specified by the `OutputType` attribute, this piece of metadata lets the user know what the type of the object returned by the cmdlet is (found in the **Outputs** section of a cmdlet's help content). The type specified here should always be a single element and not an enumeration of elements (_e.g._, `PSVirtualMachine` instead of `List<PSVirtualMachine>`).

### Valid Output Types

If the cmdlet returns an object, the type of the object returned must be defined; the output type for a cmdlet should _never_ be `object`, `PSObject`, `PSCustomObject` or the like. Returning these types of objects makes it difficult for the user to anticipate what properties will be found on the object returned from the cmdlet, as well as makes it impossible for the breaking change analyzer to detect if a breaking change was introduced to the cmdlet as the type is not defined.

In order to preserve proper piping scenarios, the output type for a cmdlet should _never_ be a `string`. If a cmdlet is expected to return a `string`, the suggestion is to introduce a new type that encapsulates the `string` information as a property and return that object. The PowerShell language revolves around objects and passing them around cmdlets; returning `string` objects can introduce inconsistencies in the piping experience for users.

### Returning Wrapped SDK Types

In most cases, cmdlets will be returning an object corresponding to a resource that a user is performing an action on. Rather than returning the .NET SDK type for that resource (exposing .NET SDK types in PowerShell cmdlets is _strongly_ discouraged), we suggest creating a new class that wraps this .NET SDK type, allowing for breaking changes in the underlying type while avoiding breaking changes in the PowerShell type.

For example, the `Get-AzVM` cmdlet uses the .NET SDK to retrieve objects of the `VirtualMachine` type, but a new class, `PSVirtualMachine`, was created to wrap the type from the .NET SDK, and is returned by the cmdlet. If, in the future, the `VirtualMachine` type in the .NET SDK has a property removed, that property can still be maintained in PowerShell by adding it to the `PSVirtualMachine` type and recreating the value, thus avoiding a breaking change in the corresponding cmdlet(s).

### Returning No Output

In the case where your cmdlet doesn't return any output (_e.g._, deleting, starting, stopping a resource), the cmdlet should implement the `-PassThru` parameter and the `OutputType` should be set to `bool`. The `-PassThru` parameter is a `SwitchParameter` set by the user to signal that they would like to receive output from a cmdlet which does not return anything. If the `-PassThru` parameter is provided, you should return the value `true` so the user is made aware that the operation was successful. If the operation was unsuccessful, then the cmdlet should throw an exception.

From the [_Strongly Encouraged Development Guidelines_](https://learn.microsoft.com/en-us/powershell/scripting/developer/cmdlet/strongly-encouraged-development-guidelines#support-the-passthru-parameter):

> _By default, many cmdlets that modify the system, such as the `Stop-Process` cmdlet, act as "sinks" for objects and do not return a result. These cmdlet should implement the `-PassThru` parameter to force the cmdlet to return an object._

The code below shows how this should look in a cmdlet:

```cs
[Cmdlet(...), OutputType(typeof(bool))]
public class MySampleCmdlet : MyBaseCmdlet
{
    // other parameters omitted

    [Parameter(Mandatory = false)]
    public SwitchParameter PassThru { get; set; }

    public override void ExecuteCmdlet()
    {
        // other code omitted

        if (this.PassThru.IsPresent)
        {
            WriteObject(true);
        }
    }
}
```

### Enumerate Collection When WriteObject()

When returning a collection of objects, the cmdlet should enumerate the collection. This ensures that the objects are written to the pipeline one at a time, which is the expected behavior for PowerShell cmdlets.

There are two ways to accomplish this: (a) call `WriteObject()` for each object in the collection, or (b) use `WriteObject()` with the `enumerateCollection` parameter set to `true`. The `enumerateCollection` parameter is a boolean that, when true, will enumerate the collection and write each object to the pipeline.

The code below shows how this should look in a cmdlet:

```cs
var resources = Client.ListResources();

// option a: call WriteObject() for each object in the collection
foreach (var resource in resources)
{
    WriteObject(resource);
}

// option b: use WriteObject() with the enumerateCollection parameter set to true
WriteObject(resources, true);
```

## Output Format

PowerShell supports several output formats, including `table`, `list`, and `wide`. The default output format for Azure PowerShell cmdlets is `table`, which is the most readable for displaying a list of resources. Here's an example:

```powershell
PS > Get-AzVM

ResourceGroupName    Name       Location          VmSize  OsType            NIC
-----------------    ----       --------          ------  ------            ---
TEST1               test1         eastus Standard_DS1_v2 Windows          test1
TEST1               test2         westus Standard_DS1_v2 Windows          test2
TEST1               test3         eastus Standard_DS1_v2 Windows          test3
TEST2               test4         westus Standard_DS1_v2 Windows          test4
TEST2               test5         eastus Standard_DS1_v2 Windows          test5
```

The idea about table format is for users to be able to quickly scan the output and find the information they are looking for. To achieve this, follow the golden rule of thumb: **show only the MVPs (most valuable properties)**.

It's obvious that important properties need to be displayed, but be careful not to overcrowd the output with too many properties. PowerShell console has a limited width, so if there are too many columns, the output may be truncated and lose the meaning of being quickly readable.

A practical way of designing the table format is:

1. List the properties from the most important to the least important.
2. Take the most important properties until (a) the width of the console is filled or (b) the rest of the properties are not important enough to be displayed.

## `ShouldProcess`

If a cmdlet makes any changes to an object on the server (_e.g._, create, delete, update, start, stop a resource), the cmdlet should implement `ShouldProcess`. This property adds the `-WhatIf` and `-Confirm` parameters to the cmdlet:

- `-WhatIf` is a `SwitchParameter` that, when provided by the user, doesn't execute the part of the cmdlet responsible for making the changes to the object, but rather displays a message alerting the user of the action that is to be performed on the object
- `-Confirm` is a `SwitchParameter` that, when provided by the user, prompts the user for confirmation that they want to continue with the execution of the cmdlet.

The code below shows how this should look in a cmdlet:

```cs
[Cmdlet(..., SupportsShouldProcess = true), OutputType(typeof(...))]
public class MySampleCmdlet : MyBaseCmdlet
{
    // parameters omitted

    public override void ExecuteCmdlet()
    {
        // other code omitted

        if (ShouldProcess(targetResource, actionMessage))
        {
            // make the change
        }
    }
}
```

More information about `ShouldProcess` can be found in the [_Should Process and Confirm Impact_](./should-process-confirm-impact.md) document.

### When to Add the Force Parameter

The `-Force` parameter is reserved for special scenarios where additional confirmation from the user is required. From the above document on [_Should Process and Confirm Impact_](./should-process-confirm-impact.md) document:

> _Some cmdlets require additional confirmation. For example, if a cmdlet would destroy existing resources in some circumstances, the cmdlet might detect that condition and prompt the user to verify before continuing. Overwriting an existing resource during resource creation, overwriting a file when downloading data, deleting a resource that is currently in use, or deleting a container that contains additional resources are all example of this pattern. To implement additional confirmation, and allow scripts to opt out of additional prompts, the above pattern is enhanced with calls to `ShouldContinue()` and the `-Force` parameter._

## `AsJob`

All long running operations must implement the `-AsJob` parameter, which will allow the user to create jobs in the background. For more information about PowerShell jobs and the `-AsJob` parameter, read [this doc](https://learn.microsoft.com/en-us/powershell/azure/using-psjobs).

To implement the `-AsJob` parameter, simply add the parameter to the end of the parameter list:

````cs
[Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
public SwitchParameter AsJob { get; set; }
````

Once you add the parameter, please manually test that the job is created and successfully completes when the parameter is specified.  Additionally, please ensure that the help files are updated with this parameter.

To ensure that `-AsJob` is not broken in future changes, please add a test for this parameter. To update tests to include this parameter, use the following pattern:

````powershell
$job = Get-AzSubscription -AsJob
$job | Wait-Job
$subscriptions = $job | Receive-Job
````

To set a custom job name, please use [`SetBackgroupJobDescription`](https://github.com/Azure/azure-powershell-common/blob/main/src/Common/AzurePSCmdlet.cs#L810). The default job description is: "Long Running Operation for '{cmdlet name}' on resource '{resource name}'"

## Required Parameter Sets

In most Azure PowerShell cmdlets, there is a bare minimum of three parameter sets that need to be implemented.

### Interactive Parameter Set

This parameter set should be implemented by _every_ cmdlet - in most cases, the user provides the name of the resource that they are acting upon (`-Name`) and the resource group in which they are acting in (`-ResourceGroupName`).

The interactive parameter set **will always be the default parameter set** for a cmdlet (specified by the `DefaultParameterSetName` property in the `Cmdlet` attribute). This means that when PowerShell is unable to determine which parameter set a user is in, it will default to the interactive parameter set and prompt the user to provide values for the missing mandatory parameters.

### ResourceId Parameter Set

This parameter set should be implemented by _every_ cmdlet - the user is able to provide a `-ResourceId` string or GUID from the Azure Portal, or from one of the generic resources cmdlets (more information about this scenario can be found in the [`piping-best-practices.md`](./piping-best-practices.md#using-the--resourceid-parameter) document), and act upon the given resource associated with the id. The typical `-Name` and `-ResourceGroupName` parameters are replaced by a single `-ResourceId` parameter of type string.

### InputObject Parameter Set

This parameter should be implemented by _most_ cmdlets - the user is able to take the object returned from the `Get`, `New`, or `Set` cmdlets (or other cmdlets that return the common resource) and provide it to the `-InputObject` parameter for a cmdlet that acts upon the same resource (more information about this scenario can be found in the [`piping-best-practices.md`](./piping-best-practices.md#using-the--inputobject-parameter) document). The typical `-Name` and `-ResourceGroupName` parameters are retrieved from the `-InputObject` that the user is passing through.

