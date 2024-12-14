using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000307 RID: 775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkUseBuffScRsp : IMessage<ClockParkUseBuffScRsp>, IMessage, IEquatable<ClockParkUseBuffScRsp>, IDeepCloneable<ClockParkUseBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0006268F File Offset: 0x0006088F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkUseBuffScRsp> Parser
		{
			get
			{
				return ClockParkUseBuffScRsp._parser;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00062696 File Offset: 0x00060896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkUseBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000626A8 File Offset: 0x000608A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkUseBuffScRsp.Descriptor;
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000626AF File Offset: 0x000608AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffScRsp()
		{
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000626B8 File Offset: 0x000608B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffScRsp(ClockParkUseBuffScRsp other) : this()
		{
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.scriptId_ = other.scriptId_;
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this.oCBBEAJPFGF_ = ((other.oCBBEAJPFGF_ != null) ? other.oCBBEAJPFGF_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00062754 File Offset: 0x00060954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffScRsp Clone()
		{
			return new ClockParkUseBuffScRsp(this);
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0006275C File Offset: 0x0006095C
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x00062764 File Offset: 0x00060964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HIAGEINLAHL
		{
			get
			{
				return this.hIAGEINLAHL_;
			}
			set
			{
				this.hIAGEINLAHL_ = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0006276D File Offset: 0x0006096D
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x00062775 File Offset: 0x00060975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKIOOBNBDEB RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x0006277E File Offset: 0x0006097E
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x00062786 File Offset: 0x00060986
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

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0006278F File Offset: 0x0006098F
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x00062797 File Offset: 0x00060997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000627A0 File Offset: 0x000609A0
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x000627A8 File Offset: 0x000609A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP MALKHNFHFAE
		{
			get
			{
				return this.mALKHNFHFAE_;
			}
			set
			{
				this.mALKHNFHFAE_ = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000627B1 File Offset: 0x000609B1
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x000627B9 File Offset: 0x000609B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMJPKICFBLI OCBBEAJPFGF
		{
			get
			{
				return this.oCBBEAJPFGF_;
			}
			set
			{
				this.oCBBEAJPFGF_ = value;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000627C2 File Offset: 0x000609C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkUseBuffScRsp);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000627D0 File Offset: 0x000609D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkUseBuffScRsp other)
		{
			return other != null && (other == this || (this.HIAGEINLAHL == other.HIAGEINLAHL && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && this.Retcode == other.Retcode && this.ScriptId == other.ScriptId && object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this.OCBBEAJPFGF, other.OCBBEAJPFGF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00062868 File Offset: 0x00060A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.mALKHNFHFAE_ != null)
			{
				num ^= this.MALKHNFHFAE.GetHashCode();
			}
			if (this.oCBBEAJPFGF_ != null)
			{
				num ^= this.OCBBEAJPFGF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0006291B File Offset: 0x00060B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00062923 File Offset: 0x00060B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0006292C File Offset: 0x00060B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(154, 71);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this.oCBBEAJPFGF_ != null)
			{
				output.WriteRawTag(146, 94);
				output.WriteMessage(this.OCBBEAJPFGF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00062A00 File Offset: 0x00060C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.mALKHNFHFAE_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MALKHNFHFAE);
			}
			if (this.oCBBEAJPFGF_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OCBBEAJPFGF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00062AB8 File Offset: 0x00060CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkUseBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new OKIOOBNBDEB();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.mALKHNFHFAE_ != null)
			{
				if (this.mALKHNFHFAE_ == null)
				{
					this.MALKHNFHFAE = new DPCAMGELHBP();
				}
				this.MALKHNFHFAE.MergeFrom(other.MALKHNFHFAE);
			}
			if (other.oCBBEAJPFGF_ != null)
			{
				if (this.oCBBEAJPFGF_ == null)
				{
					this.OCBBEAJPFGF = new IMJPKICFBLI();
				}
				this.OCBBEAJPFGF.MergeFrom(other.OCBBEAJPFGF);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00062BA0 File Offset: 0x00060DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00062BAC File Offset: 0x00060DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 8U)
					{
						this.ScriptId = input.ReadUInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.rogueBuffInfo_ == null)
						{
							this.RogueBuffInfo = new OKIOOBNBDEB();
						}
						input.ReadMessage(this.RogueBuffInfo);
						continue;
					}
					if (num == 88U)
					{
						this.HIAGEINLAHL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 9114U)
					{
						if (this.mALKHNFHFAE_ == null)
						{
							this.MALKHNFHFAE = new DPCAMGELHBP();
						}
						input.ReadMessage(this.MALKHNFHFAE);
						continue;
					}
					if (num == 12050U)
					{
						if (this.oCBBEAJPFGF_ == null)
						{
							this.OCBBEAJPFGF = new IMJPKICFBLI();
						}
						input.ReadMessage(this.OCBBEAJPFGF);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E44 RID: 3652
		private static readonly MessageParser<ClockParkUseBuffScRsp> _parser = new MessageParser<ClockParkUseBuffScRsp>(() => new ClockParkUseBuffScRsp());

		// Token: 0x04000E45 RID: 3653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E46 RID: 3654
		public const int HIAGEINLAHLFieldNumber = 11;

		// Token: 0x04000E47 RID: 3655
		private uint hIAGEINLAHL_;

		// Token: 0x04000E48 RID: 3656
		public const int RogueBuffInfoFieldNumber = 2;

		// Token: 0x04000E49 RID: 3657
		private OKIOOBNBDEB rogueBuffInfo_;

		// Token: 0x04000E4A RID: 3658
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04000E4B RID: 3659
		private uint retcode_;

		// Token: 0x04000E4C RID: 3660
		public const int ScriptIdFieldNumber = 1;

		// Token: 0x04000E4D RID: 3661
		private uint scriptId_;

		// Token: 0x04000E4E RID: 3662
		public const int MALKHNFHFAEFieldNumber = 1139;

		// Token: 0x04000E4F RID: 3663
		private DPCAMGELHBP mALKHNFHFAE_;

		// Token: 0x04000E50 RID: 3664
		public const int OCBBEAJPFGFFieldNumber = 1506;

		// Token: 0x04000E51 RID: 3665
		private IMJPKICFBLI oCBBEAJPFGF_;
	}
}
