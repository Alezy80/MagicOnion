﻿// <auto-generated />
#pragma warning disable

    partial class MagicOnionInitializer
    {
        static partial class MagicOnionGeneratedClient
        {
            [global::MagicOnion.Ignore]
            public class MyApplication1_GreeterServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::MyApplication1.IGreeterService>, global::MyApplication1.IGreeterService
            {
                class ClientCore
                {
                    public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.DynamicArgumentTuple<global::System.String, global::System.Int32>, global::MyApplication1.MyGenericObject<global::System.String>> HelloAsync;
                    public ClientCore(global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider)
                    {
                        this.HelloAsync = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_RefType<global::MagicOnion.DynamicArgumentTuple<global::System.String, global::System.Int32>, global::MyApplication1.MyGenericObject<global::System.String>>(global::Grpc.Core.MethodType.Unary, "IGreeterService", "HelloAsync", serializerProvider);
                    }
                 }

                readonly ClientCore core;

                public MyApplication1_GreeterServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider) : base(options)
                {
                    this.core = new ClientCore(serializerProvider);
                }

                private MyApplication1_GreeterServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, ClientCore core) : base(options)
                {
                    this.core = core;
                }

                protected override global::MagicOnion.Client.MagicOnionClientBase<global::MyApplication1.IGreeterService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
                    => new MyApplication1_GreeterServiceClient(options, core);

                public global::MagicOnion.UnaryResult<global::MyApplication1.MyGenericObject<global::System.String>> HelloAsync(global::System.String name, global::System.Int32 age)
                    => this.core.HelloAsync.InvokeUnary(this, "IGreeterService/HelloAsync", new global::MagicOnion.DynamicArgumentTuple<global::System.String, global::System.Int32>(name, age));
            }
        }
    }
