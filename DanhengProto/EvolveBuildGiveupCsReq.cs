using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A7 RID: 1191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildGiveupCsReq : IMessage<EvolveBuildGiveupCsReq>, IMessage, IEquatable<EvolveBuildGiveupCsReq>, IDeepCloneable<EvolveBuildGiveupCsReq>, IBufferMessage
	{
		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x00092D7B File Offset: 0x00090F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildGiveupCsReq> Parser
		{
			get
			{
				return EvolveBuildGiveupCsReq._parser;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x00092D82 File Offset: 0x00090F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildGiveupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x00092D94 File Offset: 0x00090F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildGiveupCsReq.Descriptor;
			}
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00092D9B File Offset: 0x00090F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupCsReq()
		{
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00092DA3 File Offset: 0x00090FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupCsReq(EvolveBuildGiveupCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00092DBC File Offset: 0x00090FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupCsReq Clone()
		{
			return new EvolveBuildGiveupCsReq(this);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00092DC4 File Offset: 0x00090FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildGiveupCsReq);
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00092DD2 File Offset: 0x00090FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildGiveupCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00092DF0 File Offset: 0x00090FF0
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

		// Token: 0x0600354A RID: 13642 RVA: 0x00092E16 File Offset: 0x00091016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00092E1E File Offset: 0x0009101E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00092E27 File Offset: 0x00091027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00092E40 File Offset: 0x00091040
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

		// Token: 0x0600354E RID: 13646 RVA: 0x00092E66 File Offset: 0x00091066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildGiveupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00092E83 File Offset: 0x00091083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00092E8C File Offset: 0x0009108C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001546 RID: 5446
		private static readonly MessageParser<EvolveBuildGiveupCsReq> _parser = new MessageParser<EvolveBuildGiveupCsReq>(() => new EvolveBuildGiveupCsReq());

		// Token: 0x04001547 RID: 5447
		private UnknownFieldSet _unknownFields;
	}
}
