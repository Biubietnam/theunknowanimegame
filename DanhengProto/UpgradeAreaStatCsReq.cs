using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001405 RID: 5125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpgradeAreaStatCsReq : IMessage<UpgradeAreaStatCsReq>, IMessage, IEquatable<UpgradeAreaStatCsReq>, IDeepCloneable<UpgradeAreaStatCsReq>, IBufferMessage
	{
		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x0600E487 RID: 58503 RVA: 0x0025F981 File Offset: 0x0025DB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpgradeAreaStatCsReq> Parser
		{
			get
			{
				return UpgradeAreaStatCsReq._parser;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x0600E488 RID: 58504 RVA: 0x0025F988 File Offset: 0x0025DB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaStatCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x0025F99A File Offset: 0x0025DB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpgradeAreaStatCsReq.Descriptor;
			}
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x0025F9A1 File Offset: 0x0025DBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatCsReq()
		{
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x0025F9A9 File Offset: 0x0025DBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatCsReq(UpgradeAreaStatCsReq other) : this()
		{
			this.areaId_ = other.areaId_;
			this.level_ = other.level_;
			this.iFJEBOIEGFG_ = other.iFJEBOIEGFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x0025F9E6 File Offset: 0x0025DBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpgradeAreaStatCsReq Clone()
		{
			return new UpgradeAreaStatCsReq(this);
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0600E48D RID: 58509 RVA: 0x0025F9EE File Offset: 0x0025DBEE
		// (set) Token: 0x0600E48E RID: 58510 RVA: 0x0025F9F6 File Offset: 0x0025DBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x0600E48F RID: 58511 RVA: 0x0025F9FF File Offset: 0x0025DBFF
		// (set) Token: 0x0600E490 RID: 58512 RVA: 0x0025FA07 File Offset: 0x0025DC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x0025FA10 File Offset: 0x0025DC10
		// (set) Token: 0x0600E492 RID: 58514 RVA: 0x0025FA18 File Offset: 0x0025DC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StatType IFJEBOIEGFG
		{
			get
			{
				return this.iFJEBOIEGFG_;
			}
			set
			{
				this.iFJEBOIEGFG_ = value;
			}
		}

		// Token: 0x0600E493 RID: 58515 RVA: 0x0025FA21 File Offset: 0x0025DC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpgradeAreaStatCsReq);
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x0025FA30 File Offset: 0x0025DC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpgradeAreaStatCsReq other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.Level == other.Level && this.IFJEBOIEGFG == other.IFJEBOIEGFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x0025FA8C File Offset: 0x0025DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.IFJEBOIEGFG != StatType.None)
			{
				num ^= this.IFJEBOIEGFG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x0025FB03 File Offset: 0x0025DD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x0025FB0B File Offset: 0x0025DD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x0025FB14 File Offset: 0x0025DD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IFJEBOIEGFG != StatType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.IFJEBOIEGFG);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x0025FB8C File Offset: 0x0025DD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.IFJEBOIEGFG != StatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.IFJEBOIEGFG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x0025FBFC File Offset: 0x0025DDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpgradeAreaStatCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.IFJEBOIEGFG != StatType.None)
			{
				this.IFJEBOIEGFG = other.IFJEBOIEGFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x0025FC60 File Offset: 0x0025DE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x0025FC6C File Offset: 0x0025DE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AreaId = input.ReadUInt32();
						}
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.IFJEBOIEGFG = (StatType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005AC5 RID: 23237
		private static readonly MessageParser<UpgradeAreaStatCsReq> _parser = new MessageParser<UpgradeAreaStatCsReq>(() => new UpgradeAreaStatCsReq());

		// Token: 0x04005AC6 RID: 23238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AC7 RID: 23239
		public const int AreaIdFieldNumber = 10;

		// Token: 0x04005AC8 RID: 23240
		private uint areaId_;

		// Token: 0x04005AC9 RID: 23241
		public const int LevelFieldNumber = 6;

		// Token: 0x04005ACA RID: 23242
		private uint level_;

		// Token: 0x04005ACB RID: 23243
		public const int IFJEBOIEGFGFieldNumber = 2;

		// Token: 0x04005ACC RID: 23244
		private StatType iFJEBOIEGFG_;
	}
}
