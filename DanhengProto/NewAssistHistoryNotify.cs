using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C0B RID: 3083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NewAssistHistoryNotify : IMessage<NewAssistHistoryNotify>, IMessage, IEquatable<NewAssistHistoryNotify>, IDeepCloneable<NewAssistHistoryNotify>, IBufferMessage
	{
		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600887B RID: 34939 RVA: 0x00168408 File Offset: 0x00166608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewAssistHistoryNotify> Parser
		{
			get
			{
				return NewAssistHistoryNotify._parser;
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600887C RID: 34940 RVA: 0x0016840F File Offset: 0x0016660F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NewAssistHistoryNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600887D RID: 34941 RVA: 0x00168421 File Offset: 0x00166621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewAssistHistoryNotify.Descriptor;
			}
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x00168428 File Offset: 0x00166628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewAssistHistoryNotify()
		{
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x00168430 File Offset: 0x00166630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewAssistHistoryNotify(NewAssistHistoryNotify other) : this()
		{
			this.lLFKHHCBDAF_ = other.lLFKHHCBDAF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x00168455 File Offset: 0x00166655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewAssistHistoryNotify Clone()
		{
			return new NewAssistHistoryNotify(this);
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x0016845D File Offset: 0x0016665D
		// (set) Token: 0x06008882 RID: 34946 RVA: 0x00168465 File Offset: 0x00166665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LLFKHHCBDAF
		{
			get
			{
				return this.lLFKHHCBDAF_;
			}
			set
			{
				this.lLFKHHCBDAF_ = value;
			}
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x0016846E File Offset: 0x0016666E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewAssistHistoryNotify);
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x0016847C File Offset: 0x0016667C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewAssistHistoryNotify other)
		{
			return other != null && (other == this || (this.LLFKHHCBDAF == other.LLFKHHCBDAF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x001684AC File Offset: 0x001666AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LLFKHHCBDAF != 0U)
			{
				num ^= this.LLFKHHCBDAF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x001684EB File Offset: 0x001666EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x001684F3 File Offset: 0x001666F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x001684FC File Offset: 0x001666FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LLFKHHCBDAF != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LLFKHHCBDAF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x00168530 File Offset: 0x00166730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LLFKHHCBDAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LLFKHHCBDAF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x0016856E File Offset: 0x0016676E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewAssistHistoryNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LLFKHHCBDAF != 0U)
			{
				this.LLFKHHCBDAF = other.LLFKHHCBDAF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x0016859F File Offset: 0x0016679F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x001685A8 File Offset: 0x001667A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LLFKHHCBDAF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003451 RID: 13393
		private static readonly MessageParser<NewAssistHistoryNotify> _parser = new MessageParser<NewAssistHistoryNotify>(() => new NewAssistHistoryNotify());

		// Token: 0x04003452 RID: 13394
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003453 RID: 13395
		public const int LLFKHHCBDAFFieldNumber = 14;

		// Token: 0x04003454 RID: 13396
		private uint lLFKHHCBDAF_;
	}
}
