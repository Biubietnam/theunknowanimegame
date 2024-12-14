using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F27 RID: 3879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicTalentInfo : IMessage<RogueMagicTalentInfo>, IMessage, IEquatable<RogueMagicTalentInfo>, IDeepCloneable<RogueMagicTalentInfo>, IBufferMessage
	{
		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600AD12 RID: 44306 RVA: 0x001D1A5F File Offset: 0x001CFC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicTalentInfo> Parser
		{
			get
			{
				return RogueMagicTalentInfo._parser;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x001D1A66 File Offset: 0x001CFC66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicTalentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x001D1A78 File Offset: 0x001CFC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicTalentInfo.Descriptor;
			}
		}

		// Token: 0x0600AD15 RID: 44309 RVA: 0x001D1A7F File Offset: 0x001CFC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo()
		{
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x001D1A88 File Offset: 0x001CFC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo(RogueMagicTalentInfo other) : this()
		{
			this.magicTalentCoin_ = other.magicTalentCoin_;
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x001D1AD4 File Offset: 0x001CFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo Clone()
		{
			return new RogueMagicTalentInfo(this);
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x001D1ADC File Offset: 0x001CFCDC
		// (set) Token: 0x0600AD19 RID: 44313 RVA: 0x001D1AE4 File Offset: 0x001CFCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicTalentCoin
		{
			get
			{
				return this.magicTalentCoin_;
			}
			set
			{
				this.magicTalentCoin_ = value;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x001D1AED File Offset: 0x001CFCED
		// (set) Token: 0x0600AD1B RID: 44315 RVA: 0x001D1AF5 File Offset: 0x001CFCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList TalentInfoList
		{
			get
			{
				return this.talentInfoList_;
			}
			set
			{
				this.talentInfoList_ = value;
			}
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x001D1AFE File Offset: 0x001CFCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicTalentInfo);
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x001D1B0C File Offset: 0x001CFD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicTalentInfo other)
		{
			return other != null && (other == this || (this.MagicTalentCoin == other.MagicTalentCoin && object.Equals(this.TalentInfoList, other.TalentInfoList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x001D1B5C File Offset: 0x001CFD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MagicTalentCoin != 0U)
			{
				num ^= this.MagicTalentCoin.GetHashCode();
			}
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x001D1BB1 File Offset: 0x001CFDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD20 RID: 44320 RVA: 0x001D1BB9 File Offset: 0x001CFDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x001D1BC4 File Offset: 0x001CFDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MagicTalentCoin != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MagicTalentCoin);
			}
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x001D1C20 File Offset: 0x001CFE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MagicTalentCoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicTalentCoin);
			}
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x001D1C78 File Offset: 0x001CFE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MagicTalentCoin != 0U)
			{
				this.MagicTalentCoin = other.MagicTalentCoin;
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new RogueTalentInfoList();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x001D1CE0 File Offset: 0x001CFEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x001D1CEC File Offset: 0x001CFEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.talentInfoList_ == null)
						{
							this.TalentInfoList = new RogueTalentInfoList();
						}
						input.ReadMessage(this.TalentInfoList);
					}
				}
				else
				{
					this.MagicTalentCoin = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004682 RID: 18050
		private static readonly MessageParser<RogueMagicTalentInfo> _parser = new MessageParser<RogueMagicTalentInfo>(() => new RogueMagicTalentInfo());

		// Token: 0x04004683 RID: 18051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004684 RID: 18052
		public const int MagicTalentCoinFieldNumber = 6;

		// Token: 0x04004685 RID: 18053
		private uint magicTalentCoin_;

		// Token: 0x04004686 RID: 18054
		public const int TalentInfoListFieldNumber = 10;

		// Token: 0x04004687 RID: 18055
		private RogueTalentInfoList talentInfoList_;
	}
}
