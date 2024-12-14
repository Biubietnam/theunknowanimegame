using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C7 RID: 2247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsCommentCsReq : IMessage<HeliobusSnsCommentCsReq>, IMessage, IEquatable<HeliobusSnsCommentCsReq>, IDeepCloneable<HeliobusSnsCommentCsReq>, IBufferMessage
	{
		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x0010C43D File Offset: 0x0010A63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsCommentCsReq> Parser
		{
			get
			{
				return HeliobusSnsCommentCsReq._parser;
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x0010C444 File Offset: 0x0010A644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsCommentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x0010C456 File Offset: 0x0010A656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsCommentCsReq.Descriptor;
			}
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x0010C45D File Offset: 0x0010A65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentCsReq()
		{
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x0010C465 File Offset: 0x0010A665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentCsReq(HeliobusSnsCommentCsReq other) : this()
		{
			this.hHPKIFMOEMH_ = other.hHPKIFMOEMH_;
			this.bCFCCDMEAKO_ = other.bCFCCDMEAKO_;
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x0010C4A2 File Offset: 0x0010A6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentCsReq Clone()
		{
			return new HeliobusSnsCommentCsReq(this);
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x0010C4AA File Offset: 0x0010A6AA
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0010C4B2 File Offset: 0x0010A6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HHPKIFMOEMH
		{
			get
			{
				return this.hHPKIFMOEMH_;
			}
			set
			{
				this.hHPKIFMOEMH_ = value;
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06006435 RID: 25653 RVA: 0x0010C4BB File Offset: 0x0010A6BB
		// (set) Token: 0x06006436 RID: 25654 RVA: 0x0010C4C3 File Offset: 0x0010A6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BCFCCDMEAKO
		{
			get
			{
				return this.bCFCCDMEAKO_;
			}
			set
			{
				this.bCFCCDMEAKO_ = value;
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x0010C4CC File Offset: 0x0010A6CC
		// (set) Token: 0x06006438 RID: 25656 RVA: 0x0010C4D4 File Offset: 0x0010A6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALAOMAOBNFG
		{
			get
			{
				return this.aLAOMAOBNFG_;
			}
			set
			{
				this.aLAOMAOBNFG_ = value;
			}
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x0010C4DD File Offset: 0x0010A6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsCommentCsReq);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x0010C4EC File Offset: 0x0010A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsCommentCsReq other)
		{
			return other != null && (other == this || (this.HHPKIFMOEMH == other.HHPKIFMOEMH && this.BCFCCDMEAKO == other.BCFCCDMEAKO && this.ALAOMAOBNFG == other.ALAOMAOBNFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x0010C548 File Offset: 0x0010A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HHPKIFMOEMH != 0U)
			{
				num ^= this.HHPKIFMOEMH.GetHashCode();
			}
			if (this.BCFCCDMEAKO != 0U)
			{
				num ^= this.BCFCCDMEAKO.GetHashCode();
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				num ^= this.ALAOMAOBNFG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x0010C5B9 File Offset: 0x0010A7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x0010C5C1 File Offset: 0x0010A7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x0010C5CC File Offset: 0x0010A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this.BCFCCDMEAKO != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BCFCCDMEAKO);
			}
			if (this.HHPKIFMOEMH != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.HHPKIFMOEMH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0010C644 File Offset: 0x0010A844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HHPKIFMOEMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HHPKIFMOEMH);
			}
			if (this.BCFCCDMEAKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BCFCCDMEAKO);
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALAOMAOBNFG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0010C6B4 File Offset: 0x0010A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsCommentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HHPKIFMOEMH != 0U)
			{
				this.HHPKIFMOEMH = other.HHPKIFMOEMH;
			}
			if (other.BCFCCDMEAKO != 0U)
			{
				this.BCFCCDMEAKO = other.BCFCCDMEAKO;
			}
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x0010C718 File Offset: 0x0010A918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x0010C724 File Offset: 0x0010A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HHPKIFMOEMH = input.ReadUInt32();
						}
					}
					else
					{
						this.BCFCCDMEAKO = input.ReadUInt32();
					}
				}
				else
				{
					this.ALAOMAOBNFG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400269A RID: 9882
		private static readonly MessageParser<HeliobusSnsCommentCsReq> _parser = new MessageParser<HeliobusSnsCommentCsReq>(() => new HeliobusSnsCommentCsReq());

		// Token: 0x0400269B RID: 9883
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400269C RID: 9884
		public const int HHPKIFMOEMHFieldNumber = 13;

		// Token: 0x0400269D RID: 9885
		private uint hHPKIFMOEMH_;

		// Token: 0x0400269E RID: 9886
		public const int BCFCCDMEAKOFieldNumber = 7;

		// Token: 0x0400269F RID: 9887
		private uint bCFCCDMEAKO_;

		// Token: 0x040026A0 RID: 9888
		public const int ALAOMAOBNFGFieldNumber = 3;

		// Token: 0x040026A1 RID: 9889
		private uint aLAOMAOBNFG_;
	}
}
