using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F43 RID: 3907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMiracleSelectInfo : IMessage<RogueMiracleSelectInfo>, IMessage, IEquatable<RogueMiracleSelectInfo>, IDeepCloneable<RogueMiracleSelectInfo>, IBufferMessage
	{
		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600AE58 RID: 44632 RVA: 0x001D4D9D File Offset: 0x001D2F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMiracleSelectInfo> Parser
		{
			get
			{
				return RogueMiracleSelectInfo._parser;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600AE59 RID: 44633 RVA: 0x001D4DA4 File Offset: 0x001D2FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMiracleSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x001D4DB6 File Offset: 0x001D2FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMiracleSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x001D4DBD File Offset: 0x001D2FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectInfo()
		{
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x001D4DDC File Offset: 0x001D2FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectInfo(RogueMiracleSelectInfo other) : this()
		{
			this.selectMiracleList_ = other.selectMiracleList_.Clone();
			this.miracleHandbookList_ = other.miracleHandbookList_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x001D4E2E File Offset: 0x001D302E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectInfo Clone()
		{
			return new RogueMiracleSelectInfo(this);
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600AE5E RID: 44638 RVA: 0x001D4E36 File Offset: 0x001D3036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SelectMiracleList
		{
			get
			{
				return this.selectMiracleList_;
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x001D4E3E File Offset: 0x001D303E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MiracleHandbookList
		{
			get
			{
				return this.miracleHandbookList_;
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600AE60 RID: 44640 RVA: 0x001D4E46 File Offset: 0x001D3046
		// (set) Token: 0x0600AE61 RID: 44641 RVA: 0x001D4E4E File Offset: 0x001D304E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x001D4E57 File Offset: 0x001D3057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMiracleSelectInfo);
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x001D4E68 File Offset: 0x001D3068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMiracleSelectInfo other)
		{
			return other != null && (other == this || (this.selectMiracleList_.Equals(other.selectMiracleList_) && this.miracleHandbookList_.Equals(other.miracleHandbookList_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x001D4ECC File Offset: 0x001D30CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectMiracleList_.GetHashCode();
			num ^= this.miracleHandbookList_.GetHashCode();
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE65 RID: 44645 RVA: 0x001D4F27 File Offset: 0x001D3127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE66 RID: 44646 RVA: 0x001D4F2F File Offset: 0x001D312F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE67 RID: 44647 RVA: 0x001D4F38 File Offset: 0x001D3138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miracleHandbookList_.WriteTo(ref output, RogueMiracleSelectInfo._repeated_miracleHandbookList_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.SelectHintId);
			}
			this.selectMiracleList_.WriteTo(ref output, RogueMiracleSelectInfo._repeated_selectMiracleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE68 RID: 44648 RVA: 0x001D4F98 File Offset: 0x001D3198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectMiracleList_.CalculateSize(RogueMiracleSelectInfo._repeated_selectMiracleList_codec);
			num += this.miracleHandbookList_.CalculateSize(RogueMiracleSelectInfo._repeated_miracleHandbookList_codec);
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE69 RID: 44649 RVA: 0x001D4FFC File Offset: 0x001D31FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMiracleSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectMiracleList_.Add(other.selectMiracleList_);
			this.miracleHandbookList_.Add(other.miracleHandbookList_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x001D505A File Offset: 0x001D325A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x001D5064 File Offset: 0x001D3264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.miracleHandbookList_.AddEntriesFrom(ref input, RogueMiracleSelectInfo._repeated_miracleHandbookList_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.SelectHintId = input.ReadUInt32();
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.selectMiracleList_.AddEntriesFrom(ref input, RogueMiracleSelectInfo._repeated_selectMiracleList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046F8 RID: 18168
		private static readonly MessageParser<RogueMiracleSelectInfo> _parser = new MessageParser<RogueMiracleSelectInfo>(() => new RogueMiracleSelectInfo());

		// Token: 0x040046F9 RID: 18169
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046FA RID: 18170
		public const int SelectMiracleListFieldNumber = 8;

		// Token: 0x040046FB RID: 18171
		private static readonly FieldCodec<uint> _repeated_selectMiracleList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040046FC RID: 18172
		private readonly RepeatedField<uint> selectMiracleList_ = new RepeatedField<uint>();

		// Token: 0x040046FD RID: 18173
		public const int MiracleHandbookListFieldNumber = 3;

		// Token: 0x040046FE RID: 18174
		private static readonly FieldCodec<uint> _repeated_miracleHandbookList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x040046FF RID: 18175
		private readonly RepeatedField<uint> miracleHandbookList_ = new RepeatedField<uint>();

		// Token: 0x04004700 RID: 18176
		public const int SelectHintIdFieldNumber = 5;

		// Token: 0x04004701 RID: 18177
		private uint selectHintId_;
	}
}
