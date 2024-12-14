using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EEB RID: 3819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicLeaveCsReq : IMessage<RogueMagicLeaveCsReq>, IMessage, IEquatable<RogueMagicLeaveCsReq>, IDeepCloneable<RogueMagicLeaveCsReq>, IBufferMessage
	{
		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x001CBC93 File Offset: 0x001C9E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicLeaveCsReq> Parser
		{
			get
			{
				return RogueMagicLeaveCsReq._parser;
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x001CBC9A File Offset: 0x001C9E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicLeaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x001CBCAC File Offset: 0x001C9EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicLeaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600AAA9 RID: 43689 RVA: 0x001CBCB3 File Offset: 0x001C9EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveCsReq()
		{
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x001CBCBB File Offset: 0x001C9EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveCsReq(RogueMagicLeaveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x001CBCD4 File Offset: 0x001C9ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveCsReq Clone()
		{
			return new RogueMagicLeaveCsReq(this);
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x001CBCDC File Offset: 0x001C9EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicLeaveCsReq);
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x001CBCEA File Offset: 0x001C9EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicLeaveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x001CBD08 File Offset: 0x001C9F08
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

		// Token: 0x0600AAAF RID: 43695 RVA: 0x001CBD2E File Offset: 0x001C9F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x001CBD36 File Offset: 0x001C9F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x001CBD3F File Offset: 0x001C9F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x001CBD58 File Offset: 0x001C9F58
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

		// Token: 0x0600AAB3 RID: 43699 RVA: 0x001CBD7E File Offset: 0x001C9F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicLeaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x001CBD9B File Offset: 0x001C9F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x001CBDA4 File Offset: 0x001C9FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045AC RID: 17836
		private static readonly MessageParser<RogueMagicLeaveCsReq> _parser = new MessageParser<RogueMagicLeaveCsReq>(() => new RogueMagicLeaveCsReq());

		// Token: 0x040045AD RID: 17837
		private UnknownFieldSet _unknownFields;
	}
}
