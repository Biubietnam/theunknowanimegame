using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200030D RID: 781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class COBDHAGFEHD : IMessage<COBDHAGFEHD>, IMessage, IEquatable<COBDHAGFEHD>, IDeepCloneable<COBDHAGFEHD>, IBufferMessage
	{
		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000639E8 File Offset: 0x00061BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<COBDHAGFEHD> Parser
		{
			get
			{
				return COBDHAGFEHD._parser;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000639EF File Offset: 0x00061BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return COBDHAGFEHDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00063A01 File Offset: 0x00061C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return COBDHAGFEHD.Descriptor;
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00063A08 File Offset: 0x00061C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COBDHAGFEHD()
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00063A10 File Offset: 0x00061C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COBDHAGFEHD(COBDHAGFEHD other) : this()
		{
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00063A45 File Offset: 0x00061C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COBDHAGFEHD Clone()
		{
			return new COBDHAGFEHD(this);
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00063A4D File Offset: 0x00061C4D
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x00063A55 File Offset: 0x00061C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00063A5E File Offset: 0x00061C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as COBDHAGFEHD);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00063A6C File Offset: 0x00061C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(COBDHAGFEHD other)
		{
			return other != null && (other == this || (object.Equals(this.ItemList, other.ItemList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00063AA0 File Offset: 0x00061CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00063ADC File Offset: 0x00061CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00063AE4 File Offset: 0x00061CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00063AED File Offset: 0x00061CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.itemList_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00063B20 File Offset: 0x00061D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00063B60 File Offset: 0x00061D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(COBDHAGFEHD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00063BB4 File Offset: 0x00061DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00063BC0 File Offset: 0x00061DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.itemList_ == null)
					{
						this.ItemList = new ItemList();
					}
					input.ReadMessage(this.ItemList);
				}
			}
		}

		// Token: 0x04000E6D RID: 3693
		private static readonly MessageParser<COBDHAGFEHD> _parser = new MessageParser<COBDHAGFEHD>(() => new COBDHAGFEHD());

		// Token: 0x04000E6E RID: 3694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E6F RID: 3695
		public const int ItemListFieldNumber = 7;

		// Token: 0x04000E70 RID: 3696
		private ItemList itemList_;
	}
}
