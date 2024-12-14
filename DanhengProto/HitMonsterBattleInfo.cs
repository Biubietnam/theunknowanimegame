using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008EF RID: 2287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HitMonsterBattleInfo : IMessage<HitMonsterBattleInfo>, IMessage, IEquatable<HitMonsterBattleInfo>, IDeepCloneable<HitMonsterBattleInfo>, IBufferMessage
	{
		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x001109C3 File Offset: 0x0010EBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HitMonsterBattleInfo> Parser
		{
			get
			{
				return HitMonsterBattleInfo._parser;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x001109CA File Offset: 0x0010EBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HitMonsterBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06006600 RID: 26112 RVA: 0x001109DC File Offset: 0x0010EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitMonsterBattleInfo.Descriptor;
			}
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x001109E3 File Offset: 0x0010EBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitMonsterBattleInfo()
		{
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x001109EB File Offset: 0x0010EBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitMonsterBattleInfo(HitMonsterBattleInfo other) : this()
		{
			this.monsterBattleType_ = other.monsterBattleType_;
			this.targetMonsterEntityId_ = other.targetMonsterEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x00110A1C File Offset: 0x0010EC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitMonsterBattleInfo Clone()
		{
			return new HitMonsterBattleInfo(this);
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06006604 RID: 26116 RVA: 0x00110A24 File Offset: 0x0010EC24
		// (set) Token: 0x06006605 RID: 26117 RVA: 0x00110A2C File Offset: 0x0010EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBattleType MonsterBattleType
		{
			get
			{
				return this.monsterBattleType_;
			}
			set
			{
				this.monsterBattleType_ = value;
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06006606 RID: 26118 RVA: 0x00110A35 File Offset: 0x0010EC35
		// (set) Token: 0x06006607 RID: 26119 RVA: 0x00110A3D File Offset: 0x0010EC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetMonsterEntityId
		{
			get
			{
				return this.targetMonsterEntityId_;
			}
			set
			{
				this.targetMonsterEntityId_ = value;
			}
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00110A46 File Offset: 0x0010EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitMonsterBattleInfo);
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00110A54 File Offset: 0x0010EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitMonsterBattleInfo other)
		{
			return other != null && (other == this || (this.MonsterBattleType == other.MonsterBattleType && this.TargetMonsterEntityId == other.TargetMonsterEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x00110A94 File Offset: 0x0010EC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterBattleType != MonsterBattleType.None)
			{
				num ^= this.MonsterBattleType.GetHashCode();
			}
			if (this.TargetMonsterEntityId != 0U)
			{
				num ^= this.TargetMonsterEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x00110AF2 File Offset: 0x0010ECF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00110AFA File Offset: 0x0010ECFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x00110B04 File Offset: 0x0010ED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterBattleType != MonsterBattleType.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.MonsterBattleType);
			}
			if (this.TargetMonsterEntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.TargetMonsterEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x00110B60 File Offset: 0x0010ED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterBattleType != MonsterBattleType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MonsterBattleType);
			}
			if (this.TargetMonsterEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetMonsterEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x00110BB8 File Offset: 0x0010EDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitMonsterBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterBattleType != MonsterBattleType.None)
			{
				this.MonsterBattleType = other.MonsterBattleType;
			}
			if (other.TargetMonsterEntityId != 0U)
			{
				this.TargetMonsterEntityId = other.TargetMonsterEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x00110C08 File Offset: 0x0010EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x00110C14 File Offset: 0x0010EE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetMonsterEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.MonsterBattleType = (MonsterBattleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002735 RID: 10037
		private static readonly MessageParser<HitMonsterBattleInfo> _parser = new MessageParser<HitMonsterBattleInfo>(() => new HitMonsterBattleInfo());

		// Token: 0x04002736 RID: 10038
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002737 RID: 10039
		public const int MonsterBattleTypeFieldNumber = 10;

		// Token: 0x04002738 RID: 10040
		private MonsterBattleType monsterBattleType_;

		// Token: 0x04002739 RID: 10041
		public const int TargetMonsterEntityIdFieldNumber = 12;

		// Token: 0x0400273A RID: 10042
		private uint targetMonsterEntityId_;
	}
}
