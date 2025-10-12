# Falcon Pi Player API Client

Endpoints are group by client interfaces based on their route. This version of this client has been 
test with Falcon Pi Player version 7.0 API. Future version may have additional endpoints that have 
changed and have not been tested with this version of the library.


## Example Usage

To use the API Clients defined in this library, add the below code to the Program.cs 
file of your application.

### Program.cs


```cs
builder.Services.AddFalconPiPlayerApiClientServices();
```

### Service or Controller Class

in your service or controller class, use the example code below to add the specific FPP Client that you 
need. Client that you need is based on the API route.

```cs
public class FppService(IFppdClient fppdClient)
{
    _fppdClient = fppdClient;
}
```

Other available interfaces include 

* ICommandClient
* IFppdClient
* IMediaClient
* IPlaylistClient
* IScriptsClient
* ISystemClient



## Issues and Feature Requests

Any issues, bugs, or feature requests for this library, should be submitted to its Github repository.
When submitting the request, be sure to use the appropriate template. Requests that are not submitted 
using the appropriate template, may be ignored or rejected.

### Repository URL

[https://github.com/almostengr/falcon-pi-player-apiclient](https://github.com/almostengr/falcon-pi-player-apiclient)

