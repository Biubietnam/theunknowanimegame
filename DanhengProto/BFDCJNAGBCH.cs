using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000117 RID: 279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BFDCJNAGBCH : IMessage<BFDCJNAGBCH>, IMessage, IEquatable<BFDCJNAGBCH>, IDeepCloneable<BFDCJNAGBCH>, IBufferMessage
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00025EEC File Offset: 0x000240EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BFDCJNAGBCH> Parser
		{
			get
			{
				return BFDCJNAGBCH._parser;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00025EF3 File Offset: 0x000240F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BFDCJNAGBCHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00025F05 File Offset: 0x00024105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BFDCJNAGBCH.Descriptor;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00025F0C File Offset: 0x0002410C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFDCJNAGBCH()
		{
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00025F14 File Offset: 0x00024114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFDCJNAGBCH(BFDCJNAGBCH other) : this()
		{
			this.lHAAFBELDPB_ = other.lHAAFBELDPB_;
			this.hasTakenReward_ = other.hasTakenReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00025F45 File Offset: 0x00024145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFDCJNAGBCH Clone()
		{
			return new BFDCJNAGBCH(this);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00025F4D File Offset: 0x0002414D
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00025F55 File Offset: 0x00024155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LHAAFBELDPB
		{
			get
			{
				return this.lHAAFBELDPB_;
			}
			set
			{
				this.lHAAFBELDPB_ = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00025F5E File Offset: 0x0002415E
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00025F66 File Offset: 0x00024166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTakenReward
		{
			get
			{
				return this.hasTakenReward_;
			}
			set
			{
				this.hasTakenReward_ = value;
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00025F6F File Offset: 0x0002416F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BFDCJNAGBCH);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00025F7D File Offset: 0x0002417D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BFDCJNAGBCH other)
		{
			return other != null && (other == this || (this.LHAAFBELDPB == other.LHAAFBELDPB && this.HasTakenReward == other.HasTakenReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00025FBC File Offset: 0x000241BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LHAAFBELDPB != 0U)
			{
				num ^= this.LHAAFBELDPB.GetHashCode();
			}
			if (this.HasTakenReward)
			{
				num ^= this.HasTakenReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00026014 File Offset: 0x00024214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0002601C File Offset: 0x0002421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00026028 File Offset: 0x00024228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LHAAFBELDPB != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.LHAAFBELDPB);
			}
			if (this.HasTakenReward)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.HasTakenReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00026080 File Offset: 0x00024280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LHAAFBELDPB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LHAAFBELDPB);
			}
			if (this.HasTakenReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000260CC File Offset: 0x000242CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BFDCJNAGBCH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LHAAFBELDPB != 0U)
			{
				this.LHAAFBELDPB = other.LHAAFBELDPB;
			}
			if (other.HasTakenReward)
			{
				this.HasTakenReward = other.HasTakenReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0002611C File Offset: 0x0002431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00026128 File Offset: 0x00024328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HasTakenReward = input.ReadBool();
					}
				}
				else
				{
					this.LHAAFBELDPB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400057D RID: 1405
		private static readonly MessageParser<BFDCJNAGBCH> _parser = new MessageParser<BFDCJNAGBCH>(() => new BFDCJNAGBCH());

		// Token: 0x0400057E RID: 1406
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400057F RID: 1407
		public const int LHAAFBELDPBFieldNumber = 1;

		// Token: 0x04000580 RID: 1408
		private uint lHAAFBELDPB_;

		// Token: 0x04000581 RID: 1409
		public const int HasTakenRewardFieldNumber = 6;

		// Token: 0x04000582 RID: 1410
		private bool hasTakenReward_;
	}
}
