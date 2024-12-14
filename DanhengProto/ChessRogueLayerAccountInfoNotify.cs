using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000233 RID: 563
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLayerAccountInfoNotify : IMessage<ChessRogueLayerAccountInfoNotify>, IMessage, IEquatable<ChessRogueLayerAccountInfoNotify>, IDeepCloneable<ChessRogueLayerAccountInfoNotify>, IBufferMessage
	{
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00049BC3 File Offset: 0x00047DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLayerAccountInfoNotify> Parser
		{
			get
			{
				return ChessRogueLayerAccountInfoNotify._parser;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00049BCA File Offset: 0x00047DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLayerAccountInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00049BDC File Offset: 0x00047DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLayerAccountInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00049BE3 File Offset: 0x00047DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerAccountInfoNotify()
		{
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00049BF8 File Offset: 0x00047DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerAccountInfoNotify(ChessRogueLayerAccountInfoNotify other) : this()
		{
			this.layerId_ = other.layerId_;
			this.hBLHPOLEDGA_ = other.hBLHPOLEDGA_.Clone();
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.difficultyLevel_ = other.difficultyLevel_;
			this.finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00049C7D File Offset: 0x00047E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerAccountInfoNotify Clone()
		{
			return new ChessRogueLayerAccountInfoNotify(this);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00049C85 File Offset: 0x00047E85
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x00049C8D File Offset: 0x00047E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LayerId
		{
			get
			{
				return this.layerId_;
			}
			set
			{
				this.layerId_ = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00049C96 File Offset: 0x00047E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HBLHPOLEDGA
		{
			get
			{
				return this.hBLHPOLEDGA_;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00049C9E File Offset: 0x00047E9E
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00049CA6 File Offset: 0x00047EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00049CAF File Offset: 0x00047EAF
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00049CB7 File Offset: 0x00047EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DifficultyLevel
		{
			get
			{
				return this.difficultyLevel_;
			}
			set
			{
				this.difficultyLevel_ = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00049CC0 File Offset: 0x00047EC0
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00049CC8 File Offset: 0x00047EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo FinishInfo
		{
			get
			{
				return this.finishInfo_;
			}
			set
			{
				this.finishInfo_ = value;
			}
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00049CD1 File Offset: 0x00047ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLayerAccountInfoNotify);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00049CE0 File Offset: 0x00047EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLayerAccountInfoNotify other)
		{
			return other != null && (other == this || (this.LayerId == other.LayerId && this.hBLHPOLEDGA_.Equals(other.hBLHPOLEDGA_) && object.Equals(this.LevelInfo, other.LevelInfo) && this.DifficultyLevel == other.DifficultyLevel && object.Equals(this.FinishInfo, other.FinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00049D68 File Offset: 0x00047F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LayerId != 0U)
			{
				num ^= this.LayerId.GetHashCode();
			}
			num ^= this.hBLHPOLEDGA_.GetHashCode();
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.DifficultyLevel != 0U)
			{
				num ^= this.DifficultyLevel.GetHashCode();
			}
			if (this.finishInfo_ != null)
			{
				num ^= this.FinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00049DFA File Offset: 0x00047FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00049E02 File Offset: 0x00048002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00049E0C File Offset: 0x0004800C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hBLHPOLEDGA_.WriteTo(ref output, ChessRogueLayerAccountInfoNotify._repeated_hBLHPOLEDGA_codec);
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.finishInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FinishInfo);
			}
			if (this.LayerId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LayerId);
			}
			if (this.DifficultyLevel != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DifficultyLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00049EB0 File Offset: 0x000480B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LayerId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LayerId);
			}
			num += this.hBLHPOLEDGA_.CalculateSize(ChessRogueLayerAccountInfoNotify._repeated_hBLHPOLEDGA_codec);
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.DifficultyLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyLevel);
			}
			if (this.finishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00049F4C File Offset: 0x0004814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLayerAccountInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LayerId != 0U)
			{
				this.LayerId = other.LayerId;
			}
			this.hBLHPOLEDGA_.Add(other.hBLHPOLEDGA_);
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new ChessRogueLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.DifficultyLevel != 0U)
			{
				this.DifficultyLevel = other.DifficultyLevel;
			}
			if (other.finishInfo_ != null)
			{
				if (this.finishInfo_ == null)
				{
					this.FinishInfo = new ChessRogueFinishInfo();
				}
				this.FinishInfo.MergeFrom(other.FinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0004A005 File Offset: 0x00048205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0004A010 File Offset: 0x00048210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 32U || num == 34U)
					{
						this.hBLHPOLEDGA_.AddEntriesFrom(ref input, ChessRogueLayerAccountInfoNotify._repeated_hBLHPOLEDGA_codec);
						continue;
					}
					if (num == 50U)
					{
						if (this.levelInfo_ == null)
						{
							this.LevelInfo = new ChessRogueLevelInfo();
						}
						input.ReadMessage(this.LevelInfo);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.finishInfo_ == null)
						{
							this.FinishInfo = new ChessRogueFinishInfo();
						}
						input.ReadMessage(this.FinishInfo);
						continue;
					}
					if (num == 72U)
					{
						this.LayerId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.DifficultyLevel = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly MessageParser<ChessRogueLayerAccountInfoNotify> _parser = new MessageParser<ChessRogueLayerAccountInfoNotify>(() => new ChessRogueLayerAccountInfoNotify());

		// Token: 0x04000AC8 RID: 2760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AC9 RID: 2761
		public const int LayerIdFieldNumber = 9;

		// Token: 0x04000ACA RID: 2762
		private uint layerId_;

		// Token: 0x04000ACB RID: 2763
		public const int HBLHPOLEDGAFieldNumber = 4;

		// Token: 0x04000ACC RID: 2764
		private static readonly FieldCodec<uint> _repeated_hBLHPOLEDGA_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04000ACD RID: 2765
		private readonly RepeatedField<uint> hBLHPOLEDGA_ = new RepeatedField<uint>();

		// Token: 0x04000ACE RID: 2766
		public const int LevelInfoFieldNumber = 6;

		// Token: 0x04000ACF RID: 2767
		private ChessRogueLevelInfo levelInfo_;

		// Token: 0x04000AD0 RID: 2768
		public const int DifficultyLevelFieldNumber = 11;

		// Token: 0x04000AD1 RID: 2769
		private uint difficultyLevel_;

		// Token: 0x04000AD2 RID: 2770
		public const int FinishInfoFieldNumber = 8;

		// Token: 0x04000AD3 RID: 2771
		private ChessRogueFinishInfo finishInfo_;
	}
}
