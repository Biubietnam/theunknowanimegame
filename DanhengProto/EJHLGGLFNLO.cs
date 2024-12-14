using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000405 RID: 1029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EJHLGGLFNLO : IMessage<EJHLGGLFNLO>, IMessage, IEquatable<EJHLGGLFNLO>, IDeepCloneable<EJHLGGLFNLO>, IBufferMessage
	{
		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x0007E56C File Offset: 0x0007C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EJHLGGLFNLO> Parser
		{
			get
			{
				return EJHLGGLFNLO._parser;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x0007E573 File Offset: 0x0007C773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EJHLGGLFNLOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x0007E585 File Offset: 0x0007C785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EJHLGGLFNLO.Descriptor;
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0007E58C File Offset: 0x0007C78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJHLGGLFNLO()
		{
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0007E59F File Offset: 0x0007C79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJHLGGLFNLO(EJHLGGLFNLO other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x0007E5C9 File Offset: 0x0007C7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJHLGGLFNLO Clone()
		{
			return new EJHLGGLFNLO(this);
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x0007E5D1 File Offset: 0x0007C7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ENCGLEPGAGE> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0007E5D9 File Offset: 0x0007C7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EJHLGGLFNLO);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0007E5E7 File Offset: 0x0007C7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EJHLGGLFNLO other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0007E61C File Offset: 0x0007C81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x0007E650 File Offset: 0x0007C850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x0007E658 File Offset: 0x0007C858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0007E661 File Offset: 0x0007C861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, EJHLGGLFNLO._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0007E688 File Offset: 0x0007C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(EJHLGGLFNLO._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0007E6C1 File Offset: 0x0007C8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EJHLGGLFNLO other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0007E6EF File Offset: 0x0007C8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x0007E6F8 File Offset: 0x0007C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, EJHLGGLFNLO._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x04001261 RID: 4705
		private static readonly MessageParser<EJHLGGLFNLO> _parser = new MessageParser<EJHLGGLFNLO>(() => new EJHLGGLFNLO());

		// Token: 0x04001262 RID: 4706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001263 RID: 4707
		public const int ItemListFieldNumber = 14;

		// Token: 0x04001264 RID: 4708
		private static readonly FieldCodec<ENCGLEPGAGE> _repeated_itemList_codec = FieldCodec.ForMessage<ENCGLEPGAGE>(114U, ENCGLEPGAGE.Parser);

		// Token: 0x04001265 RID: 4709
		private readonly RepeatedField<ENCGLEPGAGE> itemList_ = new RepeatedField<ENCGLEPGAGE>();
	}
}
