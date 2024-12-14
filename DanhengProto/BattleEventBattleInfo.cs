using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E5 RID: 229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleEventBattleInfo : IMessage<BattleEventBattleInfo>, IMessage, IEquatable<BattleEventBattleInfo>, IDeepCloneable<BattleEventBattleInfo>, IBufferMessage
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0001E227 File Offset: 0x0001C427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleEventBattleInfo> Parser
		{
			get
			{
				return BattleEventBattleInfo._parser;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0001E22E File Offset: 0x0001C42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleEventBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0001E240 File Offset: 0x0001C440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleEventBattleInfo.Descriptor;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001E247 File Offset: 0x0001C447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventBattleInfo()
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001E25C File Offset: 0x0001C45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventBattleInfo(BattleEventBattleInfo other) : this()
		{
			this.battleEventId_ = other.battleEventId_;
			this.status_ = ((other.status_ != null) ? other.status_.Clone() : null);
			this.skillInfo_ = other.skillInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001E2B9 File Offset: 0x0001C4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventBattleInfo Clone()
		{
			return new BattleEventBattleInfo(this);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0001E2C1 File Offset: 0x0001C4C1
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0001E2C9 File Offset: 0x0001C4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleEventId
		{
			get
			{
				return this.battleEventId_;
			}
			set
			{
				this.battleEventId_ = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0001E2D2 File Offset: 0x0001C4D2
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0001E2DA File Offset: 0x0001C4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEventProperty Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0001E2E3 File Offset: 0x0001C4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PHKMLOMCNMN> SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001E2EB File Offset: 0x0001C4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleEventBattleInfo);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleEventBattleInfo other)
		{
			return other != null && (other == this || (this.BattleEventId == other.BattleEventId && object.Equals(this.Status, other.Status) && this.skillInfo_.Equals(other.skillInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001E360 File Offset: 0x0001C560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleEventId != 0U)
			{
				num ^= this.BattleEventId.GetHashCode();
			}
			if (this.status_ != null)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.skillInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001E3C3 File Offset: 0x0001C5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001E3CB File Offset: 0x0001C5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleEventId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BattleEventId);
			}
			if (this.status_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Status);
			}
			this.skillInfo_.WriteTo(ref output, BattleEventBattleInfo._repeated_skillInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001E440 File Offset: 0x0001C640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleEventId);
			}
			if (this.status_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Status);
			}
			num += this.skillInfo_.CalculateSize(BattleEventBattleInfo._repeated_skillInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001E4AC File Offset: 0x0001C6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleEventBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleEventId != 0U)
			{
				this.BattleEventId = other.BattleEventId;
			}
			if (other.status_ != null)
			{
				if (this.status_ == null)
				{
					this.Status = new BattleEventProperty();
				}
				this.Status.MergeFrom(other.Status);
			}
			this.skillInfo_.Add(other.skillInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001E525 File Offset: 0x0001C725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001E530 File Offset: 0x0001C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.skillInfo_.AddEntriesFrom(ref input, BattleEventBattleInfo._repeated_skillInfo_codec);
						}
					}
					else
					{
						if (this.status_ == null)
						{
							this.Status = new BattleEventProperty();
						}
						input.ReadMessage(this.Status);
					}
				}
				else
				{
					this.BattleEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000441 RID: 1089
		private static readonly MessageParser<BattleEventBattleInfo> _parser = new MessageParser<BattleEventBattleInfo>(() => new BattleEventBattleInfo());

		// Token: 0x04000442 RID: 1090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000443 RID: 1091
		public const int BattleEventIdFieldNumber = 1;

		// Token: 0x04000444 RID: 1092
		private uint battleEventId_;

		// Token: 0x04000445 RID: 1093
		public const int StatusFieldNumber = 2;

		// Token: 0x04000446 RID: 1094
		private BattleEventProperty status_;

		// Token: 0x04000447 RID: 1095
		public const int SkillInfoFieldNumber = 3;

		// Token: 0x04000448 RID: 1096
		private static readonly FieldCodec<PHKMLOMCNMN> _repeated_skillInfo_codec = FieldCodec.ForMessage<PHKMLOMCNMN>(26U, PHKMLOMCNMN.Parser);

		// Token: 0x04000449 RID: 1097
		private readonly RepeatedField<PHKMLOMCNMN> skillInfo_ = new RepeatedField<PHKMLOMCNMN>();
	}
}
