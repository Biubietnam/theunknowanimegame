using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001331 RID: 4913
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueScoreRewardCsReq : IMessage<TakeRogueScoreRewardCsReq>, IMessage, IEquatable<TakeRogueScoreRewardCsReq>, IDeepCloneable<TakeRogueScoreRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600DB3A RID: 56122 RVA: 0x00247EB5 File Offset: 0x002460B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueScoreRewardCsReq> Parser
		{
			get
			{
				return TakeRogueScoreRewardCsReq._parser;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600DB3B RID: 56123 RVA: 0x00247EBC File Offset: 0x002460BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueScoreRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600DB3C RID: 56124 RVA: 0x00247ECE File Offset: 0x002460CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueScoreRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x00247ED5 File Offset: 0x002460D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardCsReq()
		{
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00247EE8 File Offset: 0x002460E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardCsReq(TakeRogueScoreRewardCsReq other) : this()
		{
			this.poolId_ = other.poolId_;
			this.nFEJLGEFBPL_ = other.nFEJLGEFBPL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x00247F1E File Offset: 0x0024611E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardCsReq Clone()
		{
			return new TakeRogueScoreRewardCsReq(this);
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600DB40 RID: 56128 RVA: 0x00247F26 File Offset: 0x00246126
		// (set) Token: 0x0600DB41 RID: 56129 RVA: 0x00247F2E File Offset: 0x0024612E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600DB42 RID: 56130 RVA: 0x00247F37 File Offset: 0x00246137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NFEJLGEFBPL
		{
			get
			{
				return this.nFEJLGEFBPL_;
			}
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x00247F3F File Offset: 0x0024613F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueScoreRewardCsReq);
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x00247F50 File Offset: 0x00246150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueScoreRewardCsReq other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && this.nFEJLGEFBPL_.Equals(other.nFEJLGEFBPL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB45 RID: 56133 RVA: 0x00247FA0 File Offset: 0x002461A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			num ^= this.nFEJLGEFBPL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB46 RID: 56134 RVA: 0x00247FED File Offset: 0x002461ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB47 RID: 56135 RVA: 0x00247FF5 File Offset: 0x002461F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB48 RID: 56136 RVA: 0x00248000 File Offset: 0x00246200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PoolId);
			}
			this.nFEJLGEFBPL_.WriteTo(ref output, TakeRogueScoreRewardCsReq._repeated_nFEJLGEFBPL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x00248050 File Offset: 0x00246250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			num += this.nFEJLGEFBPL_.CalculateSize(TakeRogueScoreRewardCsReq._repeated_nFEJLGEFBPL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB4A RID: 56138 RVA: 0x002480A4 File Offset: 0x002462A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueScoreRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this.nFEJLGEFBPL_.Add(other.nFEJLGEFBPL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB4B RID: 56139 RVA: 0x002480F1 File Offset: 0x002462F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x002480FC File Offset: 0x002462FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.nFEJLGEFBPL_.AddEntriesFrom(ref input, TakeRogueScoreRewardCsReq._repeated_nFEJLGEFBPL_codec);
					}
				}
				else
				{
					this.PoolId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400574A RID: 22346
		private static readonly MessageParser<TakeRogueScoreRewardCsReq> _parser = new MessageParser<TakeRogueScoreRewardCsReq>(() => new TakeRogueScoreRewardCsReq());

		// Token: 0x0400574B RID: 22347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400574C RID: 22348
		public const int PoolIdFieldNumber = 3;

		// Token: 0x0400574D RID: 22349
		private uint poolId_;

		// Token: 0x0400574E RID: 22350
		public const int NFEJLGEFBPLFieldNumber = 8;

		// Token: 0x0400574F RID: 22351
		private static readonly FieldCodec<uint> _repeated_nFEJLGEFBPL_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005750 RID: 22352
		private readonly RepeatedField<uint> nFEJLGEFBPL_ = new RepeatedField<uint>();
	}
}
