using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B2D RID: 2861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameBingoFlipCardCsReq : IMessage<MonopolyGameBingoFlipCardCsReq>, IMessage, IEquatable<MonopolyGameBingoFlipCardCsReq>, IDeepCloneable<MonopolyGameBingoFlipCardCsReq>, IBufferMessage
	{
		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06007EA3 RID: 32419 RVA: 0x0014ECB8 File Offset: 0x0014CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameBingoFlipCardCsReq> Parser
		{
			get
			{
				return MonopolyGameBingoFlipCardCsReq._parser;
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0014ECBF File Offset: 0x0014CEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameBingoFlipCardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06007EA5 RID: 32421 RVA: 0x0014ECD1 File Offset: 0x0014CED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameBingoFlipCardCsReq.Descriptor;
			}
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0014ECD8 File Offset: 0x0014CED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardCsReq()
		{
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x0014ECE0 File Offset: 0x0014CEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardCsReq(MonopolyGameBingoFlipCardCsReq other) : this()
		{
			this.aPBHJMDFKGK_ = other.aPBHJMDFKGK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0014ED05 File Offset: 0x0014CF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameBingoFlipCardCsReq Clone()
		{
			return new MonopolyGameBingoFlipCardCsReq(this);
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06007EA9 RID: 32425 RVA: 0x0014ED0D File Offset: 0x0014CF0D
		// (set) Token: 0x06007EAA RID: 32426 RVA: 0x0014ED15 File Offset: 0x0014CF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APBHJMDFKGK
		{
			get
			{
				return this.aPBHJMDFKGK_;
			}
			set
			{
				this.aPBHJMDFKGK_ = value;
			}
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0014ED1E File Offset: 0x0014CF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameBingoFlipCardCsReq);
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x0014ED2C File Offset: 0x0014CF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameBingoFlipCardCsReq other)
		{
			return other != null && (other == this || (this.APBHJMDFKGK == other.APBHJMDFKGK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x0014ED5C File Offset: 0x0014CF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.APBHJMDFKGK != 0U)
			{
				num ^= this.APBHJMDFKGK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0014ED9B File Offset: 0x0014CF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x0014EDA3 File Offset: 0x0014CFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0014EDAC File Offset: 0x0014CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.APBHJMDFKGK != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.APBHJMDFKGK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x0014EDE0 File Offset: 0x0014CFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.APBHJMDFKGK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APBHJMDFKGK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0014EE1E File Offset: 0x0014D01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameBingoFlipCardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.APBHJMDFKGK != 0U)
			{
				this.APBHJMDFKGK = other.APBHJMDFKGK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0014EE4F File Offset: 0x0014D04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0014EE58 File Offset: 0x0014D058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.APBHJMDFKGK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400308E RID: 12430
		private static readonly MessageParser<MonopolyGameBingoFlipCardCsReq> _parser = new MessageParser<MonopolyGameBingoFlipCardCsReq>(() => new MonopolyGameBingoFlipCardCsReq());

		// Token: 0x0400308F RID: 12431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003090 RID: 12432
		public const int APBHJMDFKGKFieldNumber = 10;

		// Token: 0x04003091 RID: 12433
		private uint aPBHJMDFKGK_;
	}
}
