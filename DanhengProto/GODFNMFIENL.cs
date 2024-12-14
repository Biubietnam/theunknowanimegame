using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000871 RID: 2161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GODFNMFIENL : IMessage<GODFNMFIENL>, IMessage, IEquatable<GODFNMFIENL>, IDeepCloneable<GODFNMFIENL>, IBufferMessage
	{
		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x000FDC2C File Offset: 0x000FBE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GODFNMFIENL> Parser
		{
			get
			{
				return GODFNMFIENL._parser;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x000FDC33 File Offset: 0x000FBE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GODFNMFIENLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x000FDC45 File Offset: 0x000FBE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GODFNMFIENL.Descriptor;
			}
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x000FDC4C File Offset: 0x000FBE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GODFNMFIENL()
		{
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x000FDC54 File Offset: 0x000FBE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GODFNMFIENL(GODFNMFIENL other) : this()
		{
			this.kEIEDKDHOFE_ = other.kEIEDKDHOFE_;
			this.optionId_ = other.optionId_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x000FDC91 File Offset: 0x000FBE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GODFNMFIENL Clone()
		{
			return new GODFNMFIENL(this);
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x000FDC99 File Offset: 0x000FBE99
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x000FDCA1 File Offset: 0x000FBEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEIEDKDHOFE
		{
			get
			{
				return this.kEIEDKDHOFE_;
			}
			set
			{
				this.kEIEDKDHOFE_ = value;
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x000FDCAA File Offset: 0x000FBEAA
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x000FDCB2 File Offset: 0x000FBEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x000FDCBB File Offset: 0x000FBEBB
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x000FDCC3 File Offset: 0x000FBEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x000FDCCC File Offset: 0x000FBECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GODFNMFIENL);
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x000FDCDC File Offset: 0x000FBEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GODFNMFIENL other)
		{
			return other != null && (other == this || (this.KEIEDKDHOFE == other.KEIEDKDHOFE && this.OptionId == other.OptionId && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x000FDD38 File Offset: 0x000FBF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KEIEDKDHOFE != 0U)
			{
				num ^= this.KEIEDKDHOFE.GetHashCode();
			}
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x000FDDA9 File Offset: 0x000FBFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x000FDDB1 File Offset: 0x000FBFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x000FDDBC File Offset: 0x000FBFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.OptionId);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventId);
			}
			if (this.KEIEDKDHOFE != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.KEIEDKDHOFE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x000FDE34 File Offset: 0x000FC034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KEIEDKDHOFE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEIEDKDHOFE);
			}
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x000FDEA4 File Offset: 0x000FC0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GODFNMFIENL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KEIEDKDHOFE != 0U)
			{
				this.KEIEDKDHOFE = other.KEIEDKDHOFE;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x000FDF08 File Offset: 0x000FC108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x000FDF14 File Offset: 0x000FC114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KEIEDKDHOFE = input.ReadUInt32();
						}
					}
					else
					{
						this.EventId = input.ReadUInt32();
					}
				}
				else
				{
					this.OptionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024E4 RID: 9444
		private static readonly MessageParser<GODFNMFIENL> _parser = new MessageParser<GODFNMFIENL>(() => new GODFNMFIENL());

		// Token: 0x040024E5 RID: 9445
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024E6 RID: 9446
		public const int KEIEDKDHOFEFieldNumber = 14;

		// Token: 0x040024E7 RID: 9447
		private uint kEIEDKDHOFE_;

		// Token: 0x040024E8 RID: 9448
		public const int OptionIdFieldNumber = 7;

		// Token: 0x040024E9 RID: 9449
		private uint optionId_;

		// Token: 0x040024EA RID: 9450
		public const int EventIdFieldNumber = 12;

		// Token: 0x040024EB RID: 9451
		private uint eventId_;
	}
}
