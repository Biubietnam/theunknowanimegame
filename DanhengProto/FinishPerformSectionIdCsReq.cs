using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000587 RID: 1415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishPerformSectionIdCsReq : IMessage<FinishPerformSectionIdCsReq>, IMessage, IEquatable<FinishPerformSectionIdCsReq>, IDeepCloneable<FinishPerformSectionIdCsReq>, IBufferMessage
	{
		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x000AC639 File Offset: 0x000AA839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishPerformSectionIdCsReq> Parser
		{
			get
			{
				return FinishPerformSectionIdCsReq._parser;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x000AC640 File Offset: 0x000AA840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishPerformSectionIdCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x000AC652 File Offset: 0x000AA852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishPerformSectionIdCsReq.Descriptor;
			}
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x000AC659 File Offset: 0x000AA859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdCsReq()
		{
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x000AC66C File Offset: 0x000AA86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdCsReq(FinishPerformSectionIdCsReq other) : this()
		{
			this.sectionId_ = other.sectionId_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x000AC6A2 File Offset: 0x000AA8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdCsReq Clone()
		{
			return new FinishPerformSectionIdCsReq(this);
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x000AC6AA File Offset: 0x000AA8AA
		// (set) Token: 0x06003F2C RID: 16172 RVA: 0x000AC6B2 File Offset: 0x000AA8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x000AC6BB File Offset: 0x000AA8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MessageItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x000AC6C3 File Offset: 0x000AA8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishPerformSectionIdCsReq);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishPerformSectionIdCsReq other)
		{
			return other != null && (other == this || (this.SectionId == other.SectionId && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x000AC724 File Offset: 0x000AA924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000AC771 File Offset: 0x000AA971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x000AC779 File Offset: 0x000AA979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000AC784 File Offset: 0x000AA984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SectionId);
			}
			this.itemList_.WriteTo(ref output, FinishPerformSectionIdCsReq._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			num += this.itemList_.CalculateSize(FinishPerformSectionIdCsReq._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x000AC828 File Offset: 0x000AAA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishPerformSectionIdCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x000AC875 File Offset: 0x000AAA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x000AC880 File Offset: 0x000AAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemList_.AddEntriesFrom(ref input, FinishPerformSectionIdCsReq._repeated_itemList_codec);
					}
				}
				else
				{
					this.SectionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001926 RID: 6438
		private static readonly MessageParser<FinishPerformSectionIdCsReq> _parser = new MessageParser<FinishPerformSectionIdCsReq>(() => new FinishPerformSectionIdCsReq());

		// Token: 0x04001927 RID: 6439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001928 RID: 6440
		public const int SectionIdFieldNumber = 3;

		// Token: 0x04001929 RID: 6441
		private uint sectionId_;

		// Token: 0x0400192A RID: 6442
		public const int ItemListFieldNumber = 7;

		// Token: 0x0400192B RID: 6443
		private static readonly FieldCodec<MessageItem> _repeated_itemList_codec = FieldCodec.ForMessage<MessageItem>(58U, MessageItem.Parser);

		// Token: 0x0400192C RID: 6444
		private readonly RepeatedField<MessageItem> itemList_ = new RepeatedField<MessageItem>();
	}
}
