using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A29 RID: 2601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LMPOJGEHFIP : IMessage<LMPOJGEHFIP>, IMessage, IEquatable<LMPOJGEHFIP>, IDeepCloneable<LMPOJGEHFIP>, IBufferMessage
	{
		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06007392 RID: 29586 RVA: 0x001337C9 File Offset: 0x001319C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LMPOJGEHFIP> Parser
		{
			get
			{
				return LMPOJGEHFIP._parser;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x001337D0 File Offset: 0x001319D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LMPOJGEHFIPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06007394 RID: 29588 RVA: 0x001337E2 File Offset: 0x001319E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LMPOJGEHFIP.Descriptor;
			}
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x001337E9 File Offset: 0x001319E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPOJGEHFIP()
		{
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x001337F1 File Offset: 0x001319F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPOJGEHFIP(LMPOJGEHFIP other) : this()
		{
			this.dFBMLDAHJDF_ = other.dFBMLDAHJDF_;
			this.hNMMJKILLKH_ = other.hNMMJKILLKH_;
			this.hKIHNFNPLAF_ = other.hKIHNFNPLAF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x0013382E File Offset: 0x00131A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPOJGEHFIP Clone()
		{
			return new LMPOJGEHFIP(this);
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x00133836 File Offset: 0x00131A36
		// (set) Token: 0x06007399 RID: 29593 RVA: 0x0013383E File Offset: 0x00131A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DFBMLDAHJDF
		{
			get
			{
				return this.dFBMLDAHJDF_;
			}
			set
			{
				this.dFBMLDAHJDF_ = value;
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600739A RID: 29594 RVA: 0x00133847 File Offset: 0x00131A47
		// (set) Token: 0x0600739B RID: 29595 RVA: 0x0013384F File Offset: 0x00131A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNMMJKILLKH
		{
			get
			{
				return this.hNMMJKILLKH_;
			}
			set
			{
				this.hNMMJKILLKH_ = value;
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x00133858 File Offset: 0x00131A58
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x00133860 File Offset: 0x00131A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HKIHNFNPLAF
		{
			get
			{
				return this.hKIHNFNPLAF_;
			}
			set
			{
				this.hKIHNFNPLAF_ = value;
			}
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00133869 File Offset: 0x00131A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LMPOJGEHFIP);
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00133878 File Offset: 0x00131A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LMPOJGEHFIP other)
		{
			return other != null && (other == this || (this.DFBMLDAHJDF == other.DFBMLDAHJDF && this.HNMMJKILLKH == other.HNMMJKILLKH && this.HKIHNFNPLAF == other.HKIHNFNPLAF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x001338D4 File Offset: 0x00131AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DFBMLDAHJDF != 0U)
			{
				num ^= this.DFBMLDAHJDF.GetHashCode();
			}
			if (this.HNMMJKILLKH != 0U)
			{
				num ^= this.HNMMJKILLKH.GetHashCode();
			}
			if (this.HKIHNFNPLAF != 0U)
			{
				num ^= this.HKIHNFNPLAF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00133945 File Offset: 0x00131B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0013394D File Offset: 0x00131B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00133958 File Offset: 0x00131B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HKIHNFNPLAF != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HKIHNFNPLAF);
			}
			if (this.DFBMLDAHJDF != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DFBMLDAHJDF);
			}
			if (this.HNMMJKILLKH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HNMMJKILLKH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x001339D0 File Offset: 0x00131BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DFBMLDAHJDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DFBMLDAHJDF);
			}
			if (this.HNMMJKILLKH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNMMJKILLKH);
			}
			if (this.HKIHNFNPLAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HKIHNFNPLAF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00133A40 File Offset: 0x00131C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LMPOJGEHFIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DFBMLDAHJDF != 0U)
			{
				this.DFBMLDAHJDF = other.DFBMLDAHJDF;
			}
			if (other.HNMMJKILLKH != 0U)
			{
				this.HNMMJKILLKH = other.HNMMJKILLKH;
			}
			if (other.HKIHNFNPLAF != 0U)
			{
				this.HKIHNFNPLAF = other.HKIHNFNPLAF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x00133AA4 File Offset: 0x00131CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x00133AB0 File Offset: 0x00131CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HNMMJKILLKH = input.ReadUInt32();
						}
					}
					else
					{
						this.DFBMLDAHJDF = input.ReadUInt32();
					}
				}
				else
				{
					this.HKIHNFNPLAF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002C71 RID: 11377
		private static readonly MessageParser<LMPOJGEHFIP> _parser = new MessageParser<LMPOJGEHFIP>(() => new LMPOJGEHFIP());

		// Token: 0x04002C72 RID: 11378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C73 RID: 11379
		public const int DFBMLDAHJDFFieldNumber = 6;

		// Token: 0x04002C74 RID: 11380
		private uint dFBMLDAHJDF_;

		// Token: 0x04002C75 RID: 11381
		public const int HNMMJKILLKHFieldNumber = 11;

		// Token: 0x04002C76 RID: 11382
		private uint hNMMJKILLKH_;

		// Token: 0x04002C77 RID: 11383
		public const int HKIHNFNPLAFFieldNumber = 2;

		// Token: 0x04002C78 RID: 11384
		private uint hKIHNFNPLAF_;
	}
}
