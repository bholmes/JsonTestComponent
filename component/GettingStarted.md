IPAddress
------

To fetch the user's IP address  call ```Client.FetchIp.```

```csharp
var ipAddress = await JsonTest.Client.FetchIp ();
```

Date & Time
------

To fetch the date & time call ```Client.FetchDateTime.```  Passing true will convert the ```DateTime``` structure to local time.

```csharp
var result = await JsonTest.Client.FetchDateTime (true);
```
