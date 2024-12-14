using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E93 RID: 3731
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGameItemValue : IMessage<RogueGameItemValue>, IMessage, IEquatable<RogueGameItemValue>, IDeepCloneable<RogueGameItemValue>, IBufferMessage
	{
		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600A6B3 RID: 42675 RVA: 0x001C1244 File Offset: 0x001BF444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGameItemValue> Parser
		{
			get
			{
				return RogueGameItemValue._parser;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x001C124B File Offset: 0x001BF44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGameItemValueReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600A6B5 RID: 42677 RVA: 0x001C125D File Offset: 0x001BF45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGameItemValue.Descriptor;
			}
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x001C1264 File Offset: 0x001BF464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameItemValue()
		{
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x001C1277 File Offset: 0x001BF477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameItemValue(RogueGameItemValue other) : this()
		{
			this.virtualItem_ = other.virtualItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x001C12A1 File Offset: 0x001BF4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameItemValue Clone()
		{
			return new RogueGameItemValue(this);
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600A6B9 RID: 42681 RVA: 0x001C12A9 File Offset: 0x001BF4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> VirtualItem
		{
			get
			{
				return this.virtualItem_;
			}
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x001C12B1 File Offset: 0x001BF4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGameItemValue);
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x001C12BF File Offset: 0x001BF4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGameItemValue other)
		{
			return other != null && (other == this || (this.VirtualItem.Equals(other.VirtualItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x001C12F4 File Offset: 0x001BF4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.VirtualItem.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x001C1328 File Offset: 0x001BF528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x001C1330 File Offset: 0x001BF530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x001C1339 File Offset: 0x001BF539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.virtualItem_.WriteTo(ref output, RogueGameItemValue._map_virtualItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x001C1360 File Offset: 0x001BF560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.virtualItem_.CalculateSize(RogueGameItemValue._map_virtualItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x001C1399 File Offset: 0x001BF599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGameItemValue other)
		{
			if (other == null)
			{
				return;
			}
			this.virtualItem_.MergeFrom(other.virtualItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x001C13C7 File Offset: 0x001BF5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x001C13D0 File Offset: 0x001BF5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.virtualItem_.AddEntriesFrom(ref input, RogueGameItemValue._map_virtualItem_codec);
				}
			}
		}

		// Token: 0x04004436 RID: 17462
		private static readonly MessageParser<RogueGameItemValue> _parser = new MessageParser<RogueGameItemValue>(() => new RogueGameItemValue());

		// Token: 0x04004437 RID: 17463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004438 RID: 17464
		public const int VirtualItemFieldNumber = 2;

		// Token: 0x04004439 RID: 17465
		private static readonly MapField<uint, uint>.Codec _map_virtualItem_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 18U);

		// Token: 0x0400443A RID: 17466
		private readonly MapField<uint, uint> virtualItem_ = new MapField<uint, uint>();
	}
}
