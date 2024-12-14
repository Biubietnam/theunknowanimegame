using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D93 RID: 3475
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RefreshTriggerByClientScNotify : IMessage<RefreshTriggerByClientScNotify>, IMessage, IEquatable<RefreshTriggerByClientScNotify>, IDeepCloneable<RefreshTriggerByClientScNotify>, IBufferMessage
	{
		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06009B29 RID: 39721 RVA: 0x0019CCAF File Offset: 0x0019AEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RefreshTriggerByClientScNotify> Parser
		{
			get
			{
				return RefreshTriggerByClientScNotify._parser;
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x0019CCB6 File Offset: 0x0019AEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x0019CCC8 File Offset: 0x0019AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshTriggerByClientScNotify.Descriptor;
			}
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x0019CCCF File Offset: 0x0019AECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScNotify()
		{
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x0019CCF0 File Offset: 0x0019AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScNotify(RefreshTriggerByClientScNotify other) : this()
		{
			this.triggerEntityId_ = other.triggerEntityId_;
			this.triggerTargetIdList_ = other.triggerTargetIdList_.Clone();
			this.triggerName_ = other.triggerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x0019CD3D File Offset: 0x0019AF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientScNotify Clone()
		{
			return new RefreshTriggerByClientScNotify(this);
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x0019CD45 File Offset: 0x0019AF45
		// (set) Token: 0x06009B30 RID: 39728 RVA: 0x0019CD4D File Offset: 0x0019AF4D
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

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06009B31 RID: 39729 RVA: 0x0019CD56 File Offset: 0x0019AF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TriggerTargetIdList
		{
			get
			{
				return this.triggerTargetIdList_;
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x0019CD5E File Offset: 0x0019AF5E
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x0019CD66 File Offset: 0x0019AF66
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

		// Token: 0x06009B34 RID: 39732 RVA: 0x0019CD79 File Offset: 0x0019AF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshTriggerByClientScNotify);
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x0019CD88 File Offset: 0x0019AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RefreshTriggerByClientScNotify other)
		{
			return other != null && (other == this || (this.TriggerEntityId == other.TriggerEntityId && this.triggerTargetIdList_.Equals(other.triggerTargetIdList_) && !(this.TriggerName != other.TriggerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x0019CDEC File Offset: 0x0019AFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TriggerEntityId != 0U)
			{
				num ^= this.TriggerEntityId.GetHashCode();
			}
			num ^= this.triggerTargetIdList_.GetHashCode();
			if (this.TriggerName.Length != 0)
			{
				num ^= this.TriggerName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x0019CE54 File Offset: 0x0019B054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x0019CE5C File Offset: 0x0019B05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x0019CE68 File Offset: 0x0019B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TriggerEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TriggerEntityId);
			}
			this.triggerTargetIdList_.WriteTo(ref output, RefreshTriggerByClientScNotify._repeated_triggerTargetIdList_codec);
			if (this.TriggerName.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.TriggerName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x0019CED8 File Offset: 0x0019B0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TriggerEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TriggerEntityId);
			}
			num += this.triggerTargetIdList_.CalculateSize(RefreshTriggerByClientScNotify._repeated_triggerTargetIdList_codec);
			if (this.TriggerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TriggerName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0019CF48 File Offset: 0x0019B148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RefreshTriggerByClientScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TriggerEntityId != 0U)
			{
				this.TriggerEntityId = other.TriggerEntityId;
			}
			this.triggerTargetIdList_.Add(other.triggerTargetIdList_);
			if (other.TriggerName.Length != 0)
			{
				this.TriggerName = other.TriggerName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x0019CFAE File Offset: 0x0019B1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x0019CFB8 File Offset: 0x0019B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 32U)
					{
						this.TriggerEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 90U)
					{
						goto IL_3F;
					}
					if (num == 122U)
					{
						this.TriggerName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.triggerTargetIdList_.AddEntriesFrom(ref input, RefreshTriggerByClientScNotify._repeated_triggerTargetIdList_codec);
			}
		}

		// Token: 0x04003C33 RID: 15411
		private static readonly MessageParser<RefreshTriggerByClientScNotify> _parser = new MessageParser<RefreshTriggerByClientScNotify>(() => new RefreshTriggerByClientScNotify());

		// Token: 0x04003C34 RID: 15412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C35 RID: 15413
		public const int TriggerEntityIdFieldNumber = 4;

		// Token: 0x04003C36 RID: 15414
		private uint triggerEntityId_;

		// Token: 0x04003C37 RID: 15415
		public const int TriggerTargetIdListFieldNumber = 11;

		// Token: 0x04003C38 RID: 15416
		private static readonly FieldCodec<uint> _repeated_triggerTargetIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04003C39 RID: 15417
		private readonly RepeatedField<uint> triggerTargetIdList_ = new RepeatedField<uint>();

		// Token: 0x04003C3A RID: 15418
		public const int TriggerNameFieldNumber = 15;

		// Token: 0x04003C3B RID: 15419
		private string triggerName_ = "";
	}
}
