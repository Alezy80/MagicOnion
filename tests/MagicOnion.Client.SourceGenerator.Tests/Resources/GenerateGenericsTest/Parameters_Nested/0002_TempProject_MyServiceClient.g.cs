﻿// <auto-generated />
#pragma warning disable

namespace TempProject
{
    partial class MagicOnionInitializer
    {
        static partial class MagicOnionGeneratedClient
        {
            [global::MagicOnion.Ignore]
            public class TempProject_MyServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::TempProject.IMyService>, global::TempProject.IMyService
            {
                class ClientCore
                {
                    public global::MagicOnion.Client.Internal.RawMethodInvoker<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>>, global::MessagePack.Nil> A;
                    public global::MagicOnion.Client.Internal.RawMethodInvoker<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>>>, global::MessagePack.Nil> B;
                    public global::MagicOnion.Client.Internal.RawMethodInvoker<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::System.Int32>>>, global::MessagePack.Nil> C;
                    public ClientCore(global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider)
                    {
                        this.A = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>>, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IMyService", "A", serializerProvider);
                        this.B = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>>>, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IMyService", "B", serializerProvider);
                        this.C = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::System.Int32>>>, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IMyService", "C", serializerProvider);
                    }
                 }

                readonly ClientCore core;

                public TempProject_MyServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider) : base(options)
                {
                    this.core = new ClientCore(serializerProvider);
                }

                private TempProject_MyServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, ClientCore core) : base(options)
                {
                    this.core = core;
                }

                protected override global::MagicOnion.Client.MagicOnionClientBase<global::TempProject.IMyService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
                    => new TempProject_MyServiceClient(options, core);

                public global::MagicOnion.UnaryResult<global::MessagePack.Nil> A(global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>> a)
                    => this.core.A.InvokeUnary(this, "IMyService/A", a);
                public global::MagicOnion.UnaryResult<global::MessagePack.Nil> B(global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyObject>>> a)
                    => this.core.B.InvokeUnary(this, "IMyService/B", a);
                public global::MagicOnion.UnaryResult<global::MessagePack.Nil> C(global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::TempProject.MyGenericObject<global::System.Int32>>> a)
                    => this.core.C.InvokeUnary(this, "IMyService/C", a);
            }
        }
    }
}
