using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011ED RID: 4589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StrongChallengeActivityData : IMessage<StrongChallengeActivityData>, IMessage, IEquatable<StrongChallengeActivityData>, IDeepCloneable<StrongChallengeActivityData>, IBufferMessage
	{
		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600CD19 RID: 52505 RVA: 0x002268B7 File Offset: 0x00224AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StrongChallengeActivityData> Parser
		{
			get
			{
				return StrongChallengeActivityData._parser;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x002268BE File Offset: 0x00224ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600CD1B RID: 52507 RVA: 0x002268D0 File Offset: 0x00224AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StrongChallengeActivityData.Descriptor;
			}
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x002268D7 File Offset: 0x00224AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityData()
		{
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x002268E0 File Offset: 0x00224AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityData(StrongChallengeActivityData other) : this()
		{
			this.panelId_ = other.panelId_;
			this.stageId_ = other.stageId_;
			this.nFKBAFFFGMO_ = ((other.nFKBAFFFGMO_ != null) ? other.nFKBAFFFGMO_.Clone() : null);
			this.lBNDGNLLADA_ = other.lBNDGNLLADA_;
			this.maxScore_ = other.maxScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x00226950 File Offset: 0x00224B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityData Clone()
		{
			return new StrongChallengeActivityData(this);
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600CD1F RID: 52511 RVA: 0x00226958 File Offset: 0x00224B58
		// (set) Token: 0x0600CD20 RID: 52512 RVA: 0x00226960 File Offset: 0x00224B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x00226969 File Offset: 0x00224B69
		// (set) Token: 0x0600CD22 RID: 52514 RVA: 0x00226971 File Offset: 0x00224B71
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

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600CD23 RID: 52515 RVA: 0x0022697A File Offset: 0x00224B7A
		// (set) Token: 0x0600CD24 RID: 52516 RVA: 0x00226982 File Offset: 0x00224B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatarData NFKBAFFFGMO
		{
			get
			{
				return this.nFKBAFFFGMO_;
			}
			set
			{
				this.nFKBAFFFGMO_ = value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600CD25 RID: 52517 RVA: 0x0022698B File Offset: 0x00224B8B
		// (set) Token: 0x0600CD26 RID: 52518 RVA: 0x00226993 File Offset: 0x00224B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LBNDGNLLADA
		{
			get
			{
				return this.lBNDGNLLADA_;
			}
			set
			{
				this.lBNDGNLLADA_ = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x0022699C File Offset: 0x00224B9C
		// (set) Token: 0x0600CD28 RID: 52520 RVA: 0x002269A4 File Offset: 0x00224BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x002269AD File Offset: 0x00224BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StrongChallengeActivityData);
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x002269BC File Offset: 0x00224BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StrongChallengeActivityData other)
		{
			return other != null && (other == this || (this.PanelId == other.PanelId && this.StageId == other.StageId && object.Equals(this.NFKBAFFFGMO, other.NFKBAFFFGMO) && this.LBNDGNLLADA == other.LBNDGNLLADA && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x00226A3C File Offset: 0x00224C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.nFKBAFFFGMO_ != null)
			{
				num ^= this.NFKBAFFFGMO.GetHashCode();
			}
			if (this.LBNDGNLLADA != 0U)
			{
				num ^= this.LBNDGNLLADA.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x00226ADC File Offset: 0x00224CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x00226AE4 File Offset: 0x00224CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x00226AF0 File Offset: 0x00224CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.StageId);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PanelId);
			}
			if (this.LBNDGNLLADA != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.LBNDGNLLADA);
			}
			if (this.nFKBAFFFGMO_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.NFKBAFFFGMO);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x00226BA0 File Offset: 0x00224DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.nFKBAFFFGMO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NFKBAFFFGMO);
			}
			if (this.LBNDGNLLADA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LBNDGNLLADA);
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x00226C40 File Offset: 0x00224E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StrongChallengeActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.nFKBAFFFGMO_ != null)
			{
				if (this.nFKBAFFFGMO_ == null)
				{
					this.NFKBAFFFGMO = new StrongChallengeAvatarData();
				}
				this.NFKBAFFFGMO.MergeFrom(other.NFKBAFFFGMO);
			}
			if (other.LBNDGNLLADA != 0U)
			{
				this.LBNDGNLLADA = other.LBNDGNLLADA;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x00226CE4 File Offset: 0x00224EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x00226CF0 File Offset: 0x00224EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LBNDGNLLADA = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.nFKBAFFFGMO_ == null)
						{
							this.NFKBAFFFGMO = new StrongChallengeAvatarData();
						}
						input.ReadMessage(this.NFKBAFFFGMO);
						continue;
					}
					if (num == 112U)
					{
						this.MaxScore = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040052B9 RID: 21177
		private static readonly MessageParser<StrongChallengeActivityData> _parser = new MessageParser<StrongChallengeActivityData>(() => new StrongChallengeActivityData());

		// Token: 0x040052BA RID: 21178
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052BB RID: 21179
		public const int PanelIdFieldNumber = 9;

		// Token: 0x040052BC RID: 21180
		private uint panelId_;

		// Token: 0x040052BD RID: 21181
		public const int StageIdFieldNumber = 5;

		// Token: 0x040052BE RID: 21182
		private uint stageId_;

		// Token: 0x040052BF RID: 21183
		public const int NFKBAFFFGMOFieldNumber = 13;

		// Token: 0x040052C0 RID: 21184
		private StrongChallengeAvatarData nFKBAFFFGMO_;

		// Token: 0x040052C1 RID: 21185
		public const int LBNDGNLLADAFieldNumber = 10;

		// Token: 0x040052C2 RID: 21186
		private uint lBNDGNLLADA_;

		// Token: 0x040052C3 RID: 21187
		public const int MaxScoreFieldNumber = 14;

		// Token: 0x040052C4 RID: 21188
		private uint maxScore_;
	}
}
