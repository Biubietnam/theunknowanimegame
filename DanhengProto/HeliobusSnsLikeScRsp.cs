using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008CD RID: 2253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsLikeScRsp : IMessage<HeliobusSnsLikeScRsp>, IMessage, IEquatable<HeliobusSnsLikeScRsp>, IDeepCloneable<HeliobusSnsLikeScRsp>, IBufferMessage
	{
		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x0010CE35 File Offset: 0x0010B035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsLikeScRsp> Parser
		{
			get
			{
				return HeliobusSnsLikeScRsp._parser;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x0010CE3C File Offset: 0x0010B03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsLikeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x0010CE4E File Offset: 0x0010B04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsLikeScRsp.Descriptor;
			}
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x0010CE55 File Offset: 0x0010B055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeScRsp()
		{
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x0010CE5D File Offset: 0x0010B05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeScRsp(HeliobusSnsLikeScRsp other) : this()
		{
			this.eDJEAKCCCNJ_ = other.eDJEAKCCCNJ_;
			this.retcode_ = other.retcode_;
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x0010CE9A File Offset: 0x0010B09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeScRsp Clone()
		{
			return new HeliobusSnsLikeScRsp(this);
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06006478 RID: 25720 RVA: 0x0010CEA2 File Offset: 0x0010B0A2
		// (set) Token: 0x06006479 RID: 25721 RVA: 0x0010CEAA File Offset: 0x0010B0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EDJEAKCCCNJ
		{
			get
			{
				return this.eDJEAKCCCNJ_;
			}
			set
			{
				this.eDJEAKCCCNJ_ = value;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x0600647A RID: 25722 RVA: 0x0010CEB3 File Offset: 0x0010B0B3
		// (set) Token: 0x0600647B RID: 25723 RVA: 0x0010CEBB File Offset: 0x0010B0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x0600647C RID: 25724 RVA: 0x0010CEC4 File Offset: 0x0010B0C4
		// (set) Token: 0x0600647D RID: 25725 RVA: 0x0010CECC File Offset: 0x0010B0CC
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

		// Token: 0x0600647E RID: 25726 RVA: 0x0010CED5 File Offset: 0x0010B0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsLikeScRsp);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x0010CEE4 File Offset: 0x0010B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsLikeScRsp other)
		{
			return other != null && (other == this || (this.EDJEAKCCCNJ == other.EDJEAKCCCNJ && this.Retcode == other.Retcode && this.ALAOMAOBNFG == other.ALAOMAOBNFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x0010CF40 File Offset: 0x0010B140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EDJEAKCCCNJ)
			{
				num ^= this.EDJEAKCCCNJ.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06006481 RID: 25729 RVA: 0x0010CFB1 File Offset: 0x0010B1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x0010CFB9 File Offset: 0x0010B1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0010CFC4 File Offset: 0x0010B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EDJEAKCCCNJ)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.EDJEAKCCCNJ);
			}
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0010D03C File Offset: 0x0010B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EDJEAKCCCNJ)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x06006485 RID: 25733 RVA: 0x0010D0A0 File Offset: 0x0010B2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsLikeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EDJEAKCCCNJ)
			{
				this.EDJEAKCCCNJ = other.EDJEAKCCCNJ;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x0010D104 File Offset: 0x0010B304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0010D110 File Offset: 0x0010B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.ALAOMAOBNFG = input.ReadUInt32();
					}
				}
				else
				{
					this.EDJEAKCCCNJ = input.ReadBool();
				}
			}
		}

		// Token: 0x040026AF RID: 9903
		private static readonly MessageParser<HeliobusSnsLikeScRsp> _parser = new MessageParser<HeliobusSnsLikeScRsp>(() => new HeliobusSnsLikeScRsp());

		// Token: 0x040026B0 RID: 9904
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026B1 RID: 9905
		public const int EDJEAKCCCNJFieldNumber = 7;

		// Token: 0x040026B2 RID: 9906
		private bool eDJEAKCCCNJ_;

		// Token: 0x040026B3 RID: 9907
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040026B4 RID: 9908
		private uint retcode_;

		// Token: 0x040026B5 RID: 9909
		public const int ALAOMAOBNFGFieldNumber = 11;

		// Token: 0x040026B6 RID: 9910
		private uint aLAOMAOBNFG_;
	}
}
