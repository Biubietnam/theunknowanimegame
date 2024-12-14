using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1F RID: 3359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordBattleRecordList : IMessage<PunkLordBattleRecordList>, IMessage, IEquatable<PunkLordBattleRecordList>, IDeepCloneable<PunkLordBattleRecordList>, IBufferMessage
	{
		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06009606 RID: 38406 RVA: 0x0018F0CD File Offset: 0x0018D2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordBattleRecordList> Parser
		{
			get
			{
				return PunkLordBattleRecordList._parser;
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06009607 RID: 38407 RVA: 0x0018F0D4 File Offset: 0x0018D2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleRecordListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x0018F0E6 File Offset: 0x0018D2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordBattleRecordList.Descriptor;
			}
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x0018F0ED File Offset: 0x0018D2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecordList()
		{
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x0018F100 File Offset: 0x0018D300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecordList(PunkLordBattleRecordList other) : this()
		{
			this.battleRecordList_ = other.battleRecordList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0018F12A File Offset: 0x0018D32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecordList Clone()
		{
			return new PunkLordBattleRecordList(this);
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600960C RID: 38412 RVA: 0x0018F132 File Offset: 0x0018D332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordBattleRecord> BattleRecordList
		{
			get
			{
				return this.battleRecordList_;
			}
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x0018F13A File Offset: 0x0018D33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordBattleRecordList);
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x0018F148 File Offset: 0x0018D348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordBattleRecordList other)
		{
			return other != null && (other == this || (this.battleRecordList_.Equals(other.battleRecordList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x0018F17C File Offset: 0x0018D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.battleRecordList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x0018F1B0 File Offset: 0x0018D3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x0018F1B8 File Offset: 0x0018D3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x0018F1C1 File Offset: 0x0018D3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleRecordList_.WriteTo(ref output, PunkLordBattleRecordList._repeated_battleRecordList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009613 RID: 38419 RVA: 0x0018F1E8 File Offset: 0x0018D3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.battleRecordList_.CalculateSize(PunkLordBattleRecordList._repeated_battleRecordList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x0018F221 File Offset: 0x0018D421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordBattleRecordList other)
		{
			if (other == null)
			{
				return;
			}
			this.battleRecordList_.Add(other.battleRecordList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x0018F24F File Offset: 0x0018D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x0018F258 File Offset: 0x0018D458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.battleRecordList_.AddEntriesFrom(ref input, PunkLordBattleRecordList._repeated_battleRecordList_codec);
				}
			}
		}

		// Token: 0x04003A31 RID: 14897
		private static readonly MessageParser<PunkLordBattleRecordList> _parser = new MessageParser<PunkLordBattleRecordList>(() => new PunkLordBattleRecordList());

		// Token: 0x04003A32 RID: 14898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A33 RID: 14899
		public const int BattleRecordListFieldNumber = 1;

		// Token: 0x04003A34 RID: 14900
		private static readonly FieldCodec<PunkLordBattleRecord> _repeated_battleRecordList_codec = FieldCodec.ForMessage<PunkLordBattleRecord>(10U, PunkLordBattleRecord.Parser);

		// Token: 0x04003A35 RID: 14901
		private readonly RepeatedField<PunkLordBattleRecord> battleRecordList_ = new RepeatedField<PunkLordBattleRecord>();
	}
}
