#Json Test Component

Although this may be an interesting Component to some, this repository is actually a sample of how to add NuGet dependencies to a Xamarin Component.   

On to the real content...

#Xamarin Components with Dependencies


###Background

If you have submitted a Xamarin Component you may have wondered what to do when your library requires another library that you did not create.  For example you are developing a client API to consume a web api and require a JSON parser and you want to use [Json.NET.][1]  Most have simply added the additional dll to their component package inside their lib/{platform} directory.

This simple solution works well for simple Xamarin projects.  However you do not have to add many components to your project to realize the problem.  Your project will contain multiple copies of a dll in the references section.  Even worse you may find multiple versions in your project and it will no longer build.


###The Solution?  NuGet Dependencies 

The **Xamarin Studio 5.5** release has added support for NuGet Dependencies in Xamarin Components.  Now when you add a component to your project **Xamarin Studio** will scan the component manifest file for the new package element and automatically add any found NuGet packages to your project.

### Adding NuGet Dependencies to Your Components

A new package item has been added to the input yaml file.  Simply declare the platform that requires the dependency and list the NuGet id and version for each package your component requires.

	packages:
	  ios:
	    - Newtonsoft.Json, Version=6.0.5
	  android:
	    - Newtonsoft.Json, Version=6.0.5
	    
See the [example][3] in this repository. 









[1]:http://james.newtonking.com/json
[2]:https://components.xamarin.com/submit/xpkg
[3]:https://github.com/bholmes/JsonTestComponent/blob/223d3b8bed3934ea59f90db689d6b321244d6822/component.yaml#L9-L11
