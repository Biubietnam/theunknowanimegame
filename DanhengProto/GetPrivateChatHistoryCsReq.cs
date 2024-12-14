using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000775 RID: 1909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPrivateChatHistoryCsReq : IMessage<GetPrivateChatHistoryCsReq>, IMessage, IEquatable<GetPrivateChatHistoryCsReq>, IDeepCloneable<GetPrivateChatHistoryCsReq>, IBufferMessage
	{
		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x000E50A5 File Offset: 0x000E32A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPrivateChatHistoryCsReq> Parser
		{
			get
			{
				return GetPrivateChatHistoryCsReq._parser;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x000E50AC File Offset: 0x000E32AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPrivateChatHistoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x000E50BE File Offset: 0x000E32BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPrivateChatHistoryCsReq.Descriptor;
			}
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x000E50C5 File Offset: 0x000E32C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryCsReq()
		{
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x000E50CD File Offset: 0x000E32CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryCsReq(GetPrivateChatHistoryCsReq other) : this()
		{
			this.contactId_ = other.contactId_;
			this.targetUid_ = other.targetUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x000E50FE File Offset: 0x000E32FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryCsReq Clone()
		{
			return new GetPrivateChatHistoryCsReq(this);
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x000E5106 File Offset: 0x000E3306
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x000E510E File Offset: 0x000E330E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContactId
		{
			get
			{
				return this.contactId_;
			}
			set
			{
				this.contactId_ = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x000E5117 File Offset: 0x000E3317
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x000E511F File Offset: 0x000E331F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetUid
		{
			get
			{
				return this.targetUid_;
			}
			set
			{
				this.targetUid_ = value;
			}
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x000E5128 File Offset: 0x000E3328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPrivateChatHistoryCsReq);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x000E5136 File Offset: 0x000E3336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPrivateChatHistoryCsReq other)
		{
			return other != null && (other == this || (this.ContactId == other.ContactId && this.TargetUid == other.TargetUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x000E5174 File Offset: 0x000E3374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContactId != 0U)
			{
				num ^= this.ContactId.GetHashCode();
			}
			if (this.TargetUid != 0U)
			{
				num ^= this.TargetUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x000E51CC File Offset: 0x000E33CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x000E51D4 File Offset: 0x000E33D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x000E51E0 File Offset: 0x000E33E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUid != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.TargetUid);
			}
			if (this.ContactId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ContactId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x000E523C File Offset: 0x000E343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContactId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContactId);
			}
			if (this.TargetUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x000E5294 File Offset: 0x000E3494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPrivateChatHistoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContactId != 0U)
			{
				this.ContactId = other.ContactId;
			}
			if (other.TargetUid != 0U)
			{
				this.TargetUid = other.TargetUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x000E52E4 File Offset: 0x000E34E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x000E52F0 File Offset: 0x000E34F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ContactId = input.ReadUInt32();
					}
				}
				else
				{
					this.TargetUid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400216D RID: 8557
		private static readonly MessageParser<GetPrivateChatHistoryCsReq> _parser = new MessageParser<GetPrivateChatHistoryCsReq>(() => new GetPrivateChatHistoryCsReq());

		// Token: 0x0400216E RID: 8558
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400216F RID: 8559
		public const int ContactIdFieldNumber = 11;

		// Token: 0x04002170 RID: 8560
		private uint contactId_;

		// Token: 0x04002171 RID: 8561
		public const int TargetUidFieldNumber = 3;

		// Token: 0x04002172 RID: 8562
		private uint targetUid_;
	}
}
