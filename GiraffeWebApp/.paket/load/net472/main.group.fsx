namespace PaketLoadScripts

#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.TestPlatform.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.net.http/4.3.4/lib/net46/System.Net.Http.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.xml/4.3.0/lib/net46/System.Runtime.Serialization.Xml.dll" 
#r "/home/justin/.nuget/packages/system.private.datacontractserialization/4.3.0/lib/netstandard1.3/System.Private.DataContractSerialization.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.x509certificates/4.3.2/lib/net461/System.Security.Cryptography.X509Certificates.dll" 
#r "/home/justin/.nuget/packages/remotion.linq/2.2.0/lib/net45/Remotion.Linq.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.csp/4.3.0/lib/net46/System.Security.Cryptography.Csp.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xdocument/4.3.0/lib/net46/System.Xml.XPath.XDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath.xmldocument/4.3.0/lib/net46/System.Xml.XPath.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.algorithms/4.3.1/lib/net463/System.Security.Cryptography.Algorithms.dll" 
#r "/home/justin/.nuget/packages/system.xml.xmldocument/4.3.0/lib/net46/System.Xml.XmlDocument.dll" 
#r "/home/justin/.nuget/packages/system.xml.xpath/4.3.0/lib/net46/System.Xml.XPath.dll" 
#r "/home/justin/.nuget/packages/system.collections.specialized/4.3.0/lib/net46/System.Collections.Specialized.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.textwritertracelistener/4.3.0/lib/net46/System.Diagnostics.TextWriterTraceListener.dll" 
#r "/home/justin/.nuget/packages/system.linq.expressions/4.3.0/lib/net463/System.Linq.Expressions.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.encoding/4.3.0/lib/net46/System.Security.Cryptography.Encoding.dll" 
#r "/home/justin/.nuget/packages/system.xml.readerwriter/4.3.1/lib/net46/System.Xml.ReaderWriter.dll" 
#r "/home/justin/.nuget/packages/utf8json/1.3.7/lib/net47/Utf8Json.dll" 
#r "/home/justin/.nuget/packages/microsoft.dotnet.platformabstractions/2.1.0/lib/net45/Microsoft.DotNet.PlatformAbstractions.dll" 
#r "/home/justin/.nuget/packages/system.collections.nongeneric/4.3.0/lib/net46/System.Collections.NonGeneric.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.fileversioninfo/4.3.0/lib/net46/System.Diagnostics.FileVersionInfo.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.process/4.3.0/lib/net461/System.Diagnostics.Process.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.tracesource/4.3.0/lib/net46/System.Diagnostics.TraceSource.dll" 
#r "/home/justin/.nuget/packages/system.globalization.extensions/4.3.0/lib/net46/System.Globalization.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.io.compression/4.3.0/lib/net46/System.IO.Compression.dll" 
#r "/home/justin/.nuget/packages/system.linq/4.3.0/lib/net463/System.Linq.dll" 
#r "/home/justin/.nuget/packages/system.runtime.serialization.primitives/4.3.0/lib/net46/System.Runtime.Serialization.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.security.claims/4.3.0/lib/net46/System.Security.Claims.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.primitives/4.3.0/lib/net46/System.Security.Cryptography.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.text.regularexpressions/4.3.0/lib/net463/System.Text.RegularExpressions.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.logging/5.3.0/lib/net461/Microsoft.IdentityModel.Logging.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.stacktrace/4.3.0/lib/net46/System.Diagnostics.StackTrace.dll" 
#r "/home/justin/.nuget/packages/system.runtime.interopservices/4.3.0/lib/net463/System.Runtime.InteropServices.dll" 
#r "/home/justin/.nuget/packages/system.console/4.3.1/lib/net46/System.Console.dll" 
#r "/home/justin/.nuget/packages/system.data.sqlclient/4.5.1/lib/net461/System.Data.SqlClient.dll" 
#r "/home/justin/.nuget/packages/system.io.filesystem/4.3.0/lib/net46/System.IO.FileSystem.dll" 
#r "/home/justin/.nuget/packages/system.reflection/4.3.0/lib/net462/System.Reflection.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.xml/4.5.0/lib/net461/System.Security.Cryptography.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnet.webapi.client/5.2.6/lib/net45/System.Net.Http.Formatting.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.registry/4.5.0/lib/net461/Microsoft.Win32.Registry.dll" 
#r "/home/justin/.nuget/packages/system.globalization.calendars/4.3.0/lib/net46/System.Globalization.Calendars.dll" 
#r "/home/justin/.nuget/packages/system.io/4.3.0/lib/net462/System.IO.dll" 
#r "/home/justin/.nuget/packages/system.security.permissions/4.5.0/lib/net461/System.Security.Permissions.dll" 
#r "/home/justin/.nuget/packages/system.threading.threadpool/4.3.0/lib/net46/System.Threading.ThreadPool.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.responsecaching.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.ResponseCaching.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.win32.primitives/4.3.0/lib/net46/Microsoft.Win32.Primitives.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json.bson/1.0.1/lib/net45/Newtonsoft.Json.Bson.dll" 
#r "/home/justin/.nuget/packages/system.appcontext/4.3.0/lib/net463/System.AppContext.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.tracing/4.3.0/lib/net462/System.Diagnostics.Tracing.dll" 
#r "/home/justin/.nuget/packages/system.io.filesystem.primitives/4.3.0/lib/net46/System.IO.FileSystem.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.runtime.extensions/4.3.0/lib/net462/System.Runtime.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.security.accesscontrol/4.5.0/lib/net461/System.Security.AccessControl.dll" 
#r "/home/justin/.nuget/packages/system.threading.thread/4.3.0/lib/net46/System.Threading.Thread.dll" 
#r "/home/justin/.nuget/packages/taskbuilder.fs/2.1.0/lib/net47/TaskBuilder.fs.dll" 
#r "/home/justin/.nuget/packages/xunit.abstractions/2.0.3/lib/net35/xunit.abstractions.dll" 
#r "/home/justin/.nuget/packages/xunit.assert/2.4.1/lib/netstandard1.1/xunit.assert.dll" 
#r "/home/justin/.nuget/packages/fsharp.data/3.0.0/lib/net45/FSharp.Data.DesignTime.dll" 
#r "/home/justin/.nuget/packages/fsharp.data/3.0.0/lib/net45/FSharp.Data.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.diagnosticadapter/2.1.0/lib/net461/Microsoft.Extensions.DiagnosticAdapter.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.typeconverter/4.3.0/lib/net462/System.ComponentModel.TypeConverter.dll" 
#r "/home/justin/.nuget/packages/system.runtime/4.3.0/lib/net462/System.Runtime.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.pkcs/4.5.1/lib/net461/System.Security.Cryptography.Pkcs.dll" 
#r "/home/justin/.nuget/packages/system.security.principal.windows/4.5.1/lib/net461/System.Security.Principal.Windows.dll" 
#r "/home/justin/.nuget/packages/system.text.encoding.codepages/4.5.0/lib/net461/System.Text.Encoding.CodePages.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.cryptography.internal/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Cryptography.Internal.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.dataprotection.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.DataProtection.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.diagnostics.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Diagnostics.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.razor.language/2.1.2/lib/net46/Microsoft.AspNetCore.Razor.Language.dll" 
#r "/home/justin/.nuget/packages/microsoft.codecoverage/15.9.0/lib/net45/Microsoft.VisualStudio.CodeCoverage.Shim.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore.abstractions/2.1.4/lib/netstandard2.0/Microsoft.EntityFrameworkCore.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencyinjection.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.DependencyInjection.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.filesystemglobbing/2.1.1/lib/netstandard2.0/Microsoft.Extensions.FileSystemGlobbing.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.localization.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Localization.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.objectpool/2.1.1/lib/netstandard2.0/Microsoft.Extensions.ObjectPool.dll" 
#r "/home/justin/.nuget/packages/newtonsoft.json/11.0.2/lib/net45/Newtonsoft.Json.dll" 
#r "/home/justin/.nuget/packages/system.buffers/4.5.0/lib/netstandard2.0/System.Buffers.dll" 
#r "/home/justin/.nuget/packages/system.collections.immutable/1.5.0/lib/netstandard2.0/System.Collections.Immutable.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.annotations/4.5.0/lib/net461/System.ComponentModel.Annotations.dll" 
#r "/home/justin/.nuget/packages/system.componentmodel.primitives/4.3.0/lib/net45/System.ComponentModel.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.diagnostics.diagnosticsource/4.5.1/lib/net46/System.Diagnostics.DiagnosticSource.dll" 
#r "/home/justin/.nuget/packages/system.interactive.async/3.2.0/lib/net46/System.Interactive.Async.dll" 
#r "/home/justin/.nuget/packages/system.memory/4.5.1/lib/netstandard2.0/System.Memory.dll" 
#r "/home/justin/.nuget/packages/system.numerics.vectors/4.5.0/lib/net46/System.Numerics.Vectors.dll" 
#r "/home/justin/.nuget/packages/system.reflection.typeextensions/4.5.1/lib/net461/System.Reflection.TypeExtensions.dll" 
#r "/home/justin/.nuget/packages/system.runtime.compilerservices.unsafe/4.5.2/lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll" 
#r "/home/justin/.nuget/packages/system.runtime.interopservices.runtimeinformation/4.3.0/lib/net45/System.Runtime.InteropServices.RuntimeInformation.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.cng/4.5.0/lib/net47/System.Security.Cryptography.Cng.dll" 
#r "/home/justin/.nuget/packages/system.security.cryptography.openssl/4.5.0/lib/netstandard2.0/System.Security.Cryptography.OpenSsl.dll" 
#r "/home/justin/.nuget/packages/system.text.encodings.web/4.5.0/lib/netstandard2.0/System.Text.Encodings.Web.dll" 
#r "/home/justin/.nuget/packages/system.threading.tasks.extensions/4.5.1/lib/netstandard2.0/System.Threading.Tasks.Extensions.dll" 
#r "/home/justin/.nuget/packages/system.valuetuple/4.5.0/lib/net47/System.ValueTuple.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.razor/2.1.2/lib/net46/Microsoft.CodeAnalysis.Razor.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens/5.3.0/lib/net461/Microsoft.IdentityModel.Tokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.TestPlatform.CoreUtilities.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencymodel/2.1.0/lib/net451/Microsoft.Extensions.DependencyModel.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http.connections.common/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.Http.Connections.Common.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.signalr.common/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.SignalR.Common.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.core/2.4.1/lib/net452/xunit.core.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.cryptography.keyderivation/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Cryptography.KeyDerivation.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.html.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Html.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.jsonpatch/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.JsonPatch.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.dependencyinjection/2.1.1/lib/net461/Microsoft.Extensions.DependencyInjection.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.primitives/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Primitives.dll" 
#r "/home/justin/.nuget/packages/system.io.pipelines/4.5.2/lib/netstandard2.0/System.IO.Pipelines.dll" 
#r "/home/justin/.nuget/packages/system.net.websockets.websocketprotocol/4.5.2/lib/netstandard2.0/System.Net.WebSockets.WebSocketProtocol.dll" 
#r "/home/justin/.nuget/packages/system.reflection.metadata/1.6.0/lib/netstandard2.0/System.Reflection.Metadata.dll" 
#r "/home/justin/.nuget/packages/system.threading.channels/4.5.0/lib/netstandard2.0/System.Threading.Channels.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.razor.extensions/2.1.2/lib/net46/Microsoft.AspNetCore.Mvc.Razor.Extensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.jsonwebtokens/5.3.0/lib/net461/Microsoft.IdentityModel.JsonWebTokens.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols/5.3.0/lib/net461/Microsoft.IdentityModel.Protocols.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.xml/5.3.0/lib/net461/Microsoft.IdentityModel.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.testplatform.objectmodel/15.9.0/lib/net451/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.common/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.dll" 
#r "/home/justin/.nuget/packages/xunit.extensibility.execution/2.4.1/lib/net452/xunit.execution.desktop.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http.features/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Http.Features.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.razor/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Razor.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.caching.abstractions/2.1.2/lib/netstandard2.0/Microsoft.Extensions.Caching.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.fileproviders.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.FileProviders.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.options/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Options.dll" 
#r "/home/justin/.nuget/packages/microsoft.net.http.headers/2.1.1/lib/netstandard2.0/Microsoft.Net.Http.Headers.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.wsfederation/5.3.0/lib/net461/Microsoft.IdentityModel.Protocols.WsFederation.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.tokens.saml/5.3.0/lib/net461/Microsoft.IdentityModel.Tokens.Saml.dll" 
#r "/home/justin/.nuget/packages/system.identitymodel.tokens.jwt/5.3.0/lib/net461/System.IdentityModel.Tokens.Jwt.dll" 
#r "/home/justin/.nuget/packages/microsoft.codeanalysis.csharp/2.9.0/lib/netstandard1.3/Microsoft.CodeAnalysis.CSharp.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.signalr.protocols.json/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.SignalR.Protocols.Json.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.caching.sqlserver/2.1.2/lib/netstandard2.0/Microsoft.Extensions.Caching.SqlServer.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.binder/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.Binder.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authorization/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authorization.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.connections.abstractions/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Connections.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.hosting.server.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Hosting.Server.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Http.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.razor.runtime/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Razor.Runtime.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.webutilities/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.WebUtilities.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.caching.memory/2.1.2/lib/netstandard2.0/Microsoft.Extensions.Caching.Memory.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.fileproviders.composite/2.1.1/lib/netstandard2.0/Microsoft.Extensions.FileProviders.Composite.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.fileproviders.embedded/2.1.1/lib/netstandard2.0/Microsoft.Extensions.FileProviders.Embedded.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.fileproviders.physical/2.1.1/lib/netstandard2.0/Microsoft.Extensions.FileProviders.Physical.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.hosting.abstractions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Hosting.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.localization/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Localization.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.webencoders/2.1.1/lib/netstandard2.0/Microsoft.Extensions.WebEncoders.dll" 
#r "/home/justin/.nuget/packages/microsoft.identitymodel.protocols.openidconnect/5.3.0/lib/net461/Microsoft.IdentityModel.Protocols.OpenIdConnect.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.diagnostics.entityframeworkcore/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore/2.1.4/lib/netstandard2.0/Microsoft.EntityFrameworkCore.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.signalr.core/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.SignalR.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.hosting/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Hosting.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.http/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Http.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.identity.core/2.1.3/lib/netstandard2.0/Microsoft.Extensions.Identity.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.debug/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.Debug.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.eventsource/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.EventSource.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.tracesource/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.TraceSource.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.cors/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Cors.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.hostfiltering/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.HostFiltering.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.httpoverrides/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.HttpOverrides.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.websockets/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.WebSockets.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.options.configurationextensions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Options.ConfigurationExtensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.hosting.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Hosting.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Http.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http.extensions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Http.Extensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.routing.abstractions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Routing.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.kestrel.transport.abstractions/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.commandline/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.CommandLine.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.environmentvariables/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.EnvironmentVariables.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.fileextensions/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.FileExtensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.keyperfile/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.KeyPerFile.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore.inmemory/2.1.4/lib/netstandard2.0/Microsoft.EntityFrameworkCore.InMemory.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore.relational/2.1.4/lib/netstandard2.0/Microsoft.EntityFrameworkCore.Relational.dll" 
#r "/home/justin/.nuget/packages/giraffe/3.4.0/lib/net461/Giraffe.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.identity/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Identity.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.identity.stores/2.1.3/lib/netstandard2.0/Microsoft.Extensions.Identity.Stores.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.hosting/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Hosting.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.configuration/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.Configuration.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.core/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authorization.policy/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authorization.Policy.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.cookiepolicy/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.CookiePolicy.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.dataprotection/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.DataProtection.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.diagnostics/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Diagnostics.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.httpspolicy/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.HttpsPolicy.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.localization/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Localization.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.middlewareanalysis/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.MiddlewareAnalysis.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.abstractions/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Abstractions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.owin/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Owin.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.responsecaching/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.ResponseCaching.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.responsecompression/2.1.1/lib/net461/Microsoft.AspNetCore.ResponseCompression.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.rewrite/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Rewrite.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.routing/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Routing.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.kestrel.core/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Server.Kestrel.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.kestrel.transport.sockets/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.staticfiles/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.StaticFiles.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.ini/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.Ini.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.json/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.Json.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.xml/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.identity.ui/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Identity.UI.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.identity.entityframeworkcore/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Identity.EntityFrameworkCore.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore.design/2.1.4/lib/net461/Microsoft.EntityFrameworkCore.Design.dll" 
#r "/home/justin/.nuget/packages/microsoft.entityframeworkcore.sqlserver/2.1.4/lib/netstandard2.0/Microsoft.EntityFrameworkCore.SqlServer.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.core/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Core.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.httpsys/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Server.HttpSys.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.kestrel/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Server.Kestrel.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.testhost/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.TestHost.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.logging.console/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Logging.Console.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.antiforgery/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Antiforgery.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.dataprotection.extensions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.DataProtection.Extensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.http.connections/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.Http.Connections.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.localization.routing/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Localization.Routing.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.iisintegration/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Server.IISIntegration.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.server.kestrel.https/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Server.Kestrel.Https.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.session/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.Session.dll" 
#r "/home/justin/.nuget/packages/microsoft.extensions.configuration.usersecrets/2.1.1/lib/netstandard2.0/Microsoft.Extensions.Configuration.UserSecrets.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.identity.ui/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Identity.UI.Views.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.jwtbearer/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.JwtBearer.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.wsfederation/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.WsFederation.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.apiexplorer/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.ApiExplorer.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.cors/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Cors.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.dataannotations/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.DataAnnotations.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.formatters.json/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Formatters.Json.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.formatters.xml/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Formatters.Xml.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore/2.1.4/lib/netstandard2.0/Microsoft.AspNetCore.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.nodeservices/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.NodeServices.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.signalr/1.0.4/lib/netstandard2.0/Microsoft.AspNetCore.SignalR.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.cookies/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Cookies.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.oauth/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.OAuth.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.spaservices/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.SpaServices.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.openidconnect/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.OpenIdConnect.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.viewfeatures/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.ViewFeatures.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.facebook/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Facebook.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.google/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Google.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.microsoftaccount/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.MicrosoftAccount.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.authentication.twitter/2.1.2/lib/netstandard2.0/Microsoft.AspNetCore.Authentication.Twitter.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.spaservices.extensions/2.1.1/lib/netstandard2.0/Microsoft.AspNetCore.SpaServices.Extensions.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.razor/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Razor.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.localization/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.Localization.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.razorpages/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.RazorPages.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc.taghelpers/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.TagHelpers.dll" 
#r "/home/justin/.nuget/packages/microsoft.aspnetcore.mvc/2.1.3/lib/netstandard2.0/Microsoft.AspNetCore.Mvc.dll" 