using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012AD RID: 4781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeActivityExpeditionRewardScRsp : IMessage<TakeActivityExpeditionRewardScRsp>, IMessage, IEquatable<TakeActivityExpeditionRewardScRsp>, IDeepCloneable<TakeActivityExpeditionRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600D540 RID: 54592 RVA: 0x00239287 File Offset: 0x00237487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeActivityExpeditionRewardScRsp> Parser
		{
			get
			{
				return TakeActivityExpeditionRewardScRsp._parser;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600D541 RID: 54593 RVA: 0x0023928E File Offset: 0x0023748E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeActivityExpeditionRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x002392A0 File Offset: 0x002374A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeActivityExpeditionRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x002392A7 File Offset: 0x002374A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardScRsp()
		{
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x002392B0 File Offset: 0x002374B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardScRsp(TakeActivityExpeditionRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.hADKPJOKKCM_ = other.hADKPJOKKCM_;
			this.kCGOBOKNMFH_ = ((other.kCGOBOKNMFH_ != null) ? other.kCGOBOKNMFH_.Clone() : null);
			this.scoreId_ = other.scoreId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x00239330 File Offset: 0x00237530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardScRsp Clone()
		{
			return new TakeActivityExpeditionRewardScRsp(this);
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x00239338 File Offset: 0x00237538
		// (set) Token: 0x0600D547 RID: 54599 RVA: 0x00239340 File Offset: 0x00237540
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x00239349 File Offset: 0x00237549
		// (set) Token: 0x0600D549 RID: 54601 RVA: 0x00239351 File Offset: 0x00237551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HADKPJOKKCM
		{
			get
			{
				return this.hADKPJOKKCM_;
			}
			set
			{
				this.hADKPJOKKCM_ = value;
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x0023935A File Offset: 0x0023755A
		// (set) Token: 0x0600D54B RID: 54603 RVA: 0x00239362 File Offset: 0x00237562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList KCGOBOKNMFH
		{
			get
			{
				return this.kCGOBOKNMFH_;
			}
			set
			{
				this.kCGOBOKNMFH_ = value;
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600D54C RID: 54604 RVA: 0x0023936B File Offset: 0x0023756B
		// (set) Token: 0x0600D54D RID: 54605 RVA: 0x00239373 File Offset: 0x00237573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600D54E RID: 54606 RVA: 0x0023937C File Offset: 0x0023757C
		// (set) Token: 0x0600D54F RID: 54607 RVA: 0x00239384 File Offset: 0x00237584
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

		// Token: 0x0600D550 RID: 54608 RVA: 0x0023938D File Offset: 0x0023758D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeActivityExpeditionRewardScRsp);
		}

		// Token: 0x0600D551 RID: 54609 RVA: 0x0023939C File Offset: 0x0023759C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeActivityExpeditionRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.HADKPJOKKCM == other.HADKPJOKKCM && object.Equals(this.KCGOBOKNMFH, other.KCGOBOKNMFH) && this.ScoreId == other.ScoreId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x00239420 File Offset: 0x00237620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.HADKPJOKKCM != 0U)
			{
				num ^= this.HADKPJOKKCM.GetHashCode();
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				num ^= this.KCGOBOKNMFH.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x002394BD File Offset: 0x002376BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D554 RID: 54612 RVA: 0x002394C5 File Offset: 0x002376C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x002394D0 File Offset: 0x002376D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HADKPJOKKCM != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.HADKPJOKKCM);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.KCGOBOKNMFH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D556 RID: 54614 RVA: 0x0023957C File Offset: 0x0023777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.HADKPJOKKCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HADKPJOKKCM);
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KCGOBOKNMFH);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x0023961C File Offset: 0x0023781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeActivityExpeditionRewardScRsp other)
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
			if (other.HADKPJOKKCM != 0U)
			{
				this.HADKPJOKKCM = other.HADKPJOKKCM;
			}
			if (other.kCGOBOKNMFH_ != null)
			{
				if (this.kCGOBOKNMFH_ == null)
				{
					this.KCGOBOKNMFH = new ItemList();
				}
				this.KCGOBOKNMFH.MergeFrom(other.KCGOBOKNMFH);
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x002396D8 File Offset: 0x002378D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x002396E4 File Offset: 0x002378E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 8U)
					{
						this.HADKPJOKKCM = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.kCGOBOKNMFH_ == null)
						{
							this.KCGOBOKNMFH = new ItemList();
						}
						input.ReadMessage(this.KCGOBOKNMFH);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005540 RID: 21824
		private static readonly MessageParser<TakeActivityExpeditionRewardScRsp> _parser = new MessageParser<TakeActivityExpeditionRewardScRsp>(() => new TakeActivityExpeditionRewardScRsp());

		// Token: 0x04005541 RID: 21825
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005542 RID: 21826
		public const int RewardFieldNumber = 5;

		// Token: 0x04005543 RID: 21827
		private ItemList reward_;

		// Token: 0x04005544 RID: 21828
		public const int HADKPJOKKCMFieldNumber = 1;

		// Token: 0x04005545 RID: 21829
		private uint hADKPJOKKCM_;

		// Token: 0x04005546 RID: 21830
		public const int KCGOBOKNMFHFieldNumber = 13;

		// Token: 0x04005547 RID: 21831
		private ItemList kCGOBOKNMFH_;

		// Token: 0x04005548 RID: 21832
		public const int ScoreIdFieldNumber = 9;

		// Token: 0x04005549 RID: 21833
		private uint scoreId_;

		// Token: 0x0400554A RID: 21834
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400554B RID: 21835
		private uint retcode_;
	}
}
