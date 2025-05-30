<!-- region Generated -->
# Az.MobileNetwork
This directory contains the PowerShell module for the MobileNetwork service.

---
## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.7.5 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.MobileNetwork`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
commit: 933dbc070dda85e2d115dc42893f07b2ed5b74f6
require:
  - $(this-folder)/../../readme.azure.noprofile.md
input-file:
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/attachedDataNetwork.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/common.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/dataNetwork.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/mobileNetwork.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/operation.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/packetCoreControlPlane.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/packetCoreDataPlane.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/service.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/sim.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/simGroup.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/simPolicy.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/site.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/slice.json
  - $(repo)/specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2022-11-01/ts29571.json

module-version: 0.1.0
title: MobileNetwork
subject-prefix: $(service-name)

directive:
  - where:
      verb: (.*)
    set:
      breaking-change:
        deprecated-by-version: 0.5.0
        deprecated-by-azversion: 14.5.0
        change-effective-date: 2025/09/30

  # Change interopSettings type from <IAny> to <HashTable>
  - from: swagger-document
    where: $.definitions.PacketCoreControlPlanePropertiesFormat.properties.interopSettings
    transform: >-
      return {
        "type": "object",
        "additionalProperties": true,
        "description": "Settings to allow interoperability with third party components e.g. RANs and UEs."
      }

  # Remove parameters from swagger file
  - from: swagger-document
    where: $.definitions
    transform: delete $.CoreNetworkTypeRm
  - from: swagger-document
    where: $.definitions
    transform: delete $.PduSessionTypeRm

  # Replace [`default`] with ['default']
  - from: swagger-document
    where: $
    transform: return $.replace(/\`default\`/g, "'default'")
  - from: swagger-document
    where: $
    transform: return $.replace(/\`requested\`/g, "'requested'")
  - from: swagger-document
    where: $
    transform: return $.replace(/\`service\`/g, "'service'")
  - from: swagger-document
    where: $
    transform: return $.replace(/\`any\`/g, "'any'")

  - where:
      variant: ^(Create|Update|Bulk|Collect)(?!.*?(Expanded|JsonFilePath|JsonString))
    remove: true

  - where:
      verb: Set
    remove: true

  - where:
      subject: ^AttachedDataNetworkTag$
    set:
      subject: AttachedDataNetwork
  - where:
      subject: ^DataNetworkTag$
    set:
      subject: DataNetwork
  - where:
      subject: ^PacketCoreControlPlaneTag$
    set:
      subject: PacketCoreControlPlane
  - where:
      subject: ^PacketCoreDataPlaneTag$
    set:
      subject: PacketCoreDataPlane
  - where:
      subject: ^ServiceTag$
    set:
      subject: Service
  - where:
      subject: ^SimGroupTag$
    set:
      subject: SimGroup
  - where:
      subject: ^SimPolicyTag$
    set:
      subject: SimPolicy
  - where:
      subject: ^SiteTag$
    set:
      subject: Site
  - where:
      subject: ^SlouseTag$
    set:
      subject: Slouse
  - where:
      subject: ^MobileNetworkTag$
    set:
      subject: MobileNetwork
  - where:
      subject: ^Slouse$
    set:
      subject: Slice

  - where:
      parameter-name: DefaultSlouseId
    set:
      parameter-name: DefaultSliceId
  
  # Due to business requirements, the update of some customized commands is using Get and PUT operation and they need to be replaced
  - remove-operation: AttachedDataNetworks_UpdateTags
  - remove-operation: DataNetworks_UpdateTags
  - remove-operation: PacketCoreControlPlanes_UpdateTags
  - remove-operation: PacketCoreDataPlanes_UpdateTags
  - remove-operation: Services_UpdateTags
  - remove-operation: SimGroups_UpdateTags
  - remove-operation: SimPolicies_UpdateTags
  - remove-operation: Slices_UpdateTags
  # parameter set ServicePrecedence, SnssaiSst to be required
  - where:
      verb: Update
      subject: ^Service$|^Slice$
    hide: true

  - where:
      verb: New
      subject: ^Site$
    hide: true

  - where:
      verb: Invoke
      subject: ^BulkSimDelete$
    set:
      verb: Remove

  - where:
      verb: Invoke
      subject: ^BulkSimUpload$
    set:
      verb: Update

  - where:
      verb: Invoke
      subject: ^BulkSimUploadEncrypted$
    set:
      verb: Update
  - where:
      verb: Invoke
      subject: ^BulkSimUploadEncrypted$
    remove: true

  - where:
      verb: Invoke
      subject: ^CollectPacketCoreControlPlaneDiagnosticPackage$
    set:
      verb: Trace
  - where:
      verb: Invoke
      subject: ^ReinstallPacketCoreControlPlane$
    set:
      verb: Deploy
  - where:
      verb: Invoke
      subject: ^RollbackPacketCoreControlPlane$
    set:
      verb: Deploy
  # - where:
  #     subject: 
  #     parameter-name: PacketCoreDataPlaneName PacketCoreControlPlaneName ServiceName
  #   set:
  #     parameter-name: Name
  #     alias: PacketCoreDataPlaneName

  # Some of the parameters are of type Object and need to be expanded into a command for the convenience of the user
  # The following are commented out and their generated cmdlets may be renamed and custom logic
  # Do not delete this code
  - model-cmdlet:
  #     - model-name: SliceConfiguration  # SlouseId -> SliceId
      - model-name: DataNetworkConfiguration
      - model-name: ServiceResourceId
      - model-name: SiteResourceId
  #     - model-name: SimStaticIPProperties # SlouseId -> SliceId
      - model-name: PccRuleConfiguration
      - model-name: ServiceDataFlowTemplate

  - where:
      model-name: MobileNetwork
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - PublicLandMobileNetworkIdentifierMcc
          - PublicLandMobileNetworkIdentifierMnc
  - where:
      model-name: Site
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: Slice
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
          - SnssaiSst
          - SnssaiSd
  - where:
      model-name: Service
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
          - Precedence
          - MaximumBitRateDownlink
          - MaximumBitRateUplink
          - QoPolicyAllocationAndRetentionPriorityLevel
          - QoPolicyFiveQi
  - where:
      model-name: DataNetwork
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: SimPolicy
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
          - RegistrationTimer
          - UeAmbrDownlink
          - UeAmbrUplink
  - where:
      model-name: SimGroup
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: PacketCoreControlPlane
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: PacketCoreDataPlane
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: AttachedDataNetwork
    set:
      format-table:
        properties:
          - Location
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: Sim
    set:
      format-table:
        properties:
          - Name
          - ResourceGroupName
          - ProvisioningState
  - where:
      model-name: PacketCoreControlPlaneVersion
    set:
      format-table:
        properties:
          - Name

  - from: RemoveAzMobileNetworkSite_Delete.cs
    where: $
    transform: $ = $.replace('Call remote \'SitesDelete\' operation', '{this.Name} and all dependent resources');
```
