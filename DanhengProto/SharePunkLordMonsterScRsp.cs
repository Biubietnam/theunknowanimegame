using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001149 RID: 4425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SharePunkLordMonsterScRsp : IMessage<SharePunkLordMonsterScRsp>, IMessage, IEquatable<SharePunkLordMonsterScRsp>, IDeepCloneable<SharePunkLordMonsterScRsp>, IBufferMessage
	{
		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600C560 RID: 50528 RVA: 0x00211A3F File Offset: 0x0020FC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SharePunkLordMonsterScRsp> Parser
		{
			get
			{
				return SharePunkLordMonsterScRsp._parser;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600C561 RID: 50529 RVA: 0x00211A46 File Offset: 0x0020FC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SharePunkLordMonsterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600C562 RID: 50530 RVA: 0x00211A58 File Offset: 0x0020FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SharePunkLordMonsterScRsp.Descriptor;
			}
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x00211A5F File Offset: 0x0020FC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterScRsp()
		{
		}

		// Token: 0x0600C564 RID: 50532 RVA: 0x00211A68 File Offset: 0x0020FC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterScRsp(SharePunkLordMonsterScRsp other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.retcode_ = other.retcode_;
			this.shareType_ = other.shareType_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x00211ABC File Offset: 0x0020FCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SharePunkLordMonsterScRsp Clone()
		{
			return new SharePunkLordMonsterScRsp(this);
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600C566 RID: 50534 RVA: 0x00211AC4 File Offset: 0x0020FCC4
		// (set) Token: 0x0600C567 RID: 50535 RVA: 0x00211ACC File Offset: 0x0020FCCC
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

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600C568 RID: 50536 RVA: 0x00211AD5 File Offset: 0x0020FCD5
		// (set) Token: 0x0600C569 RID: 50537 RVA: 0x00211ADD File Offset: 0x0020FCDD
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

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x00211AE6 File Offset: 0x0020FCE6
		// (set) Token: 0x0600C56B RID: 50539 RVA: 0x00211AEE File Offset: 0x0020FCEE
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600C56C RID: 50540 RVA: 0x00211AF7 File Offset: 0x0020FCF7
		// (set) Token: 0x0600C56D RID: 50541 RVA: 0x00211AFF File Offset: 0x0020FCFF
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

		// Token: 0x0600C56E RID: 50542 RVA: 0x00211B08 File Offset: 0x0020FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SharePunkLordMonsterScRsp);
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x00211B18 File Offset: 0x0020FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SharePunkLordMonsterScRsp other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Retcode == other.Retcode && this.ShareType == other.ShareType && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C570 RID: 50544 RVA: 0x00211B84 File Offset: 0x0020FD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num ^= this.ShareType.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C571 RID: 50545 RVA: 0x00211C14 File Offset: 0x0020FE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C572 RID: 50546 RVA: 0x00211C1C File Offset: 0x0020FE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x00211C28 File Offset: 0x0020FE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ShareType);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x00211CB8 File Offset: 0x0020FEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ShareType);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C575 RID: 50549 RVA: 0x00211D40 File Offset: 0x0020FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SharePunkLordMonsterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ShareType != PunkLordShareType.None)
			{
				this.ShareType = other.ShareType;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x00211DB8 File Offset: 0x0020FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x00211DC4 File Offset: 0x0020FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ShareType = (PunkLordShareType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.MonsterId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FB3 RID: 20403
		private static readonly MessageParser<SharePunkLordMonsterScRsp> _parser = new MessageParser<SharePunkLordMonsterScRsp>(() => new SharePunkLordMonsterScRsp());

		// Token: 0x04004FB4 RID: 20404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB5 RID: 20405
		public const int MonsterIdFieldNumber = 14;

		// Token: 0x04004FB6 RID: 20406
		private uint monsterId_;

		// Token: 0x04004FB7 RID: 20407
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04004FB8 RID: 20408
		private uint retcode_;

		// Token: 0x04004FB9 RID: 20409
		public const int ShareTypeFieldNumber = 5;

		// Token: 0x04004FBA RID: 20410
		private PunkLordShareType shareType_;

		// Token: 0x04004FBB RID: 20411
		public const int UidFieldNumber = 1;

		// Token: 0x04004FBC RID: 20412
		private uint uid_;
	}
}
