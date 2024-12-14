using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200010B RID: 267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleTargetList : IMessage<BattleTargetList>, IMessage, IEquatable<BattleTargetList>, IDeepCloneable<BattleTargetList>, IBufferMessage
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00024441 File Offset: 0x00022641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleTargetList> Parser
		{
			get
			{
				return BattleTargetList._parser;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00024448 File Offset: 0x00022648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleTargetListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0002445A File Offset: 0x0002265A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleTargetList.Descriptor;
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00024461 File Offset: 0x00022661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTargetList()
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00024474 File Offset: 0x00022674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTargetList(BattleTargetList other) : this()
		{
			this.battleTargetList_ = other.battleTargetList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0002449E File Offset: 0x0002269E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTargetList Clone()
		{
			return new BattleTargetList(this);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000244A6 File Offset: 0x000226A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleTarget> BattleTargetList_
		{
			get
			{
				return this.battleTargetList_;
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000244AE File Offset: 0x000226AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleTargetList);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000244BC File Offset: 0x000226BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleTargetList other)
		{
			return other != null && (other == this || (this.battleTargetList_.Equals(other.battleTargetList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000244F0 File Offset: 0x000226F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.battleTargetList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00024524 File Offset: 0x00022724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002452C File Offset: 0x0002272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00024535 File Offset: 0x00022735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleTargetList_.WriteTo(ref output, BattleTargetList._repeated_battleTargetList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002455C File Offset: 0x0002275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.battleTargetList_.CalculateSize(BattleTargetList._repeated_battleTargetList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00024595 File Offset: 0x00022795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleTargetList other)
		{
			if (other == null)
			{
				return;
			}
			this.battleTargetList_.Add(other.battleTargetList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000245C3 File Offset: 0x000227C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000245CC File Offset: 0x000227CC
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
					this.battleTargetList_.AddEntriesFrom(ref input, BattleTargetList._repeated_battleTargetList_codec);
				}
			}
		}

		// Token: 0x04000542 RID: 1346
		private static readonly MessageParser<BattleTargetList> _parser = new MessageParser<BattleTargetList>(() => new BattleTargetList());

		// Token: 0x04000543 RID: 1347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000544 RID: 1348
		public const int BattleTargetList_FieldNumber = 1;

		// Token: 0x04000545 RID: 1349
		private static readonly FieldCodec<BattleTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage<BattleTarget>(10U, BattleTarget.Parser);

		// Token: 0x04000546 RID: 1350
		private readonly RepeatedField<BattleTarget> battleTargetList_ = new RepeatedField<BattleTarget>();
	}
}
