using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008FB RID: 2299
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HMBLIADNKEO : IMessage<HMBLIADNKEO>, IMessage, IEquatable<HMBLIADNKEO>, IDeepCloneable<HMBLIADNKEO>, IBufferMessage
	{
		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x0011212D File Offset: 0x0011032D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HMBLIADNKEO> Parser
		{
			get
			{
				return HMBLIADNKEO._parser;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06006691 RID: 26257 RVA: 0x00112134 File Offset: 0x00110334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HMBLIADNKEOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x00112146 File Offset: 0x00110346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HMBLIADNKEO.Descriptor;
			}
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0011214D File Offset: 0x0011034D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO()
		{
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00112158 File Offset: 0x00110358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO(HMBLIADNKEO other) : this()
		{
			this.pDNCPLLOCGN_ = ((other.pDNCPLLOCGN_ != null) ? other.pDNCPLLOCGN_.Clone() : null);
			this.eHBFLALLLOJ_ = ((other.eHBFLALLLOJ_ != null) ? other.eHBFLALLLOJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x001121B4 File Offset: 0x001103B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO Clone()
		{
			return new HMBLIADNKEO(this);
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x001121BC File Offset: 0x001103BC
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x001121C4 File Offset: 0x001103C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PDNCPLLOCGN
		{
			get
			{
				return this.pDNCPLLOCGN_;
			}
			set
			{
				this.pDNCPLLOCGN_ = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x001121CD File Offset: 0x001103CD
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x001121D5 File Offset: 0x001103D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKKIHIPNHKP EHBFLALLLOJ
		{
			get
			{
				return this.eHBFLALLLOJ_;
			}
			set
			{
				this.eHBFLALLLOJ_ = value;
			}
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x001121DE File Offset: 0x001103DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HMBLIADNKEO);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x001121EC File Offset: 0x001103EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HMBLIADNKEO other)
		{
			return other != null && (other == this || (object.Equals(this.PDNCPLLOCGN, other.PDNCPLLOCGN) && object.Equals(this.EHBFLALLLOJ, other.EHBFLALLLOJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00112240 File Offset: 0x00110440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pDNCPLLOCGN_ != null)
			{
				num ^= this.PDNCPLLOCGN.GetHashCode();
			}
			if (this.eHBFLALLLOJ_ != null)
			{
				num ^= this.EHBFLALLLOJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00112292 File Offset: 0x00110492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x0011229A File Offset: 0x0011049A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x001122A4 File Offset: 0x001104A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pDNCPLLOCGN_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PDNCPLLOCGN);
			}
			if (this.eHBFLALLLOJ_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.EHBFLALLLOJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x00112300 File Offset: 0x00110500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pDNCPLLOCGN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PDNCPLLOCGN);
			}
			if (this.eHBFLALLLOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EHBFLALLLOJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x00112358 File Offset: 0x00110558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HMBLIADNKEO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pDNCPLLOCGN_ != null)
			{
				if (this.pDNCPLLOCGN_ == null)
				{
					this.PDNCPLLOCGN = new Vector();
				}
				this.PDNCPLLOCGN.MergeFrom(other.PDNCPLLOCGN);
			}
			if (other.eHBFLALLLOJ_ != null)
			{
				if (this.eHBFLALLLOJ_ == null)
				{
					this.EHBFLALLLOJ = new IKKIHIPNHKP();
				}
				this.EHBFLALLLOJ.MergeFrom(other.EHBFLALLLOJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x001123D8 File Offset: 0x001105D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x001123E4 File Offset: 0x001105E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.eHBFLALLLOJ_ == null)
						{
							this.EHBFLALLLOJ = new IKKIHIPNHKP();
						}
						input.ReadMessage(this.EHBFLALLLOJ);
					}
				}
				else
				{
					if (this.pDNCPLLOCGN_ == null)
					{
						this.PDNCPLLOCGN = new Vector();
					}
					input.ReadMessage(this.PDNCPLLOCGN);
				}
			}
		}

		// Token: 0x0400276B RID: 10091
		private static readonly MessageParser<HMBLIADNKEO> _parser = new MessageParser<HMBLIADNKEO>(() => new HMBLIADNKEO());

		// Token: 0x0400276C RID: 10092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400276D RID: 10093
		public const int PDNCPLLOCGNFieldNumber = 11;

		// Token: 0x0400276E RID: 10094
		private Vector pDNCPLLOCGN_;

		// Token: 0x0400276F RID: 10095
		public const int EHBFLALLLOJFieldNumber = 14;

		// Token: 0x04002770 RID: 10096
		private IKKIHIPNHKP eHBFLALLLOJ_;
	}
}
