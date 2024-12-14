using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA1 RID: 4001
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterCsReq : IMessage<RogueTournEnterCsReq>, IMessage, IEquatable<RogueTournEnterCsReq>, IDeepCloneable<RogueTournEnterCsReq>, IBufferMessage
	{
		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600B245 RID: 45637 RVA: 0x001DF143 File Offset: 0x001DD343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterCsReq> Parser
		{
			get
			{
				return RogueTournEnterCsReq._parser;
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x001DF14A File Offset: 0x001DD34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x001DF15C File Offset: 0x001DD35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterCsReq.Descriptor;
			}
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x001DF163 File Offset: 0x001DD363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterCsReq()
		{
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x001DF16B File Offset: 0x001DD36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterCsReq(RogueTournEnterCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x001DF184 File Offset: 0x001DD384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterCsReq Clone()
		{
			return new RogueTournEnterCsReq(this);
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x001DF18C File Offset: 0x001DD38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterCsReq);
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x001DF19A File Offset: 0x001DD39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x001DF1B8 File Offset: 0x001DD3B8
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

		// Token: 0x0600B24E RID: 45646 RVA: 0x001DF1DE File Offset: 0x001DD3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x001DF1E6 File Offset: 0x001DD3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x001DF1EF File Offset: 0x001DD3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x001DF208 File Offset: 0x001DD408
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

		// Token: 0x0600B252 RID: 45650 RVA: 0x001DF22E File Offset: 0x001DD42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x001DF24B File Offset: 0x001DD44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x001DF254 File Offset: 0x001DD454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004878 RID: 18552
		private static readonly MessageParser<RogueTournEnterCsReq> _parser = new MessageParser<RogueTournEnterCsReq>(() => new RogueTournEnterCsReq());

		// Token: 0x04004879 RID: 18553
		private UnknownFieldSet _unknownFields;
	}
}
