namespace PaketLoadScripts

#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.private.datacontractserialization/4.3.0/lib/netstandard1.3/System.Private.DataContractSerialization.dll" 
#r "/home/justin/.nuget/packages/remotion.linq/2.2.0/lib/netstandard1.0/Remotion.Linq.dll" 
#r "/home/justin/.nuget/packages/microsoft.dotnet.platformabstractions/2.1.0/lib/netstandard1.3/Microsoft.DotNet.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.logging/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Logging.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.registry/4.5.0/lib/netstandard1.3/Microsoft.Win32.Registry.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json.bson/1.0.1/lib/netstandard1.3/Newtonsoft.Json.Bson.dll" 
#r "/home/justin/.nuget/packages/system.security.accesscontrol/4.5.0/lib/netstandard1.3/System.Security.AccessControl.dll" 
#r "/home/justin/.nuget/packages/taskbuilder.fs/2.1.0/lib/netstandard1.6/TaskBuilder.fs.dll" 
#r "/home/justin/.nuget/packages/xunit.abstractions/2.0.3/lib/netstandard1.0/xunit.abstractions.dll" 
#r "/home/justin/.nuget/packages/xunit.assert/2.4.1/lib/netstandard1.1/xunit.assert.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.pkcs/4.5.1/lib/netstandard1.3/System.Security.Cryptography.Pkcs.dll" 
#r "/home/justin/.nuget/packages/system.security.principal.windows/4.5.1/lib/netstandard1.3/System.Security.Principal.Windows.dll" 
#r "/home/justin/.nuget/packages/fsharp.core/4.5.2/lib/netstandard1.6/FSharp.Core.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json/11.0.2/lib/netstandard1.3/Newtonsoft.Json.dll" 
#r "/home/justin/.nuget/packages/system.buffers/4.5.0/lib/netstandard1.1/System.Buffers.dll" 
#r "/home/justin/.nuget/packages/system.collections.immutable/1.5.0/lib/netstandard1.3/System.Collections.Immutable.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.diagnosticsource/4.5.1/lib/netstandard1.3/System.Diagnostics.DiagnosticSource.dll" 
#r "/home/justin/.nuget/packages/system.interactive.async/3.2.0/lib/netstandard1.3/System.Interactive.Async.dll" 
#r "/home/justin/.nuget/packages/system.memory/4.5.1/lib/netstandard1.1/System.Memory.dll" 
#r "/home/justin/.nuget/packages/system.runtime.compilerservices.unsafe/4.5.2/lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.openssl/4.5.0/lib/netstandard1.6/System.Security.Cryptography.OpenSsl.dll" 
#r "/home/justin/.nuget/packages/system.text.encodings.web/4.5.0/lib/netstandard1.0/System.Text.Encodings.Web.dll" 
#r "/home/justin/.nuget/packages/system.threading.channels/4.5.0/lib/netstandard1.3/System.Threading.Channels.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Tokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.CoreUtilities.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencymodel/2.1.0/lib/netstandard1.6/Microsoft.Extensions.DependencyModel.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.core/2.4.1/lib/netstandard1.1/xunit.core.dll" 
#r "/home/justin/.nuget/packages/system.io.pipelines/4.5.2/lib/netstandard1.3/System.IO.Pipelines.dll" 
#r "/home/justin/.nuget/packages/system.reflection.metadata/1.6.0/lib/netstandard1.1/System.Reflection.Metadata.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.jsonwebtokens/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.JsonWebTokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Protocols.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.xml/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/netstandard1.5/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.common/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.execution/2.4.1/lib/netstandard1.1/xunit.execution.dotnet.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.wsfederation/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Protocols.WsFederation.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens.saml/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Tokens.Saml.dll" 
#r "/home/justin/.nuget/packages/system.identitymodel.tokens.jwt/5.3.0/lib/netstandard1.4/System.IdentityModel.Tokens.Jwt.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.testhost/15.9.0/lib/netstandard1.5/Microsoft.VisualStudio.TestPlatform.Common.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.csharp/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.CSharp.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.openidconnect/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Protocols.OpenIdConnect.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.testhost/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.CommunicationUtilities.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.testhost/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.CrossPlatEngine.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.testhost/15.9.0/lib/netstandard1.5/testhost.dll" 