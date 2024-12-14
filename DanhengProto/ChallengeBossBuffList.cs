using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000195 RID: 405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossBuffList : IMessage<ChallengeBossBuffList>, IMessage, IEquatable<ChallengeBossBuffList>, IDeepCloneable<ChallengeBossBuffList>, IBufferMessage
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00034061 File Offset: 0x00032261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossBuffList> Parser
		{
			get
			{
				return ChallengeBossBuffList._parser;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00034068 File Offset: 0x00032268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossBuffListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0003407A File Offset: 0x0003227A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossBuffList.Descriptor;
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00034081 File Offset: 0x00032281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffList()
		{
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00034094 File Offset: 0x00032294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffList(ChallengeBossBuffList other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this.challengeBossConst_ = other.challengeBossConst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000340CA File Offset: 0x000322CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffList Clone()
		{
			return new ChallengeBossBuffList(this);
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000340D2 File Offset: 0x000322D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000340DA File Offset: 0x000322DA
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x000340E2 File Offset: 0x000322E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeBossConst
		{
			get
			{
				return this.challengeBossConst_;
			}
			set
			{
				this.challengeBossConst_ = value;
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000340EB File Offset: 0x000322EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossBuffList);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000340FC File Offset: 0x000322FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossBuffList other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && this.ChallengeBossConst == other.ChallengeBossConst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0003414C File Offset: 0x0003234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			if (this.ChallengeBossConst != 0U)
			{
				num ^= this.ChallengeBossConst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00034199 File Offset: 0x00032399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000341A1 File Offset: 0x000323A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000341AC File Offset: 0x000323AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, ChallengeBossBuffList._repeated_buffList_codec);
			if (this.ChallengeBossConst != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ChallengeBossConst);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000341FC File Offset: 0x000323FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(ChallengeBossBuffList._repeated_buffList_codec);
			if (this.ChallengeBossConst != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeBossConst);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00034250 File Offset: 0x00032450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossBuffList other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			if (other.ChallengeBossConst != 0U)
			{
				this.ChallengeBossConst = other.ChallengeBossConst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0003429D File Offset: 0x0003249D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000342A8 File Offset: 0x000324A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeBossConst = input.ReadUInt32();
					}
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, ChallengeBossBuffList._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x04000795 RID: 1941
		private static readonly MessageParser<ChallengeBossBuffList> _parser = new MessageParser<ChallengeBossBuffList>(() => new ChallengeBossBuffList());

		// Token: 0x04000796 RID: 1942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000797 RID: 1943
		public const int BuffListFieldNumber = 6;

		// Token: 0x04000798 RID: 1944
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04000799 RID: 1945
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

		// Token: 0x0400079A RID: 1946
		public const int ChallengeBossConstFieldNumber = 9;

		// Token: 0x0400079B RID: 1947
		private uint challengeBossConst_;
	}
}
