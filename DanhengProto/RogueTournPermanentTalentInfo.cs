using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF7 RID: 4087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournPermanentTalentInfo : IMessage<RogueTournPermanentTalentInfo>, IMessage, IEquatable<RogueTournPermanentTalentInfo>, IDeepCloneable<RogueTournPermanentTalentInfo>, IBufferMessage
	{
		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x001E82B3 File Offset: 0x001E64B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournPermanentTalentInfo> Parser
		{
			get
			{
				return RogueTournPermanentTalentInfo._parser;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x001E82BA File Offset: 0x001E64BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournPermanentTalentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600B5DD RID: 46557 RVA: 0x001E82CC File Offset: 0x001E64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournPermanentTalentInfo.Descriptor;
			}
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x001E82D3 File Offset: 0x001E64D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo()
		{
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x001E82DC File Offset: 0x001E64DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo(RogueTournPermanentTalentInfo other) : this()
		{
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.tournTalentCoinNum_ = other.tournTalentCoinNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x001E8328 File Offset: 0x001E6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo Clone()
		{
			return new RogueTournPermanentTalentInfo(this);
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600B5E1 RID: 46561 RVA: 0x001E8330 File Offset: 0x001E6530
		// (set) Token: 0x0600B5E2 RID: 46562 RVA: 0x001E8338 File Offset: 0x001E6538
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

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600B5E3 RID: 46563 RVA: 0x001E8341 File Offset: 0x001E6541
		// (set) Token: 0x0600B5E4 RID: 46564 RVA: 0x001E8349 File Offset: 0x001E6549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TournTalentCoinNum
		{
			get
			{
				return this.tournTalentCoinNum_;
			}
			set
			{
				this.tournTalentCoinNum_ = value;
			}
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x001E8352 File Offset: 0x001E6552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournPermanentTalentInfo);
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x001E8360 File Offset: 0x001E6560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournPermanentTalentInfo other)
		{
			return other != null && (other == this || (object.Equals(this.TalentInfoList, other.TalentInfoList) && this.TournTalentCoinNum == other.TournTalentCoinNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x001E83B0 File Offset: 0x001E65B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			if (this.TournTalentCoinNum != 0U)
			{
				num ^= this.TournTalentCoinNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x001E8405 File Offset: 0x001E6605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x001E840D File Offset: 0x001E660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x001E8418 File Offset: 0x001E6618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TournTalentCoinNum != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TournTalentCoinNum);
			}
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x001E8474 File Offset: 0x001E6674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			if (this.TournTalentCoinNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TournTalentCoinNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x001E84CC File Offset: 0x001E66CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournPermanentTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new RogueTalentInfoList();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			if (other.TournTalentCoinNum != 0U)
			{
				this.TournTalentCoinNum = other.TournTalentCoinNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x001E8534 File Offset: 0x001E6734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x001E8540 File Offset: 0x001E6740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 66U)
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
					this.TournTalentCoinNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040049C3 RID: 18883
		private static readonly MessageParser<RogueTournPermanentTalentInfo> _parser = new MessageParser<RogueTournPermanentTalentInfo>(() => new RogueTournPermanentTalentInfo());

		// Token: 0x040049C4 RID: 18884
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C5 RID: 18885
		public const int TalentInfoListFieldNumber = 8;

		// Token: 0x040049C6 RID: 18886
		private RogueTalentInfoList talentInfoList_;

		// Token: 0x040049C7 RID: 18887
		public const int TournTalentCoinNumFieldNumber = 4;

		// Token: 0x040049C8 RID: 18888
		private uint tournTalentCoinNum_;
	}
}
