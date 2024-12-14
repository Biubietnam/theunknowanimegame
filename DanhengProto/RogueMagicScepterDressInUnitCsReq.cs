using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F05 RID: 3845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterDressInUnitCsReq : IMessage<RogueMagicScepterDressInUnitCsReq>, IMessage, IEquatable<RogueMagicScepterDressInUnitCsReq>, IDeepCloneable<RogueMagicScepterDressInUnitCsReq>, IBufferMessage
	{
		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x001CE5CB File Offset: 0x001CC7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterDressInUnitCsReq> Parser
		{
			get
			{
				return RogueMagicScepterDressInUnitCsReq._parser;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600ABAC RID: 43948 RVA: 0x001CE5D2 File Offset: 0x001CC7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterDressInUnitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x001CE5E4 File Offset: 0x001CC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterDressInUnitCsReq.Descriptor;
			}
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x001CE5EB File Offset: 0x001CC7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitCsReq()
		{
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x001CE5F3 File Offset: 0x001CC7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitCsReq(RogueMagicScepterDressInUnitCsReq other) : this()
		{
			this.dressMagicUnitUniqueId_ = other.dressMagicUnitUniqueId_;
			this.scepterId_ = other.scepterId_;
			this.diceSlotId_ = other.diceSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x001CE630 File Offset: 0x001CC830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterDressInUnitCsReq Clone()
		{
			return new RogueMagicScepterDressInUnitCsReq(this);
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x001CE638 File Offset: 0x001CC838
		// (set) Token: 0x0600ABB2 RID: 43954 RVA: 0x001CE640 File Offset: 0x001CC840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressMagicUnitUniqueId
		{
			get
			{
				return this.dressMagicUnitUniqueId_;
			}
			set
			{
				this.dressMagicUnitUniqueId_ = value;
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600ABB3 RID: 43955 RVA: 0x001CE649 File Offset: 0x001CC849
		// (set) Token: 0x0600ABB4 RID: 43956 RVA: 0x001CE651 File Offset: 0x001CC851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x001CE65A File Offset: 0x001CC85A
		// (set) Token: 0x0600ABB6 RID: 43958 RVA: 0x001CE662 File Offset: 0x001CC862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSlotId
		{
			get
			{
				return this.diceSlotId_;
			}
			set
			{
				this.diceSlotId_ = value;
			}
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x001CE66B File Offset: 0x001CC86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterDressInUnitCsReq);
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x001CE67C File Offset: 0x001CC87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterDressInUnitCsReq other)
		{
			return other != null && (other == this || (this.DressMagicUnitUniqueId == other.DressMagicUnitUniqueId && this.ScepterId == other.ScepterId && this.DiceSlotId == other.DiceSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x001CE6D8 File Offset: 0x001CC8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DressMagicUnitUniqueId != 0U)
			{
				num ^= this.DressMagicUnitUniqueId.GetHashCode();
			}
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			if (this.DiceSlotId != 0U)
			{
				num ^= this.DiceSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x001CE749 File Offset: 0x001CC949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x001CE751 File Offset: 0x001CC951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x001CE75C File Offset: 0x001CC95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DressMagicUnitUniqueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DressMagicUnitUniqueId);
			}
			if (this.DiceSlotId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DiceSlotId);
			}
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ScepterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x001CE7D4 File Offset: 0x001CC9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DressMagicUnitUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressMagicUnitUniqueId);
			}
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			if (this.DiceSlotId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x001CE844 File Offset: 0x001CCA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterDressInUnitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DressMagicUnitUniqueId != 0U)
			{
				this.DressMagicUnitUniqueId = other.DressMagicUnitUniqueId;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			if (other.DiceSlotId != 0U)
			{
				this.DiceSlotId = other.DiceSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x001CE8A8 File Offset: 0x001CCAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x001CE8B4 File Offset: 0x001CCAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ScepterId = input.ReadUInt32();
						}
					}
					else
					{
						this.DiceSlotId = input.ReadUInt32();
					}
				}
				else
				{
					this.DressMagicUnitUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400460D RID: 17933
		private static readonly MessageParser<RogueMagicScepterDressInUnitCsReq> _parser = new MessageParser<RogueMagicScepterDressInUnitCsReq>(() => new RogueMagicScepterDressInUnitCsReq());

		// Token: 0x0400460E RID: 17934
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400460F RID: 17935
		public const int DressMagicUnitUniqueIdFieldNumber = 11;

		// Token: 0x04004610 RID: 17936
		private uint dressMagicUnitUniqueId_;

		// Token: 0x04004611 RID: 17937
		public const int ScepterIdFieldNumber = 15;

		// Token: 0x04004612 RID: 17938
		private uint scepterId_;

		// Token: 0x04004613 RID: 17939
		public const int DiceSlotIdFieldNumber = 14;

		// Token: 0x04004614 RID: 17940
		private uint diceSlotId_;
	}
}
