
Copy-Item "C:\inetpub\wwwroot\publish\wwwroot\web.config" -Destination "C:\inetpub\wwwroot\publish" -force

Import-Module -Name ServerManager
$appPool = "RingNodeCalculator"

Write-Host "Starting $appPool"
Start-WebAppPool -Name $appPool

Write-Host "Resetting IIS"
& iisreset /start
