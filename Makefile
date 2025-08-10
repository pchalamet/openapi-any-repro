
build:
	dotnet build

gen: build
	dotnet tool restore
	dotnet tool run openapigen -- Api.config.json Api/Api.json generated
