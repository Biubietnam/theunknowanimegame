using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012BB RID: 4795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAssistRewardCsReq : IMessage<TakeAssistRewardCsReq>, IMessage, IEquatable<TakeAssistRewardCsReq>, IDeepCloneable<TakeAssistRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x0023AAE7 File Offset: 0x00238CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAssistRewardCsReq> Parser
		{
			get
			{
				return TakeAssistRewardCsReq._parser;
			}
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600D5E2 RID: 54754 RVA: 0x0023AAEE File Offset: 0x00238CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAssistRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x0023AB00 File Offset: 0x00238D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAssistRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x0023AB07 File Offset: 0x00238D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardCsReq()
		{
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x0023AB0F File Offset: 0x00238D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardCsReq(TakeAssistRewardCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x0023AB28 File Offset: 0x00238D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardCsReq Clone()
		{
			return new TakeAssistRewardCsReq(this);
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x0023AB30 File Offset: 0x00238D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAssistRewardCsReq);
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x0023AB3E File Offset: 0x00238D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAssistRewardCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x0023AB5C File Offset: 0x00238D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x0023AB82 File Offset: 0x00238D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x0023AB8A File Offset: 0x00238D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x0023AB93 File Offset: 0x00238D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5ED RID: 54765 RVA: 0x0023ABAC File Offset: 0x00238DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x0023ABD2 File Offset: 0x00238DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAssistRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x0023ABEF File Offset: 0x00238DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5F0 RID: 54768 RVA: 0x0023ABF8 File Offset: 0x00238DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005575 RID: 21877
		private static readonly MessageParser<TakeAssistRewardCsReq> _parser = new MessageParser<TakeAssistRewardCsReq>(() => new TakeAssistRewardCsReq());

		// Token: 0x04005576 RID: 21878
		private UnknownFieldSet _unknownFields;
	}
}
