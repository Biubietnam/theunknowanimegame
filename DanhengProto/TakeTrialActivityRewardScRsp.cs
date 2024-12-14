using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001343 RID: 4931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTrialActivityRewardScRsp : IMessage<TakeTrialActivityRewardScRsp>, IMessage, IEquatable<TakeTrialActivityRewardScRsp>, IDeepCloneable<TakeTrialActivityRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600DC0D RID: 56333 RVA: 0x00249FE3 File Offset: 0x002481E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTrialActivityRewardScRsp> Parser
		{
			get
			{
				return TakeTrialActivityRewardScRsp._parser;
			}
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600DC0E RID: 56334 RVA: 0x00249FEA File Offset: 0x002481EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTrialActivityRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600DC0F RID: 56335 RVA: 0x00249FFC File Offset: 0x002481FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTrialActivityRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x0024A003 File Offset: 0x00248203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardScRsp()
		{
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x0024A00C File Offset: 0x0024820C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardScRsp(TakeTrialActivityRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.stageId_ = other.stageId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x0024A064 File Offset: 0x00248264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTrialActivityRewardScRsp Clone()
		{
			return new TakeTrialActivityRewardScRsp(this);
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600DC13 RID: 56339 RVA: 0x0024A06C File Offset: 0x0024826C
		// (set) Token: 0x0600DC14 RID: 56340 RVA: 0x0024A074 File Offset: 0x00248274
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

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600DC15 RID: 56341 RVA: 0x0024A07D File Offset: 0x0024827D
		// (set) Token: 0x0600DC16 RID: 56342 RVA: 0x0024A085 File Offset: 0x00248285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600DC17 RID: 56343 RVA: 0x0024A08E File Offset: 0x0024828E
		// (set) Token: 0x0600DC18 RID: 56344 RVA: 0x0024A096 File Offset: 0x00248296
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

		// Token: 0x0600DC19 RID: 56345 RVA: 0x0024A09F File Offset: 0x0024829F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTrialActivityRewardScRsp);
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x0024A0B0 File Offset: 0x002482B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTrialActivityRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.StageId == other.StageId && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC1B RID: 56347 RVA: 0x0024A110 File Offset: 0x00248310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC1C RID: 56348 RVA: 0x0024A17E File Offset: 0x0024837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC1D RID: 56349 RVA: 0x0024A186 File Offset: 0x00248386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x0024A190 File Offset: 0x00248390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x0024A208 File Offset: 0x00248408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC20 RID: 56352 RVA: 0x0024A278 File Offset: 0x00248478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTrialActivityRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC21 RID: 56353 RVA: 0x0024A2F4 File Offset: 0x002484F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC22 RID: 56354 RVA: 0x0024A300 File Offset: 0x00248500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StageId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x04005791 RID: 22417
		private static readonly MessageParser<TakeTrialActivityRewardScRsp> _parser = new MessageParser<TakeTrialActivityRewardScRsp>(() => new TakeTrialActivityRewardScRsp());

		// Token: 0x04005792 RID: 22418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005793 RID: 22419
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005794 RID: 22420
		private uint retcode_;

		// Token: 0x04005795 RID: 22421
		public const int StageIdFieldNumber = 9;

		// Token: 0x04005796 RID: 22422
		private uint stageId_;

		// Token: 0x04005797 RID: 22423
		public const int RewardFieldNumber = 2;

		// Token: 0x04005798 RID: 22424
		private ItemList reward_;
	}
}
