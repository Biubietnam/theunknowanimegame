using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001175 RID: 4469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooTakeScRsp : IMessage<SpaceZooTakeScRsp>, IMessage, IEquatable<SpaceZooTakeScRsp>, IDeepCloneable<SpaceZooTakeScRsp>, IBufferMessage
	{
		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600C763 RID: 51043 RVA: 0x002170E1 File Offset: 0x002152E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooTakeScRsp> Parser
		{
			get
			{
				return SpaceZooTakeScRsp._parser;
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x002170E8 File Offset: 0x002152E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooTakeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600C765 RID: 51045 RVA: 0x002170FA File Offset: 0x002152FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooTakeScRsp.Descriptor;
			}
		}

		// Token: 0x0600C766 RID: 51046 RVA: 0x00217101 File Offset: 0x00215301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeScRsp()
		{
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x0021710C File Offset: 0x0021530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeScRsp(SpaceZooTakeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.gDCODBCDKAA_ = other.gDCODBCDKAA_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x00217164 File Offset: 0x00215364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeScRsp Clone()
		{
			return new SpaceZooTakeScRsp(this);
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600C769 RID: 51049 RVA: 0x0021716C File Offset: 0x0021536C
		// (set) Token: 0x0600C76A RID: 51050 RVA: 0x00217174 File Offset: 0x00215374
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

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600C76B RID: 51051 RVA: 0x0021717D File Offset: 0x0021537D
		// (set) Token: 0x0600C76C RID: 51052 RVA: 0x00217185 File Offset: 0x00215385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDCODBCDKAA
		{
			get
			{
				return this.gDCODBCDKAA_;
			}
			set
			{
				this.gDCODBCDKAA_ = value;
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600C76D RID: 51053 RVA: 0x0021718E File Offset: 0x0021538E
		// (set) Token: 0x0600C76E RID: 51054 RVA: 0x00217196 File Offset: 0x00215396
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

		// Token: 0x0600C76F RID: 51055 RVA: 0x0021719F File Offset: 0x0021539F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooTakeScRsp);
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x002171B0 File Offset: 0x002153B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooTakeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.GDCODBCDKAA == other.GDCODBCDKAA && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x00217210 File Offset: 0x00215410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GDCODBCDKAA != 0U)
			{
				num ^= this.GDCODBCDKAA.GetHashCode();
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

		// Token: 0x0600C772 RID: 51058 RVA: 0x0021727E File Offset: 0x0021547E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x00217286 File Offset: 0x00215486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x00217290 File Offset: 0x00215490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GDCODBCDKAA != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GDCODBCDKAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C775 RID: 51061 RVA: 0x00217308 File Offset: 0x00215508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GDCODBCDKAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDCODBCDKAA);
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

		// Token: 0x0600C776 RID: 51062 RVA: 0x00217378 File Offset: 0x00215578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooTakeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GDCODBCDKAA != 0U)
			{
				this.GDCODBCDKAA = other.GDCODBCDKAA;
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

		// Token: 0x0600C777 RID: 51063 RVA: 0x002173F4 File Offset: 0x002155F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x00217400 File Offset: 0x00215600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GDCODBCDKAA = input.ReadUInt32();
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

		// Token: 0x04005089 RID: 20617
		private static readonly MessageParser<SpaceZooTakeScRsp> _parser = new MessageParser<SpaceZooTakeScRsp>(() => new SpaceZooTakeScRsp());

		// Token: 0x0400508A RID: 20618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400508B RID: 20619
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400508C RID: 20620
		private uint retcode_;

		// Token: 0x0400508D RID: 20621
		public const int GDCODBCDKAAFieldNumber = 15;

		// Token: 0x0400508E RID: 20622
		private uint gDCODBCDKAA_;

		// Token: 0x0400508F RID: 20623
		public const int RewardFieldNumber = 10;

		// Token: 0x04005090 RID: 20624
		private ItemList reward_;
	}
}
