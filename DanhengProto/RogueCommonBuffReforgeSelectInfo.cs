using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E39 RID: 3641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonBuffReforgeSelectInfo : IMessage<RogueCommonBuffReforgeSelectInfo>, IMessage, IEquatable<RogueCommonBuffReforgeSelectInfo>, IDeepCloneable<RogueCommonBuffReforgeSelectInfo>, IBufferMessage
	{
		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600A267 RID: 41575 RVA: 0x001B4957 File Offset: 0x001B2B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonBuffReforgeSelectInfo> Parser
		{
			get
			{
				return RogueCommonBuffReforgeSelectInfo._parser;
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600A268 RID: 41576 RVA: 0x001B495E File Offset: 0x001B2B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffReforgeSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x001B4970 File Offset: 0x001B2B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonBuffReforgeSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x001B4977 File Offset: 0x001B2B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffReforgeSelectInfo()
		{
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x001B498A File Offset: 0x001B2B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffReforgeSelectInfo(RogueCommonBuffReforgeSelectInfo other) : this()
		{
			this.selectBuffs_ = other.selectBuffs_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x001B49C0 File Offset: 0x001B2BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffReforgeSelectInfo Clone()
		{
			return new RogueCommonBuffReforgeSelectInfo(this);
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600A26D RID: 41581 RVA: 0x001B49C8 File Offset: 0x001B2BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> SelectBuffs
		{
			get
			{
				return this.selectBuffs_;
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600A26E RID: 41582 RVA: 0x001B49D0 File Offset: 0x001B2BD0
		// (set) Token: 0x0600A26F RID: 41583 RVA: 0x001B49D8 File Offset: 0x001B2BD8
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

		// Token: 0x0600A270 RID: 41584 RVA: 0x001B49E1 File Offset: 0x001B2BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonBuffReforgeSelectInfo);
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x001B49F0 File Offset: 0x001B2BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonBuffReforgeSelectInfo other)
		{
			return other != null && (other == this || (this.selectBuffs_.Equals(other.selectBuffs_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x001B4A40 File Offset: 0x001B2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectBuffs_.GetHashCode();
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

		// Token: 0x0600A273 RID: 41587 RVA: 0x001B4A8D File Offset: 0x001B2C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x001B4A95 File Offset: 0x001B2C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x001B4AA0 File Offset: 0x001B2CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectBuffs_.WriteTo(ref output, RogueCommonBuffReforgeSelectInfo._repeated_selectBuffs_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x001B4AF0 File Offset: 0x001B2CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectBuffs_.CalculateSize(RogueCommonBuffReforgeSelectInfo._repeated_selectBuffs_codec);
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

		// Token: 0x0600A277 RID: 41591 RVA: 0x001B4B44 File Offset: 0x001B2D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonBuffReforgeSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectBuffs_.Add(other.selectBuffs_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x001B4B91 File Offset: 0x001B2D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x001B4B9C File Offset: 0x001B2D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.selectBuffs_.AddEntriesFrom(ref input, RogueCommonBuffReforgeSelectInfo._repeated_selectBuffs_codec);
				}
			}
		}

		// Token: 0x04004278 RID: 17016
		private static readonly MessageParser<RogueCommonBuffReforgeSelectInfo> _parser = new MessageParser<RogueCommonBuffReforgeSelectInfo>(() => new RogueCommonBuffReforgeSelectInfo());

		// Token: 0x04004279 RID: 17017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400427A RID: 17018
		public const int SelectBuffsFieldNumber = 1;

		// Token: 0x0400427B RID: 17019
		private static readonly FieldCodec<RogueCommonBuff> _repeated_selectBuffs_codec = FieldCodec.ForMessage<RogueCommonBuff>(10U, RogueCommonBuff.Parser);

		// Token: 0x0400427C RID: 17020
		private readonly RepeatedField<RogueCommonBuff> selectBuffs_ = new RepeatedField<RogueCommonBuff>();

		// Token: 0x0400427D RID: 17021
		public const int SelectHintIdFieldNumber = 10;

		// Token: 0x0400427E RID: 17022
		private uint selectHintId_;
	}
}
