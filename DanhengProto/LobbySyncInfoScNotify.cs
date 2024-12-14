using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A53 RID: 2643
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbySyncInfoScNotify : IMessage<LobbySyncInfoScNotify>, IMessage, IEquatable<LobbySyncInfoScNotify>, IDeepCloneable<LobbySyncInfoScNotify>, IBufferMessage
	{
		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x001374C3 File Offset: 0x001356C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbySyncInfoScNotify> Parser
		{
			get
			{
				return LobbySyncInfoScNotify._parser;
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x001374CA File Offset: 0x001356CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbySyncInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06007530 RID: 30000 RVA: 0x001374DC File Offset: 0x001356DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbySyncInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x001374E3 File Offset: 0x001356E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbySyncInfoScNotify()
		{
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x001374F8 File Offset: 0x001356F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbySyncInfoScNotify(LobbySyncInfoScNotify other) : this()
		{
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.uid_ = other.uid_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00137545 File Offset: 0x00135745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbySyncInfoScNotify Clone()
		{
			return new LobbySyncInfoScNotify(this);
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06007534 RID: 30004 RVA: 0x0013754D File Offset: 0x0013574D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x00137555 File Offset: 0x00135755
		// (set) Token: 0x06007536 RID: 30006 RVA: 0x0013755D File Offset: 0x0013575D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x00137566 File Offset: 0x00135766
		// (set) Token: 0x06007538 RID: 30008 RVA: 0x0013756E File Offset: 0x0013576E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00137577 File Offset: 0x00135777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbySyncInfoScNotify);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00137588 File Offset: 0x00135788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbySyncInfoScNotify other)
		{
			return other != null && (other == this || (this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && this.Uid == other.Uid && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x001375E8 File Offset: 0x001357E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Type != LobbyModifyType.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00137654 File Offset: 0x00135854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x0013765C File Offset: 0x0013585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x00137668 File Offset: 0x00135868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Uid);
			}
			this.eBMOKPBKMMD_.WriteTo(ref output, LobbySyncInfoScNotify._repeated_eBMOKPBKMMD_codec);
			if (this.Type != LobbyModifyType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x001376D4 File Offset: 0x001358D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eBMOKPBKMMD_.CalculateSize(LobbySyncInfoScNotify._repeated_eBMOKPBKMMD_codec);
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Type != LobbyModifyType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00137740 File Offset: 0x00135940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbySyncInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Type != LobbyModifyType.None)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x001377A1 File Offset: 0x001359A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x001377AC File Offset: 0x001359AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 82U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = (LobbyModifyType)input.ReadEnum();
						}
					}
					else
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, LobbySyncInfoScNotify._repeated_eBMOKPBKMMD_codec);
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D14 RID: 11540
		private static readonly MessageParser<LobbySyncInfoScNotify> _parser = new MessageParser<LobbySyncInfoScNotify>(() => new LobbySyncInfoScNotify());

		// Token: 0x04002D15 RID: 11541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D16 RID: 11542
		public const int EBMOKPBKMMDFieldNumber = 10;

		// Token: 0x04002D17 RID: 11543
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(82U, CCHCPNLPBDK.Parser);

		// Token: 0x04002D18 RID: 11544
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04002D19 RID: 11545
		public const int UidFieldNumber = 2;

		// Token: 0x04002D1A RID: 11546
		private uint uid_;

		// Token: 0x04002D1B RID: 11547
		public const int TypeFieldNumber = 13;

		// Token: 0x04002D1C RID: 11548
		private LobbyModifyType type_;
	}
}
