using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000995 RID: 2453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KeywordUnlockValue : IMessage<KeywordUnlockValue>, IMessage, IEquatable<KeywordUnlockValue>, IDeepCloneable<KeywordUnlockValue>, IBufferMessage
	{
		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x0012574C File Offset: 0x0012394C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KeywordUnlockValue> Parser
		{
			get
			{
				return KeywordUnlockValue._parser;
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x00125753 File Offset: 0x00123953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KeywordUnlockValueReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x00125765 File Offset: 0x00123965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KeywordUnlockValue.Descriptor;
			}
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x0012576C File Offset: 0x0012396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KeywordUnlockValue()
		{
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x0012577F File Offset: 0x0012397F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KeywordUnlockValue(KeywordUnlockValue other) : this()
		{
			this.keywordUnlockMap_ = other.keywordUnlockMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x001257A9 File Offset: 0x001239A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KeywordUnlockValue Clone()
		{
			return new KeywordUnlockValue(this);
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x001257B1 File Offset: 0x001239B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, bool> KeywordUnlockMap
		{
			get
			{
				return this.keywordUnlockMap_;
			}
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x001257B9 File Offset: 0x001239B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KeywordUnlockValue);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x001257C7 File Offset: 0x001239C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KeywordUnlockValue other)
		{
			return other != null && (other == this || (this.KeywordUnlockMap.Equals(other.KeywordUnlockMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x001257FC File Offset: 0x001239FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.KeywordUnlockMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00125830 File Offset: 0x00123A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00125838 File Offset: 0x00123A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x00125841 File Offset: 0x00123A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.keywordUnlockMap_.WriteTo(ref output, KeywordUnlockValue._map_keywordUnlockMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x00125868 File Offset: 0x00123A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.keywordUnlockMap_.CalculateSize(KeywordUnlockValue._map_keywordUnlockMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x001258A1 File Offset: 0x00123AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KeywordUnlockValue other)
		{
			if (other == null)
			{
				return;
			}
			this.keywordUnlockMap_.MergeFrom(other.keywordUnlockMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x001258CF File Offset: 0x00123ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x001258D8 File Offset: 0x00123AD8
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
					this.keywordUnlockMap_.AddEntriesFrom(ref input, KeywordUnlockValue._map_keywordUnlockMap_codec);
				}
			}
		}

		// Token: 0x04002A2B RID: 10795
		private static readonly MessageParser<KeywordUnlockValue> _parser = new MessageParser<KeywordUnlockValue>(() => new KeywordUnlockValue());

		// Token: 0x04002A2C RID: 10796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A2D RID: 10797
		public const int KeywordUnlockMapFieldNumber = 1;

		// Token: 0x04002A2E RID: 10798
		private static readonly MapField<uint, bool>.Codec _map_keywordUnlockMap_codec = new MapField<uint, bool>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForBool(16U, false), 10U);

		// Token: 0x04002A2F RID: 10799
		private readonly MapField<uint, bool> keywordUnlockMap_ = new MapField<uint, bool>();
	}
}
