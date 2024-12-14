using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C1 RID: 705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChooseBoxingClubResonanceCsReq : IMessage<ChooseBoxingClubResonanceCsReq>, IMessage, IEquatable<ChooseBoxingClubResonanceCsReq>, IDeepCloneable<ChooseBoxingClubResonanceCsReq>, IBufferMessage
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00059485 File Offset: 0x00057685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChooseBoxingClubResonanceCsReq> Parser
		{
			get
			{
				return ChooseBoxingClubResonanceCsReq._parser;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0005948C File Offset: 0x0005768C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChooseBoxingClubResonanceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0005949E File Offset: 0x0005769E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChooseBoxingClubResonanceCsReq.Descriptor;
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000594A5 File Offset: 0x000576A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceCsReq()
		{
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000594AD File Offset: 0x000576AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceCsReq(ChooseBoxingClubResonanceCsReq other) : this()
		{
			this.jIBAEJKHDJA_ = other.jIBAEJKHDJA_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000594DE File Offset: 0x000576DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceCsReq Clone()
		{
			return new ChooseBoxingClubResonanceCsReq(this);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x000594E6 File Offset: 0x000576E6
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x000594EE File Offset: 0x000576EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIBAEJKHDJA
		{
			get
			{
				return this.jIBAEJKHDJA_;
			}
			set
			{
				this.jIBAEJKHDJA_ = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x000594F7 File Offset: 0x000576F7
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x000594FF File Offset: 0x000576FF
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

		// Token: 0x06001F59 RID: 8025 RVA: 0x00059508 File Offset: 0x00057708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChooseBoxingClubResonanceCsReq);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00059516 File Offset: 0x00057716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChooseBoxingClubResonanceCsReq other)
		{
			return other != null && (other == this || (this.JIBAEJKHDJA == other.JIBAEJKHDJA && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00059554 File Offset: 0x00057754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JIBAEJKHDJA != 0U)
			{
				num ^= this.JIBAEJKHDJA.GetHashCode();
			}
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

		// Token: 0x06001F5C RID: 8028 RVA: 0x000595AC File Offset: 0x000577AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000595B4 File Offset: 0x000577B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000595C0 File Offset: 0x000577C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JIBAEJKHDJA != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.JIBAEJKHDJA);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0005961C File Offset: 0x0005781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JIBAEJKHDJA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIBAEJKHDJA);
			}
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

		// Token: 0x06001F60 RID: 8032 RVA: 0x00059674 File Offset: 0x00057874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChooseBoxingClubResonanceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JIBAEJKHDJA != 0U)
			{
				this.JIBAEJKHDJA = other.JIBAEJKHDJA;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000596C4 File Offset: 0x000578C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000596D0 File Offset: 0x000578D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeId = input.ReadUInt32();
					}
				}
				else
				{
					this.JIBAEJKHDJA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000CFE RID: 3326
		private static readonly MessageParser<ChooseBoxingClubResonanceCsReq> _parser = new MessageParser<ChooseBoxingClubResonanceCsReq>(() => new ChooseBoxingClubResonanceCsReq());

		// Token: 0x04000CFF RID: 3327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D00 RID: 3328
		public const int JIBAEJKHDJAFieldNumber = 9;

		// Token: 0x04000D01 RID: 3329
		private uint jIBAEJKHDJA_;

		// Token: 0x04000D02 RID: 3330
		public const int ChallengeIdFieldNumber = 15;

		// Token: 0x04000D03 RID: 3331
		private uint challengeId_;
	}
}
