using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200081F RID: 2079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSwordTrainingDataScRsp : IMessage<GetSwordTrainingDataScRsp>, IMessage, IEquatable<GetSwordTrainingDataScRsp>, IDeepCloneable<GetSwordTrainingDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06005C8D RID: 23693 RVA: 0x000F5D1F File Offset: 0x000F3F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSwordTrainingDataScRsp> Parser
		{
			get
			{
				return GetSwordTrainingDataScRsp._parser;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x000F5D26 File Offset: 0x000F3F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSwordTrainingDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06005C8F RID: 23695 RVA: 0x000F5D38 File Offset: 0x000F3F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSwordTrainingDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x000F5D3F File Offset: 0x000F3F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataScRsp()
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x000F5D68 File Offset: 0x000F3F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataScRsp(GetSwordTrainingDataScRsp other) : this()
		{
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this.cJIKOHPNNMP_ = other.cJIKOHPNNMP_.Clone();
			this.oJFJFEJMJPG_ = ((other.oJFJFEJMJPG_ != null) ? other.oJFJFEJMJPG_.Clone() : null);
			this.oFMIAGOIPJM_ = other.oFMIAGOIPJM_.Clone();
			this.pJEADDDAGKK_ = other.pJEADDDAGKK_;
			this.jFOJHGPHAHF_ = other.jFOJHGPHAHF_;
			this.pNIBCBABNLC_ = other.pNIBCBABNLC_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x000F5E1B File Offset: 0x000F401B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSwordTrainingDataScRsp Clone()
		{
			return new GetSwordTrainingDataScRsp(this);
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06005C93 RID: 23699 RVA: 0x000F5E23 File Offset: 0x000F4023
		// (set) Token: 0x06005C94 RID: 23700 RVA: 0x000F5E2B File Offset: 0x000F402B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPPHNMBHEEJ BEDINILDMEB
		{
			get
			{
				return this.bEDINILDMEB_;
			}
			set
			{
				this.bEDINILDMEB_ = value;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06005C95 RID: 23701 RVA: 0x000F5E34 File Offset: 0x000F4034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CJIKOHPNNMP
		{
			get
			{
				return this.cJIKOHPNNMP_;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06005C96 RID: 23702 RVA: 0x000F5E3C File Offset: 0x000F403C
		// (set) Token: 0x06005C97 RID: 23703 RVA: 0x000F5E44 File Offset: 0x000F4044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOMJFEEALFA OJFJFEJMJPG
		{
			get
			{
				return this.oJFJFEJMJPG_;
			}
			set
			{
				this.oJFJFEJMJPG_ = value;
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06005C98 RID: 23704 RVA: 0x000F5E4D File Offset: 0x000F404D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OFMIAGOIPJM
		{
			get
			{
				return this.oFMIAGOIPJM_;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x000F5E55 File Offset: 0x000F4055
		// (set) Token: 0x06005C9A RID: 23706 RVA: 0x000F5E5D File Offset: 0x000F405D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PJEADDDAGKK
		{
			get
			{
				return this.pJEADDDAGKK_;
			}
			set
			{
				this.pJEADDDAGKK_ = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06005C9B RID: 23707 RVA: 0x000F5E66 File Offset: 0x000F4066
		// (set) Token: 0x06005C9C RID: 23708 RVA: 0x000F5E6E File Offset: 0x000F406E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JFOJHGPHAHF
		{
			get
			{
				return this.jFOJHGPHAHF_;
			}
			set
			{
				this.jFOJHGPHAHF_ = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x000F5E77 File Offset: 0x000F4077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PNIBCBABNLC
		{
			get
			{
				return this.pNIBCBABNLC_;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06005C9E RID: 23710 RVA: 0x000F5E7F File Offset: 0x000F407F
		// (set) Token: 0x06005C9F RID: 23711 RVA: 0x000F5E87 File Offset: 0x000F4087
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

		// Token: 0x06005CA0 RID: 23712 RVA: 0x000F5E90 File Offset: 0x000F4090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSwordTrainingDataScRsp);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x000F5EA0 File Offset: 0x000F40A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSwordTrainingDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && this.cJIKOHPNNMP_.Equals(other.cJIKOHPNNMP_) && object.Equals(this.OJFJFEJMJPG, other.OJFJFEJMJPG) && this.oFMIAGOIPJM_.Equals(other.oFMIAGOIPJM_) && this.PJEADDDAGKK == other.PJEADDDAGKK && this.JFOJHGPHAHF == other.JFOJHGPHAHF && this.pNIBCBABNLC_.Equals(other.pNIBCBABNLC_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x000F5F64 File Offset: 0x000F4164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			num ^= this.cJIKOHPNNMP_.GetHashCode();
			if (this.oJFJFEJMJPG_ != null)
			{
				num ^= this.OJFJFEJMJPG.GetHashCode();
			}
			num ^= this.oFMIAGOIPJM_.GetHashCode();
			if (this.PJEADDDAGKK != 0U)
			{
				num ^= this.PJEADDDAGKK.GetHashCode();
			}
			if (this.JFOJHGPHAHF)
			{
				num ^= this.JFOJHGPHAHF.GetHashCode();
			}
			num ^= this.pNIBCBABNLC_.GetHashCode();
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

		// Token: 0x06005CA3 RID: 23715 RVA: 0x000F602B File Offset: 0x000F422B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x000F6033 File Offset: 0x000F4233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x000F603C File Offset: 0x000F423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this.JFOJHGPHAHF)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.JFOJHGPHAHF);
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.OJFJFEJMJPG);
			}
			this.cJIKOHPNNMP_.WriteTo(ref output, GetSwordTrainingDataScRsp._repeated_cJIKOHPNNMP_codec);
			this.pNIBCBABNLC_.WriteTo(ref output, GetSwordTrainingDataScRsp._repeated_pNIBCBABNLC_codec);
			this.oFMIAGOIPJM_.WriteTo(ref output, GetSwordTrainingDataScRsp._repeated_oFMIAGOIPJM_codec);
			if (this.PJEADDDAGKK != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PJEADDDAGKK);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x000F611C File Offset: 0x000F431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			num += this.cJIKOHPNNMP_.CalculateSize(GetSwordTrainingDataScRsp._repeated_cJIKOHPNNMP_codec);
			if (this.oJFJFEJMJPG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OJFJFEJMJPG);
			}
			num += this.oFMIAGOIPJM_.CalculateSize(GetSwordTrainingDataScRsp._repeated_oFMIAGOIPJM_codec);
			if (this.PJEADDDAGKK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PJEADDDAGKK);
			}
			if (this.JFOJHGPHAHF)
			{
				num += 2;
			}
			num += this.pNIBCBABNLC_.CalculateSize(GetSwordTrainingDataScRsp._repeated_pNIBCBABNLC_codec);
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

		// Token: 0x06005CA7 RID: 23719 RVA: 0x000F61E8 File Offset: 0x000F43E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSwordTrainingDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new HPPHNMBHEEJ();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			this.cJIKOHPNNMP_.Add(other.cJIKOHPNNMP_);
			if (other.oJFJFEJMJPG_ != null)
			{
				if (this.oJFJFEJMJPG_ == null)
				{
					this.OJFJFEJMJPG = new NOMJFEEALFA();
				}
				this.OJFJFEJMJPG.MergeFrom(other.OJFJFEJMJPG);
			}
			this.oFMIAGOIPJM_.Add(other.oFMIAGOIPJM_);
			if (other.PJEADDDAGKK != 0U)
			{
				this.PJEADDDAGKK = other.PJEADDDAGKK;
			}
			if (other.JFOJHGPHAHF)
			{
				this.JFOJHGPHAHF = other.JFOJHGPHAHF;
			}
			this.pNIBCBABNLC_.Add(other.pNIBCBABNLC_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x000F62D7 File Offset: 0x000F44D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x000F62E0 File Offset: 0x000F44E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 34U)
				{
					if (num <= 64U)
					{
						if (num == 48U || num == 50U)
						{
							this.pNIBCBABNLC_.AddEntriesFrom(ref input, GetSwordTrainingDataScRsp._repeated_pNIBCBABNLC_codec);
							continue;
						}
						if (num != 64U)
						{
							goto IL_6F;
						}
					}
					else if (num != 66U)
					{
						if (num == 80U)
						{
							this.PJEADDDAGKK = input.ReadUInt32();
							continue;
						}
						if (num != 96U)
						{
							goto IL_6F;
						}
						this.Retcode = input.ReadUInt32();
						continue;
					}
					this.oFMIAGOIPJM_.AddEntriesFrom(ref input, GetSwordTrainingDataScRsp._repeated_oFMIAGOIPJM_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.bEDINILDMEB_ == null)
						{
							this.BEDINILDMEB = new HPPHNMBHEEJ();
						}
						input.ReadMessage(this.BEDINILDMEB);
						continue;
					}
					if (num == 16U)
					{
						this.JFOJHGPHAHF = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.oJFJFEJMJPG_ == null)
						{
							this.OJFJFEJMJPG = new NOMJFEEALFA();
						}
						input.ReadMessage(this.OJFJFEJMJPG);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.cJIKOHPNNMP_.AddEntriesFrom(ref input, GetSwordTrainingDataScRsp._repeated_cJIKOHPNNMP_codec);
						continue;
					}
				}
				IL_6F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023C4 RID: 9156
		private static readonly MessageParser<GetSwordTrainingDataScRsp> _parser = new MessageParser<GetSwordTrainingDataScRsp>(() => new GetSwordTrainingDataScRsp());

		// Token: 0x040023C5 RID: 9157
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C6 RID: 9158
		public const int BEDINILDMEBFieldNumber = 1;

		// Token: 0x040023C7 RID: 9159
		private HPPHNMBHEEJ bEDINILDMEB_;

		// Token: 0x040023C8 RID: 9160
		public const int CJIKOHPNNMPFieldNumber = 4;

		// Token: 0x040023C9 RID: 9161
		private static readonly FieldCodec<uint> _repeated_cJIKOHPNNMP_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040023CA RID: 9162
		private readonly RepeatedField<uint> cJIKOHPNNMP_ = new RepeatedField<uint>();

		// Token: 0x040023CB RID: 9163
		public const int OJFJFEJMJPGFieldNumber = 3;

		// Token: 0x040023CC RID: 9164
		private NOMJFEEALFA oJFJFEJMJPG_;

		// Token: 0x040023CD RID: 9165
		public const int OFMIAGOIPJMFieldNumber = 8;

		// Token: 0x040023CE RID: 9166
		private static readonly FieldCodec<uint> _repeated_oFMIAGOIPJM_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040023CF RID: 9167
		private readonly RepeatedField<uint> oFMIAGOIPJM_ = new RepeatedField<uint>();

		// Token: 0x040023D0 RID: 9168
		public const int PJEADDDAGKKFieldNumber = 10;

		// Token: 0x040023D1 RID: 9169
		private uint pJEADDDAGKK_;

		// Token: 0x040023D2 RID: 9170
		public const int JFOJHGPHAHFFieldNumber = 2;

		// Token: 0x040023D3 RID: 9171
		private bool jFOJHGPHAHF_;

		// Token: 0x040023D4 RID: 9172
		public const int PNIBCBABNLCFieldNumber = 6;

		// Token: 0x040023D5 RID: 9173
		private static readonly FieldCodec<uint> _repeated_pNIBCBABNLC_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040023D6 RID: 9174
		private readonly RepeatedField<uint> pNIBCBABNLC_ = new RepeatedField<uint>();

		// Token: 0x040023D7 RID: 9175
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040023D8 RID: 9176
		private uint retcode_;
	}
}
