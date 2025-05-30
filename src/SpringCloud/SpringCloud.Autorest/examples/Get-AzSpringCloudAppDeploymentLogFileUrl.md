### Example 1: Get deployment log file URL
```powershell
Get-AzSpringCloudAppDeploymentLogFileUrl -ResourceGroupName SpringCloud-gp-junxi -ServiceName springcloud-01 -AppName tools -Name default
```

```output
url         :"https://xxxxxxxxxxxxxxxxxxxxxxxxxxx.blob.core.windows.net/*****/logs/?sv=2018-03-28&sr=b&sig=******%3D&se=2022-07-13T10%3A15%3A46Z&sp=r"
```

Get deployment log file URL.

### Example 2: Get deployment log file URL by pipeline
```powershell
Get-AzSpringCloudAppDeployment -ResourceGroupName SpringCloud-gp-junxi -ServiceName springcloud-01 -AppName tools -Name default | Get-AzSpringCloudAppDeploymentLogFileUrl
```

```output
url         :"https://xxxxxxxxxxxxxxxxxxxxxxxxxxx.blob.core.windows.net/*****/logs/?sv=2018-03-28&sr=b&sig=******%3D&se=2022-07-13T10%3A15%3A46Z&sp=r"
```

Get deployment log file URL by pipeline.