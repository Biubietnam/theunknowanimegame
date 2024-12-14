using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055D RID: 1373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTreasureDungeonMonsterScRsp : IMessage<FightTreasureDungeonMonsterScRsp>, IMessage, IEquatable<FightTreasureDungeonMonsterScRsp>, IDeepCloneable<FightTreasureDungeonMonsterScRsp>, IBufferMessage
	{
		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x000A7AD7 File Offset: 0x000A5CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTreasureDungeonMonsterScRsp> Parser
		{
			get
			{
				return FightTreasureDungeonMonsterScRsp._parser;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x000A7ADE File Offset: 0x000A5CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x000A7AF0 File Offset: 0x000A5CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterScRsp.Descriptor;
			}
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000A7AF7 File Offset: 0x000A5CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterScRsp()
		{
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000A7B00 File Offset: 0x000A5D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterScRsp(FightTreasureDungeonMonsterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x000A7B4C File Offset: 0x000A5D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTreasureDungeonMonsterScRsp Clone()
		{
			return new FightTreasureDungeonMonsterScRsp(this);
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x000A7B54 File Offset: 0x000A5D54
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x000A7B5C File Offset: 0x000A5D5C
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

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x000A7B65 File Offset: 0x000A5D65
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x000A7B6D File Offset: 0x000A5D6D
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

		// Token: 0x06003D3F RID: 15679 RVA: 0x000A7B76 File Offset: 0x000A5D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightTreasureDungeonMonsterScRsp);
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x000A7B84 File Offset: 0x000A5D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightTreasureDungeonMonsterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x000A7BD4 File Offset: 0x000A5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x000A7C29 File Offset: 0x000A5E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x000A7C31 File Offset: 0x000A5E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x000A7C3C File Offset: 0x000A5E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x000A7C98 File Offset: 0x000A5E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x000A7CF0 File Offset: 0x000A5EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightTreasureDungeonMonsterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x000A7D58 File Offset: 0x000A5F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x000A7D64 File Offset: 0x000A5F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001884 RID: 6276
		private static readonly MessageParser<FightTreasureDungeonMonsterScRsp> _parser = new MessageParser<FightTreasureDungeonMonsterScRsp>(() => new FightTreasureDungeonMonsterScRsp());

		// Token: 0x04001885 RID: 6277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001886 RID: 6278
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001887 RID: 6279
		private uint retcode_;

		// Token: 0x04001888 RID: 6280
		public const int BattleInfoFieldNumber = 15;

		// Token: 0x04001889 RID: 6281
		private SceneBattleInfo battleInfo_;
	}
}
