using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C9 RID: 2505
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KNGCGMILGKE : IMessage<KNGCGMILGKE>, IMessage, IEquatable<KNGCGMILGKE>, IDeepCloneable<KNGCGMILGKE>, IBufferMessage
	{
		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06006FB9 RID: 28601 RVA: 0x0012A450 File Offset: 0x00128650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KNGCGMILGKE> Parser
		{
			get
			{
				return KNGCGMILGKE._parser;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06006FBA RID: 28602 RVA: 0x0012A457 File Offset: 0x00128657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KNGCGMILGKEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x0012A469 File Offset: 0x00128669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KNGCGMILGKE.Descriptor;
			}
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x0012A470 File Offset: 0x00128670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNGCGMILGKE()
		{
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x0012A483 File Offset: 0x00128683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNGCGMILGKE(KNGCGMILGKE other) : this()
		{
			this.kIJPNCLPMGC_ = other.kIJPNCLPMGC_.Clone();
			this.gPCFHFKHMID_ = other.gPCFHFKHMID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x0012A4B9 File Offset: 0x001286B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KNGCGMILGKE Clone()
		{
			return new KNGCGMILGKE(this);
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x0012A4C1 File Offset: 0x001286C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KIJPNCLPMGC
		{
			get
			{
				return this.kIJPNCLPMGC_;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06006FC0 RID: 28608 RVA: 0x0012A4C9 File Offset: 0x001286C9
		// (set) Token: 0x06006FC1 RID: 28609 RVA: 0x0012A4D1 File Offset: 0x001286D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPCFHFKHMID
		{
			get
			{
				return this.gPCFHFKHMID_;
			}
			set
			{
				this.gPCFHFKHMID_ = value;
			}
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x0012A4DA File Offset: 0x001286DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KNGCGMILGKE);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x0012A4E8 File Offset: 0x001286E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KNGCGMILGKE other)
		{
			return other != null && (other == this || (this.kIJPNCLPMGC_.Equals(other.kIJPNCLPMGC_) && this.GPCFHFKHMID == other.GPCFHFKHMID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x0012A538 File Offset: 0x00128738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kIJPNCLPMGC_.GetHashCode();
			if (this.GPCFHFKHMID != 0U)
			{
				num ^= this.GPCFHFKHMID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x0012A585 File Offset: 0x00128785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x0012A58D File Offset: 0x0012878D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x0012A598 File Offset: 0x00128798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kIJPNCLPMGC_.WriteTo(ref output, KNGCGMILGKE._repeated_kIJPNCLPMGC_codec);
			if (this.GPCFHFKHMID != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GPCFHFKHMID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x0012A5E8 File Offset: 0x001287E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kIJPNCLPMGC_.CalculateSize(KNGCGMILGKE._repeated_kIJPNCLPMGC_codec);
			if (this.GPCFHFKHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPCFHFKHMID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x0012A63C File Offset: 0x0012883C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KNGCGMILGKE other)
		{
			if (other == null)
			{
				return;
			}
			this.kIJPNCLPMGC_.Add(other.kIJPNCLPMGC_);
			if (other.GPCFHFKHMID != 0U)
			{
				this.GPCFHFKHMID = other.GPCFHFKHMID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x0012A689 File Offset: 0x00128889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x0012A694 File Offset: 0x00128894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GPCFHFKHMID = input.ReadUInt32();
					}
				}
				else
				{
					this.kIJPNCLPMGC_.AddEntriesFrom(ref input, KNGCGMILGKE._repeated_kIJPNCLPMGC_codec);
				}
			}
		}

		// Token: 0x04002AFD RID: 11005
		private static readonly MessageParser<KNGCGMILGKE> _parser = new MessageParser<KNGCGMILGKE>(() => new KNGCGMILGKE());

		// Token: 0x04002AFE RID: 11006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AFF RID: 11007
		public const int KIJPNCLPMGCFieldNumber = 1;

		// Token: 0x04002B00 RID: 11008
		private static readonly FieldCodec<uint> _repeated_kIJPNCLPMGC_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002B01 RID: 11009
		private readonly RepeatedField<uint> kIJPNCLPMGC_ = new RepeatedField<uint>();

		// Token: 0x04002B02 RID: 11010
		public const int GPCFHFKHMIDFieldNumber = 13;

		// Token: 0x04002B03 RID: 11011
		private uint gPCFHFKHMID_;
	}
}
