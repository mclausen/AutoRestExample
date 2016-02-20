$swaggerEndpoint = "http://localhost:54403/swagger/docs/v1"
$outputDirectory = ".\server\proxies"
$autoRestRelativePath = ".\server\packages\autorest.0.14.0\tools\AutoRest.exe"
& $autoRestRelativePath -Input $swaggerEndpoint -Namespace AutoRestTest -OutputDirectory $outputDirectory -CodeGenerator CSharp