using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003BF RID: 959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DNPMGACEBMM : IMessage<DNPMGACEBMM>, IMessage, IEquatable<DNPMGACEBMM>, IDeepCloneable<DNPMGACEBMM>, IBufferMessage
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x0007672A File Offset: 0x0007492A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DNPMGACEBMM> Parser
		{
			get
			{
				return DNPMGACEBMM._parser;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x00076731 File Offset: 0x00074931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DNPMGACEBMMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x00076743 File Offset: 0x00074943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DNPMGACEBMM.Descriptor;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0007674A File Offset: 0x0007494A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNPMGACEBMM()
		{
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00076768 File Offset: 0x00074968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNPMGACEBMM(DNPMGACEBMM other) : this()
		{
			this.chessRogueBuffInfo_ = ((other.chessRogueBuffInfo_ != null) ? other.chessRogueBuffInfo_.Clone() : null);
			this.eIFHOCNALBA_ = other.eIFHOCNALBA_;
			this.bGJKOLNCOPN_ = other.bGJKOLNCOPN_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.status_ = other.status_;
			this.mapId_ = other.mapId_;
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.chessRogueMiracleInfo_ = ((other.chessRogueMiracleInfo_ != null) ? other.chessRogueMiracleInfo_.Clone() : null);
			this.cGHKMJGKKIJ_ = other.cGHKMJGKKIJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00076822 File Offset: 0x00074A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNPMGACEBMM Clone()
		{
			return new DNPMGACEBMM(this);
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0007682A File Offset: 0x00074A2A
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00076832 File Offset: 0x00074A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff ChessRogueBuffInfo
		{
			get
			{
				return this.chessRogueBuffInfo_;
			}
			set
			{
				this.chessRogueBuffInfo_ = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0007683B File Offset: 0x00074A3B
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00076843 File Offset: 0x00074A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EIFHOCNALBA
		{
			get
			{
				return this.eIFHOCNALBA_;
			}
			set
			{
				this.eIFHOCNALBA_ = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0007684C File Offset: 0x00074A4C
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00076854 File Offset: 0x00074A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BGJKOLNCOPN
		{
			get
			{
				return this.bGJKOLNCOPN_;
			}
			set
			{
				this.bGJKOLNCOPN_ = value;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x0007685D File Offset: 0x00074A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x00076865 File Offset: 0x00074A65
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x0007686D File Offset: 0x00074A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00076876 File Offset: 0x00074A76
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0007687E File Offset: 0x00074A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x00076887 File Offset: 0x00074A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x0007688F File Offset: 0x00074A8F
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x00076897 File Offset: 0x00074A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle ChessRogueMiracleInfo
		{
			get
			{
				return this.chessRogueMiracleInfo_;
			}
			set
			{
				this.chessRogueMiracleInfo_ = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000768A0 File Offset: 0x00074AA0
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x000768A8 File Offset: 0x00074AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGHKMJGKKIJ
		{
			get
			{
				return this.cGHKMJGKKIJ_;
			}
			set
			{
				this.cGHKMJGKKIJ_ = value;
			}
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000768B1 File Offset: 0x00074AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DNPMGACEBMM);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000768C0 File Offset: 0x00074AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DNPMGACEBMM other)
		{
			return other != null && (other == this || (object.Equals(this.ChessRogueBuffInfo, other.ChessRogueBuffInfo) && this.EIFHOCNALBA == other.EIFHOCNALBA && this.BGJKOLNCOPN == other.BGJKOLNCOPN && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.Status == other.Status && this.MapId == other.MapId && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && object.Equals(this.ChessRogueMiracleInfo, other.ChessRogueMiracleInfo) && this.CGHKMJGKKIJ == other.CGHKMJGKKIJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00076990 File Offset: 0x00074B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chessRogueBuffInfo_ != null)
			{
				num ^= this.ChessRogueBuffInfo.GetHashCode();
			}
			if (this.EIFHOCNALBA != 0U)
			{
				num ^= this.EIFHOCNALBA.GetHashCode();
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				num ^= this.BGJKOLNCOPN.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.Status != RogueStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			num ^= this.trialAvatarIdList_.GetHashCode();
			if (this.chessRogueMiracleInfo_ != null)
			{
				num ^= this.ChessRogueMiracleInfo.GetHashCode();
			}
			if (this.CGHKMJGKKIJ != 0U)
			{
				num ^= this.CGHKMJGKKIJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00076A81 File Offset: 0x00074C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00076A89 File Offset: 0x00074C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00076A94 File Offset: 0x00074C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MapId);
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BGJKOLNCOPN);
			}
			this.baseAvatarIdList_.WriteTo(ref output, DNPMGACEBMM._repeated_baseAvatarIdList_codec);
			if (this.chessRogueBuffInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ChessRogueBuffInfo);
			}
			if (this.Status != RogueStatus.None)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			this.trialAvatarIdList_.WriteTo(ref output, DNPMGACEBMM._repeated_trialAvatarIdList_codec);
			if (this.EIFHOCNALBA != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EIFHOCNALBA);
			}
			if (this.CGHKMJGKKIJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CGHKMJGKKIJ);
			}
			if (this.chessRogueMiracleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ChessRogueMiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00076B9C File Offset: 0x00074D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chessRogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessRogueBuffInfo);
			}
			if (this.EIFHOCNALBA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EIFHOCNALBA);
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BGJKOLNCOPN);
			}
			num += this.baseAvatarIdList_.CalculateSize(DNPMGACEBMM._repeated_baseAvatarIdList_codec);
			if (this.Status != RogueStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			num += this.trialAvatarIdList_.CalculateSize(DNPMGACEBMM._repeated_trialAvatarIdList_codec);
			if (this.chessRogueMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessRogueMiracleInfo);
			}
			if (this.CGHKMJGKKIJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGHKMJGKKIJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00076C90 File Offset: 0x00074E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DNPMGACEBMM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chessRogueBuffInfo_ != null)
			{
				if (this.chessRogueBuffInfo_ == null)
				{
					this.ChessRogueBuffInfo = new ChessRogueBuff();
				}
				this.ChessRogueBuffInfo.MergeFrom(other.ChessRogueBuffInfo);
			}
			if (other.EIFHOCNALBA != 0U)
			{
				this.EIFHOCNALBA = other.EIFHOCNALBA;
			}
			if (other.BGJKOLNCOPN != 0U)
			{
				this.BGJKOLNCOPN = other.BGJKOLNCOPN;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.Status != RogueStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.chessRogueMiracleInfo_ != null)
			{
				if (this.chessRogueMiracleInfo_ == null)
				{
					this.ChessRogueMiracleInfo = new ChessRogueMiracle();
				}
				this.ChessRogueMiracleInfo.MergeFrom(other.ChessRogueMiracleInfo);
			}
			if (other.CGHKMJGKKIJ != 0U)
			{
				this.CGHKMJGKKIJ = other.CGHKMJGKKIJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00076D96 File Offset: 0x00074F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00076DA0 File Offset: 0x00074FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.MapId = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.BGJKOLNCOPN = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U || num == 34U)
						{
							this.baseAvatarIdList_.AddEntriesFrom(ref input, DNPMGACEBMM._repeated_baseAvatarIdList_codec);
							continue;
						}
						if (num == 42U)
						{
							if (this.chessRogueBuffInfo_ == null)
							{
								this.ChessRogueBuffInfo = new ChessRogueBuff();
							}
							input.ReadMessage(this.ChessRogueBuffInfo);
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 56U)
					{
						this.Status = (RogueStatus)input.ReadEnum();
						continue;
					}
					if (num == 72U || num == 74U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, DNPMGACEBMM._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EIFHOCNALBA = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.CGHKMJGKKIJ = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.chessRogueMiracleInfo_ == null)
						{
							this.ChessRogueMiracleInfo = new ChessRogueMiracle();
						}
						input.ReadMessage(this.ChessRogueMiracleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400113B RID: 4411
		private static readonly MessageParser<DNPMGACEBMM> _parser = new MessageParser<DNPMGACEBMM>(() => new DNPMGACEBMM());

		// Token: 0x0400113C RID: 4412
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400113D RID: 4413
		public const int ChessRogueBuffInfoFieldNumber = 5;

		// Token: 0x0400113E RID: 4414
		private ChessRogueBuff chessRogueBuffInfo_;

		// Token: 0x0400113F RID: 4415
		public const int EIFHOCNALBAFieldNumber = 10;

		// Token: 0x04001140 RID: 4416
		private uint eIFHOCNALBA_;

		// Token: 0x04001141 RID: 4417
		public const int BGJKOLNCOPNFieldNumber = 3;

		// Token: 0x04001142 RID: 4418
		private uint bGJKOLNCOPN_;

		// Token: 0x04001143 RID: 4419
		public const int BaseAvatarIdListFieldNumber = 4;

		// Token: 0x04001144 RID: 4420
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04001145 RID: 4421
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04001146 RID: 4422
		public const int StatusFieldNumber = 7;

		// Token: 0x04001147 RID: 4423
		private RogueStatus status_;

		// Token: 0x04001148 RID: 4424
		public const int MapIdFieldNumber = 1;

		// Token: 0x04001149 RID: 4425
		private uint mapId_;

		// Token: 0x0400114A RID: 4426
		public const int TrialAvatarIdListFieldNumber = 9;

		// Token: 0x0400114B RID: 4427
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400114C RID: 4428
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x0400114D RID: 4429
		public const int ChessRogueMiracleInfoFieldNumber = 13;

		// Token: 0x0400114E RID: 4430
		private ChessRogueMiracle chessRogueMiracleInfo_;

		// Token: 0x0400114F RID: 4431
		public const int CGHKMJGKKIJFieldNumber = 12;

		// Token: 0x04001150 RID: 4432
		private uint cGHKMJGKKIJ_;
	}
}
