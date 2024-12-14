using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F3 RID: 2035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetShareDataScRsp : IMessage<GetShareDataScRsp>, IMessage, IEquatable<GetShareDataScRsp>, IDeepCloneable<GetShareDataScRsp>, IBufferMessage
	{
		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x000F1D51 File Offset: 0x000EFF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetShareDataScRsp> Parser
		{
			get
			{
				return GetShareDataScRsp._parser;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x000F1D58 File Offset: 0x000EFF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetShareDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x000F1D6A File Offset: 0x000EFF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetShareDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x000F1D71 File Offset: 0x000EFF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataScRsp()
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x000F1D84 File Offset: 0x000EFF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataScRsp(GetShareDataScRsp other) : this()
		{
			this.kOLOPPHNHPE_ = other.kOLOPPHNHPE_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x000F1DBA File Offset: 0x000EFFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataScRsp Clone()
		{
			return new GetShareDataScRsp(this);
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x000F1DC2 File Offset: 0x000EFFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShareData> KOLOPPHNHPE
		{
			get
			{
				return this.kOLOPPHNHPE_;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x000F1DCA File Offset: 0x000EFFCA
		// (set) Token: 0x06005ACA RID: 23242 RVA: 0x000F1DD2 File Offset: 0x000EFFD2
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

		// Token: 0x06005ACB RID: 23243 RVA: 0x000F1DDB File Offset: 0x000EFFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetShareDataScRsp);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x000F1DEC File Offset: 0x000EFFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetShareDataScRsp other)
		{
			return other != null && (other == this || (this.kOLOPPHNHPE_.Equals(other.kOLOPPHNHPE_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x000F1E3C File Offset: 0x000F003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kOLOPPHNHPE_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x000F1E89 File Offset: 0x000F0089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x000F1E91 File Offset: 0x000F0091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x000F1E9C File Offset: 0x000F009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.kOLOPPHNHPE_.WriteTo(ref output, GetShareDataScRsp._repeated_kOLOPPHNHPE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x000F1EEC File Offset: 0x000F00EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kOLOPPHNHPE_.CalculateSize(GetShareDataScRsp._repeated_kOLOPPHNHPE_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x000F1F40 File Offset: 0x000F0140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetShareDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.kOLOPPHNHPE_.Add(other.kOLOPPHNHPE_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x000F1F8D File Offset: 0x000F018D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x000F1F98 File Offset: 0x000F0198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.kOLOPPHNHPE_.AddEntriesFrom(ref input, GetShareDataScRsp._repeated_kOLOPPHNHPE_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002332 RID: 9010
		private static readonly MessageParser<GetShareDataScRsp> _parser = new MessageParser<GetShareDataScRsp>(() => new GetShareDataScRsp());

		// Token: 0x04002333 RID: 9011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002334 RID: 9012
		public const int KOLOPPHNHPEFieldNumber = 6;

		// Token: 0x04002335 RID: 9013
		private static readonly FieldCodec<ShareData> _repeated_kOLOPPHNHPE_codec = FieldCodec.ForMessage<ShareData>(50U, ShareData.Parser);

		// Token: 0x04002336 RID: 9014
		private readonly RepeatedField<ShareData> kOLOPPHNHPE_ = new RepeatedField<ShareData>();

		// Token: 0x04002337 RID: 9015
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002338 RID: 9016
		private uint retcode_;
	}
}
