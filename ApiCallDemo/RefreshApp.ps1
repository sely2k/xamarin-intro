
iwr http://localhost:64477/swagger/v1/swagger.json -o testapi.yaml
autorest --namespace=ApiCallDemo.resclient --csharp  --input-file=testapi.yaml --output-folder=.\ApiCallDemo\ApiCallDemo\restclient\restapi