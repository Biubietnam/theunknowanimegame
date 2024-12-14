using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200091D RID: 2333
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IFIJMOECCOE : IMessage<IFIJMOECCOE>, IMessage, IEquatable<IFIJMOECCOE>, IDeepCloneable<IFIJMOECCOE>, IBufferMessage
	{
		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x00116068 File Offset: 0x00114268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IFIJMOECCOE> Parser
		{
			get
			{
				return IFIJMOECCOE._parser;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x0011606F File Offset: 0x0011426F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IFIJMOECCOEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x00116081 File Offset: 0x00114281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IFIJMOECCOE.Descriptor;
			}
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00116088 File Offset: 0x00114288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IFIJMOECCOE()
		{
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x00116090 File Offset: 0x00114290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IFIJMOECCOE(IFIJMOECCOE other) : this()
		{
			this.dAJCFCAEIHN_ = other.dAJCFCAEIHN_;
			this.areaId_ = other.areaId_;
			this.kPNGCKLNFGN_ = other.kPNGCKLNFGN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x001160CD File Offset: 0x001142CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IFIJMOECCOE Clone()
		{
			return new IFIJMOECCOE(this);
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x001160D5 File Offset: 0x001142D5
		// (set) Token: 0x06006816 RID: 26646 RVA: 0x001160DD File Offset: 0x001142DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DAJCFCAEIHN
		{
			get
			{
				return this.dAJCFCAEIHN_;
			}
			set
			{
				this.dAJCFCAEIHN_ = value;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x001160E6 File Offset: 0x001142E6
		// (set) Token: 0x06006818 RID: 26648 RVA: 0x001160EE File Offset: 0x001142EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x001160F7 File Offset: 0x001142F7
		// (set) Token: 0x0600681A RID: 26650 RVA: 0x001160FF File Offset: 0x001142FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KPNGCKLNFGN
		{
			get
			{
				return this.kPNGCKLNFGN_;
			}
			set
			{
				this.kPNGCKLNFGN_ = value;
			}
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x00116108 File Offset: 0x00114308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IFIJMOECCOE);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00116118 File Offset: 0x00114318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IFIJMOECCOE other)
		{
			return other != null && (other == this || (this.DAJCFCAEIHN == other.DAJCFCAEIHN && this.AreaId == other.AreaId && this.KPNGCKLNFGN == other.KPNGCKLNFGN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x00116174 File Offset: 0x00114374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DAJCFCAEIHN != 0U)
			{
				num ^= this.DAJCFCAEIHN.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.KPNGCKLNFGN != 0U)
			{
				num ^= this.KPNGCKLNFGN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x001161E5 File Offset: 0x001143E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x001161ED File Offset: 0x001143ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x001161F8 File Offset: 0x001143F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KPNGCKLNFGN != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.KPNGCKLNFGN);
			}
			if (this.DAJCFCAEIHN != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DAJCFCAEIHN);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x00116270 File Offset: 0x00114470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DAJCFCAEIHN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DAJCFCAEIHN);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.KPNGCKLNFGN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KPNGCKLNFGN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x001162E0 File Offset: 0x001144E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IFIJMOECCOE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DAJCFCAEIHN != 0U)
			{
				this.DAJCFCAEIHN = other.DAJCFCAEIHN;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.KPNGCKLNFGN != 0U)
			{
				this.KPNGCKLNFGN = other.KPNGCKLNFGN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x00116344 File Offset: 0x00114544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00116350 File Offset: 0x00114550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AreaId = input.ReadUInt32();
						}
					}
					else
					{
						this.DAJCFCAEIHN = input.ReadUInt32();
					}
				}
				else
				{
					this.KPNGCKLNFGN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027F3 RID: 10227
		private static readonly MessageParser<IFIJMOECCOE> _parser = new MessageParser<IFIJMOECCOE>(() => new IFIJMOECCOE());

		// Token: 0x040027F4 RID: 10228
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F5 RID: 10229
		public const int DAJCFCAEIHNFieldNumber = 11;

		// Token: 0x040027F6 RID: 10230
		private uint dAJCFCAEIHN_;

		// Token: 0x040027F7 RID: 10231
		public const int AreaIdFieldNumber = 15;

		// Token: 0x040027F8 RID: 10232
		private uint areaId_;

		// Token: 0x040027F9 RID: 10233
		public const int KPNGCKLNFGNFieldNumber = 8;

		// Token: 0x040027FA RID: 10234
		private uint kPNGCKLNFGN_;
	}
}
