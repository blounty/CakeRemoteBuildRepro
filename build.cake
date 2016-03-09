#addin "Cake.FileHelpers"
#addin "Cake.Xamarin"

var target = Argument("target", "Default");



Task("Default").Does(() => {
    NuGetRestore ("./CakeBuild.sln");
    
	DotNetBuild ("./CakeBuild/CakeBuild.csproj", c => 
    {
        c.Configuration = "Debug";
        c.WithProperty("ServerAddress", "192.168.229.128");
        c.WithProperty("Platform", "iPhoneSimulator");
        c.WithProperty("ServerUser", "Blounty");
        c.WithProperty("OutputPath", "./CakeBuild/bin/iPhoneSimulator/Debug");
    });
});

RunTarget (target);