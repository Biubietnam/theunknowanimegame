using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000713 RID: 1811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMarkItemListScRsp : IMessage<GetMarkItemListScRsp>, IMessage, IEquatable<GetMarkItemListScRsp>, IDeepCloneable<GetMarkItemListScRsp>, IBufferMessage
	{
		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x000DA0F8 File Offset: 0x000D82F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMarkItemListScRsp> Parser
		{
			get
			{
				return GetMarkItemListScRsp._parser;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x000DA0FF File Offset: 0x000D82FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMarkItemListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x000DA111 File Offset: 0x000D8311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMarkItemListScRsp.Descriptor;
			}
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x000DA118 File Offset: 0x000D8318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListScRsp()
		{
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x000DA12B File Offset: 0x000D832B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListScRsp(GetMarkItemListScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bDGECCMOCJA_ = other.bDGECCMOCJA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x000DA161 File Offset: 0x000D8361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListScRsp Clone()
		{
			return new GetMarkItemListScRsp(this);
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x000DA169 File Offset: 0x000D8369
		// (set) Token: 0x060050F6 RID: 20726 RVA: 0x000DA171 File Offset: 0x000D8371
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

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x000DA17A File Offset: 0x000D837A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BDGECCMOCJA
		{
			get
			{
				return this.bDGECCMOCJA_;
			}
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x000DA182 File Offset: 0x000D8382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMarkItemListScRsp);
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x000DA190 File Offset: 0x000D8390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMarkItemListScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.bDGECCMOCJA_.Equals(other.bDGECCMOCJA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x000DA1E0 File Offset: 0x000D83E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.bDGECCMOCJA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x000DA22D File Offset: 0x000D842D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x000DA235 File Offset: 0x000D8435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x000DA240 File Offset: 0x000D8440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.bDGECCMOCJA_.WriteTo(ref output, GetMarkItemListScRsp._repeated_bDGECCMOCJA_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x000DA290 File Offset: 0x000D8490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.bDGECCMOCJA_.CalculateSize(GetMarkItemListScRsp._repeated_bDGECCMOCJA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x000DA2E4 File Offset: 0x000D84E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMarkItemListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.bDGECCMOCJA_.Add(other.bDGECCMOCJA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x000DA331 File Offset: 0x000D8531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x000DA33C File Offset: 0x000D853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bDGECCMOCJA_.AddEntriesFrom(ref input, GetMarkItemListScRsp._repeated_bDGECCMOCJA_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001FD1 RID: 8145
		private static readonly MessageParser<GetMarkItemListScRsp> _parser = new MessageParser<GetMarkItemListScRsp>(() => new GetMarkItemListScRsp());

		// Token: 0x04001FD2 RID: 8146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FD3 RID: 8147
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001FD4 RID: 8148
		private uint retcode_;

		// Token: 0x04001FD5 RID: 8149
		public const int BDGECCMOCJAFieldNumber = 11;

		// Token: 0x04001FD6 RID: 8150
		private static readonly FieldCodec<uint> _repeated_bDGECCMOCJA_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04001FD7 RID: 8151
		private readonly RepeatedField<uint> bDGECCMOCJA_ = new RepeatedField<uint>();
	}
}
