using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200011F RID: 287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BHCFGECDIDJ : IMessage<BHCFGECDIDJ>, IMessage, IEquatable<BHCFGECDIDJ>, IDeepCloneable<BHCFGECDIDJ>, IBufferMessage
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00026C23 File Offset: 0x00024E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BHCFGECDIDJ> Parser
		{
			get
			{
				return BHCFGECDIDJ._parser;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00026C2A File Offset: 0x00024E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BHCFGECDIDJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00026C3C File Offset: 0x00024E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BHCFGECDIDJ.Descriptor;
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00026C43 File Offset: 0x00024E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHCFGECDIDJ()
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00026C4C File Offset: 0x00024E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHCFGECDIDJ(BHCFGECDIDJ other) : this()
		{
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this.dFGIFLKMMFD_ = other.dFGIFLKMMFD_;
			this.scriptId_ = other.scriptId_;
			this.progress_ = other.progress_;
			this.jFMPKBHGOPE_ = other.jFMPKBHGOPE_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.dFFMIACMHLD_ = other.dFFMIACMHLD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00026CD4 File Offset: 0x00024ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHCFGECDIDJ Clone()
		{
			return new BHCFGECDIDJ(this);
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00026CDC File Offset: 0x00024EDC
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00026CE4 File Offset: 0x00024EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIGPMMBDEJD
		{
			get
			{
				return this.cIGPMMBDEJD_;
			}
			set
			{
				this.cIGPMMBDEJD_ = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00026CED File Offset: 0x00024EED
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00026CF5 File Offset: 0x00024EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DFGIFLKMMFD
		{
			get
			{
				return this.dFGIFLKMMFD_;
			}
			set
			{
				this.dFGIFLKMMFD_ = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00026CFE File Offset: 0x00024EFE
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00026D06 File Offset: 0x00024F06
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00026D0F File Offset: 0x00024F0F
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00026D17 File Offset: 0x00024F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00026D20 File Offset: 0x00024F20
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00026D28 File Offset: 0x00024F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JFMPKBHGOPE
		{
			get
			{
				return this.jFMPKBHGOPE_;
			}
			set
			{
				this.jFMPKBHGOPE_ = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00026D31 File Offset: 0x00024F31
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00026D39 File Offset: 0x00024F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00026D42 File Offset: 0x00024F42
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00026D4A File Offset: 0x00024F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DFFMIACMHLD
		{
			get
			{
				return this.dFFMIACMHLD_;
			}
			set
			{
				this.dFFMIACMHLD_ = value;
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00026D53 File Offset: 0x00024F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BHCFGECDIDJ);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00026D64 File Offset: 0x00024F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BHCFGECDIDJ other)
		{
			return other != null && (other == this || (this.CIGPMMBDEJD == other.CIGPMMBDEJD && this.DFGIFLKMMFD == other.DFGIFLKMMFD && this.ScriptId == other.ScriptId && this.Progress == other.Progress && this.JFMPKBHGOPE == other.JFMPKBHGOPE && object.Equals(this.Reward, other.Reward) && this.DFFMIACMHLD == other.DFFMIACMHLD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00026E04 File Offset: 0x00025004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
			}
			if (this.DFGIFLKMMFD)
			{
				num ^= this.DFGIFLKMMFD.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				num ^= this.JFMPKBHGOPE.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.DFFMIACMHLD)
			{
				num ^= this.DFFMIACMHLD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00026ED6 File Offset: 0x000250D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00026EDE File Offset: 0x000250DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00026EE8 File Offset: 0x000250E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.DFFMIACMHLD)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DFFMIACMHLD);
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.JFMPKBHGOPE);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Progress);
			}
			if (this.DFGIFLKMMFD)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.DFGIFLKMMFD);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Reward);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00026FCC File Offset: 0x000251CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
			}
			if (this.DFGIFLKMMFD)
			{
				num += 2;
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JFMPKBHGOPE);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.DFFMIACMHLD)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00027084 File Offset: 0x00025284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BHCFGECDIDJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			if (other.DFGIFLKMMFD)
			{
				this.DFGIFLKMMFD = other.DFGIFLKMMFD;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.JFMPKBHGOPE != 0U)
			{
				this.JFMPKBHGOPE = other.JFMPKBHGOPE;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.DFFMIACMHLD)
			{
				this.DFFMIACMHLD = other.DFFMIACMHLD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00027150 File Offset: 0x00025350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0002715C File Offset: 0x0002535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.ScriptId = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.DFFMIACMHLD = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.JFMPKBHGOPE = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.Progress = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.DFGIFLKMMFD = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 104U)
					{
						this.CIGPMMBDEJD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400059A RID: 1434
		private static readonly MessageParser<BHCFGECDIDJ> _parser = new MessageParser<BHCFGECDIDJ>(() => new BHCFGECDIDJ());

		// Token: 0x0400059B RID: 1435
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400059C RID: 1436
		public const int CIGPMMBDEJDFieldNumber = 13;

		// Token: 0x0400059D RID: 1437
		private uint cIGPMMBDEJD_;

		// Token: 0x0400059E RID: 1438
		public const int DFGIFLKMMFDFieldNumber = 10;

		// Token: 0x0400059F RID: 1439
		private bool dFGIFLKMMFD_;

		// Token: 0x040005A0 RID: 1440
		public const int ScriptIdFieldNumber = 1;

		// Token: 0x040005A1 RID: 1441
		private uint scriptId_;

		// Token: 0x040005A2 RID: 1442
		public const int ProgressFieldNumber = 8;

		// Token: 0x040005A3 RID: 1443
		private uint progress_;

		// Token: 0x040005A4 RID: 1444
		public const int JFMPKBHGOPEFieldNumber = 7;

		// Token: 0x040005A5 RID: 1445
		private uint jFMPKBHGOPE_;

		// Token: 0x040005A6 RID: 1446
		public const int RewardFieldNumber = 12;

		// Token: 0x040005A7 RID: 1447
		private ItemList reward_;

		// Token: 0x040005A8 RID: 1448
		public const int DFFMIACMHLDFieldNumber = 3;

		// Token: 0x040005A9 RID: 1449
		private bool dFFMIACMHLD_;
	}
}
