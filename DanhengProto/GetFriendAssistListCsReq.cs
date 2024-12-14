using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B5 RID: 1717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendAssistListCsReq : IMessage<GetFriendAssistListCsReq>, IMessage, IEquatable<GetFriendAssistListCsReq>, IDeepCloneable<GetFriendAssistListCsReq>, IBufferMessage
	{
		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x000D03FF File Offset: 0x000CE5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendAssistListCsReq> Parser
		{
			get
			{
				return GetFriendAssistListCsReq._parser;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x000D0406 File Offset: 0x000CE606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendAssistListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x000D0418 File Offset: 0x000CE618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendAssistListCsReq.Descriptor;
			}
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x000D041F File Offset: 0x000CE61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListCsReq()
		{
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x000D0440 File Offset: 0x000CE640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListCsReq(GetFriendAssistListCsReq other) : this()
		{
			this.oPCHJHGGKJP_ = other.oPCHJHGGKJP_;
			this.kKKMMPBNECM_ = other.kKKMMPBNECM_.Clone();
			this.targetUid_ = other.targetUid_;
			this.gJECOHCGNMP_ = other.gJECOHCGNMP_.Clone();
			this.cOBDHLMALKI_ = other.cOBDHLMALKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x000D04AA File Offset: 0x000CE6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListCsReq Clone()
		{
			return new GetFriendAssistListCsReq(this);
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x000D04B2 File Offset: 0x000CE6B2
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x000D04BA File Offset: 0x000CE6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistAvatarType OPCHJHGGKJP
		{
			get
			{
				return this.oPCHJHGGKJP_;
			}
			set
			{
				this.oPCHJHGGKJP_ = value;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x000D04C3 File Offset: 0x000CE6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KKKMMPBNECM
		{
			get
			{
				return this.kKKMMPBNECM_;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x000D04CB File Offset: 0x000CE6CB
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x000D04D3 File Offset: 0x000CE6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetUid
		{
			get
			{
				return this.targetUid_;
			}
			set
			{
				this.targetUid_ = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x000D04DC File Offset: 0x000CE6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GJECOHCGNMP
		{
			get
			{
				return this.gJECOHCGNMP_;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x000D04E4 File Offset: 0x000CE6E4
		// (set) Token: 0x06004CDE RID: 19678 RVA: 0x000D04EC File Offset: 0x000CE6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool COBDHLMALKI
		{
			get
			{
				return this.cOBDHLMALKI_;
			}
			set
			{
				this.cOBDHLMALKI_ = value;
			}
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x000D04F5 File Offset: 0x000CE6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendAssistListCsReq);
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x000D0504 File Offset: 0x000CE704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendAssistListCsReq other)
		{
			return other != null && (other == this || (this.OPCHJHGGKJP == other.OPCHJHGGKJP && this.kKKMMPBNECM_.Equals(other.kKKMMPBNECM_) && this.TargetUid == other.TargetUid && this.gJECOHCGNMP_.Equals(other.gJECOHCGNMP_) && this.COBDHLMALKI == other.COBDHLMALKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x000D0588 File Offset: 0x000CE788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OPCHJHGGKJP != AssistAvatarType.AssistAvatarUnknow)
			{
				num ^= this.OPCHJHGGKJP.GetHashCode();
			}
			num ^= this.kKKMMPBNECM_.GetHashCode();
			if (this.TargetUid != 0U)
			{
				num ^= this.TargetUid.GetHashCode();
			}
			num ^= this.gJECOHCGNMP_.GetHashCode();
			if (this.COBDHLMALKI)
			{
				num ^= this.COBDHLMALKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x000D061B File Offset: 0x000CE81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x000D0623 File Offset: 0x000CE823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x000D062C File Offset: 0x000CE82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OPCHJHGGKJP != AssistAvatarType.AssistAvatarUnknow)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.OPCHJHGGKJP);
			}
			if (this.TargetUid != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TargetUid);
			}
			this.kKKMMPBNECM_.WriteTo(ref output, GetFriendAssistListCsReq._repeated_kKKMMPBNECM_codec);
			if (this.COBDHLMALKI)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.COBDHLMALKI);
			}
			this.gJECOHCGNMP_.WriteTo(ref output, GetFriendAssistListCsReq._repeated_gJECOHCGNMP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x000D06C4 File Offset: 0x000CE8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OPCHJHGGKJP != AssistAvatarType.AssistAvatarUnknow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OPCHJHGGKJP);
			}
			num += this.kKKMMPBNECM_.CalculateSize(GetFriendAssistListCsReq._repeated_kKKMMPBNECM_codec);
			if (this.TargetUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetUid);
			}
			num += this.gJECOHCGNMP_.CalculateSize(GetFriendAssistListCsReq._repeated_gJECOHCGNMP_codec);
			if (this.COBDHLMALKI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x000D074C File Offset: 0x000CE94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendAssistListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OPCHJHGGKJP != AssistAvatarType.AssistAvatarUnknow)
			{
				this.OPCHJHGGKJP = other.OPCHJHGGKJP;
			}
			this.kKKMMPBNECM_.Add(other.kKKMMPBNECM_);
			if (other.TargetUid != 0U)
			{
				this.TargetUid = other.TargetUid;
			}
			this.gJECOHCGNMP_.Add(other.gJECOHCGNMP_);
			if (other.COBDHLMALKI)
			{
				this.COBDHLMALKI = other.COBDHLMALKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x000D07D2 File Offset: 0x000CE9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x000D07DC File Offset: 0x000CE9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.OPCHJHGGKJP = (AssistAvatarType)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.TargetUid = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_66;
					}
				}
				else if (num <= 88U)
				{
					if (num == 74U)
					{
						goto IL_66;
					}
					if (num == 88U)
					{
						this.COBDHLMALKI = input.ReadBool();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.gJECOHCGNMP_.AddEntriesFrom(ref input, GetFriendAssistListCsReq._repeated_gJECOHCGNMP_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_66:
				this.kKKMMPBNECM_.AddEntriesFrom(ref input, GetFriendAssistListCsReq._repeated_kKKMMPBNECM_codec);
			}
		}

		// Token: 0x04001E61 RID: 7777
		private static readonly MessageParser<GetFriendAssistListCsReq> _parser = new MessageParser<GetFriendAssistListCsReq>(() => new GetFriendAssistListCsReq());

		// Token: 0x04001E62 RID: 7778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E63 RID: 7779
		public const int OPCHJHGGKJPFieldNumber = 5;

		// Token: 0x04001E64 RID: 7780
		private AssistAvatarType oPCHJHGGKJP_;

		// Token: 0x04001E65 RID: 7781
		public const int KKKMMPBNECMFieldNumber = 9;

		// Token: 0x04001E66 RID: 7782
		private static readonly FieldCodec<uint> _repeated_kKKMMPBNECM_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04001E67 RID: 7783
		private readonly RepeatedField<uint> kKKMMPBNECM_ = new RepeatedField<uint>();

		// Token: 0x04001E68 RID: 7784
		public const int TargetUidFieldNumber = 6;

		// Token: 0x04001E69 RID: 7785
		private uint targetUid_;

		// Token: 0x04001E6A RID: 7786
		public const int GJECOHCGNMPFieldNumber = 13;

		// Token: 0x04001E6B RID: 7787
		private static readonly FieldCodec<uint> _repeated_gJECOHCGNMP_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04001E6C RID: 7788
		private readonly RepeatedField<uint> gJECOHCGNMP_ = new RepeatedField<uint>();

		// Token: 0x04001E6D RID: 7789
		public const int COBDHLMALKIFieldNumber = 11;

		// Token: 0x04001E6E RID: 7790
		private bool cOBDHLMALKI_;
	}
}
