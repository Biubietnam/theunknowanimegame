using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D5 RID: 4309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetBoxingClubResonanceLineupCsReq : IMessage<SetBoxingClubResonanceLineupCsReq>, IMessage, IEquatable<SetBoxingClubResonanceLineupCsReq>, IDeepCloneable<SetBoxingClubResonanceLineupCsReq>, IBufferMessage
	{
		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600C025 RID: 49189 RVA: 0x00205227 File Offset: 0x00203427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetBoxingClubResonanceLineupCsReq> Parser
		{
			get
			{
				return SetBoxingClubResonanceLineupCsReq._parser;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x0020522E File Offset: 0x0020342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetBoxingClubResonanceLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600C027 RID: 49191 RVA: 0x00205240 File Offset: 0x00203440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBoxingClubResonanceLineupCsReq.Descriptor;
			}
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x00205247 File Offset: 0x00203447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupCsReq()
		{
		}

		// Token: 0x0600C029 RID: 49193 RVA: 0x0020525A File Offset: 0x0020345A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupCsReq(SetBoxingClubResonanceLineupCsReq other) : this()
		{
			this.hHMFMFHCMOK_ = other.hHMFMFHCMOK_.Clone();
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x00205290 File Offset: 0x00203490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupCsReq Clone()
		{
			return new SetBoxingClubResonanceLineupCsReq(this);
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600C02B RID: 49195 RVA: 0x00205298 File Offset: 0x00203498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BFJBLOCEHJG> HHMFMFHCMOK
		{
			get
			{
				return this.hHMFMFHCMOK_;
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600C02C RID: 49196 RVA: 0x002052A0 File Offset: 0x002034A0
		// (set) Token: 0x0600C02D RID: 49197 RVA: 0x002052A8 File Offset: 0x002034A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x002052B1 File Offset: 0x002034B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBoxingClubResonanceLineupCsReq);
		}

		// Token: 0x0600C02F RID: 49199 RVA: 0x002052C0 File Offset: 0x002034C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBoxingClubResonanceLineupCsReq other)
		{
			return other != null && (other == this || (this.hHMFMFHCMOK_.Equals(other.hHMFMFHCMOK_) && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x00205310 File Offset: 0x00203510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hHMFMFHCMOK_.GetHashCode();
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C031 RID: 49201 RVA: 0x0020535D File Offset: 0x0020355D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x00205365 File Offset: 0x00203565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x00205370 File Offset: 0x00203570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChallengeId);
			}
			this.hHMFMFHCMOK_.WriteTo(ref output, SetBoxingClubResonanceLineupCsReq._repeated_hHMFMFHCMOK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x002053C0 File Offset: 0x002035C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hHMFMFHCMOK_.CalculateSize(SetBoxingClubResonanceLineupCsReq._repeated_hHMFMFHCMOK_codec);
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C035 RID: 49205 RVA: 0x00205414 File Offset: 0x00203614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBoxingClubResonanceLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.hHMFMFHCMOK_.Add(other.hHMFMFHCMOK_);
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x00205461 File Offset: 0x00203661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x0020546C File Offset: 0x0020366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hHMFMFHCMOK_.AddEntriesFrom(ref input, SetBoxingClubResonanceLineupCsReq._repeated_hHMFMFHCMOK_codec);
					}
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DF2 RID: 19954
		private static readonly MessageParser<SetBoxingClubResonanceLineupCsReq> _parser = new MessageParser<SetBoxingClubResonanceLineupCsReq>(() => new SetBoxingClubResonanceLineupCsReq());

		// Token: 0x04004DF3 RID: 19955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DF4 RID: 19956
		public const int HHMFMFHCMOKFieldNumber = 12;

		// Token: 0x04004DF5 RID: 19957
		private static readonly FieldCodec<BFJBLOCEHJG> _repeated_hHMFMFHCMOK_codec = FieldCodec.ForMessage<BFJBLOCEHJG>(98U, BFJBLOCEHJG.Parser);

		// Token: 0x04004DF6 RID: 19958
		private readonly RepeatedField<BFJBLOCEHJG> hHMFMFHCMOK_ = new RepeatedField<BFJBLOCEHJG>();

		// Token: 0x04004DF7 RID: 19959
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04004DF8 RID: 19960
		private uint challengeId_;
	}
}
