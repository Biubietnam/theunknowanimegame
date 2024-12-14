using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002CD RID: 717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CKFJJBFEAPC : IMessage<CKFJJBFEAPC>, IMessage, IEquatable<CKFJJBFEAPC>, IDeepCloneable<CKFJJBFEAPC>, IBufferMessage
	{
		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0005AE81 File Offset: 0x00059081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CKFJJBFEAPC> Parser
		{
			get
			{
				return CKFJJBFEAPC._parser;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0005AE88 File Offset: 0x00059088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CKFJJBFEAPCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x0005AE9A File Offset: 0x0005909A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CKFJJBFEAPC.Descriptor;
			}
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0005AEA1 File Offset: 0x000590A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKFJJBFEAPC()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0005AEA9 File Offset: 0x000590A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKFJJBFEAPC(CKFJJBFEAPC other) : this()
		{
			this.state_ = other.state_;
			this.eventId_ = other.eventId_;
			this.iMDJGMHFEFJ_ = other.iMDJGMHFEFJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0005AEE6 File Offset: 0x000590E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKFJJBFEAPC Clone()
		{
			return new CKFJJBFEAPC(this);
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x0005AEEE File Offset: 0x000590EE
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x0005AEF6 File Offset: 0x000590F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0005AEFF File Offset: 0x000590FF
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x0005AF07 File Offset: 0x00059107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x0005AF10 File Offset: 0x00059110
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x0005AF18 File Offset: 0x00059118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IMDJGMHFEFJ
		{
			get
			{
				return this.iMDJGMHFEFJ_;
			}
			set
			{
				this.iMDJGMHFEFJ_ = value;
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0005AF21 File Offset: 0x00059121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CKFJJBFEAPC);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0005AF30 File Offset: 0x00059130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CKFJJBFEAPC other)
		{
			return other != null && (other == this || (this.State == other.State && this.EventId == other.EventId && this.IMDJGMHFEFJ == other.IMDJGMHFEFJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0005AF8C File Offset: 0x0005918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != AlleyEventState.AlleyStateNone)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.IMDJGMHFEFJ != 0U)
			{
				num ^= this.IMDJGMHFEFJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0005B003 File Offset: 0x00059203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0005B00B File Offset: 0x0005920B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0005B014 File Offset: 0x00059214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EventId);
			}
			if (this.State != AlleyEventState.AlleyStateNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.IMDJGMHFEFJ != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.IMDJGMHFEFJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0005B088 File Offset: 0x00059288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != AlleyEventState.AlleyStateNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.IMDJGMHFEFJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IMDJGMHFEFJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0005B0F8 File Offset: 0x000592F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CKFJJBFEAPC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != AlleyEventState.AlleyStateNone)
			{
				this.State = other.State;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.IMDJGMHFEFJ != 0U)
			{
				this.IMDJGMHFEFJ = other.IMDJGMHFEFJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0005B15C File Offset: 0x0005935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0005B168 File Offset: 0x00059368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IMDJGMHFEFJ = input.ReadUInt32();
						}
					}
					else
					{
						this.State = (AlleyEventState)input.ReadEnum();
					}
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D39 RID: 3385
		private static readonly MessageParser<CKFJJBFEAPC> _parser = new MessageParser<CKFJJBFEAPC>(() => new CKFJJBFEAPC());

		// Token: 0x04000D3A RID: 3386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D3B RID: 3387
		public const int StateFieldNumber = 2;

		// Token: 0x04000D3C RID: 3388
		private AlleyEventState state_;

		// Token: 0x04000D3D RID: 3389
		public const int EventIdFieldNumber = 1;

		// Token: 0x04000D3E RID: 3390
		private uint eventId_;

		// Token: 0x04000D3F RID: 3391
		public const int IMDJGMHFEFJFieldNumber = 10;

		// Token: 0x04000D40 RID: 3392
		private uint iMDJGMHFEFJ_;
	}
}
