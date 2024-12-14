using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D91 RID: 3473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RefreshTriggerByClientCsReq : IMessage<RefreshTriggerByClientCsReq>, IMessage, IEquatable<RefreshTriggerByClientCsReq>, IDeepCloneable<RefreshTriggerByClientCsReq>, IBufferMessage
	{
		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x06009B0F RID: 39695 RVA: 0x0019C787 File Offset: 0x0019A987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RefreshTriggerByClientCsReq> Parser
		{
			get
			{
				return RefreshTriggerByClientCsReq._parser;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06009B10 RID: 39696 RVA: 0x0019C78E File Offset: 0x0019A98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06009B11 RID: 39697 RVA: 0x0019C7A0 File Offset: 0x0019A9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshTriggerByClientCsReq.Descriptor;
			}
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x0019C7A7 File Offset: 0x0019A9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientCsReq()
		{
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0019C7C8 File Offset: 0x0019A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientCsReq(RefreshTriggerByClientCsReq other) : this()
		{
			this.triggerTargetIdList_ = other.triggerTargetIdList_.Clone();
			this.triggerMotion_ = ((other.triggerMotion_ != null) ? other.triggerMotion_.Clone() : null);
			this.triggerEntityId_ = other.triggerEntityId_;
			this.triggerName_ = other.triggerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x0019C831 File Offset: 0x0019AA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshTriggerByClientCsReq Clone()
		{
			return new RefreshTriggerByClientCsReq(this);
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x0019C839 File Offset: 0x0019AA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TriggerTargetIdList
		{
			get
			{
				return this.triggerTargetIdList_;
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06009B16 RID: 39702 RVA: 0x0019C841 File Offset: 0x0019AA41
		// (set) Token: 0x06009B17 RID: 39703 RVA: 0x0019C849 File Offset: 0x0019AA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo TriggerMotion
		{
			get
			{
				return this.triggerMotion_;
			}
			set
			{
				this.triggerMotion_ = value;
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06009B18 RID: 39704 RVA: 0x0019C852 File Offset: 0x0019AA52
		// (set) Token: 0x06009B19 RID: 39705 RVA: 0x0019C85A File Offset: 0x0019AA5A
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

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x0019C863 File Offset: 0x0019AA63
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x0019C86B File Offset: 0x0019AA6B
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

		// Token: 0x06009B1C RID: 39708 RVA: 0x0019C87E File Offset: 0x0019AA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshTriggerByClientCsReq);
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x0019C88C File Offset: 0x0019AA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RefreshTriggerByClientCsReq other)
		{
			return other != null && (other == this || (this.triggerTargetIdList_.Equals(other.triggerTargetIdList_) && object.Equals(this.TriggerMotion, other.TriggerMotion) && this.TriggerEntityId == other.TriggerEntityId && !(this.TriggerName != other.TriggerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x0019C904 File Offset: 0x0019AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.triggerTargetIdList_.GetHashCode();
			if (this.triggerMotion_ != null)
			{
				num ^= this.TriggerMotion.GetHashCode();
			}
			if (this.TriggerEntityId != 0U)
			{
				num ^= this.TriggerEntityId.GetHashCode();
			}
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

		// Token: 0x06009B1F RID: 39711 RVA: 0x0019C982 File Offset: 0x0019AB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0019C98A File Offset: 0x0019AB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x0019C994 File Offset: 0x0019AB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.triggerTargetIdList_.WriteTo(ref output, RefreshTriggerByClientCsReq._repeated_triggerTargetIdList_codec);
			if (this.triggerMotion_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TriggerMotion);
			}
			if (this.TriggerName.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.TriggerName);
			}
			if (this.TriggerEntityId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TriggerEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0019CA20 File Offset: 0x0019AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.triggerTargetIdList_.CalculateSize(RefreshTriggerByClientCsReq._repeated_triggerTargetIdList_codec);
			if (this.triggerMotion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TriggerMotion);
			}
			if (this.TriggerEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TriggerEntityId);
			}
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

		// Token: 0x06009B23 RID: 39715 RVA: 0x0019CAA8 File Offset: 0x0019ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RefreshTriggerByClientCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.triggerTargetIdList_.Add(other.triggerTargetIdList_);
			if (other.triggerMotion_ != null)
			{
				if (this.triggerMotion_ == null)
				{
					this.TriggerMotion = new MotionInfo();
				}
				this.TriggerMotion.MergeFrom(other.TriggerMotion);
			}
			if (other.TriggerEntityId != 0U)
			{
				this.TriggerEntityId = other.TriggerEntityId;
			}
			if (other.TriggerName.Length != 0)
			{
				this.TriggerName = other.TriggerName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x0019CB3A File Offset: 0x0019AD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x0019CB44 File Offset: 0x0019AD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.triggerTargetIdList_.AddEntriesFrom(ref input, RefreshTriggerByClientCsReq._repeated_triggerTargetIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.triggerMotion_ == null)
						{
							this.TriggerMotion = new MotionInfo();
						}
						input.ReadMessage(this.TriggerMotion);
						continue;
					}
					if (num == 74U)
					{
						this.TriggerName = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.TriggerEntityId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C27 RID: 15399
		private static readonly MessageParser<RefreshTriggerByClientCsReq> _parser = new MessageParser<RefreshTriggerByClientCsReq>(() => new RefreshTriggerByClientCsReq());

		// Token: 0x04003C28 RID: 15400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C29 RID: 15401
		public const int TriggerTargetIdListFieldNumber = 2;

		// Token: 0x04003C2A RID: 15402
		private static readonly FieldCodec<uint> _repeated_triggerTargetIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04003C2B RID: 15403
		private readonly RepeatedField<uint> triggerTargetIdList_ = new RepeatedField<uint>();

		// Token: 0x04003C2C RID: 15404
		public const int TriggerMotionFieldNumber = 8;

		// Token: 0x04003C2D RID: 15405
		private MotionInfo triggerMotion_;

		// Token: 0x04003C2E RID: 15406
		public const int TriggerEntityIdFieldNumber = 10;

		// Token: 0x04003C2F RID: 15407
		private uint triggerEntityId_;

		// Token: 0x04003C30 RID: 15408
		public const int TriggerNameFieldNumber = 9;

		// Token: 0x04003C31 RID: 15409
		private string triggerName_ = "";
	}
}
