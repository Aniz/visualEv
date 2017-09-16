#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Ufba")]
[assembly: AssemblyProduct(@"Ev")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Ufba.Ev.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100AD00186ADC4C4D38E64B7D86AAF88858A0BCE624C2FDAAECD295AD62D092DD6E8207A1ED631C4633BA8A5A2B428B3A77012D8A4E6F232F65D2029E9E4CDC9E226CA4885CB73DF6026939FB049EA23A56AA62575FDAFBF0124F22B901CA6C86100CC9A6985FDA7A184586E7D3B7DBE5A077B12F7F4177165F5AA0893ADFD26FB3")]