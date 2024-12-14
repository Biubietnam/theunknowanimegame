using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F7 RID: 503
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCheatRollCsReq : IMessage<ChessRogueCheatRollCsReq>, IMessage, IEquatable<ChessRogueCheatRollCsReq>, IDeepCloneable<ChessRogueCheatRollCsReq>, IBufferMessage
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x0004060D File Offset: 0x0003E80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCheatRollCsReq> Parser
		{
			get
			{
				return ChessRogueCheatRollCsReq._parser;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00040614 File Offset: 0x0003E814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCheatRollCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00040626 File Offset: 0x0003E826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCheatRollCsReq.Descriptor;
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0004062D File Offset: 0x0003E82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollCsReq()
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00040635 File Offset: 0x0003E835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollCsReq(ChessRogueCheatRollCsReq other) : this()
		{
			this.diceSurfaceId_ = other.diceSurfaceId_;
			this.oKCOHJJEEAA_ = other.oKCOHJJEEAA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00040666 File Offset: 0x0003E866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollCsReq Clone()
		{
			return new ChessRogueCheatRollCsReq(this);
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x0004066E File Offset: 0x0003E86E
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00040676 File Offset: 0x0003E876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSurfaceId
		{
			get
			{
				return this.diceSurfaceId_;
			}
			set
			{
				this.diceSurfaceId_ = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x0004067F File Offset: 0x0003E87F
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00040687 File Offset: 0x0003E887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKCOHJJEEAA
		{
			get
			{
				return this.oKCOHJJEEAA_;
			}
			set
			{
				this.oKCOHJJEEAA_ = value;
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00040690 File Offset: 0x0003E890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCheatRollCsReq);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0004069E File Offset: 0x0003E89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCheatRollCsReq other)
		{
			return other != null && (other == this || (this.DiceSurfaceId == other.DiceSurfaceId && this.OKCOHJJEEAA == other.OKCOHJJEEAA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000406DC File Offset: 0x0003E8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiceSurfaceId != 0U)
			{
				num ^= this.DiceSurfaceId.GetHashCode();
			}
			if (this.OKCOHJJEEAA != 0U)
			{
				num ^= this.OKCOHJJEEAA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00040734 File Offset: 0x0003E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0004073C File Offset: 0x0003E93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00040748 File Offset: 0x0003E948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKCOHJJEEAA != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.OKCOHJJEEAA);
			}
			if (this.DiceSurfaceId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DiceSurfaceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000407A4 File Offset: 0x0003E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiceSurfaceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSurfaceId);
			}
			if (this.OKCOHJJEEAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000407FC File Offset: 0x0003E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCheatRollCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiceSurfaceId != 0U)
			{
				this.DiceSurfaceId = other.DiceSurfaceId;
			}
			if (other.OKCOHJJEEAA != 0U)
			{
				this.OKCOHJJEEAA = other.OKCOHJJEEAA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0004084C File Offset: 0x0003EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00040858 File Offset: 0x0003EA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DiceSurfaceId = input.ReadUInt32();
					}
				}
				else
				{
					this.OKCOHJJEEAA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400097D RID: 2429
		private static readonly MessageParser<ChessRogueCheatRollCsReq> _parser = new MessageParser<ChessRogueCheatRollCsReq>(() => new ChessRogueCheatRollCsReq());

		// Token: 0x0400097E RID: 2430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400097F RID: 2431
		public const int DiceSurfaceIdFieldNumber = 6;

		// Token: 0x04000980 RID: 2432
		private uint diceSurfaceId_;

		// Token: 0x04000981 RID: 2433
		public const int OKCOHJJEEAAFieldNumber = 2;

		// Token: 0x04000982 RID: 2434
		private uint oKCOHJJEEAA_;
	}
}
