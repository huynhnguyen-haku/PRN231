// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos {
  public static partial class ProductServiceGRPC
  {
    static readonly string __ServiceName = "ProductServiceGRPC";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList> __Marshaller_ProductList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest> __Marshaller_ProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> __Marshaller_ProductReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest> __Marshaller_ProductAddRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest> __Marshaller_ProductUpdateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList> __Method_GetAllProducts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllProducts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ProductList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> __Method_GetProductById = new grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_ProductRequest,
        __Marshaller_ProductReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> __Method_AddProduct = new grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddProduct",
        __Marshaller_ProductAddRequest,
        __Marshaller_ProductReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> __Method_UpdateProduct = new grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_ProductUpdateRequest,
        __Marshaller_ProductReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteProduct = new grpc::Method<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_ProductRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductServiceGRPC</summary>
    [grpc::BindServiceMethod(typeof(ProductServiceGRPC), "BindService")]
    public abstract partial class ProductServiceGRPCBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList> GetAllProducts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> GetProductById(global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> AddProduct(global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply> UpdateProduct(global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteProduct(global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductServiceGRPCBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllProducts, serviceImpl.GetAllProducts)
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById)
          .AddMethod(__Method_AddProduct, serviceImpl.AddProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductServiceGRPCBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductList>(serviceImpl.GetAllProducts));
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(serviceImpl.GetProductById));
      serviceBinder.AddMethod(__Method_AddProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductAddRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(serviceImpl.AddProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductUpdateRequest, global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductReply>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Net1711_231_ASM3_SE160414_HuynhHoangKhoiNguyen_gRPC.Protos.ProductRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteProduct));
    }

  }
}
#endregion
