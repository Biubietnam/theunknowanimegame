using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200113D RID: 4413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SettleTrackPhotoStageScRsp : IMessage<SettleTrackPhotoStageScRsp>, IMessage, IEquatable<SettleTrackPhotoStageScRsp>, IDeepCloneable<SettleTrackPhotoStageScRsp>, IBufferMessage
	{
		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600C4D1 RID: 50385 RVA: 0x0021046F File Offset: 0x0020E66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SettleTrackPhotoStageScRsp> Parser
		{
			get
			{
				return SettleTrackPhotoStageScRsp._parser;
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600C4D2 RID: 50386 RVA: 0x00210476 File Offset: 0x0020E676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettleTrackPhotoStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600C4D3 RID: 50387 RVA: 0x00210488 File Offset: 0x0020E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettleTrackPhotoStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x0021048F File Offset: 0x0020E68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageScRsp()
		{
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x002104A4 File Offset: 0x0020E6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageScRsp(SettleTrackPhotoStageScRsp other) : this()
		{
			this.pMEHDGILNEF_ = other.pMEHDGILNEF_.Clone();
			this.scoreId_ = other.scoreId_;
			this.stageId_ = other.stageId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x002104FD File Offset: 0x0020E6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageScRsp Clone()
		{
			return new SettleTrackPhotoStageScRsp(this);
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x00210505 File Offset: 0x0020E705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HOELBNFBGHB> PMEHDGILNEF
		{
			get
			{
				return this.pMEHDGILNEF_;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600C4D8 RID: 50392 RVA: 0x0021050D File Offset: 0x0020E70D
		// (set) Token: 0x0600C4D9 RID: 50393 RVA: 0x00210515 File Offset: 0x0020E715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600C4DA RID: 50394 RVA: 0x0021051E File Offset: 0x0020E71E
		// (set) Token: 0x0600C4DB RID: 50395 RVA: 0x00210526 File Offset: 0x0020E726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600C4DC RID: 50396 RVA: 0x0021052F File Offset: 0x0020E72F
		// (set) Token: 0x0600C4DD RID: 50397 RVA: 0x00210537 File Offset: 0x0020E737
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

		// Token: 0x0600C4DE RID: 50398 RVA: 0x00210540 File Offset: 0x0020E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettleTrackPhotoStageScRsp);
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x00210550 File Offset: 0x0020E750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettleTrackPhotoStageScRsp other)
		{
			return other != null && (other == this || (this.pMEHDGILNEF_.Equals(other.pMEHDGILNEF_) && this.ScoreId == other.ScoreId && this.StageId == other.StageId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x002105C0 File Offset: 0x0020E7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pMEHDGILNEF_.GetHashCode();
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x0021063F File Offset: 0x0020E83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x00210647 File Offset: 0x0020E847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00210650 File Offset: 0x0020E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.pMEHDGILNEF_.WriteTo(ref output, SettleTrackPhotoStageScRsp._repeated_pMEHDGILNEF_codec);
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x002106D8 File Offset: 0x0020E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pMEHDGILNEF_.CalculateSize(SettleTrackPhotoStageScRsp._repeated_pMEHDGILNEF_codec);
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x0021075C File Offset: 0x0020E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettleTrackPhotoStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pMEHDGILNEF_.Add(other.pMEHDGILNEF_);
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x002107D1 File Offset: 0x0020E9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x002107DC File Offset: 0x0020E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.pMEHDGILNEF_.AddEntriesFrom(ref input, SettleTrackPhotoStageScRsp._repeated_pMEHDGILNEF_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F82 RID: 20354
		private static readonly MessageParser<SettleTrackPhotoStageScRsp> _parser = new MessageParser<SettleTrackPhotoStageScRsp>(() => new SettleTrackPhotoStageScRsp());

		// Token: 0x04004F83 RID: 20355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F84 RID: 20356
		public const int PMEHDGILNEFFieldNumber = 6;

		// Token: 0x04004F85 RID: 20357
		private static readonly FieldCodec<HOELBNFBGHB> _repeated_pMEHDGILNEF_codec = FieldCodec.ForMessage<HOELBNFBGHB>(50U, HOELBNFBGHB.Parser);

		// Token: 0x04004F86 RID: 20358
		private readonly RepeatedField<HOELBNFBGHB> pMEHDGILNEF_ = new RepeatedField<HOELBNFBGHB>();

		// Token: 0x04004F87 RID: 20359
		public const int ScoreIdFieldNumber = 10;

		// Token: 0x04004F88 RID: 20360
		private uint scoreId_;

		// Token: 0x04004F89 RID: 20361
		public const int StageIdFieldNumber = 12;

		// Token: 0x04004F8A RID: 20362
		private uint stageId_;

		// Token: 0x04004F8B RID: 20363
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004F8C RID: 20364
		private uint retcode_;
	}
}
