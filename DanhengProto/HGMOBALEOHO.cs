using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E7 RID: 2279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HGMOBALEOHO : IMessage<HGMOBALEOHO>, IMessage, IEquatable<HGMOBALEOHO>, IDeepCloneable<HGMOBALEOHO>, IBufferMessage
	{
		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x060065A5 RID: 26021 RVA: 0x0010FCFC File Offset: 0x0010DEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HGMOBALEOHO> Parser
		{
			get
			{
				return HGMOBALEOHO._parser;
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x060065A6 RID: 26022 RVA: 0x0010FD03 File Offset: 0x0010DF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HGMOBALEOHOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x060065A7 RID: 26023 RVA: 0x0010FD15 File Offset: 0x0010DF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HGMOBALEOHO.Descriptor;
			}
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x0010FD1C File Offset: 0x0010DF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGMOBALEOHO()
		{
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x0010FD24 File Offset: 0x0010DF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGMOBALEOHO(HGMOBALEOHO other) : this()
		{
			this.itemCount_ = other.itemCount_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x0010FD55 File Offset: 0x0010DF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGMOBALEOHO Clone()
		{
			return new HGMOBALEOHO(this);
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x0010FD5D File Offset: 0x0010DF5D
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x0010FD65 File Offset: 0x0010DF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x0010FD6E File Offset: 0x0010DF6E
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x0010FD76 File Offset: 0x0010DF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x0010FD7F File Offset: 0x0010DF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HGMOBALEOHO);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x0010FD8D File Offset: 0x0010DF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HGMOBALEOHO other)
		{
			return other != null && (other == this || (this.ItemCount == other.ItemCount && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0010FDCC File Offset: 0x0010DFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemCount != 0U)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x0010FE24 File Offset: 0x0010E024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x0010FE2C File Offset: 0x0010E02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x0010FE38 File Offset: 0x0010E038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ItemId);
			}
			if (this.ItemCount != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x0010FE90 File Offset: 0x0010E090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemCount);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x0010FEE8 File Offset: 0x0010E0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HGMOBALEOHO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemCount != 0U)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x0010FF38 File Offset: 0x0010E138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x0010FF44 File Offset: 0x0010E144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400271A RID: 10010
		private static readonly MessageParser<HGMOBALEOHO> _parser = new MessageParser<HGMOBALEOHO>(() => new HGMOBALEOHO());

		// Token: 0x0400271B RID: 10011
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400271C RID: 10012
		public const int ItemCountFieldNumber = 14;

		// Token: 0x0400271D RID: 10013
		private uint itemCount_;

		// Token: 0x0400271E RID: 10014
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400271F RID: 10015
		private uint itemId_;
	}
}
