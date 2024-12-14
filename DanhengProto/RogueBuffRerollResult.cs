using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E25 RID: 3621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffRerollResult : IMessage<RogueBuffRerollResult>, IMessage, IEquatable<RogueBuffRerollResult>, IDeepCloneable<RogueBuffRerollResult>, IBufferMessage
	{
		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600A1AD RID: 41389 RVA: 0x001B1327 File Offset: 0x001AF527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffRerollResult> Parser
		{
			get
			{
				return RogueBuffRerollResult._parser;
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x001B132E File Offset: 0x001AF52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffRerollResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600A1AF RID: 41391 RVA: 0x001B1340 File Offset: 0x001AF540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffRerollResult.Descriptor;
			}
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x001B1347 File Offset: 0x001AF547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollResult()
		{
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x001B134F File Offset: 0x001AF54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollResult(RogueBuffRerollResult other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x001B1368 File Offset: 0x001AF568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollResult Clone()
		{
			return new RogueBuffRerollResult(this);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x001B1370 File Offset: 0x001AF570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffRerollResult);
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x001B137E File Offset: 0x001AF57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffRerollResult other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x001B139C File Offset: 0x001AF59C
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

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x001B13C2 File Offset: 0x001AF5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x001B13CA File Offset: 0x001AF5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x001B13D3 File Offset: 0x001AF5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x001B13EC File Offset: 0x001AF5EC
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

		// Token: 0x0600A1BA RID: 41402 RVA: 0x001B1412 File Offset: 0x001AF612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffRerollResult other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x001B142F File Offset: 0x001AF62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x001B1438 File Offset: 0x001AF638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400421F RID: 16927
		private static readonly MessageParser<RogueBuffRerollResult> _parser = new MessageParser<RogueBuffRerollResult>(() => new RogueBuffRerollResult());

		// Token: 0x04004220 RID: 16928
		private UnknownFieldSet _unknownFields;
	}
}
