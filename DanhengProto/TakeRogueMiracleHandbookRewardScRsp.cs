using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200132F RID: 4911
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueMiracleHandbookRewardScRsp : IMessage<TakeRogueMiracleHandbookRewardScRsp>, IMessage, IEquatable<TakeRogueMiracleHandbookRewardScRsp>, IDeepCloneable<TakeRogueMiracleHandbookRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600DB22 RID: 56098 RVA: 0x00247A7B File Offset: 0x00245C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueMiracleHandbookRewardScRsp> Parser
		{
			get
			{
				return TakeRogueMiracleHandbookRewardScRsp._parser;
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600DB23 RID: 56099 RVA: 0x00247A82 File Offset: 0x00245C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueMiracleHandbookRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x00247A94 File Offset: 0x00245C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueMiracleHandbookRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00247A9B File Offset: 0x00245C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardScRsp()
		{
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x00247AB0 File Offset: 0x00245CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardScRsp(TakeRogueMiracleHandbookRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.pMKNBMIMHOA_ = other.pMKNBMIMHOA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00247B0D File Offset: 0x00245D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueMiracleHandbookRewardScRsp Clone()
		{
			return new TakeRogueMiracleHandbookRewardScRsp(this);
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x00247B15 File Offset: 0x00245D15
		// (set) Token: 0x0600DB29 RID: 56105 RVA: 0x00247B1D File Offset: 0x00245D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x00247B26 File Offset: 0x00245D26
		// (set) Token: 0x0600DB2B RID: 56107 RVA: 0x00247B2E File Offset: 0x00245D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600DB2C RID: 56108 RVA: 0x00247B37 File Offset: 0x00245D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PMKNBMIMHOA
		{
			get
			{
				return this.pMKNBMIMHOA_;
			}
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x00247B3F File Offset: 0x00245D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueMiracleHandbookRewardScRsp);
		}

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00247B50 File Offset: 0x00245D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueMiracleHandbookRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.pMKNBMIMHOA_.Equals(other.pMKNBMIMHOA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00247BB4 File Offset: 0x00245DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pMKNBMIMHOA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00247C17 File Offset: 0x00245E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x00247C1F File Offset: 0x00245E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00247C28 File Offset: 0x00245E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.pMKNBMIMHOA_.WriteTo(ref output, TakeRogueMiracleHandbookRewardScRsp._repeated_pMKNBMIMHOA_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x00247C94 File Offset: 0x00245E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pMKNBMIMHOA_.CalculateSize(TakeRogueMiracleHandbookRewardScRsp._repeated_pMKNBMIMHOA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB34 RID: 56116 RVA: 0x00247D00 File Offset: 0x00245F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueMiracleHandbookRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pMKNBMIMHOA_.Add(other.pMKNBMIMHOA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB35 RID: 56117 RVA: 0x00247D79 File Offset: 0x00245F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00247D84 File Offset: 0x00245F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 10U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.pMKNBMIMHOA_.AddEntriesFrom(ref input, TakeRogueMiracleHandbookRewardScRsp._repeated_pMKNBMIMHOA_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005740 RID: 22336
		private static readonly MessageParser<TakeRogueMiracleHandbookRewardScRsp> _parser = new MessageParser<TakeRogueMiracleHandbookRewardScRsp>(() => new TakeRogueMiracleHandbookRewardScRsp());

		// Token: 0x04005741 RID: 22337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005742 RID: 22338
		public const int RewardFieldNumber = 1;

		// Token: 0x04005743 RID: 22339
		private ItemList reward_;

		// Token: 0x04005744 RID: 22340
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04005745 RID: 22341
		private uint retcode_;

		// Token: 0x04005746 RID: 22342
		public const int PMKNBMIMHOAFieldNumber = 14;

		// Token: 0x04005747 RID: 22343
		private static readonly FieldCodec<uint> _repeated_pMKNBMIMHOA_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04005748 RID: 22344
		private readonly RepeatedField<uint> pMKNBMIMHOA_ = new RepeatedField<uint>();
	}
}
