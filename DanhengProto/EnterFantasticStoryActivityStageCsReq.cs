using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000443 RID: 1091
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFantasticStoryActivityStageCsReq : IMessage<EnterFantasticStoryActivityStageCsReq>, IMessage, IEquatable<EnterFantasticStoryActivityStageCsReq>, IDeepCloneable<EnterFantasticStoryActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x00084F3B File Offset: 0x0008313B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFantasticStoryActivityStageCsReq> Parser
		{
			get
			{
				return EnterFantasticStoryActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x00084F42 File Offset: 0x00083142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFantasticStoryActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x00084F54 File Offset: 0x00083154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFantasticStoryActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00084F5B File Offset: 0x0008315B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageCsReq()
		{
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00084F7C File Offset: 0x0008317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageCsReq(EnterFantasticStoryActivityStageCsReq other) : this()
		{
			this.kLANEABKELD_ = other.kLANEABKELD_;
			this.avatarList_ = other.avatarList_.Clone();
			this.buffList_ = other.buffList_.Clone();
			this.battleId_ = other.battleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00084FDA File Offset: 0x000831DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFantasticStoryActivityStageCsReq Clone()
		{
			return new EnterFantasticStoryActivityStageCsReq(this);
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x00084FE2 File Offset: 0x000831E2
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x00084FEA File Offset: 0x000831EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLANEABKELD
		{
			get
			{
				return this.kLANEABKELD_;
			}
			set
			{
				this.kLANEABKELD_ = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x00084FF3 File Offset: 0x000831F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ALLFKPIPPDH> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x00084FFB File Offset: 0x000831FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x00085003 File Offset: 0x00083203
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x0008500B File Offset: 0x0008320B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00085014 File Offset: 0x00083214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFantasticStoryActivityStageCsReq);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00085024 File Offset: 0x00083224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFantasticStoryActivityStageCsReq other)
		{
			return other != null && (other == this || (this.KLANEABKELD == other.KLANEABKELD && this.avatarList_.Equals(other.avatarList_) && this.buffList_.Equals(other.buffList_) && this.BattleId == other.BattleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00085098 File Offset: 0x00083298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KLANEABKELD != 0U)
			{
				num ^= this.KLANEABKELD.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			num ^= this.buffList_.GetHashCode();
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0008510C File Offset: 0x0008330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00085114 File Offset: 0x00083314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00085120 File Offset: 0x00083320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, EnterFantasticStoryActivityStageCsReq._repeated_avatarList_codec);
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BattleId);
			}
			this.buffList_.WriteTo(ref output, EnterFantasticStoryActivityStageCsReq._repeated_buffList_codec);
			if (this.KLANEABKELD != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.KLANEABKELD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0008519C File Offset: 0x0008339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KLANEABKELD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLANEABKELD);
			}
			num += this.avatarList_.CalculateSize(EnterFantasticStoryActivityStageCsReq._repeated_avatarList_codec);
			num += this.buffList_.CalculateSize(EnterFantasticStoryActivityStageCsReq._repeated_buffList_codec);
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00085218 File Offset: 0x00083418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFantasticStoryActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KLANEABKELD != 0U)
			{
				this.KLANEABKELD = other.KLANEABKELD;
			}
			this.avatarList_.Add(other.avatarList_);
			this.buffList_.Add(other.buffList_);
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0008528A File Offset: 0x0008348A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00085294 File Offset: 0x00083494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterFantasticStoryActivityStageCsReq._repeated_avatarList_codec);
						continue;
					}
					if (num == 24U)
					{
						this.BattleId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U || num == 114U)
					{
						this.buffList_.AddEntriesFrom(ref input, EnterFantasticStoryActivityStageCsReq._repeated_buffList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.KLANEABKELD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001340 RID: 4928
		private static readonly MessageParser<EnterFantasticStoryActivityStageCsReq> _parser = new MessageParser<EnterFantasticStoryActivityStageCsReq>(() => new EnterFantasticStoryActivityStageCsReq());

		// Token: 0x04001341 RID: 4929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001342 RID: 4930
		public const int KLANEABKELDFieldNumber = 15;

		// Token: 0x04001343 RID: 4931
		private uint kLANEABKELD_;

		// Token: 0x04001344 RID: 4932
		public const int AvatarListFieldNumber = 1;

		// Token: 0x04001345 RID: 4933
		private static readonly FieldCodec<ALLFKPIPPDH> _repeated_avatarList_codec = FieldCodec.ForMessage<ALLFKPIPPDH>(10U, ALLFKPIPPDH.Parser);

		// Token: 0x04001346 RID: 4934
		private readonly RepeatedField<ALLFKPIPPDH> avatarList_ = new RepeatedField<ALLFKPIPPDH>();

		// Token: 0x04001347 RID: 4935
		public const int BuffListFieldNumber = 14;

		// Token: 0x04001348 RID: 4936
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04001349 RID: 4937
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

		// Token: 0x0400134A RID: 4938
		public const int BattleIdFieldNumber = 3;

		// Token: 0x0400134B RID: 4939
		private uint battleId_;
	}
}
