using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000247 RID: 583
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueModifierInfo : IMessage<ChessRogueModifierInfo>, IMessage, IEquatable<ChessRogueModifierInfo>, IDeepCloneable<ChessRogueModifierInfo>, IBufferMessage
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0004C2B5 File Offset: 0x0004A4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueModifierInfo> Parser
		{
			get
			{
				return ChessRogueModifierInfo._parser;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0004C2BC File Offset: 0x0004A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueModifierInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0004C2CE File Offset: 0x0004A4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueModifierInfo.Descriptor;
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0004C2D5 File Offset: 0x0004A4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueModifierInfo()
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0004C2E8 File Offset: 0x0004A4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueModifierInfo(ChessRogueModifierInfo other) : this()
		{
			this.confirm_ = other.confirm_;
			this.gNDJCFDJHEJ_ = other.gNDJCFDJHEJ_.Clone();
			this.selectCellId_ = other.selectCellId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0004C335 File Offset: 0x0004A535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueModifierInfo Clone()
		{
			return new ChessRogueModifierInfo(this);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x0004C33D File Offset: 0x0004A53D
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0004C345 File Offset: 0x0004A545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Confirm
		{
			get
			{
				return this.confirm_;
			}
			set
			{
				this.confirm_ = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0004C34E File Offset: 0x0004A54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GNDJCFDJHEJ
		{
			get
			{
				return this.gNDJCFDJHEJ_;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0004C356 File Offset: 0x0004A556
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0004C35E File Offset: 0x0004A55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectCellId
		{
			get
			{
				return this.selectCellId_;
			}
			set
			{
				this.selectCellId_ = value;
			}
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0004C367 File Offset: 0x0004A567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueModifierInfo);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0004C378 File Offset: 0x0004A578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueModifierInfo other)
		{
			return other != null && (other == this || (this.Confirm == other.Confirm && this.gNDJCFDJHEJ_.Equals(other.gNDJCFDJHEJ_) && this.SelectCellId == other.SelectCellId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0004C3D8 File Offset: 0x0004A5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Confirm)
			{
				num ^= this.Confirm.GetHashCode();
			}
			num ^= this.gNDJCFDJHEJ_.GetHashCode();
			if (this.SelectCellId != 0U)
			{
				num ^= this.SelectCellId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0004C43E File Offset: 0x0004A63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004C446 File Offset: 0x0004A646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0004C450 File Offset: 0x0004A650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectCellId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SelectCellId);
			}
			if (this.Confirm)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Confirm);
			}
			this.gNDJCFDJHEJ_.WriteTo(ref output, ChessRogueModifierInfo._repeated_gNDJCFDJHEJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0004C4BC File Offset: 0x0004A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Confirm)
			{
				num += 2;
			}
			num += this.gNDJCFDJHEJ_.CalculateSize(ChessRogueModifierInfo._repeated_gNDJCFDJHEJ_codec);
			if (this.SelectCellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectCellId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0004C51C File Offset: 0x0004A71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueModifierInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Confirm)
			{
				this.Confirm = other.Confirm;
			}
			this.gNDJCFDJHEJ_.Add(other.gNDJCFDJHEJ_);
			if (other.SelectCellId != 0U)
			{
				this.SelectCellId = other.SelectCellId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0004C57D File Offset: 0x0004A77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0004C588 File Offset: 0x0004A788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.SelectCellId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Confirm = input.ReadBool();
						continue;
					}
				}
				else if (num == 80U || num == 82U)
				{
					this.gNDJCFDJHEJ_.AddEntriesFrom(ref input, ChessRogueModifierInfo._repeated_gNDJCFDJHEJ_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000B26 RID: 2854
		private static readonly MessageParser<ChessRogueModifierInfo> _parser = new MessageParser<ChessRogueModifierInfo>(() => new ChessRogueModifierInfo());

		// Token: 0x04000B27 RID: 2855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B28 RID: 2856
		public const int ConfirmFieldNumber = 8;

		// Token: 0x04000B29 RID: 2857
		private bool confirm_;

		// Token: 0x04000B2A RID: 2858
		public const int GNDJCFDJHEJFieldNumber = 10;

		// Token: 0x04000B2B RID: 2859
		private static readonly FieldCodec<uint> _repeated_gNDJCFDJHEJ_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04000B2C RID: 2860
		private readonly RepeatedField<uint> gNDJCFDJHEJ_ = new RepeatedField<uint>();

		// Token: 0x04000B2D RID: 2861
		public const int SelectCellIdFieldNumber = 3;

		// Token: 0x04000B2E RID: 2862
		private uint selectCellId_;
	}
}
