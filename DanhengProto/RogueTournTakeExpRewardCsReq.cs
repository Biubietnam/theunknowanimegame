using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001021 RID: 4129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournTakeExpRewardCsReq : IMessage<RogueTournTakeExpRewardCsReq>, IMessage, IEquatable<RogueTournTakeExpRewardCsReq>, IDeepCloneable<RogueTournTakeExpRewardCsReq>, IBufferMessage
	{
		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600B79D RID: 47005 RVA: 0x001ECB15 File Offset: 0x001EAD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournTakeExpRewardCsReq> Parser
		{
			get
			{
				return RogueTournTakeExpRewardCsReq._parser;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x001ECB1C File Offset: 0x001EAD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournTakeExpRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x001ECB2E File Offset: 0x001EAD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournTakeExpRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x001ECB35 File Offset: 0x001EAD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardCsReq()
		{
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x001ECB48 File Offset: 0x001EAD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardCsReq(RogueTournTakeExpRewardCsReq other) : this()
		{
			this.subTournId_ = other.subTournId_;
			this.jGMGCJNFDIG_ = other.jGMGCJNFDIG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x001ECB7E File Offset: 0x001EAD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardCsReq Clone()
		{
			return new RogueTournTakeExpRewardCsReq(this);
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x001ECB86 File Offset: 0x001EAD86
		// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x001ECB8E File Offset: 0x001EAD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubTournId
		{
			get
			{
				return this.subTournId_;
			}
			set
			{
				this.subTournId_ = value;
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x001ECB97 File Offset: 0x001EAD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JGMGCJNFDIG
		{
			get
			{
				return this.jGMGCJNFDIG_;
			}
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x001ECB9F File Offset: 0x001EAD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournTakeExpRewardCsReq);
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x001ECBB0 File Offset: 0x001EADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournTakeExpRewardCsReq other)
		{
			return other != null && (other == this || (this.SubTournId == other.SubTournId && this.jGMGCJNFDIG_.Equals(other.jGMGCJNFDIG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x001ECC00 File Offset: 0x001EAE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubTournId != 0U)
			{
				num ^= this.SubTournId.GetHashCode();
			}
			num ^= this.jGMGCJNFDIG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x001ECC4D File Offset: 0x001EAE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x001ECC55 File Offset: 0x001EAE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x001ECC60 File Offset: 0x001EAE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jGMGCJNFDIG_.WriteTo(ref output, RogueTournTakeExpRewardCsReq._repeated_jGMGCJNFDIG_codec);
			if (this.SubTournId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SubTournId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x001ECCB0 File Offset: 0x001EAEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubTournId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubTournId);
			}
			num += this.jGMGCJNFDIG_.CalculateSize(RogueTournTakeExpRewardCsReq._repeated_jGMGCJNFDIG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x001ECD04 File Offset: 0x001EAF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournTakeExpRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubTournId != 0U)
			{
				this.SubTournId = other.SubTournId;
			}
			this.jGMGCJNFDIG_.Add(other.jGMGCJNFDIG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x001ECD51 File Offset: 0x001EAF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001ECD5C File Offset: 0x001EAF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubTournId = input.ReadUInt32();
					}
				}
				else
				{
					this.jGMGCJNFDIG_.AddEntriesFrom(ref input, RogueTournTakeExpRewardCsReq._repeated_jGMGCJNFDIG_codec);
				}
			}
		}

		// Token: 0x04004A63 RID: 19043
		private static readonly MessageParser<RogueTournTakeExpRewardCsReq> _parser = new MessageParser<RogueTournTakeExpRewardCsReq>(() => new RogueTournTakeExpRewardCsReq());

		// Token: 0x04004A64 RID: 19044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A65 RID: 19045
		public const int SubTournIdFieldNumber = 13;

		// Token: 0x04004A66 RID: 19046
		private uint subTournId_;

		// Token: 0x04004A67 RID: 19047
		public const int JGMGCJNFDIGFieldNumber = 8;

		// Token: 0x04004A68 RID: 19048
		private static readonly FieldCodec<uint> _repeated_jGMGCJNFDIG_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04004A69 RID: 19049
		private readonly RepeatedField<uint> jGMGCJNFDIG_ = new RepeatedField<uint>();
	}
}
