using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200113B RID: 4411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SettleTrackPhotoStageCsReq : IMessage<SettleTrackPhotoStageCsReq>, IMessage, IEquatable<SettleTrackPhotoStageCsReq>, IDeepCloneable<SettleTrackPhotoStageCsReq>, IBufferMessage
	{
		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600C4B9 RID: 50361 RVA: 0x00210047 File Offset: 0x0020E247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SettleTrackPhotoStageCsReq> Parser
		{
			get
			{
				return SettleTrackPhotoStageCsReq._parser;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600C4BA RID: 50362 RVA: 0x0021004E File Offset: 0x0020E24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettleTrackPhotoStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600C4BB RID: 50363 RVA: 0x00210060 File Offset: 0x0020E260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettleTrackPhotoStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x00210067 File Offset: 0x0020E267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageCsReq()
		{
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x0021007C File Offset: 0x0020E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageCsReq(SettleTrackPhotoStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this.pMEHDGILNEF_ = other.pMEHDGILNEF_.Clone();
			this.costTime_ = other.costTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x002100C9 File Offset: 0x0020E2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleTrackPhotoStageCsReq Clone()
		{
			return new SettleTrackPhotoStageCsReq(this);
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600C4BF RID: 50367 RVA: 0x002100D1 File Offset: 0x0020E2D1
		// (set) Token: 0x0600C4C0 RID: 50368 RVA: 0x002100D9 File Offset: 0x0020E2D9
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

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600C4C1 RID: 50369 RVA: 0x002100E2 File Offset: 0x0020E2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HOELBNFBGHB> PMEHDGILNEF
		{
			get
			{
				return this.pMEHDGILNEF_;
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x002100EA File Offset: 0x0020E2EA
		// (set) Token: 0x0600C4C3 RID: 50371 RVA: 0x002100F2 File Offset: 0x0020E2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x002100FB File Offset: 0x0020E2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettleTrackPhotoStageCsReq);
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x0021010C File Offset: 0x0020E30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettleTrackPhotoStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.pMEHDGILNEF_.Equals(other.pMEHDGILNEF_) && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x0021016C File Offset: 0x0020E36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			num ^= this.pMEHDGILNEF_.GetHashCode();
			if (this.CostTime != 0U)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x002101D2 File Offset: 0x0020E3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x002101DA File Offset: 0x0020E3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x002101E4 File Offset: 0x0020E3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostTime != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CostTime);
			}
			this.pMEHDGILNEF_.WriteTo(ref output, SettleTrackPhotoStageCsReq._repeated_pMEHDGILNEF_codec);
			if (this.StageId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x00210250 File Offset: 0x0020E450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			num += this.pMEHDGILNEF_.CalculateSize(SettleTrackPhotoStageCsReq._repeated_pMEHDGILNEF_codec);
			if (this.CostTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x002102BC File Offset: 0x0020E4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettleTrackPhotoStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this.pMEHDGILNEF_.Add(other.pMEHDGILNEF_);
			if (other.CostTime != 0U)
			{
				this.CostTime = other.CostTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x0021031D File Offset: 0x0020E51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x00210328 File Offset: 0x0020E528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 34U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StageId = input.ReadUInt32();
						}
					}
					else
					{
						this.pMEHDGILNEF_.AddEntriesFrom(ref input, SettleTrackPhotoStageCsReq._repeated_pMEHDGILNEF_codec);
					}
				}
				else
				{
					this.CostTime = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004F78 RID: 20344
		private static readonly MessageParser<SettleTrackPhotoStageCsReq> _parser = new MessageParser<SettleTrackPhotoStageCsReq>(() => new SettleTrackPhotoStageCsReq());

		// Token: 0x04004F79 RID: 20345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F7A RID: 20346
		public const int StageIdFieldNumber = 9;

		// Token: 0x04004F7B RID: 20347
		private uint stageId_;

		// Token: 0x04004F7C RID: 20348
		public const int PMEHDGILNEFFieldNumber = 4;

		// Token: 0x04004F7D RID: 20349
		private static readonly FieldCodec<HOELBNFBGHB> _repeated_pMEHDGILNEF_codec = FieldCodec.ForMessage<HOELBNFBGHB>(34U, HOELBNFBGHB.Parser);

		// Token: 0x04004F7E RID: 20350
		private readonly RepeatedField<HOELBNFBGHB> pMEHDGILNEF_ = new RepeatedField<HOELBNFBGHB>();

		// Token: 0x04004F7F RID: 20351
		public const int CostTimeFieldNumber = 1;

		// Token: 0x04004F80 RID: 20352
		private uint costTime_;
	}
}
