using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200140D RID: 5133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UseTreasureDungeonItemCsReq : IMessage<UseTreasureDungeonItemCsReq>, IMessage, IEquatable<UseTreasureDungeonItemCsReq>, IDeepCloneable<UseTreasureDungeonItemCsReq>, IBufferMessage
	{
		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x00260ED5 File Offset: 0x0025F0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UseTreasureDungeonItemCsReq> Parser
		{
			get
			{
				return UseTreasureDungeonItemCsReq._parser;
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x00260EDC File Offset: 0x0025F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UseTreasureDungeonItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x00260EEE File Offset: 0x0025F0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseTreasureDungeonItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00260EF5 File Offset: 0x0025F0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemCsReq()
		{
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00260EFD File Offset: 0x0025F0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemCsReq(UseTreasureDungeonItemCsReq other) : this()
		{
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.itemId_ = other.itemId_;
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00260F3A File Offset: 0x0025F13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemCsReq Clone()
		{
			return new UseTreasureDungeonItemCsReq(this);
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x00260F42 File Offset: 0x0025F142
		// (set) Token: 0x0600E500 RID: 58624 RVA: 0x00260F4A File Offset: 0x0025F14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x0600E501 RID: 58625 RVA: 0x00260F53 File Offset: 0x0025F153
		// (set) Token: 0x0600E502 RID: 58626 RVA: 0x00260F5B File Offset: 0x0025F15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x0600E503 RID: 58627 RVA: 0x00260F64 File Offset: 0x0025F164
		// (set) Token: 0x0600E504 RID: 58628 RVA: 0x00260F6C File Offset: 0x0025F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x00260F75 File Offset: 0x0025F175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseTreasureDungeonItemCsReq);
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00260F84 File Offset: 0x0025F184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseTreasureDungeonItemCsReq other)
		{
			return other != null && (other == this || (this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.ItemId == other.ItemId && this.EEEABJCNKDO == other.EEEABJCNKDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E507 RID: 58631 RVA: 0x00260FE0 File Offset: 0x0025F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E508 RID: 58632 RVA: 0x00261051 File Offset: 0x0025F251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E509 RID: 58633 RVA: 0x00261059 File Offset: 0x0025F259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E50A RID: 58634 RVA: 0x00261064 File Offset: 0x0025F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E50B RID: 58635 RVA: 0x002610DC File Offset: 0x0025F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E50C RID: 58636 RVA: 0x0026114C File Offset: 0x0025F34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseTreasureDungeonItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E50D RID: 58637 RVA: 0x002611B0 File Offset: 0x0025F3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E50E RID: 58638 RVA: 0x002611BC File Offset: 0x0025F3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadUInt32();
						}
					}
					else
					{
						this.NCFAJPAMBGD = input.ReadUInt32();
					}
				}
				else
				{
					this.EEEABJCNKDO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005AF7 RID: 23287
		private static readonly MessageParser<UseTreasureDungeonItemCsReq> _parser = new MessageParser<UseTreasureDungeonItemCsReq>(() => new UseTreasureDungeonItemCsReq());

		// Token: 0x04005AF8 RID: 23288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AF9 RID: 23289
		public const int NCFAJPAMBGDFieldNumber = 10;

		// Token: 0x04005AFA RID: 23290
		private uint nCFAJPAMBGD_;

		// Token: 0x04005AFB RID: 23291
		public const int ItemIdFieldNumber = 11;

		// Token: 0x04005AFC RID: 23292
		private uint itemId_;

		// Token: 0x04005AFD RID: 23293
		public const int EEEABJCNKDOFieldNumber = 2;

		// Token: 0x04005AFE RID: 23294
		private uint eEEABJCNKDO_;
	}
}
