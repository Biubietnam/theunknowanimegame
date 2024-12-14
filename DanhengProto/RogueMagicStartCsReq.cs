using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F1F RID: 3871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicStartCsReq : IMessage<RogueMagicStartCsReq>, IMessage, IEquatable<RogueMagicStartCsReq>, IDeepCloneable<RogueMagicStartCsReq>, IBufferMessage
	{
		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600ACB7 RID: 44215 RVA: 0x001D0C07 File Offset: 0x001CEE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicStartCsReq> Parser
		{
			get
			{
				return RogueMagicStartCsReq._parser;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x001D0C0E File Offset: 0x001CEE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicStartCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600ACB9 RID: 44217 RVA: 0x001D0C20 File Offset: 0x001CEE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicStartCsReq.Descriptor;
			}
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x001D0C27 File Offset: 0x001CEE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartCsReq()
		{
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x001D0C48 File Offset: 0x001CEE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartCsReq(RogueMagicStartCsReq other) : this()
		{
			this.selectStyleType_ = other.selectStyleType_;
			this.startDifficultyIdList_ = other.startDifficultyIdList_.Clone();
			this.areaId_ = other.areaId_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x001D0CA6 File Offset: 0x001CEEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartCsReq Clone()
		{
			return new RogueMagicStartCsReq(this);
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600ACBD RID: 44221 RVA: 0x001D0CAE File Offset: 0x001CEEAE
		// (set) Token: 0x0600ACBE RID: 44222 RVA: 0x001D0CB6 File Offset: 0x001CEEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectStyleType
		{
			get
			{
				return this.selectStyleType_;
			}
			set
			{
				this.selectStyleType_ = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600ACBF RID: 44223 RVA: 0x001D0CBF File Offset: 0x001CEEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StartDifficultyIdList
		{
			get
			{
				return this.startDifficultyIdList_;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600ACC0 RID: 44224 RVA: 0x001D0CC7 File Offset: 0x001CEEC7
		// (set) Token: 0x0600ACC1 RID: 44225 RVA: 0x001D0CCF File Offset: 0x001CEECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x001D0CD8 File Offset: 0x001CEED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x001D0CE0 File Offset: 0x001CEEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicStartCsReq);
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x001D0CF0 File Offset: 0x001CEEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicStartCsReq other)
		{
			return other != null && (other == this || (this.SelectStyleType == other.SelectStyleType && this.startDifficultyIdList_.Equals(other.startDifficultyIdList_) && this.AreaId == other.AreaId && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x001D0D64 File Offset: 0x001CEF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectStyleType != 0U)
			{
				num ^= this.SelectStyleType.GetHashCode();
			}
			num ^= this.startDifficultyIdList_.GetHashCode();
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x001D0DD8 File Offset: 0x001CEFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x001D0DE0 File Offset: 0x001CEFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x001D0DEC File Offset: 0x001CEFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.startDifficultyIdList_.WriteTo(ref output, RogueMagicStartCsReq._repeated_startDifficultyIdList_codec);
			if (this.SelectStyleType != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.SelectStyleType);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AreaId);
			}
			this.baseAvatarIdList_.WriteTo(ref output, RogueMagicStartCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x001D0E68 File Offset: 0x001CF068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectStyleType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectStyleType);
			}
			num += this.startDifficultyIdList_.CalculateSize(RogueMagicStartCsReq._repeated_startDifficultyIdList_codec);
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			num += this.baseAvatarIdList_.CalculateSize(RogueMagicStartCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x001D0EE4 File Offset: 0x001CF0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicStartCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectStyleType != 0U)
			{
				this.SelectStyleType = other.SelectStyleType;
			}
			this.startDifficultyIdList_.Add(other.startDifficultyIdList_);
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x001D0F56 File Offset: 0x001CF156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x001D0F60 File Offset: 0x001CF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U || num == 34U)
					{
						this.startDifficultyIdList_.AddEntriesFrom(ref input, RogueMagicStartCsReq._repeated_startDifficultyIdList_codec);
						continue;
					}
					if (num == 56U)
					{
						this.SelectStyleType = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 72U || num == 74U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueMagicStartCsReq._repeated_baseAvatarIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004661 RID: 18017
		private static readonly MessageParser<RogueMagicStartCsReq> _parser = new MessageParser<RogueMagicStartCsReq>(() => new RogueMagicStartCsReq());

		// Token: 0x04004662 RID: 18018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004663 RID: 18019
		public const int SelectStyleTypeFieldNumber = 7;

		// Token: 0x04004664 RID: 18020
		private uint selectStyleType_;

		// Token: 0x04004665 RID: 18021
		public const int StartDifficultyIdListFieldNumber = 4;

		// Token: 0x04004666 RID: 18022
		private static readonly FieldCodec<uint> _repeated_startDifficultyIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04004667 RID: 18023
		private readonly RepeatedField<uint> startDifficultyIdList_ = new RepeatedField<uint>();

		// Token: 0x04004668 RID: 18024
		public const int AreaIdFieldNumber = 8;

		// Token: 0x04004669 RID: 18025
		private uint areaId_;

		// Token: 0x0400466A RID: 18026
		public const int BaseAvatarIdListFieldNumber = 9;

		// Token: 0x0400466B RID: 18027
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400466C RID: 18028
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
