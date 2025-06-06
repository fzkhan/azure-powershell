---
external help file: Az.Cdn-help.xml
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/Az.Cdn/new-azcdnorigingroupoverrideactionobject
schema: 2.0.0
---

# New-AzCdnOriginGroupOverrideActionObject

## SYNOPSIS
Create an in-memory object for OriginGroupOverrideAction.

## SYNTAX

```
New-AzCdnOriginGroupOverrideActionObject -ParameterTypeName <String> [-OriginGroupId <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for OriginGroupOverrideAction.

## EXAMPLES

### Example 1: Create an in-memory object for AzureCDN OriginGroupOverrideAction
```powershell
New-AzCdnOriginGroupOverrideActionObject -Name OriginGroupOverride -OriginGroupId 001
```

```output
Name
----
OriginGroupOverride
```

Create an in-memory object for AzureCDN OriginGroupOverrideAction

## PARAMETERS

### -OriginGroupId
Resource ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterTypeName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Name

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.OriginGroupOverrideAction

## NOTES

## RELATED LINKS
