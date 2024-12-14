using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E27 RID: 3623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffSelectCallback : IMessage<RogueBuffSelectCallback>, IMessage, IEquatable<RogueBuffSelectCallback>, IDeepCloneable<RogueBuffSelectCallback>, IBufferMessage
	{
		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600A1C0 RID: 41408 RVA: 0x001B14DB File Offset: 0x001AF6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffSelectCallback> Parser
		{
			get
			{
				return RogueBuffSelectCallback._parser;
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x001B14E2 File Offset: 0x001AF6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600A1C2 RID: 41410 RVA: 0x001B14F4 File Offset: 0x001AF6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x001B14FB File Offset: 0x001AF6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectCallback()
		{
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x001B1503 File Offset: 0x001AF703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectCallback(RogueBuffSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x001B151C File Offset: 0x001AF71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectCallback Clone()
		{
			return new RogueBuffSelectCallback(this);
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x001B1524 File Offset: 0x001AF724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffSelectCallback);
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x001B1532 File Offset: 0x001AF732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x001B1550 File Offset: 0x001AF750
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

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x001B1576 File Offset: 0x001AF776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x001B157E File Offset: 0x001AF77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x001B1587 File Offset: 0x001AF787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x001B15A0 File Offset: 0x001AF7A0
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

		// Token: 0x0600A1CD RID: 41421 RVA: 0x001B15C6 File Offset: 0x001AF7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x001B15E3 File Offset: 0x001AF7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x001B15EC File Offset: 0x001AF7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004222 RID: 16930
		private static readonly MessageParser<RogueBuffSelectCallback> _parser = new MessageParser<RogueBuffSelectCallback>(() => new RogueBuffSelectCallback());

		// Token: 0x04004223 RID: 16931
		private UnknownFieldSet _unknownFields;
	}
}
