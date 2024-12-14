using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE9 RID: 3561
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomGameplayWolfGunTarget : IMessage<RogueAdventureRoomGameplayWolfGunTarget>, IMessage, IEquatable<RogueAdventureRoomGameplayWolfGunTarget>, IDeepCloneable<RogueAdventureRoomGameplayWolfGunTarget>, IBufferMessage
	{
		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x001AC277 File Offset: 0x001AA477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomGameplayWolfGunTarget> Parser
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunTarget._parser;
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x06009F5D RID: 40797 RVA: 0x001AC27E File Offset: 0x001AA47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunTargetReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x001AC290 File Offset: 0x001AA490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunTarget.Descriptor;
			}
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x001AC297 File Offset: 0x001AA497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunTarget()
		{
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x001AC2A0 File Offset: 0x001AA4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunTarget(RogueAdventureRoomGameplayWolfGunTarget other) : this()
		{
			this.targetNone_ = ((other.targetNone_ != null) ? other.targetNone_.Clone() : null);
			this.targetCoin_ = ((other.targetCoin_ != null) ? other.targetCoin_.Clone() : null);
			this.targetMiracle_ = ((other.targetMiracle_ != null) ? other.targetMiracle_.Clone() : null);
			this.targetRuanmei_ = ((other.targetRuanmei_ != null) ? other.targetRuanmei_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F61 RID: 40801 RVA: 0x001AC334 File Offset: 0x001AA534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunTarget Clone()
		{
			return new RogueAdventureRoomGameplayWolfGunTarget(this);
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x06009F62 RID: 40802 RVA: 0x001AC33C File Offset: 0x001AA53C
		// (set) Token: 0x06009F63 RID: 40803 RVA: 0x001AC344 File Offset: 0x001AA544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetNone TargetNone
		{
			get
			{
				return this.targetNone_;
			}
			set
			{
				this.targetNone_ = value;
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x06009F64 RID: 40804 RVA: 0x001AC34D File Offset: 0x001AA54D
		// (set) Token: 0x06009F65 RID: 40805 RVA: 0x001AC355 File Offset: 0x001AA555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetCoin TargetCoin
		{
			get
			{
				return this.targetCoin_;
			}
			set
			{
				this.targetCoin_ = value;
			}
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x001AC35E File Offset: 0x001AA55E
		// (set) Token: 0x06009F67 RID: 40807 RVA: 0x001AC366 File Offset: 0x001AA566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetMiracle TargetMiracle
		{
			get
			{
				return this.targetMiracle_;
			}
			set
			{
				this.targetMiracle_ = value;
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x06009F68 RID: 40808 RVA: 0x001AC36F File Offset: 0x001AA56F
		// (set) Token: 0x06009F69 RID: 40809 RVA: 0x001AC377 File Offset: 0x001AA577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetRuanmei TargetRuanmei
		{
			get
			{
				return this.targetRuanmei_;
			}
			set
			{
				this.targetRuanmei_ = value;
			}
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x001AC380 File Offset: 0x001AA580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomGameplayWolfGunTarget);
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x001AC390 File Offset: 0x001AA590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomGameplayWolfGunTarget other)
		{
			return other != null && (other == this || (object.Equals(this.TargetNone, other.TargetNone) && object.Equals(this.TargetCoin, other.TargetCoin) && object.Equals(this.TargetMiracle, other.TargetMiracle) && object.Equals(this.TargetRuanmei, other.TargetRuanmei) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x001AC410 File Offset: 0x001AA610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetNone_ != null)
			{
				num ^= this.TargetNone.GetHashCode();
			}
			if (this.targetCoin_ != null)
			{
				num ^= this.TargetCoin.GetHashCode();
			}
			if (this.targetMiracle_ != null)
			{
				num ^= this.TargetMiracle.GetHashCode();
			}
			if (this.targetRuanmei_ != null)
			{
				num ^= this.TargetRuanmei.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x001AC48E File Offset: 0x001AA68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x001AC496 File Offset: 0x001AA696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x001AC4A0 File Offset: 0x001AA6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetMiracle_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TargetMiracle);
			}
			if (this.targetRuanmei_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TargetRuanmei);
			}
			if (this.targetCoin_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TargetCoin);
			}
			if (this.targetNone_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TargetNone);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x001AC534 File Offset: 0x001AA734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.targetNone_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetNone);
			}
			if (this.targetCoin_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetCoin);
			}
			if (this.targetMiracle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetMiracle);
			}
			if (this.targetRuanmei_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetRuanmei);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x001AC5BC File Offset: 0x001AA7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomGameplayWolfGunTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.targetNone_ != null)
			{
				if (this.targetNone_ == null)
				{
					this.TargetNone = new RogueAdventureRoomTargetNone();
				}
				this.TargetNone.MergeFrom(other.TargetNone);
			}
			if (other.targetCoin_ != null)
			{
				if (this.targetCoin_ == null)
				{
					this.TargetCoin = new RogueAdventureRoomTargetCoin();
				}
				this.TargetCoin.MergeFrom(other.TargetCoin);
			}
			if (other.targetMiracle_ != null)
			{
				if (this.targetMiracle_ == null)
				{
					this.TargetMiracle = new RogueAdventureRoomTargetMiracle();
				}
				this.TargetMiracle.MergeFrom(other.TargetMiracle);
			}
			if (other.targetRuanmei_ != null)
			{
				if (this.targetRuanmei_ == null)
				{
					this.TargetRuanmei = new RogueAdventureRoomTargetRuanmei();
				}
				this.TargetRuanmei.MergeFrom(other.TargetRuanmei);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x001AC694 File Offset: 0x001AA894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x001AC6A0 File Offset: 0x001AA8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 26U)
					{
						if (this.targetMiracle_ == null)
						{
							this.TargetMiracle = new RogueAdventureRoomTargetMiracle();
						}
						input.ReadMessage(this.TargetMiracle);
						continue;
					}
					if (num == 42U)
					{
						if (this.targetRuanmei_ == null)
						{
							this.TargetRuanmei = new RogueAdventureRoomTargetRuanmei();
						}
						input.ReadMessage(this.TargetRuanmei);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.targetCoin_ == null)
						{
							this.TargetCoin = new RogueAdventureRoomTargetCoin();
						}
						input.ReadMessage(this.TargetCoin);
						continue;
					}
					if (num == 82U)
					{
						if (this.targetNone_ == null)
						{
							this.TargetNone = new RogueAdventureRoomTargetNone();
						}
						input.ReadMessage(this.TargetNone);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004167 RID: 16743
		private static readonly MessageParser<RogueAdventureRoomGameplayWolfGunTarget> _parser = new MessageParser<RogueAdventureRoomGameplayWolfGunTarget>(() => new RogueAdventureRoomGameplayWolfGunTarget());

		// Token: 0x04004168 RID: 16744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004169 RID: 16745
		public const int TargetNoneFieldNumber = 10;

		// Token: 0x0400416A RID: 16746
		private RogueAdventureRoomTargetNone targetNone_;

		// Token: 0x0400416B RID: 16747
		public const int TargetCoinFieldNumber = 7;

		// Token: 0x0400416C RID: 16748
		private RogueAdventureRoomTargetCoin targetCoin_;

		// Token: 0x0400416D RID: 16749
		public const int TargetMiracleFieldNumber = 3;

		// Token: 0x0400416E RID: 16750
		private RogueAdventureRoomTargetMiracle targetMiracle_;

		// Token: 0x0400416F RID: 16751
		public const int TargetRuanmeiFieldNumber = 5;

		// Token: 0x04004170 RID: 16752
		private RogueAdventureRoomTargetRuanmei targetRuanmei_;
	}
}
