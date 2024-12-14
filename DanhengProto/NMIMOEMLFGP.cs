using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C23 RID: 3107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NMIMOEMLFGP : IMessage<NMIMOEMLFGP>, IMessage, IEquatable<NMIMOEMLFGP>, IDeepCloneable<NMIMOEMLFGP>, IBufferMessage
	{
		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x060089A5 RID: 35237 RVA: 0x0016B84C File Offset: 0x00169A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NMIMOEMLFGP> Parser
		{
			get
			{
				return NMIMOEMLFGP._parser;
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x0016B853 File Offset: 0x00169A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NMIMOEMLFGPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x060089A7 RID: 35239 RVA: 0x0016B865 File Offset: 0x00169A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NMIMOEMLFGP.Descriptor;
			}
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0016B86C File Offset: 0x00169A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMIMOEMLFGP()
		{
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x0016B874 File Offset: 0x00169A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMIMOEMLFGP(NMIMOEMLFGP other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x0016B899 File Offset: 0x00169A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NMIMOEMLFGP Clone()
		{
			return new NMIMOEMLFGP(this);
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x060089AB RID: 35243 RVA: 0x0016B8A1 File Offset: 0x00169AA1
		// (set) Token: 0x060089AC RID: 35244 RVA: 0x0016B8A9 File Offset: 0x00169AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x0016B8B2 File Offset: 0x00169AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NMIMOEMLFGP);
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x0016B8C0 File Offset: 0x00169AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NMIMOEMLFGP other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x0016B8F0 File Offset: 0x00169AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x0016B92F File Offset: 0x00169B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x0016B937 File Offset: 0x00169B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x0016B940 File Offset: 0x00169B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x0016B974 File Offset: 0x00169B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x0016B9B2 File Offset: 0x00169BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NMIMOEMLFGP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x0016B9E3 File Offset: 0x00169BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x0016B9EC File Offset: 0x00169BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.COJGEGHIADI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040034CB RID: 13515
		private static readonly MessageParser<NMIMOEMLFGP> _parser = new MessageParser<NMIMOEMLFGP>(() => new NMIMOEMLFGP());

		// Token: 0x040034CC RID: 13516
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034CD RID: 13517
		public const int COJGEGHIADIFieldNumber = 5;

		// Token: 0x040034CE RID: 13518
		private uint cOJGEGHIADI_;
	}
}
