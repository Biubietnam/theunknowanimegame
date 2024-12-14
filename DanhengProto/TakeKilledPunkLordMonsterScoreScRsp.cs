using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012DD RID: 4829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeKilledPunkLordMonsterScoreScRsp : IMessage<TakeKilledPunkLordMonsterScoreScRsp>, IMessage, IEquatable<TakeKilledPunkLordMonsterScoreScRsp>, IDeepCloneable<TakeKilledPunkLordMonsterScoreScRsp>, IBufferMessage
	{
		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600D772 RID: 55154 RVA: 0x0023E94F File Offset: 0x0023CB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeKilledPunkLordMonsterScoreScRsp> Parser
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreScRsp._parser;
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600D773 RID: 55155 RVA: 0x0023E956 File Offset: 0x0023CB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600D774 RID: 55156 RVA: 0x0023E968 File Offset: 0x0023CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeKilledPunkLordMonsterScoreScRsp.Descriptor;
			}
		}

		// Token: 0x0600D775 RID: 55157 RVA: 0x0023E96F File Offset: 0x0023CB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreScRsp()
		{
		}

		// Token: 0x0600D776 RID: 55158 RVA: 0x0023E984 File Offset: 0x0023CB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreScRsp(TakeKilledPunkLordMonsterScoreScRsp other) : this()
		{
			this.oGKAKMAMMHJ_ = other.oGKAKMAMMHJ_.Clone();
			this.scoreId_ = other.scoreId_;
			this.retcode_ = other.retcode_;
			this.mHEIIMDJKLC_ = other.mHEIIMDJKLC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x0023E9DD File Offset: 0x0023CBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeKilledPunkLordMonsterScoreScRsp Clone()
		{
			return new TakeKilledPunkLordMonsterScoreScRsp(this);
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600D778 RID: 55160 RVA: 0x0023E9E5 File Offset: 0x0023CBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordMonsterKey> OGKAKMAMMHJ
		{
			get
			{
				return this.oGKAKMAMMHJ_;
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600D779 RID: 55161 RVA: 0x0023E9ED File Offset: 0x0023CBED
		// (set) Token: 0x0600D77A RID: 55162 RVA: 0x0023E9F5 File Offset: 0x0023CBF5
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

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600D77B RID: 55163 RVA: 0x0023E9FE File Offset: 0x0023CBFE
		// (set) Token: 0x0600D77C RID: 55164 RVA: 0x0023EA06 File Offset: 0x0023CC06
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

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600D77D RID: 55165 RVA: 0x0023EA0F File Offset: 0x0023CC0F
		// (set) Token: 0x0600D77E RID: 55166 RVA: 0x0023EA17 File Offset: 0x0023CC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MHEIIMDJKLC
		{
			get
			{
				return this.mHEIIMDJKLC_;
			}
			set
			{
				this.mHEIIMDJKLC_ = value;
			}
		}

		// Token: 0x0600D77F RID: 55167 RVA: 0x0023EA20 File Offset: 0x0023CC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeKilledPunkLordMonsterScoreScRsp);
		}

		// Token: 0x0600D780 RID: 55168 RVA: 0x0023EA30 File Offset: 0x0023CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeKilledPunkLordMonsterScoreScRsp other)
		{
			return other != null && (other == this || (this.oGKAKMAMMHJ_.Equals(other.oGKAKMAMMHJ_) && this.ScoreId == other.ScoreId && this.Retcode == other.Retcode && this.MHEIIMDJKLC == other.MHEIIMDJKLC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x0023EAA0 File Offset: 0x0023CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.oGKAKMAMMHJ_.GetHashCode();
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.MHEIIMDJKLC)
			{
				num ^= this.MHEIIMDJKLC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D782 RID: 55170 RVA: 0x0023EB1F File Offset: 0x0023CD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x0023EB27 File Offset: 0x0023CD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D784 RID: 55172 RVA: 0x0023EB30 File Offset: 0x0023CD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MHEIIMDJKLC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MHEIIMDJKLC);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ScoreId);
			}
			this.oGKAKMAMMHJ_.WriteTo(ref output, TakeKilledPunkLordMonsterScoreScRsp._repeated_oGKAKMAMMHJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x0023EBB8 File Offset: 0x0023CDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.oGKAKMAMMHJ_.CalculateSize(TakeKilledPunkLordMonsterScoreScRsp._repeated_oGKAKMAMMHJ_codec);
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.MHEIIMDJKLC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x0023EC30 File Offset: 0x0023CE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeKilledPunkLordMonsterScoreScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.oGKAKMAMMHJ_.Add(other.oGKAKMAMMHJ_);
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.MHEIIMDJKLC)
			{
				this.MHEIIMDJKLC = other.MHEIIMDJKLC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D787 RID: 55175 RVA: 0x0023ECA5 File Offset: 0x0023CEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x0023ECB0 File Offset: 0x0023CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.MHEIIMDJKLC = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
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
					if (num == 90U)
					{
						this.oGKAKMAMMHJ_.AddEntriesFrom(ref input, TakeKilledPunkLordMonsterScoreScRsp._repeated_oGKAKMAMMHJ_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055FA RID: 22010
		private static readonly MessageParser<TakeKilledPunkLordMonsterScoreScRsp> _parser = new MessageParser<TakeKilledPunkLordMonsterScoreScRsp>(() => new TakeKilledPunkLordMonsterScoreScRsp());

		// Token: 0x040055FB RID: 22011
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055FC RID: 22012
		public const int OGKAKMAMMHJFieldNumber = 11;

		// Token: 0x040055FD RID: 22013
		private static readonly FieldCodec<PunkLordMonsterKey> _repeated_oGKAKMAMMHJ_codec = FieldCodec.ForMessage<PunkLordMonsterKey>(90U, PunkLordMonsterKey.Parser);

		// Token: 0x040055FE RID: 22014
		private readonly RepeatedField<PunkLordMonsterKey> oGKAKMAMMHJ_ = new RepeatedField<PunkLordMonsterKey>();

		// Token: 0x040055FF RID: 22015
		public const int ScoreIdFieldNumber = 10;

		// Token: 0x04005600 RID: 22016
		private uint scoreId_;

		// Token: 0x04005601 RID: 22017
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04005602 RID: 22018
		private uint retcode_;

		// Token: 0x04005603 RID: 22019
		public const int MHEIIMDJKLCFieldNumber = 5;

		// Token: 0x04005604 RID: 22020
		private bool mHEIIMDJKLC_;
	}
}
