using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D95 RID: 3477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RefreshTriggerByClientScRsp : IMessage<RefreshTriggerByClientScRsp>, IMessage, IEquatable<RefreshTriggerByClientScRsp>, IDeepCloneable<RefreshTriggerByClientScRsp>, IBufferMessage
	{
		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x06009B41 RID: 39745 RVA: 0x0019D0FF File Offset: 0x0019B2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RefreshTriggerByClientScRsp> Parser
		{
			get
			{
				return RefreshTriggerByClientScRsp._parser;
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06009B42 RID: 39746 RVA: 0x0019D106 File Offset: 0x0019B306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x0019D118 File Offset: 0x0019B318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshTriggerByClientScRsp.Descriptor;
			}
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x0019D11F File Offset: 0x0019B31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScRsp()
		{
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x0019D134 File Offset: 0x0019B334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScRsp(RefreshTriggerByClientScRsp other) : this()
		{
			this.refreshTrigger_ = other.refreshTrigger_;
			this.triggerName_ = other.triggerName_;
			this.triggerEntityId_ = other.triggerEntityId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0019D188 File Offset: 0x0019B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScRsp Clone()
		{
			return new RefreshTriggerByClientScRsp(this);
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06009B47 RID: 39751 RVA: 0x0019D190 File Offset: 0x0019B390
		// (set) Token: 0x06009B48 RID: 39752 RVA: 0x0019D198 File Offset: 0x0019B398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RefreshTrigger
		{
			get
			{
				return this.refreshTrigger_;
			}
			set
			{
				this.refreshTrigger_ = value;
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06009B49 RID: 39753 RVA: 0x0019D1A1 File Offset: 0x0019B3A1
		// (set) Token: 0x06009B4A RID: 39754 RVA: 0x0019D1A9 File Offset: 0x0019B3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TriggerName
		{
			get
			{
				return this.triggerName_;
			}
			set
			{
				this.triggerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06009B4B RID: 39755 RVA: 0x0019D1BC File Offset: 0x0019B3BC
		// (set) Token: 0x06009B4C RID: 39756 RVA: 0x0019D1C4 File Offset: 0x0019B3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TriggerEntityId
		{
			get
			{
				return this.triggerEntityId_;
			}
			set
			{
				this.triggerEntityId_ = value;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06009B4D RID: 39757 RVA: 0x0019D1CD File Offset: 0x0019B3CD
		// (set) Token: 0x06009B4E RID: 39758 RVA: 0x0019D1D5 File Offset: 0x0019B3D5
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

		// Token: 0x06009B4F RID: 39759 RVA: 0x0019D1DE File Offset: 0x0019B3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshTriggerByClientScRsp);
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x0019D1EC File Offset: 0x0019B3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RefreshTriggerByClientScRsp other)
		{
			return other != null && (other == this || (this.RefreshTrigger == other.RefreshTrigger && !(this.TriggerName != other.TriggerName) && this.TriggerEntityId == other.TriggerEntityId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x0019D25C File Offset: 0x0019B45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RefreshTrigger)
			{
				num ^= this.RefreshTrigger.GetHashCode();
			}
			if (this.TriggerName.Length != 0)
			{
				num ^= this.TriggerName.GetHashCode();
			}
			if (this.TriggerEntityId != 0U)
			{
				num ^= this.TriggerEntityId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x0019D2E8 File Offset: 0x0019B4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x0019D2F0 File Offset: 0x0019B4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x0019D2FC File Offset: 0x0019B4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TriggerName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TriggerName);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.TriggerEntityId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.TriggerEntityId);
			}
			if (this.RefreshTrigger)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.RefreshTrigger);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x0019D394 File Offset: 0x0019B594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RefreshTrigger)
			{
				num += 2;
			}
			if (this.TriggerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TriggerName);
			}
			if (this.TriggerEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TriggerEntityId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x0019D414 File Offset: 0x0019B614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RefreshTriggerByClientScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RefreshTrigger)
			{
				this.RefreshTrigger = other.RefreshTrigger;
			}
			if (other.TriggerName.Length != 0)
			{
				this.TriggerName = other.TriggerName;
			}
			if (other.TriggerEntityId != 0U)
			{
				this.TriggerEntityId = other.TriggerEntityId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x0019D491 File Offset: 0x0019B691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x0019D49C File Offset: 0x0019B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.TriggerName = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.TriggerEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RefreshTrigger = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C3D RID: 15421
		private static readonly MessageParser<RefreshTriggerByClientScRsp> _parser = new MessageParser<RefreshTriggerByClientScRsp>(() => new RefreshTriggerByClientScRsp());

		// Token: 0x04003C3E RID: 15422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C3F RID: 15423
		public const int RefreshTriggerFieldNumber = 15;

		// Token: 0x04003C40 RID: 15424
		private bool refreshTrigger_;

		// Token: 0x04003C41 RID: 15425
		public const int TriggerNameFieldNumber = 1;

		// Token: 0x04003C42 RID: 15426
		private string triggerName_ = "";

		// Token: 0x04003C43 RID: 15427
		public const int TriggerEntityIdFieldNumber = 9;

		// Token: 0x04003C44 RID: 15428
		private uint triggerEntityId_;

		// Token: 0x04003C45 RID: 15429
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04003C46 RID: 15430
		private uint retcode_;
	}
}
