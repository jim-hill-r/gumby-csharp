& 'C:\Program Files\Azure Cosmos DB Emulator\Microsoft.Azure.Cosmos.Emulator.exe' /Shutdown
& 'C:\Program Files\Azure Cosmos DB Emulator\Microsoft.Azure.Cosmos.Emulator.exe' /EnableGremlinEndpoint
& 'C:\Users\jimhi\AppData\Local\AzureFunctionsTools\Releases\2.42.0\cli\func.exe' start --script-root '../../Src/Gumby.Graph/bin/Debug/netcoreapp3.0'