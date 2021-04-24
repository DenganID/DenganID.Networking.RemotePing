# Remote Ping
## Synopsis
RemotePing (netstandard2.0) is C# library for pinging host.

## Code Example

### Console App
```
using System;
using DenganID.Networking.RemotePing;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "8.8.8.8";
            var ping = new Ping();
            var isAlive = ping.IsAlive(host);
            Console.WriteLine(host+ " alive: " + isAlive);
        }
    }
}
```

## Installation
### Package Manager
```
Install-Package DenganID.Networking.RemotePing -Version 1.0.1
```

### Dotnet CLI
```
dotnet add package DenganID.Networking.RemotePing
```

### PackageReference
```
<PackageReference Include="DenganID.Networking.RemotePing" Version="1.0.1" />
```
## Contributors
[List of contribution](https://github.com/DenganID/DenganID.Networking.RemotePing/graphs/contributors)

You can always contribute to this package and create pull requests. Just give me a note

## License

This package is released under the MIT License (MIT). Please read [LICENSE.md](https://github.com/DenganID/DenganID.Networking.RemotePing/blob/master/LICENSE.md)

