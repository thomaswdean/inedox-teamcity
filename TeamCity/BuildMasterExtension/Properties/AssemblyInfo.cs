﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Inedo.BuildMaster.Extensibility;
using Inedo.Extensibility;

[assembly: AssemblyTitle("TeamCity")]
[assembly: AssemblyDescription("Contains actions to get artifacts and trigger builds in TeamCity.")]

[assembly: ComVisible(false)]
[assembly: AssemblyCompany("Inedo, LLC")]
[assembly: AssemblyProduct("BuildMaster")]
[assembly: AssemblyCopyright("Copyright © 2008 - 2016")]
[assembly: AssemblyVersion("0.0.0.0")]
[assembly: AssemblyFileVersion("0.0")]
[assembly: CLSCompliant(false)]
[assembly: RequiredBuildMasterVersion("5.0.0")]

[assembly: ScriptNamespace("TeamCity")]