using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F6B RID: 3947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueReviveInfo : IMessage<RogueReviveInfo>, IMessage, IEquatable<RogueReviveInfo>, IDeepCloneable<RogueReviveInfo>, IBufferMessage
	{
		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x001D8793 File Offset: 0x001D6993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueReviveInfo> Parser
		{
			get
			{
				return RogueReviveInfo._parser;
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600AFEB RID: 45035 RVA: 0x001D879A File Offset: 0x001D699A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueReviveInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600AFEC RID: 45036 RVA: 0x001D87AC File Offset: 0x001D69AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueReviveInfo.Descriptor;
			}
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x001D87B3 File Offset: 0x001D69B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReviveInfo()
		{
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x001D87C8 File Offset: 0x001D69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReviveInfo(RogueReviveInfo other) : this()
		{
			this.mEFOAOFHODG_ = other.mEFOAOFHODG_.Clone();
			this.pAHGOIDCMIM_ = other.pAHGOIDCMIM_;
			this.kJEPCEBBDKF_ = other.kJEPCEBBDKF_;
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x001D8831 File Offset: 0x001D6A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReviveInfo Clone()
		{
			return new RogueReviveInfo(this);
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600AFF0 RID: 45040 RVA: 0x001D8839 File Offset: 0x001D6A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MEFOAOFHODG
		{
			get
			{
				return this.mEFOAOFHODG_;
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600AFF1 RID: 45041 RVA: 0x001D8841 File Offset: 0x001D6A41
		// (set) Token: 0x0600AFF2 RID: 45042 RVA: 0x001D8849 File Offset: 0x001D6A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PAHGOIDCMIM
		{
			get
			{
				return this.pAHGOIDCMIM_;
			}
			set
			{
				this.pAHGOIDCMIM_ = value;
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x001D8852 File Offset: 0x001D6A52
		// (set) Token: 0x0600AFF4 RID: 45044 RVA: 0x001D885A File Offset: 0x001D6A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KJEPCEBBDKF
		{
			get
			{
				return this.kJEPCEBBDKF_;
			}
			set
			{
				this.kJEPCEBBDKF_ = value;
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x001D8863 File Offset: 0x001D6A63
		// (set) Token: 0x0600AFF6 RID: 45046 RVA: 0x001D886B File Offset: 0x001D6A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x001D8874 File Offset: 0x001D6A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueReviveInfo);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x001D8884 File Offset: 0x001D6A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueReviveInfo other)
		{
			return other != null && (other == this || (this.mEFOAOFHODG_.Equals(other.mEFOAOFHODG_) && this.PAHGOIDCMIM == other.PAHGOIDCMIM && this.KJEPCEBBDKF == other.KJEPCEBBDKF && object.Equals(this.RogueReviveCost, other.RogueReviveCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x001D88F8 File Offset: 0x001D6AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mEFOAOFHODG_.GetHashCode();
			if (this.PAHGOIDCMIM != 0U)
			{
				num ^= this.PAHGOIDCMIM.GetHashCode();
			}
			if (this.KJEPCEBBDKF != 0U)
			{
				num ^= this.KJEPCEBBDKF.GetHashCode();
			}
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x001D8974 File Offset: 0x001D6B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFFB RID: 45051 RVA: 0x001D897C File Offset: 0x001D6B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x001D8988 File Offset: 0x001D6B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this.KJEPCEBBDKF != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.KJEPCEBBDKF);
			}
			this.mEFOAOFHODG_.WriteTo(ref output, RogueReviveInfo._repeated_mEFOAOFHODG_codec);
			if (this.PAHGOIDCMIM != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PAHGOIDCMIM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x001D8A10 File Offset: 0x001D6C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mEFOAOFHODG_.CalculateSize(RogueReviveInfo._repeated_mEFOAOFHODG_codec);
			if (this.PAHGOIDCMIM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PAHGOIDCMIM);
			}
			if (this.KJEPCEBBDKF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KJEPCEBBDKF);
			}
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x001D8A94 File Offset: 0x001D6C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueReviveInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.mEFOAOFHODG_.Add(other.mEFOAOFHODG_);
			if (other.PAHGOIDCMIM != 0U)
			{
				this.PAHGOIDCMIM = other.PAHGOIDCMIM;
			}
			if (other.KJEPCEBBDKF != 0U)
			{
				this.KJEPCEBBDKF = other.KJEPCEBBDKF;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x001D8B21 File Offset: 0x001D6D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x001D8B2C File Offset: 0x001D6D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 18U)
					{
						if (this.rogueReviveCost_ == null)
						{
							this.RogueReviveCost = new ItemCostData();
						}
						input.ReadMessage(this.RogueReviveCost);
						continue;
					}
					if (num == 24U)
					{
						this.KJEPCEBBDKF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.mEFOAOFHODG_.AddEntriesFrom(ref input, RogueReviveInfo._repeated_mEFOAOFHODG_codec);
						continue;
					}
					if (num == 80U)
					{
						this.PAHGOIDCMIM = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004782 RID: 18306
		private static readonly MessageParser<RogueReviveInfo> _parser = new MessageParser<RogueReviveInfo>(() => new RogueReviveInfo());

		// Token: 0x04004783 RID: 18307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004784 RID: 18308
		public const int MEFOAOFHODGFieldNumber = 7;

		// Token: 0x04004785 RID: 18309
		private static readonly FieldCodec<uint> _repeated_mEFOAOFHODG_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04004786 RID: 18310
		private readonly RepeatedField<uint> mEFOAOFHODG_ = new RepeatedField<uint>();

		// Token: 0x04004787 RID: 18311
		public const int PAHGOIDCMIMFieldNumber = 10;

		// Token: 0x04004788 RID: 18312
		private uint pAHGOIDCMIM_;

		// Token: 0x04004789 RID: 18313
		public const int KJEPCEBBDKFFieldNumber = 3;

		// Token: 0x0400478A RID: 18314
		private uint kJEPCEBBDKF_;

		// Token: 0x0400478B RID: 18315
		public const int RogueReviveCostFieldNumber = 2;

		// Token: 0x0400478C RID: 18316
		private ItemCostData rogueReviveCost_;
	}
}
