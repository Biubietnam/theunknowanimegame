using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A59 RID: 2649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockRelicCsReq : IMessage<LockRelicCsReq>, IMessage, IEquatable<LockRelicCsReq>, IDeepCloneable<LockRelicCsReq>, IBufferMessage
	{
		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x00137E7D File Offset: 0x0013607D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockRelicCsReq> Parser
		{
			get
			{
				return LockRelicCsReq._parser;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06007572 RID: 30066 RVA: 0x00137E84 File Offset: 0x00136084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LockRelicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06007573 RID: 30067 RVA: 0x00137E96 File Offset: 0x00136096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LockRelicCsReq.Descriptor;
			}
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00137E9D File Offset: 0x0013609D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicCsReq()
		{
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00137EB0 File Offset: 0x001360B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicCsReq(LockRelicCsReq other) : this()
		{
			this.isProtected_ = other.isProtected_;
			this.relicUniqueIdList_ = other.relicUniqueIdList_.Clone();
			this.oKKJFIBNGCE_ = other.oKKJFIBNGCE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00137EFD File Offset: 0x001360FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicCsReq Clone()
		{
			return new LockRelicCsReq(this);
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06007577 RID: 30071 RVA: 0x00137F05 File Offset: 0x00136105
		// (set) Token: 0x06007578 RID: 30072 RVA: 0x00137F0D File Offset: 0x0013610D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsProtected
		{
			get
			{
				return this.isProtected_;
			}
			set
			{
				this.isProtected_ = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x00137F16 File Offset: 0x00136116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> RelicUniqueIdList
		{
			get
			{
				return this.relicUniqueIdList_;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x00137F1E File Offset: 0x0013611E
		// (set) Token: 0x0600757B RID: 30075 RVA: 0x00137F26 File Offset: 0x00136126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OKKJFIBNGCE
		{
			get
			{
				return this.oKKJFIBNGCE_;
			}
			set
			{
				this.oKKJFIBNGCE_ = value;
			}
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00137F2F File Offset: 0x0013612F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LockRelicCsReq);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00137F40 File Offset: 0x00136140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LockRelicCsReq other)
		{
			return other != null && (other == this || (this.IsProtected == other.IsProtected && this.relicUniqueIdList_.Equals(other.relicUniqueIdList_) && this.OKKJFIBNGCE == other.OKKJFIBNGCE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x00137FA0 File Offset: 0x001361A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsProtected)
			{
				num ^= this.IsProtected.GetHashCode();
			}
			num ^= this.relicUniqueIdList_.GetHashCode();
			if (this.OKKJFIBNGCE)
			{
				num ^= this.OKKJFIBNGCE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00138006 File Offset: 0x00136206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0013800E File Offset: 0x0013620E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00138018 File Offset: 0x00136218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKKJFIBNGCE)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.OKKJFIBNGCE);
			}
			this.relicUniqueIdList_.WriteTo(ref output, LockRelicCsReq._repeated_relicUniqueIdList_codec);
			if (this.IsProtected)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsProtected);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x00138084 File Offset: 0x00136284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsProtected)
			{
				num += 2;
			}
			num += this.relicUniqueIdList_.CalculateSize(LockRelicCsReq._repeated_relicUniqueIdList_codec);
			if (this.OKKJFIBNGCE)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x001380D8 File Offset: 0x001362D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LockRelicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsProtected)
			{
				this.IsProtected = other.IsProtected;
			}
			this.relicUniqueIdList_.Add(other.relicUniqueIdList_);
			if (other.OKKJFIBNGCE)
			{
				this.OKKJFIBNGCE = other.OKKJFIBNGCE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00138139 File Offset: 0x00136339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00138144 File Offset: 0x00136344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.OKKJFIBNGCE = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_3F;
					}
					if (num == 104U)
					{
						this.IsProtected = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.relicUniqueIdList_.AddEntriesFrom(ref input, LockRelicCsReq._repeated_relicUniqueIdList_codec);
			}
		}

		// Token: 0x04002D2B RID: 11563
		private static readonly MessageParser<LockRelicCsReq> _parser = new MessageParser<LockRelicCsReq>(() => new LockRelicCsReq());

		// Token: 0x04002D2C RID: 11564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D2D RID: 11565
		public const int IsProtectedFieldNumber = 13;

		// Token: 0x04002D2E RID: 11566
		private bool isProtected_;

		// Token: 0x04002D2F RID: 11567
		public const int RelicUniqueIdListFieldNumber = 8;

		// Token: 0x04002D30 RID: 11568
		private static readonly FieldCodec<uint> _repeated_relicUniqueIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04002D31 RID: 11569
		private readonly RepeatedField<uint> relicUniqueIdList_ = new RepeatedField<uint>();

		// Token: 0x04002D32 RID: 11570
		public const int OKKJFIBNGCEFieldNumber = 2;

		// Token: 0x04002D33 RID: 11571
		private bool oKKJFIBNGCE_;
	}
}
