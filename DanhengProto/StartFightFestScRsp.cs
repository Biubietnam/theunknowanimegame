using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AF RID: 4527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartFightFestScRsp : IMessage<StartFightFestScRsp>, IMessage, IEquatable<StartFightFestScRsp>, IDeepCloneable<StartFightFestScRsp>, IBufferMessage
	{
		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600CA2A RID: 51754 RVA: 0x0021E6FF File Offset: 0x0021C8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartFightFestScRsp> Parser
		{
			get
			{
				return StartFightFestScRsp._parser;
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600CA2B RID: 51755 RVA: 0x0021E706 File Offset: 0x0021C906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartFightFestScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600CA2C RID: 51756 RVA: 0x0021E718 File Offset: 0x0021C918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartFightFestScRsp.Descriptor;
			}
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x0021E71F File Offset: 0x0021C91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestScRsp()
		{
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x0021E728 File Offset: 0x0021C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestScRsp(StartFightFestScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x0021E798 File Offset: 0x0021C998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestScRsp Clone()
		{
			return new StartFightFestScRsp(this);
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x0021E7A0 File Offset: 0x0021C9A0
		// (set) Token: 0x0600CA31 RID: 51761 RVA: 0x0021E7A8 File Offset: 0x0021C9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x0021E7B1 File Offset: 0x0021C9B1
		// (set) Token: 0x0600CA33 RID: 51763 RVA: 0x0021E7B9 File Offset: 0x0021C9B9
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

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600CA34 RID: 51764 RVA: 0x0021E7C2 File Offset: 0x0021C9C2
		// (set) Token: 0x0600CA35 RID: 51765 RVA: 0x0021E7CA File Offset: 0x0021C9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x0021E7D3 File Offset: 0x0021C9D3
		// (set) Token: 0x0600CA37 RID: 51767 RVA: 0x0021E7DB File Offset: 0x0021C9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestType Type
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

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600CA38 RID: 51768 RVA: 0x0021E7E4 File Offset: 0x0021C9E4
		// (set) Token: 0x0600CA39 RID: 51769 RVA: 0x0021E7EC File Offset: 0x0021C9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x0021E7F5 File Offset: 0x0021C9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartFightFestScRsp);
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x0021E804 File Offset: 0x0021CA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartFightFestScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.Id == other.Id && this.Type == other.Type && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x0021E884 File Offset: 0x0021CA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != FightFestType.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x0021E92A File Offset: 0x0021CB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x0021E932 File Offset: 0x0021CB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x0021E93C File Offset: 0x0021CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Type != FightFestType.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x0021E9EC File Offset: 0x0021CBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Type != FightFestType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x0021EA8C File Offset: 0x0021CC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartFightFestScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Type != FightFestType.None)
			{
				this.Type = other.Type;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA42 RID: 51778 RVA: 0x0021EB30 File Offset: 0x0021CD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x0021EB3C File Offset: 0x0021CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 26U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
					if (num == 32U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Type = (FightFestType)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005190 RID: 20880
		private static readonly MessageParser<StartFightFestScRsp> _parser = new MessageParser<StartFightFestScRsp>(() => new StartFightFestScRsp());

		// Token: 0x04005191 RID: 20881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005192 RID: 20882
		public const int BattleInfoFieldNumber = 3;

		// Token: 0x04005193 RID: 20883
		private SceneBattleInfo battleInfo_;

		// Token: 0x04005194 RID: 20884
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005195 RID: 20885
		private uint retcode_;

		// Token: 0x04005196 RID: 20886
		public const int IdFieldNumber = 15;

		// Token: 0x04005197 RID: 20887
		private uint id_;

		// Token: 0x04005198 RID: 20888
		public const int TypeFieldNumber = 12;

		// Token: 0x04005199 RID: 20889
		private FightFestType type_;

		// Token: 0x0400519A RID: 20890
		public const int EventIdFieldNumber = 4;

		// Token: 0x0400519B RID: 20891
		private uint eventId_;
	}
}
