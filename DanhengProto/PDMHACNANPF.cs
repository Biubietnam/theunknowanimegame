using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C89 RID: 3209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PDMHACNANPF : IMessage<PDMHACNANPF>, IMessage, IEquatable<PDMHACNANPF>, IDeepCloneable<PDMHACNANPF>, IBufferMessage
	{
		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x06008EA9 RID: 36521 RVA: 0x001790EF File Offset: 0x001772EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PDMHACNANPF> Parser
		{
			get
			{
				return PDMHACNANPF._parser;
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x06008EAA RID: 36522 RVA: 0x001790F6 File Offset: 0x001772F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PDMHACNANPFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x00179108 File Offset: 0x00177308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PDMHACNANPF.Descriptor;
			}
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x0017910F File Offset: 0x0017730F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDMHACNANPF()
		{
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x00179118 File Offset: 0x00177318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDMHACNANPF(PDMHACNANPF other) : this()
		{
			this.jGOGLLKDBBA_ = ((other.jGOGLLKDBBA_ != null) ? other.jGOGLLKDBBA_.Clone() : null);
			this.bFBAFDCAEPD_ = ((other.bFBAFDCAEPD_ != null) ? other.bFBAFDCAEPD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x00179174 File Offset: 0x00177374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDMHACNANPF Clone()
		{
			return new PDMHACNANPF(this);
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x06008EAF RID: 36527 RVA: 0x0017917C File Offset: 0x0017737C
		// (set) Token: 0x06008EB0 RID: 36528 RVA: 0x00179184 File Offset: 0x00177384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSyncContextBoardEvent JGOGLLKDBBA
		{
			get
			{
				return this.jGOGLLKDBBA_;
			}
			set
			{
				this.jGOGLLKDBBA_ = value;
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x0017918D File Offset: 0x0017738D
		// (set) Token: 0x06008EB2 RID: 36530 RVA: 0x00179195 File Offset: 0x00177395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COBDHAGFEHD BFBAFDCAEPD
		{
			get
			{
				return this.bFBAFDCAEPD_;
			}
			set
			{
				this.bFBAFDCAEPD_ = value;
			}
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0017919E File Offset: 0x0017739E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PDMHACNANPF);
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x001791AC File Offset: 0x001773AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PDMHACNANPF other)
		{
			return other != null && (other == this || (object.Equals(this.JGOGLLKDBBA, other.JGOGLLKDBBA) && object.Equals(this.BFBAFDCAEPD, other.BFBAFDCAEPD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00179200 File Offset: 0x00177400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jGOGLLKDBBA_ != null)
			{
				num ^= this.JGOGLLKDBBA.GetHashCode();
			}
			if (this.bFBAFDCAEPD_ != null)
			{
				num ^= this.BFBAFDCAEPD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x00179252 File Offset: 0x00177452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0017925A File Offset: 0x0017745A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x00179264 File Offset: 0x00177464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jGOGLLKDBBA_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.JGOGLLKDBBA);
			}
			if (this.bFBAFDCAEPD_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BFBAFDCAEPD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x001792C0 File Offset: 0x001774C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jGOGLLKDBBA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JGOGLLKDBBA);
			}
			if (this.bFBAFDCAEPD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BFBAFDCAEPD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x00179318 File Offset: 0x00177518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PDMHACNANPF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jGOGLLKDBBA_ != null)
			{
				if (this.jGOGLLKDBBA_ == null)
				{
					this.JGOGLLKDBBA = new RogueSyncContextBoardEvent();
				}
				this.JGOGLLKDBBA.MergeFrom(other.JGOGLLKDBBA);
			}
			if (other.bFBAFDCAEPD_ != null)
			{
				if (this.bFBAFDCAEPD_ == null)
				{
					this.BFBAFDCAEPD = new COBDHAGFEHD();
				}
				this.BFBAFDCAEPD.MergeFrom(other.BFBAFDCAEPD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x00179398 File Offset: 0x00177598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x001793A4 File Offset: 0x001775A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.bFBAFDCAEPD_ == null)
						{
							this.BFBAFDCAEPD = new COBDHAGFEHD();
						}
						input.ReadMessage(this.BFBAFDCAEPD);
					}
				}
				else
				{
					if (this.jGOGLLKDBBA_ == null)
					{
						this.JGOGLLKDBBA = new RogueSyncContextBoardEvent();
					}
					input.ReadMessage(this.JGOGLLKDBBA);
				}
			}
		}

		// Token: 0x040036CD RID: 14029
		private static readonly MessageParser<PDMHACNANPF> _parser = new MessageParser<PDMHACNANPF>(() => new PDMHACNANPF());

		// Token: 0x040036CE RID: 14030
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036CF RID: 14031
		public const int JGOGLLKDBBAFieldNumber = 5;

		// Token: 0x040036D0 RID: 14032
		private RogueSyncContextBoardEvent jGOGLLKDBBA_;

		// Token: 0x040036D1 RID: 14033
		public const int BFBAFDCAEPDFieldNumber = 13;

		// Token: 0x040036D2 RID: 14034
		private COBDHAGFEHD bFBAFDCAEPD_;
	}
}
