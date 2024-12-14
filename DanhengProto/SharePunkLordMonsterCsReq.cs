using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001147 RID: 4423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SharePunkLordMonsterCsReq : IMessage<SharePunkLordMonsterCsReq>, IMessage, IEquatable<SharePunkLordMonsterCsReq>, IDeepCloneable<SharePunkLordMonsterCsReq>, IBufferMessage
	{
		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600C547 RID: 50503 RVA: 0x0021161F File Offset: 0x0020F81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SharePunkLordMonsterCsReq> Parser
		{
			get
			{
				return SharePunkLordMonsterCsReq._parser;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600C548 RID: 50504 RVA: 0x00211626 File Offset: 0x0020F826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SharePunkLordMonsterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600C549 RID: 50505 RVA: 0x00211638 File Offset: 0x0020F838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SharePunkLordMonsterCsReq.Descriptor;
			}
		}

		// Token: 0x0600C54A RID: 50506 RVA: 0x0021163F File Offset: 0x0020F83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterCsReq()
		{
		}

		// Token: 0x0600C54B RID: 50507 RVA: 0x00211647 File Offset: 0x0020F847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterCsReq(SharePunkLordMonsterCsReq other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.uid_ = other.uid_;
			this.shareType_ = other.shareType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x00211684 File Offset: 0x0020F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterCsReq Clone()
		{
			return new SharePunkLordMonsterCsReq(this);
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600C54D RID: 50509 RVA: 0x0021168C File Offset: 0x0020F88C
		// (set) Token: 0x0600C54E RID: 50510 RVA: 0x00211694 File Offset: 0x0020F894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600C54F RID: 50511 RVA: 0x0021169D File Offset: 0x0020F89D
		// (set) Token: 0x0600C550 RID: 50512 RVA: 0x002116A5 File Offset: 0x0020F8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600C551 RID: 50513 RVA: 0x002116AE File Offset: 0x0020F8AE
		// (set) Token: 0x0600C552 RID: 50514 RVA: 0x002116B6 File Offset: 0x0020F8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordShareType ShareType
		{
			get
			{
				return this.shareType_;
			}
			set
			{
				this.shareType_ = value;
			}
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x002116BF File Offset: 0x0020F8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SharePunkLordMonsterCsReq);
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x002116D0 File Offset: 0x0020F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SharePunkLordMonsterCsReq other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Uid == other.Uid && this.ShareType == other.ShareType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C555 RID: 50517 RVA: 0x0021172C File Offset: 0x0020F92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num ^= this.ShareType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C556 RID: 50518 RVA: 0x002117A3 File Offset: 0x0020F9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C557 RID: 50519 RVA: 0x002117AB File Offset: 0x0020F9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C558 RID: 50520 RVA: 0x002117B4 File Offset: 0x0020F9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ShareType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x0021182C File Offset: 0x0020FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ShareType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C55A RID: 50522 RVA: 0x0021189C File Offset: 0x0020FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SharePunkLordMonsterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.ShareType != PunkLordShareType.None)
			{
				this.ShareType = other.ShareType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C55B RID: 50523 RVA: 0x00211900 File Offset: 0x0020FB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C55C RID: 50524 RVA: 0x0021190C File Offset: 0x0020FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ShareType = (PunkLordShareType)input.ReadEnum();
						}
					}
					else
					{
						this.MonsterId = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004FAA RID: 20394
		private static readonly MessageParser<SharePunkLordMonsterCsReq> _parser = new MessageParser<SharePunkLordMonsterCsReq>(() => new SharePunkLordMonsterCsReq());

		// Token: 0x04004FAB RID: 20395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FAC RID: 20396
		public const int MonsterIdFieldNumber = 10;

		// Token: 0x04004FAD RID: 20397
		private uint monsterId_;

		// Token: 0x04004FAE RID: 20398
		public const int UidFieldNumber = 4;

		// Token: 0x04004FAF RID: 20399
		private uint uid_;

		// Token: 0x04004FB0 RID: 20400
		public const int ShareTypeFieldNumber = 14;

		// Token: 0x04004FB1 RID: 20401
		private PunkLordShareType shareType_;
	}
}
