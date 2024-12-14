using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA3 RID: 3235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PKGEFMGJONL : IMessage<PKGEFMGJONL>, IMessage, IEquatable<PKGEFMGJONL>, IDeepCloneable<PKGEFMGJONL>, IBufferMessage
	{
		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06008FDA RID: 36826 RVA: 0x0017C0E8 File Offset: 0x0017A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PKGEFMGJONL> Parser
		{
			get
			{
				return PKGEFMGJONL._parser;
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x06008FDB RID: 36827 RVA: 0x0017C0EF File Offset: 0x0017A2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PKGEFMGJONLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x0017C101 File Offset: 0x0017A301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PKGEFMGJONL.Descriptor;
			}
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0017C108 File Offset: 0x0017A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKGEFMGJONL()
		{
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0017C110 File Offset: 0x0017A310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKGEFMGJONL(PKGEFMGJONL other) : this()
		{
			this.shopId_ = other.shopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x0017C135 File Offset: 0x0017A335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKGEFMGJONL Clone()
		{
			return new PKGEFMGJONL(this);
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x0017C13D File Offset: 0x0017A33D
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x0017C145 File Offset: 0x0017A345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0017C14E File Offset: 0x0017A34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PKGEFMGJONL);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0017C15C File Offset: 0x0017A35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PKGEFMGJONL other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0017C18C File Offset: 0x0017A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0017C1CB File Offset: 0x0017A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0017C1D3 File Offset: 0x0017A3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0017C1DC File Offset: 0x0017A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0017C210 File Offset: 0x0017A410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0017C24E File Offset: 0x0017A44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PKGEFMGJONL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0017C27F File Offset: 0x0017A47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0017C288 File Offset: 0x0017A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShopId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400373E RID: 14142
		private static readonly MessageParser<PKGEFMGJONL> _parser = new MessageParser<PKGEFMGJONL>(() => new PKGEFMGJONL());

		// Token: 0x0400373F RID: 14143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003740 RID: 14144
		public const int ShopIdFieldNumber = 1;

		// Token: 0x04003741 RID: 14145
		private uint shopId_;
	}
}
