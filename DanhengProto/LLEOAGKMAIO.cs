using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A1F RID: 2591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LLEOAGKMAIO : IMessage<LLEOAGKMAIO>, IMessage, IEquatable<LLEOAGKMAIO>, IDeepCloneable<LLEOAGKMAIO>, IBufferMessage
	{
		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x00132C50 File Offset: 0x00130E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LLEOAGKMAIO> Parser
		{
			get
			{
				return LLEOAGKMAIO._parser;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x00132C57 File Offset: 0x00130E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LLEOAGKMAIOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600732E RID: 29486 RVA: 0x00132C69 File Offset: 0x00130E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LLEOAGKMAIO.Descriptor;
			}
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00132C70 File Offset: 0x00130E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO()
		{
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00132C83 File Offset: 0x00130E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO(LLEOAGKMAIO other) : this()
		{
			this.lIOJFHICBMJ_ = other.lIOJFHICBMJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00132CAD File Offset: 0x00130EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO Clone()
		{
			return new LLEOAGKMAIO(this);
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x00132CB5 File Offset: 0x00130EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LIOJFHICBMJ
		{
			get
			{
				return this.lIOJFHICBMJ_;
			}
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00132CBD File Offset: 0x00130EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LLEOAGKMAIO);
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00132CCB File Offset: 0x00130ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LLEOAGKMAIO other)
		{
			return other != null && (other == this || (this.lIOJFHICBMJ_.Equals(other.lIOJFHICBMJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x00132D00 File Offset: 0x00130F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lIOJFHICBMJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00132D34 File Offset: 0x00130F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00132D3C File Offset: 0x00130F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00132D45 File Offset: 0x00130F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lIOJFHICBMJ_.WriteTo(ref output, LLEOAGKMAIO._repeated_lIOJFHICBMJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00132D6C File Offset: 0x00130F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lIOJFHICBMJ_.CalculateSize(LLEOAGKMAIO._repeated_lIOJFHICBMJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00132DA5 File Offset: 0x00130FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LLEOAGKMAIO other)
		{
			if (other == null)
			{
				return;
			}
			this.lIOJFHICBMJ_.Add(other.lIOJFHICBMJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00132DD3 File Offset: 0x00130FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x00132DDC File Offset: 0x00130FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lIOJFHICBMJ_.AddEntriesFrom(ref input, LLEOAGKMAIO._repeated_lIOJFHICBMJ_codec);
				}
			}
		}

		// Token: 0x04002C59 RID: 11353
		private static readonly MessageParser<LLEOAGKMAIO> _parser = new MessageParser<LLEOAGKMAIO>(() => new LLEOAGKMAIO());

		// Token: 0x04002C5A RID: 11354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C5B RID: 11355
		public const int LIOJFHICBMJFieldNumber = 5;

		// Token: 0x04002C5C RID: 11356
		private static readonly FieldCodec<string> _repeated_lIOJFHICBMJ_codec = FieldCodec.ForString(42U);

		// Token: 0x04002C5D RID: 11357
		private readonly RepeatedField<string> lIOJFHICBMJ_ = new RepeatedField<string>();
	}
}
