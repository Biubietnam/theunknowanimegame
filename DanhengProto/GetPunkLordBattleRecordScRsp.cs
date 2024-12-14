using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200077B RID: 1915
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordBattleRecordScRsp : IMessage<GetPunkLordBattleRecordScRsp>, IMessage, IEquatable<GetPunkLordBattleRecordScRsp>, IDeepCloneable<GetPunkLordBattleRecordScRsp>, IBufferMessage
	{
		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x000E5BD3 File Offset: 0x000E3DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordBattleRecordScRsp> Parser
		{
			get
			{
				return GetPunkLordBattleRecordScRsp._parser;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600558C RID: 21900 RVA: 0x000E5BDA File Offset: 0x000E3DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordBattleRecordScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x000E5BEC File Offset: 0x000E3DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordBattleRecordScRsp.Descriptor;
			}
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x000E5BF3 File Offset: 0x000E3DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordScRsp()
		{
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x000E5C14 File Offset: 0x000E3E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordScRsp(GetPunkLordBattleRecordScRsp other) : this()
		{
			this.battleRecordList_ = other.battleRecordList_.Clone();
			this.retcode_ = other.retcode_;
			this.lEHPJLFNONE_ = ((other.lEHPJLFNONE_ != null) ? other.lEHPJLFNONE_.Clone() : null);
			this.iAJEKEMIJFA_ = other.iAJEKEMIJFA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x000E5C82 File Offset: 0x000E3E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordBattleRecordScRsp Clone()
		{
			return new GetPunkLordBattleRecordScRsp(this);
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x000E5C8A File Offset: 0x000E3E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordBattleRecord> BattleRecordList
		{
			get
			{
				return this.battleRecordList_;
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06005592 RID: 21906 RVA: 0x000E5C92 File Offset: 0x000E3E92
		// (set) Token: 0x06005593 RID: 21907 RVA: 0x000E5C9A File Offset: 0x000E3E9A
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

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x000E5CA3 File Offset: 0x000E3EA3
		// (set) Token: 0x06005595 RID: 21909 RVA: 0x000E5CAB File Offset: 0x000E3EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKey LEHPJLFNONE
		{
			get
			{
				return this.lEHPJLFNONE_;
			}
			set
			{
				this.lEHPJLFNONE_ = value;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06005596 RID: 21910 RVA: 0x000E5CB4 File Offset: 0x000E3EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordBattleReplay> IAJEKEMIJFA
		{
			get
			{
				return this.iAJEKEMIJFA_;
			}
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x000E5CBC File Offset: 0x000E3EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordBattleRecordScRsp);
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x000E5CCC File Offset: 0x000E3ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordBattleRecordScRsp other)
		{
			return other != null && (other == this || (this.battleRecordList_.Equals(other.battleRecordList_) && this.Retcode == other.Retcode && object.Equals(this.LEHPJLFNONE, other.LEHPJLFNONE) && this.iAJEKEMIJFA_.Equals(other.iAJEKEMIJFA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x000E5D44 File Offset: 0x000E3F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.battleRecordList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lEHPJLFNONE_ != null)
			{
				num ^= this.LEHPJLFNONE.GetHashCode();
			}
			num ^= this.iAJEKEMIJFA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x000E5DB5 File Offset: 0x000E3FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x000E5DBD File Offset: 0x000E3FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x000E5DC8 File Offset: 0x000E3FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleRecordList_.WriteTo(ref output, GetPunkLordBattleRecordScRsp._repeated_battleRecordList_codec);
			if (this.lEHPJLFNONE_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LEHPJLFNONE);
			}
			this.iAJEKEMIJFA_.WriteTo(ref output, GetPunkLordBattleRecordScRsp._repeated_iAJEKEMIJFA_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x000E5E44 File Offset: 0x000E4044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.battleRecordList_.CalculateSize(GetPunkLordBattleRecordScRsp._repeated_battleRecordList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lEHPJLFNONE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LEHPJLFNONE);
			}
			num += this.iAJEKEMIJFA_.CalculateSize(GetPunkLordBattleRecordScRsp._repeated_iAJEKEMIJFA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x000E5EC0 File Offset: 0x000E40C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordBattleRecordScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.battleRecordList_.Add(other.battleRecordList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.lEHPJLFNONE_ != null)
			{
				if (this.lEHPJLFNONE_ == null)
				{
					this.LEHPJLFNONE = new PunkLordMonsterKey();
				}
				this.LEHPJLFNONE.MergeFrom(other.LEHPJLFNONE);
			}
			this.iAJEKEMIJFA_.Add(other.iAJEKEMIJFA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x000E5F4A File Offset: 0x000E414A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x000E5F54 File Offset: 0x000E4154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.battleRecordList_.AddEntriesFrom(ref input, GetPunkLordBattleRecordScRsp._repeated_battleRecordList_codec);
						continue;
					}
					if (num == 18U)
					{
						if (this.lEHPJLFNONE_ == null)
						{
							this.LEHPJLFNONE = new PunkLordMonsterKey();
						}
						input.ReadMessage(this.LEHPJLFNONE);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.iAJEKEMIJFA_.AddEntriesFrom(ref input, GetPunkLordBattleRecordScRsp._repeated_iAJEKEMIJFA_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002185 RID: 8581
		private static readonly MessageParser<GetPunkLordBattleRecordScRsp> _parser = new MessageParser<GetPunkLordBattleRecordScRsp>(() => new GetPunkLordBattleRecordScRsp());

		// Token: 0x04002186 RID: 8582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002187 RID: 8583
		public const int BattleRecordListFieldNumber = 1;

		// Token: 0x04002188 RID: 8584
		private static readonly FieldCodec<PunkLordBattleRecord> _repeated_battleRecordList_codec = FieldCodec.ForMessage<PunkLordBattleRecord>(10U, PunkLordBattleRecord.Parser);

		// Token: 0x04002189 RID: 8585
		private readonly RepeatedField<PunkLordBattleRecord> battleRecordList_ = new RepeatedField<PunkLordBattleRecord>();

		// Token: 0x0400218A RID: 8586
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400218B RID: 8587
		private uint retcode_;

		// Token: 0x0400218C RID: 8588
		public const int LEHPJLFNONEFieldNumber = 2;

		// Token: 0x0400218D RID: 8589
		private PunkLordMonsterKey lEHPJLFNONE_;

		// Token: 0x0400218E RID: 8590
		public const int IAJEKEMIJFAFieldNumber = 11;

		// Token: 0x0400218F RID: 8591
		private static readonly FieldCodec<PunkLordBattleReplay> _repeated_iAJEKEMIJFA_codec = FieldCodec.ForMessage<PunkLordBattleReplay>(90U, PunkLordBattleReplay.Parser);

		// Token: 0x04002190 RID: 8592
		private readonly RepeatedField<PunkLordBattleReplay> iAJEKEMIJFA_ = new RepeatedField<PunkLordBattleReplay>();
	}
}
