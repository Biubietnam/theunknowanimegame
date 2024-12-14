using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200013B RID: 315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BOEHIOPOPAF : IMessage<BOEHIOPOPAF>, IMessage, IEquatable<BOEHIOPOPAF>, IDeepCloneable<BOEHIOPOPAF>, IBufferMessage
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0002A29C File Offset: 0x0002849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BOEHIOPOPAF> Parser
		{
			get
			{
				return BOEHIOPOPAF._parser;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0002A2A3 File Offset: 0x000284A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BOEHIOPOPAFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0002A2B5 File Offset: 0x000284B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BOEHIOPOPAF.Descriptor;
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0002A2BC File Offset: 0x000284BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BOEHIOPOPAF()
		{
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002A2CF File Offset: 0x000284CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BOEHIOPOPAF(BOEHIOPOPAF other) : this()
		{
			this.iKJJPGBFLPD_ = other.iKJJPGBFLPD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0002A2F9 File Offset: 0x000284F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BOEHIOPOPAF Clone()
		{
			return new BOEHIOPOPAF(this);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0002A301 File Offset: 0x00028501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IKJJPGBFLPD
		{
			get
			{
				return this.iKJJPGBFLPD_;
			}
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002A309 File Offset: 0x00028509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BOEHIOPOPAF);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0002A317 File Offset: 0x00028517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BOEHIOPOPAF other)
		{
			return other != null && (other == this || (this.iKJJPGBFLPD_.Equals(other.iKJJPGBFLPD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0002A34C File Offset: 0x0002854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iKJJPGBFLPD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0002A380 File Offset: 0x00028580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0002A388 File Offset: 0x00028588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0002A391 File Offset: 0x00028591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iKJJPGBFLPD_.WriteTo(ref output, BOEHIOPOPAF._repeated_iKJJPGBFLPD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0002A3B8 File Offset: 0x000285B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iKJJPGBFLPD_.CalculateSize(BOEHIOPOPAF._repeated_iKJJPGBFLPD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0002A3F1 File Offset: 0x000285F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BOEHIOPOPAF other)
		{
			if (other == null)
			{
				return;
			}
			this.iKJJPGBFLPD_.Add(other.iKJJPGBFLPD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0002A41F File Offset: 0x0002861F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0002A428 File Offset: 0x00028628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.iKJJPGBFLPD_.AddEntriesFrom(ref input, BOEHIOPOPAF._repeated_iKJJPGBFLPD_codec);
				}
			}
		}

		// Token: 0x0400061F RID: 1567
		private static readonly MessageParser<BOEHIOPOPAF> _parser = new MessageParser<BOEHIOPOPAF>(() => new BOEHIOPOPAF());

		// Token: 0x04000620 RID: 1568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000621 RID: 1569
		public const int IKJJPGBFLPDFieldNumber = 5;

		// Token: 0x04000622 RID: 1570
		private static readonly FieldCodec<uint> _repeated_iKJJPGBFLPD_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04000623 RID: 1571
		private readonly RepeatedField<uint> iKJJPGBFLPD_ = new RepeatedField<uint>();
	}
}
