namespace PaketLoadScripts

#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.TestPlatform.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.net.http/4.3.4/lib/net46/System.Net.Http.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.xml/4.3.0/lib/net46/System.Runtime.Serialization.Xml.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.x509certificates/4.3.2/lib/net46/System.Security.Cryptography.X509Certificates.dll" 
#r "/home/justin/.nuget/packages/remotion.linq/2.2.0/lib/net45/Remotion.Linq.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.csp/4.3.0/lib/net46/System.Security.Cryptography.Csp.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xdocument/4.3.0/lib/net46/System.Xml.XPath.XDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xmldocument/4.3.0/lib/net46/System.Xml.XPath.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.algorithms/4.3.1/lib/net46/System.Security.Cryptography.Algorithms.dll" 
#r "/home/justin/.nuget/packages/system.xml.xmldocument/4.3.0/lib/net46/System.Xml.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath/4.3.0/lib/net46/System.Xml.XPath.dll" 
#r "/home/justin/.nuget/packages/system.collections.specialized/4.3.0/lib/net46/System.Collections.Specialized.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.textwritertracelistener/4.3.0/lib/net46/System.Diagnostics.TextWriterTraceListener.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.encoding/4.3.0/lib/net46/System.Security.Cryptography.Encoding.dll" 
#r "/home/justin/.nuget/packages/system.xml.readerwriter/4.3.1/lib/net46/System.Xml.ReaderWriter.dll" 
#r "/home/justin/.nuget/packages/utf8json/1.3.7/lib/net45/Utf8Json.dll" 
#r "/home/justin/.nuget/packages/microsoft.dotnet.platformabstractions/2.1.0/lib/net45/Microsoft.DotNet.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.collections.nongeneric/4.3.0/lib/net46/System.Collections.NonGeneric.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.fileversioninfo/4.3.0/lib/net46/System.Diagnostics.FileVersionInfo.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.process/4.3.0/lib/net46/System.Diagnostics.Process.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.tracesource/4.3.0/lib/net46/System.Diagnostics.TraceSource.dll" 
#r "/home/justin/.nuget/packages/system.globalization.extensions/4.3.0/lib/net46/System.Globalization.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.io.compression/4.3.0/lib/net46/System.IO.Compression.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.primitives/4.3.0/lib/net46/System.Runtime.Serialization.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.security.claims/4.3.0/lib/net46/System.Security.Claims.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.primitives/4.3.0/lib/net46/System.Security.Cryptography.Primitives.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.logging/5.3.0/lib/net451/Microsoft.IdentityModel.Logging.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.stacktrace/4.3.0/lib/net46/System.Diagnostics.StackTrace.dll" 
#r "/home/justin/.nuget/packages/system.console/4.3.1/lib/net46/System.Console.dll" 
#r "/home/justin/.nuget/packages/system.data.sqlclient/4.5.1/lib/net46/System.Data.SqlClient.dll" 
#r "/home/justin/.nuget/packages/system.io.filesystem/4.3.0/lib/net46/System.IO.FileSystem.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnet.webapi.client/5.2.6/lib/net45/System.Net.Http.Formatting.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.registry/4.5.0/lib/net46/Microsoft.Win32.Registry.dll" 
#r "/home/justin/.nuget/packages/system.globalization.calendars/4.3.0/lib/net46/System.Globalization.Calendars.dll" 
#r "/home/justin/.nuget/packages/system.threading.threadpool/4.3.0/lib/net46/System.Threading.ThreadPool.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.primitives/4.3.0/lib/net46/Microsoft.Win32.Primitives.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json.bson/1.0.1/lib/net45/Newtonsoft.Json.Bson.dll" 
#r "/home/justin/.nuget/packages/system.appcontext/4.3.0/lib/net46/System.AppContext.dll" 
#r "/home/justin/.nuget/packages/system.io.filesystem.primitives/4.3.0/lib/net46/System.IO.FileSystem.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.security.accesscontrol/4.5.0/lib/net46/System.Security.AccessControl.dll" 
#r "/home/justin/.nuget/packages/system.threading.thread/4.3.0/lib/net46/System.Threading.Thread.dll" 
#r "/home/justin/.nuget/packages/taskbuilder.fs/2.1.0/lib/net46/TaskBuilder.fs.dll" 
#r "/home/justin/.nuget/packages/xunit.abstractions/2.0.3/lib/net35/xunit.abstractions.dll" 
#r "/home/justin/.nuget/packages/xunit.assert/2.4.1/lib/netstandard1.1/xunit.assert.dll" 
#r "/home/justin/.nuget/packages/fsharp.data/3.0.0/lib/net45/FSharp.Data.DesignTime.dll" 
#r "/home/justin/.nuget/packages/fsharp.data/3.0.0/lib/net45/FSharp.Data.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.typeconverter/4.3.0/lib/net45/System.ComponentModel.TypeConverter.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.pkcs/4.5.1/lib/net46/System.Security.Cryptography.Pkcs.dll" 
#r "/home/justin/.nuget/packages/system.security.principal.windows/4.5.1/lib/net46/System.Security.Principal.Windows.dll" 
#r "/home/justin/.nuget/packages/system.text.encoding.codepages/4.5.0/lib/net46/System.Text.Encoding.CodePages.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.razor.language/2.1.2/lib/net46/Microsoft.AspNetCore.Razor.Language.dll" 
#r "/home/justin/.nuget/packages/microsoft.codecoverage/15.9.0/lib/net45/Microsoft.VisualStudio.CodeCoverage.Shim.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json/11.0.2/lib/net45/Newtonsoft.Json.dll" 
#r "/home/justin/.nuget/packages/system.buffers/4.5.0/lib/netstandard1.1/System.Buffers.dll" 
#r "/home/justin/.nuget/packages/system.collections.immutable/1.5.0/lib/netstandard1.3/System.Collections.Immutable.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.primitives/4.3.0/lib/net45/System.ComponentModel.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.diagnosticsource/4.5.1/lib/net46/System.Diagnostics.DiagnosticSource.dll" 
#r "/home/justin/.nuget/packages/system.interactive.async/3.2.0/lib/net46/System.Interactive.Async.dll" 
#r "/home/justin/.nuget/packages/system.memory/4.5.1/lib/netstandard1.1/System.Memory.dll" 
#r "/home/justin/.nuget/packages/system.numerics.vectors/4.5.0/lib/net46/System.Numerics.Vectors.dll" 
#r "/home/justin/.nuget/packages/system.reflection.typeextensions/4.5.1/lib/net46/System.Reflection.TypeExtensions.dll" 
#r "/home/justin/.nuget/packages/system.runtime.compilerservices.unsafe/4.5.2/lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll" 
#r "/home/justin/.nuget/packages/system.runtime.interopservices.runtimeinformation/4.3.0/lib/net45/System.Runtime.InteropServices.RuntimeInformation.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.cng/4.5.0/lib/net46/System.Security.Cryptography.Cng.dll" 
#r "/home/justin/.nuget/packages/system.text.encodings.web/4.5.0/lib/netstandard1.0/System.Text.Encodings.Web.dll" 
#r "/home/justin/.nuget/packages/system.threading.tasks.extensions/4.5.1/lib/netstandard1.0/System.Threading.Tasks.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.valuetuple/4.5.0/lib/netstandard1.0/System.ValueTuple.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.razor/2.1.2/lib/net46/Microsoft.CodeAnalysis.Razor.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens/5.3.0/lib/net451/Microsoft.IdentityModel.Tokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.TestPlatform.CoreUtilities.dll" 
#r "/home/justin/.nuget/packages/system.private.datacontractserialization/4.3.0/lib/netstandard1.3/System.Private.DataContractSerialization.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencymodel/2.1.0/lib/net451/Microsoft.Extensions.DependencyModel.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.core/2.4.1/lib/net452/xunit.core.dll" 
#r "/home/justin/.nuget/packages/system.io.pipelines/4.5.2/lib/netstandard1.3/System.IO.Pipelines.dll" 
#r "/home/justin/.nuget/packages/system.reflection.metadata/1.6.0/lib/netstandard1.1/System.Reflection.Metadata.dll" 
#r "/home/justin/.nuget/packages/system.threading.channels/4.5.0/lib/netstandard1.3/System.Threading.Channels.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.razor.extensions/2.1.2/lib/net46/Microsoft.AspNetCore.Mvc.Razor.Extensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.jsonwebtokens/5.3.0/lib/net451/Microsoft.IdentityModel.JsonWebTokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols/5.3.0/lib/net451/Microsoft.IdentityModel.Protocols.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.xml/5.3.0/lib/net451/Microsoft.IdentityModel.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.common/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.execution/2.4.1/lib/net452/xunit.execution.desktop.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.wsfederation/5.3.0/lib/net451/Microsoft.IdentityModel.Protocols.WsFederation.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens.saml/5.3.0/lib/net451/Microsoft.IdentityModel.Tokens.Saml.dll" 
#r "/home/justin/.nuget/packages/system.identitymodel.tokens.jwt/5.3.0/lib/net451/System.IdentityModel.Tokens.Jwt.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.csharp/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.CSharp.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.openidconnect/5.3.0/lib/net451/Microsoft.IdentityModel.Protocols.OpenIdConnect.dll" 