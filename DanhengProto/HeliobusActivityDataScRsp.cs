using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B5 RID: 2229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusActivityDataScRsp : IMessage<HeliobusActivityDataScRsp>, IMessage, IEquatable<HeliobusActivityDataScRsp>, IDeepCloneable<HeliobusActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x00109ED4 File Offset: 0x001080D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusActivityDataScRsp> Parser
		{
			get
			{
				return HeliobusActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06006351 RID: 25425 RVA: 0x00109EDB File Offset: 0x001080DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x00109EED File Offset: 0x001080ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00109EF4 File Offset: 0x001080F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataScRsp()
		{
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00109F20 File Offset: 0x00108120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataScRsp(HeliobusActivityDataScRsp other) : this()
		{
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this.fMAJFICFMFO_ = other.fMAJFICFMFO_.Clone();
			this.aIJHHHCOBFF_ = other.aIJHHHCOBFF_;
			this.phase_ = other.phase_;
			this.retcode_ = other.retcode_;
			this.cBHOAPIBCJM_ = other.cBHOAPIBCJM_;
			this.challengeList_ = other.challengeList_.Clone();
			this.jGKJJKFBLCF_ = other.jGKJJKFBLCF_;
			this.iBNHFLHJFEO_ = other.iBNHFLHJFEO_.Clone();
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x00109FDB File Offset: 0x001081DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataScRsp Clone()
		{
			return new HeliobusActivityDataScRsp(this);
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x00109FE3 File Offset: 0x001081E3
		// (set) Token: 0x06006357 RID: 25431 RVA: 0x00109FEB File Offset: 0x001081EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCIHLLAEJJK SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
			set
			{
				this.skillInfo_ = value;
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x00109FF4 File Offset: 0x001081F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeliobusChallengeLineup> FMAJFICFMFO
		{
			get
			{
				return this.fMAJFICFMFO_;
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x00109FFC File Offset: 0x001081FC
		// (set) Token: 0x0600635A RID: 25434 RVA: 0x0010A004 File Offset: 0x00108204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AIJHHHCOBFF
		{
			get
			{
				return this.aIJHHHCOBFF_;
			}
			set
			{
				this.aIJHHHCOBFF_ = value;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x0600635B RID: 25435 RVA: 0x0010A00D File Offset: 0x0010820D
		// (set) Token: 0x0600635C RID: 25436 RVA: 0x0010A015 File Offset: 0x00108215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = value;
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x0600635D RID: 25437 RVA: 0x0010A01E File Offset: 0x0010821E
		// (set) Token: 0x0600635E RID: 25438 RVA: 0x0010A026 File Offset: 0x00108226
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

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x0600635F RID: 25439 RVA: 0x0010A02F File Offset: 0x0010822F
		// (set) Token: 0x06006360 RID: 25440 RVA: 0x0010A037 File Offset: 0x00108237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBHOAPIBCJM
		{
			get
			{
				return this.cBHOAPIBCJM_;
			}
			set
			{
				this.cBHOAPIBCJM_ = value;
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x0010A040 File Offset: 0x00108240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeList> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x0010A048 File Offset: 0x00108248
		// (set) Token: 0x06006363 RID: 25443 RVA: 0x0010A050 File Offset: 0x00108250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JGKJJKFBLCF
		{
			get
			{
				return this.jGKJJKFBLCF_;
			}
			set
			{
				this.jGKJJKFBLCF_ = value;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x0010A059 File Offset: 0x00108259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PCMDGDLANFF> IBNHFLHJFEO
		{
			get
			{
				return this.iBNHFLHJFEO_;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06006365 RID: 25445 RVA: 0x0010A061 File Offset: 0x00108261
		// (set) Token: 0x06006366 RID: 25446 RVA: 0x0010A069 File Offset: 0x00108269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0010A072 File Offset: 0x00108272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusActivityDataScRsp);
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x0010A080 File Offset: 0x00108280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusActivityDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.SkillInfo, other.SkillInfo) && this.fMAJFICFMFO_.Equals(other.fMAJFICFMFO_) && this.AIJHHHCOBFF == other.AIJHHHCOBFF && this.Phase == other.Phase && this.Retcode == other.Retcode && this.CBHOAPIBCJM == other.CBHOAPIBCJM && this.challengeList_.Equals(other.challengeList_) && this.JGKJJKFBLCF == other.JGKJJKFBLCF && this.iBNHFLHJFEO_.Equals(other.iBNHFLHJFEO_) && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x0010A160 File Offset: 0x00108360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.skillInfo_ != null)
			{
				num ^= this.SkillInfo.GetHashCode();
			}
			num ^= this.fMAJFICFMFO_.GetHashCode();
			if (this.AIJHHHCOBFF != 0U)
			{
				num ^= this.AIJHHHCOBFF.GetHashCode();
			}
			if (this.Phase != 0U)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CBHOAPIBCJM != 0U)
			{
				num ^= this.CBHOAPIBCJM.GetHashCode();
			}
			num ^= this.challengeList_.GetHashCode();
			if (this.JGKJJKFBLCF != 0U)
			{
				num ^= this.JGKJJKFBLCF.GetHashCode();
			}
			num ^= this.iBNHFLHJFEO_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x0010A25C File Offset: 0x0010845C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x0010A264 File Offset: 0x00108464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x0010A270 File Offset: 0x00108470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.iBNHFLHJFEO_.WriteTo(ref output, HeliobusActivityDataScRsp._repeated_iBNHFLHJFEO_codec);
			if (this.AIJHHHCOBFF != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AIJHHHCOBFF);
			}
			if (this.CBHOAPIBCJM != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CBHOAPIBCJM);
			}
			this.fMAJFICFMFO_.WriteTo(ref output, HeliobusActivityDataScRsp._repeated_fMAJFICFMFO_codec);
			if (this.Phase != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Phase);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.JGKJJKFBLCF);
			}
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SkillInfo);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Level);
			}
			this.challengeList_.WriteTo(ref output, HeliobusActivityDataScRsp._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x0010A388 File Offset: 0x00108588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.skillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfo);
			}
			num += this.fMAJFICFMFO_.CalculateSize(HeliobusActivityDataScRsp._repeated_fMAJFICFMFO_codec);
			if (this.AIJHHHCOBFF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AIJHHHCOBFF);
			}
			if (this.Phase != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Phase);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CBHOAPIBCJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBHOAPIBCJM);
			}
			num += this.challengeList_.CalculateSize(HeliobusActivityDataScRsp._repeated_challengeList_codec);
			if (this.JGKJJKFBLCF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JGKJJKFBLCF);
			}
			num += this.iBNHFLHJFEO_.CalculateSize(HeliobusActivityDataScRsp._repeated_iBNHFLHJFEO_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x0010A490 File Offset: 0x00108690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.skillInfo_ != null)
			{
				if (this.skillInfo_ == null)
				{
					this.SkillInfo = new NCIHLLAEJJK();
				}
				this.SkillInfo.MergeFrom(other.SkillInfo);
			}
			this.fMAJFICFMFO_.Add(other.fMAJFICFMFO_);
			if (other.AIJHHHCOBFF != 0U)
			{
				this.AIJHHHCOBFF = other.AIJHHHCOBFF;
			}
			if (other.Phase != 0U)
			{
				this.Phase = other.Phase;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CBHOAPIBCJM != 0U)
			{
				this.CBHOAPIBCJM = other.CBHOAPIBCJM;
			}
			this.challengeList_.Add(other.challengeList_);
			if (other.JGKJJKFBLCF != 0U)
			{
				this.JGKJJKFBLCF = other.JGKJJKFBLCF;
			}
			this.iBNHFLHJFEO_.Add(other.iBNHFLHJFEO_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0010A58F File Offset: 0x0010878F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x0010A598 File Offset: 0x00108798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 34U)
					{
						if (num == 8U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 34U)
						{
							this.iBNHFLHJFEO_.AddEntriesFrom(ref input, HeliobusActivityDataScRsp._repeated_iBNHFLHJFEO_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.AIJHHHCOBFF = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.CBHOAPIBCJM = input.ReadUInt32();
							continue;
						}
						if (num == 58U)
						{
							this.fMAJFICFMFO_.AddEntriesFrom(ref input, HeliobusActivityDataScRsp._repeated_fMAJFICFMFO_codec);
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 64U)
					{
						this.Phase = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.JGKJJKFBLCF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.skillInfo_ == null)
						{
							this.SkillInfo = new NCIHLLAEJJK();
						}
						input.ReadMessage(this.SkillInfo);
						continue;
					}
					if (num == 112U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						this.challengeList_.AddEntriesFrom(ref input, HeliobusActivityDataScRsp._repeated_challengeList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002641 RID: 9793
		private static readonly MessageParser<HeliobusActivityDataScRsp> _parser = new MessageParser<HeliobusActivityDataScRsp>(() => new HeliobusActivityDataScRsp());

		// Token: 0x04002642 RID: 9794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002643 RID: 9795
		public const int SkillInfoFieldNumber = 13;

		// Token: 0x04002644 RID: 9796
		private NCIHLLAEJJK skillInfo_;

		// Token: 0x04002645 RID: 9797
		public const int FMAJFICFMFOFieldNumber = 7;

		// Token: 0x04002646 RID: 9798
		private static readonly FieldCodec<HeliobusChallengeLineup> _repeated_fMAJFICFMFO_codec = FieldCodec.ForMessage<HeliobusChallengeLineup>(58U, HeliobusChallengeLineup.Parser);

		// Token: 0x04002647 RID: 9799
		private readonly RepeatedField<HeliobusChallengeLineup> fMAJFICFMFO_ = new RepeatedField<HeliobusChallengeLineup>();

		// Token: 0x04002648 RID: 9800
		public const int AIJHHHCOBFFFieldNumber = 5;

		// Token: 0x04002649 RID: 9801
		private uint aIJHHHCOBFF_;

		// Token: 0x0400264A RID: 9802
		public const int PhaseFieldNumber = 8;

		// Token: 0x0400264B RID: 9803
		private uint phase_;

		// Token: 0x0400264C RID: 9804
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400264D RID: 9805
		private uint retcode_;

		// Token: 0x0400264E RID: 9806
		public const int CBHOAPIBCJMFieldNumber = 6;

		// Token: 0x0400264F RID: 9807
		private uint cBHOAPIBCJM_;

		// Token: 0x04002650 RID: 9808
		public const int ChallengeListFieldNumber = 15;

		// Token: 0x04002651 RID: 9809
		private static readonly FieldCodec<ChallengeList> _repeated_challengeList_codec = FieldCodec.ForMessage<ChallengeList>(122U, EggLink.DanhengServer.Proto.ChallengeList.Parser);

		// Token: 0x04002652 RID: 9810
		private readonly RepeatedField<ChallengeList> challengeList_ = new RepeatedField<ChallengeList>();

		// Token: 0x04002653 RID: 9811
		public const int JGKJJKFBLCFFieldNumber = 12;

		// Token: 0x04002654 RID: 9812
		private uint jGKJJKFBLCF_;

		// Token: 0x04002655 RID: 9813
		public const int IBNHFLHJFEOFieldNumber = 4;

		// Token: 0x04002656 RID: 9814
		private static readonly FieldCodec<PCMDGDLANFF> _repeated_iBNHFLHJFEO_codec = FieldCodec.ForMessage<PCMDGDLANFF>(34U, PCMDGDLANFF.Parser);

		// Token: 0x04002657 RID: 9815
		private readonly RepeatedField<PCMDGDLANFF> iBNHFLHJFEO_ = new RepeatedField<PCMDGDLANFF>();

		// Token: 0x04002658 RID: 9816
		public const int LevelFieldNumber = 14;

		// Token: 0x04002659 RID: 9817
		private uint level_;
	}
}
