using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002BB RID: 699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateUnlockLevelScNotify : IMessage<ChessRogueUpdateUnlockLevelScNotify>, IMessage, IEquatable<ChessRogueUpdateUnlockLevelScNotify>, IDeepCloneable<ChessRogueUpdateUnlockLevelScNotify>, IBufferMessage
	{
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x00058D95 File Offset: 0x00056F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateUnlockLevelScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateUnlockLevelScNotify._parser;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00058D9C File Offset: 0x00056F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateUnlockLevelScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00058DAE File Offset: 0x00056FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateUnlockLevelScNotify.Descriptor;
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00058DB5 File Offset: 0x00056FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateUnlockLevelScNotify()
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00058DC8 File Offset: 0x00056FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateUnlockLevelScNotify(ChessRogueUpdateUnlockLevelScNotify other) : this()
		{
			this.areaIdList_ = other.areaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00058DF2 File Offset: 0x00056FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateUnlockLevelScNotify Clone()
		{
			return new ChessRogueUpdateUnlockLevelScNotify(this);
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00058DFA File Offset: 0x00056FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00058E02 File Offset: 0x00057002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateUnlockLevelScNotify);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00058E10 File Offset: 0x00057010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateUnlockLevelScNotify other)
		{
			return other != null && (other == this || (this.areaIdList_.Equals(other.areaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00058E44 File Offset: 0x00057044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.areaIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00058E78 File Offset: 0x00057078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00058E80 File Offset: 0x00057080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00058E89 File Offset: 0x00057089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaIdList_.WriteTo(ref output, ChessRogueUpdateUnlockLevelScNotify._repeated_areaIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00058EB0 File Offset: 0x000570B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.areaIdList_.CalculateSize(ChessRogueUpdateUnlockLevelScNotify._repeated_areaIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00058EE9 File Offset: 0x000570E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateUnlockLevelScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.areaIdList_.Add(other.areaIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00058F17 File Offset: 0x00057117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00058F20 File Offset: 0x00057120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.areaIdList_.AddEntriesFrom(ref input, ChessRogueUpdateUnlockLevelScNotify._repeated_areaIdList_codec);
				}
			}
		}

		// Token: 0x04000CE9 RID: 3305
		private static readonly MessageParser<ChessRogueUpdateUnlockLevelScNotify> _parser = new MessageParser<ChessRogueUpdateUnlockLevelScNotify>(() => new ChessRogueUpdateUnlockLevelScNotify());

		// Token: 0x04000CEA RID: 3306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CEB RID: 3307
		public const int AreaIdListFieldNumber = 3;

		// Token: 0x04000CEC RID: 3308
		private static readonly FieldCodec<uint> _repeated_areaIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04000CED RID: 3309
		private readonly RepeatedField<uint> areaIdList_ = new RepeatedField<uint>();
	}
}
