Old School Runescape Client Library.

This library provides the boiler plate clients to obtain data from the OSRS Apis.

The best way to integrate this library is to inject your desired client interfaces into a class of your choosing.
From here, call the ConfigureOSServices() function from your Startup.cs ConfigureServices() function (services.ConfigureOSServices())
and this will prepare the DI for the library.