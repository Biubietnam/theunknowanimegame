using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E5 RID: 485
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueBuff : IMessage<ChessRogueBuff>, IMessage, IEquatable<ChessRogueBuff>, IDeepCloneable<ChessRogueBuff>, IBufferMessage
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x0003E6D5 File Offset: 0x0003C8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueBuff> Parser
		{
			get
			{
				return ChessRogueBuff._parser;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0003E6DC File Offset: 0x0003C8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x0003E6EE File Offset: 0x0003C8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueBuff.Descriptor;
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0003E6F5 File Offset: 0x0003C8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff()
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0003E708 File Offset: 0x0003C908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff(ChessRogueBuff other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0003E732 File Offset: 0x0003C932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff Clone()
		{
			return new ChessRogueBuff(this);
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x0003E73A File Offset: 0x0003C93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0003E742 File Offset: 0x0003C942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueBuff);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0003E750 File Offset: 0x0003C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueBuff other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0003E784 File Offset: 0x0003C984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0003E7B8 File Offset: 0x0003C9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0003E7C9 File Offset: 0x0003C9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, ChessRogueBuff._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(ChessRogueBuff._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0003E829 File Offset: 0x0003CA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueBuff other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0003E857 File Offset: 0x0003CA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0003E860 File Offset: 0x0003CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, ChessRogueBuff._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x0400092C RID: 2348
		private static readonly MessageParser<ChessRogueBuff> _parser = new MessageParser<ChessRogueBuff>(() => new ChessRogueBuff());

		// Token: 0x0400092D RID: 2349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400092E RID: 2350
		public const int BuffListFieldNumber = 10;

		// Token: 0x0400092F RID: 2351
		private static readonly FieldCodec<RogueCommonBuff> _repeated_buffList_codec = FieldCodec.ForMessage<RogueCommonBuff>(82U, RogueCommonBuff.Parser);

		// Token: 0x04000930 RID: 2352
		private readonly RepeatedField<RogueCommonBuff> buffList_ = new RepeatedField<RogueCommonBuff>();
	}
}
