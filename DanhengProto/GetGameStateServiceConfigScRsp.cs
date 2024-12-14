using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006DF RID: 1759
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGameStateServiceConfigScRsp : IMessage<GetGameStateServiceConfigScRsp>, IMessage, IEquatable<GetGameStateServiceConfigScRsp>, IDeepCloneable<GetGameStateServiceConfigScRsp>, IBufferMessage
	{
		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x000D4D7F File Offset: 0x000D2F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGameStateServiceConfigScRsp> Parser
		{
			get
			{
				return GetGameStateServiceConfigScRsp._parser;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x000D4D86 File Offset: 0x000D2F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGameStateServiceConfigScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x000D4D98 File Offset: 0x000D2F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameStateServiceConfigScRsp.Descriptor;
			}
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x000D4D9F File Offset: 0x000D2F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigScRsp()
		{
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x000D4DC8 File Offset: 0x000D2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigScRsp(GetGameStateServiceConfigScRsp other) : this()
		{
			this.kKGILJCIPJO_ = other.kKGILJCIPJO_.Clone();
			this.iEKAEGAJCEG_ = other.iEKAEGAJCEG_.Clone();
			this.retcode_ = other.retcode_;
			this.nLKANAKEMEJ_ = other.nLKANAKEMEJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x000D4E2B File Offset: 0x000D302B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGameStateServiceConfigScRsp Clone()
		{
			return new GetGameStateServiceConfigScRsp(this);
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x000D4E33 File Offset: 0x000D3033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> KKGILJCIPJO
		{
			get
			{
				return this.kKGILJCIPJO_;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x000D4E3B File Offset: 0x000D303B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> IEKAEGAJCEG
		{
			get
			{
				return this.iEKAEGAJCEG_;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x000D4E43 File Offset: 0x000D3043
		// (set) Token: 0x06004EBC RID: 20156 RVA: 0x000D4E4B File Offset: 0x000D304B
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x000D4E54 File Offset: 0x000D3054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> NLKANAKEMEJ
		{
			get
			{
				return this.nLKANAKEMEJ_;
			}
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x000D4E5C File Offset: 0x000D305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameStateServiceConfigScRsp);
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x000D4E6C File Offset: 0x000D306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGameStateServiceConfigScRsp other)
		{
			return other != null && (other == this || (this.kKGILJCIPJO_.Equals(other.kKGILJCIPJO_) && this.iEKAEGAJCEG_.Equals(other.iEKAEGAJCEG_) && this.Retcode == other.Retcode && this.nLKANAKEMEJ_.Equals(other.nLKANAKEMEJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x000D4EE4 File Offset: 0x000D30E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kKGILJCIPJO_.GetHashCode();
			num ^= this.iEKAEGAJCEG_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.nLKANAKEMEJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x000D4F4D File Offset: 0x000D314D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x000D4F55 File Offset: 0x000D3155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000D4F60 File Offset: 0x000D3160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iEKAEGAJCEG_.WriteTo(ref output, GetGameStateServiceConfigScRsp._repeated_iEKAEGAJCEG_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.kKGILJCIPJO_.WriteTo(ref output, GetGameStateServiceConfigScRsp._repeated_kKGILJCIPJO_codec);
			this.nLKANAKEMEJ_.WriteTo(ref output, GetGameStateServiceConfigScRsp._repeated_nLKANAKEMEJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x000D4FD0 File Offset: 0x000D31D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kKGILJCIPJO_.CalculateSize(GetGameStateServiceConfigScRsp._repeated_kKGILJCIPJO_codec);
			num += this.iEKAEGAJCEG_.CalculateSize(GetGameStateServiceConfigScRsp._repeated_iEKAEGAJCEG_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.nLKANAKEMEJ_.CalculateSize(GetGameStateServiceConfigScRsp._repeated_nLKANAKEMEJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x000D5048 File Offset: 0x000D3248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGameStateServiceConfigScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.kKGILJCIPJO_.Add(other.kKGILJCIPJO_);
			this.iEKAEGAJCEG_.Add(other.iEKAEGAJCEG_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.nLKANAKEMEJ_.Add(other.nLKANAKEMEJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x000D50B7 File Offset: 0x000D32B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x000D50C0 File Offset: 0x000D32C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.iEKAEGAJCEG_.AddEntriesFrom(ref input, GetGameStateServiceConfigScRsp._repeated_iEKAEGAJCEG_codec);
						continue;
					}
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.kKGILJCIPJO_.AddEntriesFrom(ref input, GetGameStateServiceConfigScRsp._repeated_kKGILJCIPJO_codec);
						continue;
					}
					if (num == 106U)
					{
						this.nLKANAKEMEJ_.AddEntriesFrom(ref input, GetGameStateServiceConfigScRsp._repeated_nLKANAKEMEJ_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F0D RID: 7949
		private static readonly MessageParser<GetGameStateServiceConfigScRsp> _parser = new MessageParser<GetGameStateServiceConfigScRsp>(() => new GetGameStateServiceConfigScRsp());

		// Token: 0x04001F0E RID: 7950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F0F RID: 7951
		public const int KKGILJCIPJOFieldNumber = 11;

		// Token: 0x04001F10 RID: 7952
		private static readonly FieldCodec<string> _repeated_kKGILJCIPJO_codec = FieldCodec.ForString(90U);

		// Token: 0x04001F11 RID: 7953
		private readonly RepeatedField<string> kKGILJCIPJO_ = new RepeatedField<string>();

		// Token: 0x04001F12 RID: 7954
		public const int IEKAEGAJCEGFieldNumber = 1;

		// Token: 0x04001F13 RID: 7955
		private static readonly FieldCodec<string> _repeated_iEKAEGAJCEG_codec = FieldCodec.ForString(10U);

		// Token: 0x04001F14 RID: 7956
		private readonly RepeatedField<string> iEKAEGAJCEG_ = new RepeatedField<string>();

		// Token: 0x04001F15 RID: 7957
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001F16 RID: 7958
		private uint retcode_;

		// Token: 0x04001F17 RID: 7959
		public const int NLKANAKEMEJFieldNumber = 13;

		// Token: 0x04001F18 RID: 7960
		private static readonly FieldCodec<string> _repeated_nLKANAKEMEJ_codec = FieldCodec.ForString(106U);

		// Token: 0x04001F19 RID: 7961
		private readonly RepeatedField<string> nLKANAKEMEJ_ = new RepeatedField<string>();
	}
}
