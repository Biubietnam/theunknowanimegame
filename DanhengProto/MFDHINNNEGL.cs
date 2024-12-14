using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ACD RID: 2765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MFDHINNNEGL : IMessage<MFDHINNNEGL>, IMessage, IEquatable<MFDHINNNEGL>, IDeepCloneable<MFDHINNNEGL>, IBufferMessage
	{
		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x0014474E File Offset: 0x0014294E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MFDHINNNEGL> Parser
		{
			get
			{
				return MFDHINNNEGL._parser;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x00144755 File Offset: 0x00142955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MFDHINNNEGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x00144767 File Offset: 0x00142967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MFDHINNNEGL.Descriptor;
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x0014476E File Offset: 0x0014296E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDHINNNEGL()
		{
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00144776 File Offset: 0x00142976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDHINNNEGL(MFDHINNNEGL other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x0014478F File Offset: 0x0014298F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFDHINNNEGL Clone()
		{
			return new MFDHINNNEGL(this);
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00144797 File Offset: 0x00142997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MFDHINNNEGL);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x001447A5 File Offset: 0x001429A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MFDHINNNEGL other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x001447C4 File Offset: 0x001429C4
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

		// Token: 0x06007A87 RID: 31367 RVA: 0x001447EA File Offset: 0x001429EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x001447F2 File Offset: 0x001429F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x001447FB File Offset: 0x001429FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x00144814 File Offset: 0x00142A14
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

		// Token: 0x06007A8B RID: 31371 RVA: 0x0014483A File Offset: 0x00142A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MFDHINNNEGL other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x00144857 File Offset: 0x00142A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00144860 File Offset: 0x00142A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F09 RID: 12041
		private static readonly MessageParser<MFDHINNNEGL> _parser = new MessageParser<MFDHINNNEGL>(() => new MFDHINNNEGL());

		// Token: 0x04002F0A RID: 12042
		private UnknownFieldSet _unknownFields;
	}
}
