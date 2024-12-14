using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000113 RID: 275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BEJAIEGKJCN : IMessage<BEJAIEGKJCN>, IMessage, IEquatable<BEJAIEGKJCN>, IDeepCloneable<BEJAIEGKJCN>, IBufferMessage
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00025880 File Offset: 0x00023A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BEJAIEGKJCN> Parser
		{
			get
			{
				return BEJAIEGKJCN._parser;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00025887 File Offset: 0x00023A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BEJAIEGKJCNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00025899 File Offset: 0x00023A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BEJAIEGKJCN.Descriptor;
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000258A0 File Offset: 0x00023AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BEJAIEGKJCN()
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000258B3 File Offset: 0x00023AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BEJAIEGKJCN(BEJAIEGKJCN other) : this()
		{
			this.nFGFDOGFMMP_ = other.nFGFDOGFMMP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000258DD File Offset: 0x00023ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BEJAIEGKJCN Clone()
		{
			return new BEJAIEGKJCN(this);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000258E5 File Offset: 0x00023AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MONFGAKJBGN> NFGFDOGFMMP
		{
			get
			{
				return this.nFGFDOGFMMP_;
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000258ED File Offset: 0x00023AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BEJAIEGKJCN);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000258FB File Offset: 0x00023AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BEJAIEGKJCN other)
		{
			return other != null && (other == this || (this.nFGFDOGFMMP_.Equals(other.nFGFDOGFMMP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00025930 File Offset: 0x00023B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nFGFDOGFMMP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00025964 File Offset: 0x00023B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002596C File Offset: 0x00023B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00025975 File Offset: 0x00023B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nFGFDOGFMMP_.WriteTo(ref output, BEJAIEGKJCN._repeated_nFGFDOGFMMP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0002599C File Offset: 0x00023B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nFGFDOGFMMP_.CalculateSize(BEJAIEGKJCN._repeated_nFGFDOGFMMP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000259D5 File Offset: 0x00023BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BEJAIEGKJCN other)
		{
			if (other == null)
			{
				return;
			}
			this.nFGFDOGFMMP_.Add(other.nFGFDOGFMMP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00025A03 File Offset: 0x00023C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00025A0C File Offset: 0x00023C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.nFGFDOGFMMP_.AddEntriesFrom(ref input, BEJAIEGKJCN._repeated_nFGFDOGFMMP_codec);
				}
			}
		}

		// Token: 0x04000570 RID: 1392
		private static readonly MessageParser<BEJAIEGKJCN> _parser = new MessageParser<BEJAIEGKJCN>(() => new BEJAIEGKJCN());

		// Token: 0x04000571 RID: 1393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000572 RID: 1394
		public const int NFGFDOGFMMPFieldNumber = 13;

		// Token: 0x04000573 RID: 1395
		private static readonly FieldCodec<MONFGAKJBGN> _repeated_nFGFDOGFMMP_codec = FieldCodec.ForMessage<MONFGAKJBGN>(106U, MONFGAKJBGN.Parser);

		// Token: 0x04000574 RID: 1396
		private readonly RepeatedField<MONFGAKJBGN> nFGFDOGFMMP_ = new RepeatedField<MONFGAKJBGN>();
	}
}
