
JSONTEST_VERSION=1.0

all : jsontest-$(JSONTEST_VERSION).xam

source/samples/JsonTestSample/packages/Newtonsoft.Json.6.0.5 :
	nuget restore source/samples/JsonTestSample/JsonTestSample-Classic.sln 

tools/xamarin-component.exe :
	mkdir -p tools
	curl -L https://components.xamarin.com/submit/xpkg -o tools/xpkg.zip
	unzip tools/xpkg.zip -d tools/

jsontest-1.0.xam : source/samples/JsonTestSample/packages/Newtonsoft.Json.6.0.5 tools/xamarin-component.exe
	#needed to stop the recursion
	touch jsontest-$(JSONTEST_VERSION).xam
	mono tools/xamarin-component.exe package

clean : 
	rm -rf source/samples/JsonTestSample/packages/Newtonsoft.Json.6.0.5 tools jsontest-$(JSONTEST_VERSION).xam
	find . -name bin | xargs rm -rf
	find . -name obj | xargs rm -rf
