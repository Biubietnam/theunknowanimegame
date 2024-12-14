using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E1 RID: 737
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientObjUploadCsReq : IMessage<ClientObjUploadCsReq>, IMessage, IEquatable<ClientObjUploadCsReq>, IDeepCloneable<ClientObjUploadCsReq>, IBufferMessage
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x0005D898 File Offset: 0x0005BA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientObjUploadCsReq> Parser
		{
			get
			{
				return ClientObjUploadCsReq._parser;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0005D89F File Offset: 0x0005BA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientObjUploadCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0005D8B1 File Offset: 0x0005BAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientObjUploadCsReq.Descriptor;
			}
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadCsReq()
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0005D8CB File Offset: 0x0005BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadCsReq(ClientObjUploadCsReq other) : this()
		{
			this.lFEIOFIHJAB_ = other.lFEIOFIHJAB_;
			this.cANDPJMDEAD_ = other.cANDPJMDEAD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0005D8FC File Offset: 0x0005BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadCsReq Clone()
		{
			return new ClientObjUploadCsReq(this);
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0005D904 File Offset: 0x0005BB04
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0005D90C File Offset: 0x0005BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString LFEIOFIHJAB
		{
			get
			{
				return this.lFEIOFIHJAB_;
			}
			set
			{
				this.lFEIOFIHJAB_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0005D91F File Offset: 0x0005BB1F
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x0005D927 File Offset: 0x0005BB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CANDPJMDEAD
		{
			get
			{
				return this.cANDPJMDEAD_;
			}
			set
			{
				this.cANDPJMDEAD_ = value;
			}
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0005D930 File Offset: 0x0005BB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientObjUploadCsReq);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0005D940 File Offset: 0x0005BB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientObjUploadCsReq other)
		{
			return other != null && (other == this || (!(this.LFEIOFIHJAB != other.LFEIOFIHJAB) && this.CANDPJMDEAD == other.CANDPJMDEAD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0005D990 File Offset: 0x0005BB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LFEIOFIHJAB.Length != 0)
			{
				num ^= this.LFEIOFIHJAB.GetHashCode();
			}
			if (this.CANDPJMDEAD != 0U)
			{
				num ^= this.CANDPJMDEAD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0005D9EA File Offset: 0x0005BBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0005D9F2 File Offset: 0x0005BBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0005D9FC File Offset: 0x0005BBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LFEIOFIHJAB.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.LFEIOFIHJAB);
			}
			if (this.CANDPJMDEAD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CANDPJMDEAD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0005DA5C File Offset: 0x0005BC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LFEIOFIHJAB.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LFEIOFIHJAB);
			}
			if (this.CANDPJMDEAD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CANDPJMDEAD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0005DAB8 File Offset: 0x0005BCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientObjUploadCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LFEIOFIHJAB.Length != 0)
			{
				this.LFEIOFIHJAB = other.LFEIOFIHJAB;
			}
			if (other.CANDPJMDEAD != 0U)
			{
				this.CANDPJMDEAD = other.CANDPJMDEAD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0005DB0D File Offset: 0x0005BD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0005DB18 File Offset: 0x0005BD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CANDPJMDEAD = input.ReadUInt32();
					}
				}
				else
				{
					this.LFEIOFIHJAB = input.ReadBytes();
				}
			}
		}

		// Token: 0x04000D94 RID: 3476
		private static readonly MessageParser<ClientObjUploadCsReq> _parser = new MessageParser<ClientObjUploadCsReq>(() => new ClientObjUploadCsReq());

		// Token: 0x04000D95 RID: 3477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D96 RID: 3478
		public const int LFEIOFIHJABFieldNumber = 1;

		// Token: 0x04000D97 RID: 3479
		private ByteString lFEIOFIHJAB_ = ByteString.Empty;

		// Token: 0x04000D98 RID: 3480
		public const int CANDPJMDEADFieldNumber = 2;

		// Token: 0x04000D99 RID: 3481
		private uint cANDPJMDEAD_;
	}
}
