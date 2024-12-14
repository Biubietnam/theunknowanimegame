using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001367 RID: 4967
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrainVisitorRewardSendNotify : IMessage<TrainVisitorRewardSendNotify>, IMessage, IEquatable<TrainVisitorRewardSendNotify>, IDeepCloneable<TrainVisitorRewardSendNotify>, IBufferMessage
	{
		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600DDA2 RID: 56738 RVA: 0x0024E023 File Offset: 0x0024C223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrainVisitorRewardSendNotify> Parser
		{
			get
			{
				return TrainVisitorRewardSendNotify._parser;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600DDA3 RID: 56739 RVA: 0x0024E02A File Offset: 0x0024C22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrainVisitorRewardSendNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600DDA4 RID: 56740 RVA: 0x0024E03C File Offset: 0x0024C23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrainVisitorRewardSendNotify.Descriptor;
			}
		}

		// Token: 0x0600DDA5 RID: 56741 RVA: 0x0024E043 File Offset: 0x0024C243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorRewardSendNotify()
		{
		}

		// Token: 0x0600DDA6 RID: 56742 RVA: 0x0024E04C File Offset: 0x0024C24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorRewardSendNotify(TrainVisitorRewardSendNotify other) : this()
		{
			this.type_ = other.type_;
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDA7 RID: 56743 RVA: 0x0024E0A4 File Offset: 0x0024C2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorRewardSendNotify Clone()
		{
			return new TrainVisitorRewardSendNotify(this);
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x0024E0AC File Offset: 0x0024C2AC
		// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x0024E0B4 File Offset: 0x0024C2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFHIAMADHKF Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x0024E0BD File Offset: 0x0024C2BD
		// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x0024E0C5 File Offset: 0x0024C2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x0024E0CE File Offset: 0x0024C2CE
		// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x0024E0D6 File Offset: 0x0024C2D6
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

		// Token: 0x0600DDAE RID: 56750 RVA: 0x0024E0DF File Offset: 0x0024C2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrainVisitorRewardSendNotify);
		}

		// Token: 0x0600DDAF RID: 56751 RVA: 0x0024E0F0 File Offset: 0x0024C2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrainVisitorRewardSendNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.DJLKCHKMNMI == other.DJLKCHKMNMI && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDB0 RID: 56752 RVA: 0x0024E150 File Offset: 0x0024C350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != KFHIAMADHKF.TrainVisitorRewardSendNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
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

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x0024E1C4 File Offset: 0x0024C3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x0024E1CC File Offset: 0x0024C3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDB3 RID: 56755 RVA: 0x0024E1D8 File Offset: 0x0024C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != KFHIAMADHKF.TrainVisitorRewardSendNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x0024E250 File Offset: 0x0024C450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != KFHIAMADHKF.TrainVisitorRewardSendNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
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

		// Token: 0x0600DDB5 RID: 56757 RVA: 0x0024E2C0 File Offset: 0x0024C4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrainVisitorRewardSendNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != KFHIAMADHKF.TrainVisitorRewardSendNone)
			{
				this.Type = other.Type;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
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

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x0024E33C File Offset: 0x0024C53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDB7 RID: 56759 RVA: 0x0024E348 File Offset: 0x0024C548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.DJLKCHKMNMI = input.ReadUInt32();
					}
				}
				else
				{
					this.Type = (KFHIAMADHKF)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005826 RID: 22566
		private static readonly MessageParser<TrainVisitorRewardSendNotify> _parser = new MessageParser<TrainVisitorRewardSendNotify>(() => new TrainVisitorRewardSendNotify());

		// Token: 0x04005827 RID: 22567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005828 RID: 22568
		public const int TypeFieldNumber = 2;

		// Token: 0x04005829 RID: 22569
		private KFHIAMADHKF type_;

		// Token: 0x0400582A RID: 22570
		public const int DJLKCHKMNMIFieldNumber = 11;

		// Token: 0x0400582B RID: 22571
		private uint dJLKCHKMNMI_;

		// Token: 0x0400582C RID: 22572
		public const int RewardFieldNumber = 13;

		// Token: 0x0400582D RID: 22573
		private ItemList reward_;
	}
}
