using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DFB RID: 3579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeLeaveCsReq : IMessage<RogueArcadeLeaveCsReq>, IMessage, IEquatable<RogueArcadeLeaveCsReq>, IDeepCloneable<RogueArcadeLeaveCsReq>, IBufferMessage
	{
		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600A00D RID: 40973 RVA: 0x001ADA5F File Offset: 0x001ABC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeLeaveCsReq> Parser
		{
			get
			{
				return RogueArcadeLeaveCsReq._parser;
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x001ADA66 File Offset: 0x001ABC66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeLeaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600A00F RID: 40975 RVA: 0x001ADA78 File Offset: 0x001ABC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeLeaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x001ADA7F File Offset: 0x001ABC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveCsReq()
		{
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x001ADA87 File Offset: 0x001ABC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveCsReq(RogueArcadeLeaveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x001ADAA0 File Offset: 0x001ABCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeLeaveCsReq Clone()
		{
			return new RogueArcadeLeaveCsReq(this);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x001ADAA8 File Offset: 0x001ABCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeLeaveCsReq);
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x001ADAB6 File Offset: 0x001ABCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeLeaveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x001ADAD4 File Offset: 0x001ABCD4
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

		// Token: 0x0600A016 RID: 40982 RVA: 0x001ADAFA File Offset: 0x001ABCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x001ADB02 File Offset: 0x001ABD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x001ADB0B File Offset: 0x001ABD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x001ADB24 File Offset: 0x001ABD24
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

		// Token: 0x0600A01A RID: 40986 RVA: 0x001ADB4A File Offset: 0x001ABD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeLeaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x001ADB67 File Offset: 0x001ABD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x001ADB70 File Offset: 0x001ABD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400419E RID: 16798
		private static readonly MessageParser<RogueArcadeLeaveCsReq> _parser = new MessageParser<RogueArcadeLeaveCsReq>(() => new RogueArcadeLeaveCsReq());

		// Token: 0x0400419F RID: 16799
		private UnknownFieldSet _unknownFields;
	}
}
