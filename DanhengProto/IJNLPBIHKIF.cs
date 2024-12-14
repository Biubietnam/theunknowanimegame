using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000925 RID: 2341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IJNLPBIHKIF : IMessage<IJNLPBIHKIF>, IMessage, IEquatable<IJNLPBIHKIF>, IDeepCloneable<IJNLPBIHKIF>, IBufferMessage
	{
		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x00116D6B File Offset: 0x00114F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IJNLPBIHKIF> Parser
		{
			get
			{
				return IJNLPBIHKIF._parser;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600686C RID: 26732 RVA: 0x00116D72 File Offset: 0x00114F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IJNLPBIHKIFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x00116D84 File Offset: 0x00114F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IJNLPBIHKIF.Descriptor;
			}
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00116D8B File Offset: 0x00114F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IJNLPBIHKIF()
		{
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00116D94 File Offset: 0x00114F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IJNLPBIHKIF(IJNLPBIHKIF other) : this()
		{
			this.kCGOBOKNMFH_ = ((other.kCGOBOKNMFH_ != null) ? other.kCGOBOKNMFH_.Clone() : null);
			this.hADKPJOKKCM_ = other.hADKPJOKKCM_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.scoreId_ = other.scoreId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00116E08 File Offset: 0x00115008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IJNLPBIHKIF Clone()
		{
			return new IJNLPBIHKIF(this);
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x00116E10 File Offset: 0x00115010
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x00116E18 File Offset: 0x00115018
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

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x00116E21 File Offset: 0x00115021
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x00116E29 File Offset: 0x00115029
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

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x00116E32 File Offset: 0x00115032
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x00116E3A File Offset: 0x0011503A
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

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x00116E43 File Offset: 0x00115043
		// (set) Token: 0x06006878 RID: 26744 RVA: 0x00116E4B File Offset: 0x0011504B
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

		// Token: 0x06006879 RID: 26745 RVA: 0x00116E54 File Offset: 0x00115054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IJNLPBIHKIF);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00116E64 File Offset: 0x00115064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IJNLPBIHKIF other)
		{
			return other != null && (other == this || (object.Equals(this.KCGOBOKNMFH, other.KCGOBOKNMFH) && this.HADKPJOKKCM == other.HADKPJOKKCM && object.Equals(this.Reward, other.Reward) && this.ScoreId == other.ScoreId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00116ED8 File Offset: 0x001150D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kCGOBOKNMFH_ != null)
			{
				num ^= this.KCGOBOKNMFH.GetHashCode();
			}
			if (this.HADKPJOKKCM != 0U)
			{
				num ^= this.HADKPJOKKCM.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00116F5C File Offset: 0x0011515C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x00116F64 File Offset: 0x00115164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00116F70 File Offset: 0x00115170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.HADKPJOKKCM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.HADKPJOKKCM);
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.KCGOBOKNMFH);
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

		// Token: 0x0600687F RID: 26751 RVA: 0x00117000 File Offset: 0x00115200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kCGOBOKNMFH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KCGOBOKNMFH);
			}
			if (this.HADKPJOKKCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HADKPJOKKCM);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x00117088 File Offset: 0x00115288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IJNLPBIHKIF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kCGOBOKNMFH_ != null)
			{
				if (this.kCGOBOKNMFH_ == null)
				{
					this.KCGOBOKNMFH = new ItemList();
				}
				this.KCGOBOKNMFH.MergeFrom(other.KCGOBOKNMFH);
			}
			if (other.HADKPJOKKCM != 0U)
			{
				this.HADKPJOKKCM = other.HADKPJOKKCM;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00117130 File Offset: 0x00115330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x0011713C File Offset: 0x0011533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.HADKPJOKKCM = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.kCGOBOKNMFH_ == null)
						{
							this.KCGOBOKNMFH = new ItemList();
						}
						input.ReadMessage(this.KCGOBOKNMFH);
						continue;
					}
					if (num == 106U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400280F RID: 10255
		private static readonly MessageParser<IJNLPBIHKIF> _parser = new MessageParser<IJNLPBIHKIF>(() => new IJNLPBIHKIF());

		// Token: 0x04002810 RID: 10256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002811 RID: 10257
		public const int KCGOBOKNMFHFieldNumber = 12;

		// Token: 0x04002812 RID: 10258
		private ItemList kCGOBOKNMFH_;

		// Token: 0x04002813 RID: 10259
		public const int HADKPJOKKCMFieldNumber = 9;

		// Token: 0x04002814 RID: 10260
		private uint hADKPJOKKCM_;

		// Token: 0x04002815 RID: 10261
		public const int RewardFieldNumber = 13;

		// Token: 0x04002816 RID: 10262
		private ItemList reward_;

		// Token: 0x04002817 RID: 10263
		public const int ScoreIdFieldNumber = 1;

		// Token: 0x04002818 RID: 10264
		private uint scoreId_;
	}
}
