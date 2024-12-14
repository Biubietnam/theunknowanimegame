using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001FF RID: 511
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCurrentDifficultyInfo : IMessage<ChessRogueCurrentDifficultyInfo>, IMessage, IEquatable<ChessRogueCurrentDifficultyInfo>, IDeepCloneable<ChessRogueCurrentDifficultyInfo>, IBufferMessage
	{
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00041471 File Offset: 0x0003F671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCurrentDifficultyInfo> Parser
		{
			get
			{
				return ChessRogueCurrentDifficultyInfo._parser;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00041478 File Offset: 0x0003F678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCurrentDifficultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0004148A File Offset: 0x0003F68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCurrentDifficultyInfo.Descriptor;
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00041491 File Offset: 0x0003F691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentDifficultyInfo()
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000414A4 File Offset: 0x0003F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentDifficultyInfo(ChessRogueCurrentDifficultyInfo other) : this()
		{
			this.difficultyIdList_ = other.difficultyIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000414CE File Offset: 0x0003F6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentDifficultyInfo Clone()
		{
			return new ChessRogueCurrentDifficultyInfo(this);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000414D6 File Offset: 0x0003F6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DifficultyIdList
		{
			get
			{
				return this.difficultyIdList_;
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000414DE File Offset: 0x0003F6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCurrentDifficultyInfo);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000414EC File Offset: 0x0003F6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCurrentDifficultyInfo other)
		{
			return other != null && (other == this || (this.difficultyIdList_.Equals(other.difficultyIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00041520 File Offset: 0x0003F720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.difficultyIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00041554 File Offset: 0x0003F754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0004155C File Offset: 0x0003F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00041565 File Offset: 0x0003F765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.difficultyIdList_.WriteTo(ref output, ChessRogueCurrentDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0004158C File Offset: 0x0003F78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.difficultyIdList_.CalculateSize(ChessRogueCurrentDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000415C5 File Offset: 0x0003F7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCurrentDifficultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.difficultyIdList_.Add(other.difficultyIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x000415F3 File Offset: 0x0003F7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000415FC File Offset: 0x0003F7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.difficultyIdList_.AddEntriesFrom(ref input, ChessRogueCurrentDifficultyInfo._repeated_difficultyIdList_codec);
				}
			}
		}

		// Token: 0x0400099B RID: 2459
		private static readonly MessageParser<ChessRogueCurrentDifficultyInfo> _parser = new MessageParser<ChessRogueCurrentDifficultyInfo>(() => new ChessRogueCurrentDifficultyInfo());

		// Token: 0x0400099C RID: 2460
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400099D RID: 2461
		public const int DifficultyIdListFieldNumber = 15;

		// Token: 0x0400099E RID: 2462
		private static readonly FieldCodec<uint> _repeated_difficultyIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400099F RID: 2463
		private readonly RepeatedField<uint> difficultyIdList_ = new RepeatedField<uint>();
	}
}
