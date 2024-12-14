using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D89 RID: 3465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RecoverAllLineupCsReq : IMessage<RecoverAllLineupCsReq>, IMessage, IEquatable<RecoverAllLineupCsReq>, IDeepCloneable<RecoverAllLineupCsReq>, IBufferMessage
	{
		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x0019BC43 File Offset: 0x00199E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecoverAllLineupCsReq> Parser
		{
			get
			{
				return RecoverAllLineupCsReq._parser;
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x0019BC4A File Offset: 0x00199E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecoverAllLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06009ABB RID: 39611 RVA: 0x0019BC5C File Offset: 0x00199E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverAllLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x0019BC63 File Offset: 0x00199E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupCsReq()
		{
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x0019BC6B File Offset: 0x00199E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupCsReq(RecoverAllLineupCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x0019BC84 File Offset: 0x00199E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAllLineupCsReq Clone()
		{
			return new RecoverAllLineupCsReq(this);
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x0019BC8C File Offset: 0x00199E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverAllLineupCsReq);
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x0019BC9A File Offset: 0x00199E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverAllLineupCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x0019BCB8 File Offset: 0x00199EB8
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

		// Token: 0x06009AC2 RID: 39618 RVA: 0x0019BCDE File Offset: 0x00199EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x0019BCE6 File Offset: 0x00199EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x0019BCEF File Offset: 0x00199EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x0019BD08 File Offset: 0x00199F08
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

		// Token: 0x06009AC6 RID: 39622 RVA: 0x0019BD2E File Offset: 0x00199F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecoverAllLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x0019BD4B File Offset: 0x00199F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x0019BD54 File Offset: 0x00199F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C11 RID: 15377
		private static readonly MessageParser<RecoverAllLineupCsReq> _parser = new MessageParser<RecoverAllLineupCsReq>(() => new RecoverAllLineupCsReq());

		// Token: 0x04003C12 RID: 15378
		private UnknownFieldSet _unknownFields;
	}
}
