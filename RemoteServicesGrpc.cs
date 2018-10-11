// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: remote_services.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Remoteservices {
  public static partial class RemoteServices
  {
    static readonly string __ServiceName = "remoteservices.RemoteServices";

    static readonly Marshaller<global::Remoteservices.Request> __Marshaller_Request = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remoteservices.Request.Parser.ParseFrom);
    static readonly Marshaller<global::Remoteservices.Response> __Marshaller_Response = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remoteservices.Response.Parser.ParseFrom);

    static readonly Method<global::Remoteservices.Request, global::Remoteservices.Response> __Method_GetStatus = new Method<global::Remoteservices.Request, global::Remoteservices.Response>(
        MethodType.Unary,
        __ServiceName,
        "GetStatus",
        __Marshaller_Request,
        __Marshaller_Response);

    static readonly Method<global::Remoteservices.Request, global::Remoteservices.Response> __Method_GetStatusStream = new Method<global::Remoteservices.Request, global::Remoteservices.Response>(
        MethodType.ServerStreaming,
        __ServiceName,
        "GetStatusStream",
        __Marshaller_Request,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Remoteservices.RemoteServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteServices</summary>
    public abstract partial class RemoteServicesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Remoteservices.Response> GetStatus(global::Remoteservices.Request request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetStatusStream(global::Remoteservices.Request request, IServerStreamWriter<global::Remoteservices.Response> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemoteServices</summary>
    public partial class RemoteServicesClient : ClientBase<RemoteServicesClient>
    {
      /// <summary>Creates a new client for RemoteServices</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemoteServicesClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemoteServices that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemoteServicesClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemoteServicesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemoteServicesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Remoteservices.Response GetStatus(global::Remoteservices.Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetStatus(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remoteservices.Response GetStatus(global::Remoteservices.Request request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStatus, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Remoteservices.Response> GetStatusAsync(global::Remoteservices.Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetStatusAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Remoteservices.Response> GetStatusAsync(global::Remoteservices.Request request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStatus, null, options, request);
      }
      public virtual AsyncServerStreamingCall<global::Remoteservices.Response> GetStatusStream(global::Remoteservices.Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetStatusStream(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncServerStreamingCall<global::Remoteservices.Response> GetStatusStream(global::Remoteservices.Request request, CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetStatusStream, null, options, request);
      }
      protected override RemoteServicesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemoteServicesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(RemoteServicesBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStatus, serviceImpl.GetStatus)
          .AddMethod(__Method_GetStatusStream, serviceImpl.GetStatusStream).Build();
    }

  }
}
#endregion
