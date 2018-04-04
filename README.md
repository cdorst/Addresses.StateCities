# Addresses.StateCities

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-statecities)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.StateCities)

## Description

Contains US State-City pair component of addresses

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Code.Entities.Metapackages.Annotations](https://github.com/CDorst/DevOps.Code.Entities.Metapackages.Annotations) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-metapackages-annotations.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-metapackages-annotations) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Metapackages.Annotations.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Metapackages.Annotations)
[CDorst.DevOps.Code.Entities.Interfaces.StaticEntity](https://github.com/CDorst/DevOps.Code.Entities.Interfaces.StaticEntity) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-interfaces-staticentity.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-interfaces-staticentity) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.Interfaces.StaticEntity.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.Interfaces.StaticEntity)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Addresses.StateCities.DatabaseContext](https://github.com/CDorst/Addresses.StateCities.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecities-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCities.DatabaseContext)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.StateCities](https://www.nuget.org/packages/CDorst.Addresses.StateCities)

## Version

1.0.4

## Metaproject

Addresses.StateCities is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

