using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DFF RID: 3583
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeRestartCsReq : IMessage<RogueArcadeRestartCsReq>, IMessage, IEquatable<RogueArcadeRestartCsReq>, IDeepCloneable<RogueArcadeRestartCsReq>, IBufferMessage
	{
		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x001ADFAB File Offset: 0x001AC1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeRestartCsReq> Parser
		{
			get
			{
				return RogueArcadeRestartCsReq._parser;
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600A038 RID: 41016 RVA: 0x001ADFB2 File Offset: 0x001AC1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeRestartCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600A039 RID: 41017 RVA: 0x001ADFC4 File Offset: 0x001AC1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeRestartCsReq.Descriptor;
			}
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x001ADFCB File Offset: 0x001AC1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartCsReq()
		{
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x001ADFD3 File Offset: 0x001AC1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartCsReq(RogueArcadeRestartCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x001ADFEC File Offset: 0x001AC1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartCsReq Clone()
		{
			return new RogueArcadeRestartCsReq(this);
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x001ADFF4 File Offset: 0x001AC1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeRestartCsReq);
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x001AE002 File Offset: 0x001AC202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeRestartCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x001AE020 File Offset: 0x001AC220
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

		// Token: 0x0600A040 RID: 41024 RVA: 0x001AE046 File Offset: 0x001AC246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x001AE04E File Offset: 0x001AC24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x001AE057 File Offset: 0x001AC257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x001AE070 File Offset: 0x001AC270
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

		// Token: 0x0600A044 RID: 41028 RVA: 0x001AE096 File Offset: 0x001AC296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeRestartCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x001AE0B3 File Offset: 0x001AC2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x001AE0BC File Offset: 0x001AC2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041A8 RID: 16808
		private static readonly MessageParser<RogueArcadeRestartCsReq> _parser = new MessageParser<RogueArcadeRestartCsReq>(() => new RogueArcadeRestartCsReq());

		// Token: 0x040041A9 RID: 16809
		private UnknownFieldSet _unknownFields;
	}
}
