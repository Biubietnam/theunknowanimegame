using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F5 RID: 1525
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GeneralVirtualItemDataNotify : IMessage<GeneralVirtualItemDataNotify>, IMessage, IEquatable<GeneralVirtualItemDataNotify>, IDeepCloneable<GeneralVirtualItemDataNotify>, IBufferMessage
	{
		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000BBC71 File Offset: 0x000B9E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GeneralVirtualItemDataNotify> Parser
		{
			get
			{
				return GeneralVirtualItemDataNotify._parser;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x000BBC78 File Offset: 0x000B9E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GeneralVirtualItemDataNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x000BBC8A File Offset: 0x000B9E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GeneralVirtualItemDataNotify.Descriptor;
			}
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x000BBC91 File Offset: 0x000B9E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneralVirtualItemDataNotify()
		{
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x000BBCA4 File Offset: 0x000B9EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneralVirtualItemDataNotify(GeneralVirtualItemDataNotify other) : this()
		{
			this.pKMCBDCFEDN_ = other.pKMCBDCFEDN_;
			this.nDFAIEEHEDM_ = other.nDFAIEEHEDM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x000BBCDA File Offset: 0x000B9EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneralVirtualItemDataNotify Clone()
		{
			return new GeneralVirtualItemDataNotify(this);
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x000BBCE2 File Offset: 0x000B9EE2
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x000BBCEA File Offset: 0x000B9EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PKMCBDCFEDN
		{
			get
			{
				return this.pKMCBDCFEDN_;
			}
			set
			{
				this.pKMCBDCFEDN_ = value;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x000BBCF3 File Offset: 0x000B9EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PileItem> NDFAIEEHEDM
		{
			get
			{
				return this.nDFAIEEHEDM_;
			}
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x000BBCFB File Offset: 0x000B9EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GeneralVirtualItemDataNotify);
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x000BBD0C File Offset: 0x000B9F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GeneralVirtualItemDataNotify other)
		{
			return other != null && (other == this || (this.PKMCBDCFEDN == other.PKMCBDCFEDN && this.nDFAIEEHEDM_.Equals(other.nDFAIEEHEDM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PKMCBDCFEDN)
			{
				num ^= this.PKMCBDCFEDN.GetHashCode();
			}
			num ^= this.nDFAIEEHEDM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x000BBDA9 File Offset: 0x000B9FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x000BBDB1 File Offset: 0x000B9FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x000BBDBC File Offset: 0x000B9FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nDFAIEEHEDM_.WriteTo(ref output, GeneralVirtualItemDataNotify._repeated_nDFAIEEHEDM_codec);
			if (this.PKMCBDCFEDN)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.PKMCBDCFEDN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000BBE0C File Offset: 0x000BA00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PKMCBDCFEDN)
			{
				num += 2;
			}
			num += this.nDFAIEEHEDM_.CalculateSize(GeneralVirtualItemDataNotify._repeated_nDFAIEEHEDM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x000BBE54 File Offset: 0x000BA054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GeneralVirtualItemDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PKMCBDCFEDN)
			{
				this.PKMCBDCFEDN = other.PKMCBDCFEDN;
			}
			this.nDFAIEEHEDM_.Add(other.nDFAIEEHEDM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x000BBEA1 File Offset: 0x000BA0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x000BBEAC File Offset: 0x000BA0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PKMCBDCFEDN = input.ReadBool();
					}
				}
				else
				{
					this.nDFAIEEHEDM_.AddEntriesFrom(ref input, GeneralVirtualItemDataNotify._repeated_nDFAIEEHEDM_codec);
				}
			}
		}

		// Token: 0x04001B66 RID: 7014
		private static readonly MessageParser<GeneralVirtualItemDataNotify> _parser = new MessageParser<GeneralVirtualItemDataNotify>(() => new GeneralVirtualItemDataNotify());

		// Token: 0x04001B67 RID: 7015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B68 RID: 7016
		public const int PKMCBDCFEDNFieldNumber = 14;

		// Token: 0x04001B69 RID: 7017
		private bool pKMCBDCFEDN_;

		// Token: 0x04001B6A RID: 7018
		public const int NDFAIEEHEDMFieldNumber = 4;

		// Token: 0x04001B6B RID: 7019
		private static readonly FieldCodec<PileItem> _repeated_nDFAIEEHEDM_codec = FieldCodec.ForMessage<PileItem>(34U, PileItem.Parser);

		// Token: 0x04001B6C RID: 7020
		private readonly RepeatedField<PileItem> nDFAIEEHEDM_ = new RepeatedField<PileItem>();
	}
}
