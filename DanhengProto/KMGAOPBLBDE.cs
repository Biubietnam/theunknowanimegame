using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C5 RID: 2501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KMGAOPBLBDE : IMessage<KMGAOPBLBDE>, IMessage, IEquatable<KMGAOPBLBDE>, IDeepCloneable<KMGAOPBLBDE>, IBufferMessage
	{
		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x0012A140 File Offset: 0x00128340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KMGAOPBLBDE> Parser
		{
			get
			{
				return KMGAOPBLBDE._parser;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x0012A147 File Offset: 0x00128347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KMGAOPBLBDEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x0012A159 File Offset: 0x00128359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KMGAOPBLBDE.Descriptor;
			}
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x0012A160 File Offset: 0x00128360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KMGAOPBLBDE()
		{
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x0012A168 File Offset: 0x00128368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KMGAOPBLBDE(KMGAOPBLBDE other) : this()
		{
			this.cFMLIILILHD_ = other.cFMLIILILHD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x0012A18D File Offset: 0x0012838D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KMGAOPBLBDE Clone()
		{
			return new KMGAOPBLBDE(this);
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x0012A195 File Offset: 0x00128395
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x0012A19D File Offset: 0x0012839D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CFMLIILILHD
		{
			get
			{
				return this.cFMLIILILHD_;
			}
			set
			{
				this.cFMLIILILHD_ = value;
			}
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x0012A1A6 File Offset: 0x001283A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KMGAOPBLBDE);
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x0012A1B4 File Offset: 0x001283B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KMGAOPBLBDE other)
		{
			return other != null && (other == this || (this.CFMLIILILHD == other.CFMLIILILHD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x0012A1E4 File Offset: 0x001283E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CFMLIILILHD != 0U)
			{
				num ^= this.CFMLIILILHD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x0012A223 File Offset: 0x00128423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x0012A22B File Offset: 0x0012842B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x0012A234 File Offset: 0x00128434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CFMLIILILHD != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CFMLIILILHD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x0012A268 File Offset: 0x00128468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CFMLIILILHD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CFMLIILILHD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x0012A2A6 File Offset: 0x001284A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KMGAOPBLBDE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CFMLIILILHD != 0U)
			{
				this.CFMLIILILHD = other.CFMLIILILHD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x0012A2D7 File Offset: 0x001284D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x0012A2E0 File Offset: 0x001284E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CFMLIILILHD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002AEE RID: 10990
		private static readonly MessageParser<KMGAOPBLBDE> _parser = new MessageParser<KMGAOPBLBDE>(() => new KMGAOPBLBDE());

		// Token: 0x04002AEF RID: 10991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AF0 RID: 10992
		public const int CFMLIILILHDFieldNumber = 8;

		// Token: 0x04002AF1 RID: 10993
		private uint cFMLIILILHD_;
	}
}
