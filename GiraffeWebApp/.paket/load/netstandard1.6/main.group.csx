namespace PaketLoadScripts

#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.private.datacontractserialization/4.3.0/lib/netstandard1.3/System.Private.DataContractSerialization.dll" 
#r "/home/justin/.nuget/packages/remotion.linq/2.2.0/lib/netstandard1.0/Remotion.Linq.dll" 
#r "/home/justin/.nuget/packages/system.xml.xmlserializer/4.3.0/lib/netstandard1.3/System.Xml.XmlSerializer.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xmldocument/4.3.0/lib/netstandard1.3/System.Xml.XPath.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.dynamic.runtime/4.3.0/lib/netstandard1.3/System.Dynamic.Runtime.dll" 
#r "/home/justin/.nuget/packages/system.linq.queryable/4.3.0/lib/netstandard1.3/System.Linq.Queryable.dll" 
#r "/home/justin/.nuget/packages/system.xml.xdocument/4.3.0/lib/netstandard1.3/System.Xml.XDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xmldocument/4.3.0/lib/netstandard1.3/System.Xml.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath/4.3.0/lib/netstandard1.3/System.Xml.XPath.dll" 
#r "/home/justin/.nuget/packages/system.collections.specialized/4.3.0/lib/netstandard1.3/System.Collections.Specialized.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.textwritertracelistener/4.3.0/lib/netstandard1.3/System.Diagnostics.TextWriterTraceListener.dll" 
#r "/home/justin/.nuget/packages/system.linq.expressions/4.3.0/lib/netstandard1.6/System.Linq.Expressions.dll" 
#r "/home/justin/.nuget/packages/system.threading.tasks.parallel/4.3.0/lib/netstandard1.3/System.Threading.Tasks.Parallel.dll" 
#r "/home/justin/.nuget/packages/system.xml.readerwriter/4.3.1/lib/netstandard1.3/System.Xml.ReaderWriter.dll" 
#r "/home/justin/.nuget/packages/microsoft.dotnet.platformabstractions/2.1.0/lib/netstandard1.3/Microsoft.DotNet.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.collections.concurrent/4.3.0/lib/netstandard1.3/System.Collections.Concurrent.dll" 
#r "/home/justin/.nuget/packages/system.collections.nongeneric/4.3.0/lib/netstandard1.3/System.Collections.NonGeneric.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.eventbasedasync/4.3.0/lib/netstandard1.3/System.ComponentModel.EventBasedAsync.dll" 
#r "/home/justin/.nuget/packages/system.linq/4.3.0/lib/netstandard1.6/System.Linq.dll" 
#r "/home/justin/.nuget/packages/system.objectmodel/4.3.0/lib/netstandard1.3/System.ObjectModel.dll" 
#r "/home/justin/.nuget/packages/system.reflection.emit/4.3.0/lib/netstandard1.3/System.Reflection.Emit.dll" 
#r "/home/justin/.nuget/packages/system.reflection.emit.lightweight/4.3.0/lib/netstandard1.3/System.Reflection.Emit.Lightweight.dll" 
#r "/home/justin/.nuget/packages/system.runtime.numerics/4.3.0/lib/netstandard1.3/System.Runtime.Numerics.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.primitives/4.3.0/lib/netstandard1.3/System.Runtime.Serialization.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.security.claims/4.3.0/lib/netstandard1.3/System.Security.Claims.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.primitives/4.3.0/lib/netstandard1.3/System.Security.Cryptography.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.text.regularexpressions/4.3.0/lib/netstandard1.6/System.Text.RegularExpressions.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.logging/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Logging.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.stacktrace/4.3.0/lib/netstandard1.3/System.Diagnostics.StackTrace.dll" 
#r "/home/justin/.nuget/packages/system.reflection.emit.ilgeneration/4.3.0/lib/netstandard1.3/System.Reflection.Emit.ILGeneration.dll" 
#r "/home/justin/.nuget/packages/system.runtime.loader/4.3.0/lib/netstandard1.5/System.Runtime.Loader.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.registry/4.5.0/lib/netstandard1.3/Microsoft.Win32.Registry.dll" 
#r "/home/justin/.nuget/packages/system.threading/4.3.0/lib/netstandard1.3/System.Threading.dll" 
#r "/home/justin/.nuget/packages/system.threading.threadpool/4.3.0/lib/netstandard1.3/System.Threading.ThreadPool.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json.bson/1.0.1/lib/netstandard1.3/Newtonsoft.Json.Bson.dll" 
#r "/home/justin/.nuget/packages/system.appcontext/4.3.0/lib/netstandard1.6/System.AppContext.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.contracts/4.3.0/lib/netstandard1.0/System.Diagnostics.Contracts.dll" 
#r "/home/justin/.nuget/packages/system.io.filesystem.primitives/4.3.0/lib/netstandard1.3/System.IO.FileSystem.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.security.accesscontrol/4.5.0/lib/netstandard1.3/System.Security.AccessControl.dll" 
#r "/home/justin/.nuget/packages/system.security.principal/4.3.0/lib/netstandard1.0/System.Security.Principal.dll" 
#r "/home/justin/.nuget/packages/system.threading.thread/4.3.0/lib/netstandard1.3/System.Threading.Thread.dll" 
#r "/home/justin/.nuget/packages/taskbuilder.fs/2.1.0/lib/netstandard1.6/TaskBuilder.fs.dll" 
#r "/home/justin/.nuget/packages/xunit.abstractions/2.0.3/lib/netstandard1.0/xunit.abstractions.dll" 
#r "/home/justin/.nuget/packages/xunit.assert/2.4.1/lib/netstandard1.1/xunit.assert.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.pkcs/4.5.1/lib/netstandard1.3/System.Security.Cryptography.Pkcs.dll" 
#r "/home/justin/.nuget/packages/system.security.principal.windows/4.5.1/lib/netstandard1.3/System.Security.Principal.Windows.dll" 
#r "/home/justin/.nuget/packages/system.text.encoding.codepages/4.5.0/lib/netstandard1.3/System.Text.Encoding.CodePages.dll" 
#r "/home/justin/.nuget/packages/fsharp.core/4.5.2/lib/netstandard1.6/FSharp.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.csharp/4.5.0/lib/netstandard1.3/Microsoft.CSharp.dll" 
#r "/home/justin/.nuget/packages/system.buffers/4.5.0/lib/netstandard1.1/System.Buffers.dll" 
#r "/home/justin/.nuget/packages/system.collections.immutable/1.5.0/lib/netstandard1.3/System.Collections.Immutable.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.annotations/4.5.0/lib/netstandard1.4/System.ComponentModel.Annotations.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.primitives/4.3.0/lib/netstandard1.0/System.ComponentModel.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.diagnosticsource/4.5.1/lib/netstandard1.3/System.Diagnostics.DiagnosticSource.dll" 
#r "/home/justin/.nuget/packages/system.interactive.async/3.2.0/lib/netstandard1.3/System.Interactive.Async.dll" 
#r "/home/justin/.nuget/packages/system.memory/4.5.1/lib/netstandard1.1/System.Memory.dll" 
#r "/home/justin/.nuget/packages/system.numerics.vectors/4.5.0/lib/netstandard1.0/System.Numerics.Vectors.dll" 
#r "/home/justin/.nuget/packages/system.reflection.typeextensions/4.5.1/lib/netstandard1.5/System.Reflection.TypeExtensions.dll" 
#r "/home/justin/.nuget/packages/system.runtime.compilerservices.unsafe/4.5.2/lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll" 
#r "/home/justin/.nuget/packages/system.runtime.interopservices.runtimeinformation/4.3.0/lib/netstandard1.1/System.Runtime.InteropServices.RuntimeInformation.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.cng/4.5.0/lib/netstandard1.6/System.Security.Cryptography.Cng.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.openssl/4.5.0/lib/netstandard1.6/System.Security.Cryptography.OpenSsl.dll" 
#r "/home/justin/.nuget/packages/system.text.encodings.web/4.5.0/lib/netstandard1.0/System.Text.Encodings.Web.dll" 
#r "/home/justin/.nuget/packages/system.threading.tasks.extensions/4.5.1/lib/netstandard1.0/System.Threading.Tasks.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.valuetuple/4.5.0/lib/netstandard1.0/System.ValueTuple.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens/5.3.0/lib/netstandard1.4/Microsoft.IdentityModel.Tokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/netstandard1.5/Microsoft.TestPlatform.CoreUtilities.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.json/4.3.0/lib/netstandard1.3/System.Runtime.Serialization.Json.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.xml/4.3.0/lib/netstandard1.3/System.Runtime.Serialization.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencymodel/2.1.0/lib/netstandard1.6/Microsoft.Extensions.DependencyModel.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xdocument/4.3.0/lib/netstandard1.3/System.Xml.XPath.XDocument.dll" 
#r "/home/justin/.nuget/packages/system.data.sqlclient/4.5.1/lib/netstandard1.3/System.Data.SqlClient.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.core/2.4.1/lib/netstandard1.1/xunit.core.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.typeconverter/4.3.0/lib/netstandard1.5/System.ComponentModel.TypeConverter.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json/11.0.2/lib/netstandard1.3/Newtonsoft.Json.dll" 
#r "/home/justin/.nuget/packages/system.io.pipelines/4.5.2/lib/netstandard1.3/System.IO.Pipelines.dll" 
#r "/home/justin/.nuget/packages/system.reflection.metadata/1.6.0/lib/netstandard1.1/System.Reflection.Metadata.dll" 
#r "/home/justin/.nuget/packages/system.threading.channels/4.5.0/lib/netstandard1.3/System.Threading.Channels.dll" 
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