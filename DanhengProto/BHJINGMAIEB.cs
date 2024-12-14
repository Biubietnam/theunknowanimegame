using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000121 RID: 289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BHJINGMAIEB : IMessage<BHJINGMAIEB>, IMessage, IEquatable<BHJINGMAIEB>, IDeepCloneable<BHJINGMAIEB>, IBufferMessage
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000272CC File Offset: 0x000254CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BHJINGMAIEB> Parser
		{
			get
			{
				return BHJINGMAIEB._parser;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x000272D3 File Offset: 0x000254D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BHJINGMAIEBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000272E5 File Offset: 0x000254E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BHJINGMAIEB.Descriptor;
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000272EC File Offset: 0x000254EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHJINGMAIEB()
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000272F4 File Offset: 0x000254F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHJINGMAIEB(BHJINGMAIEB other) : this()
		{
			this.iDJGOIDALMN_ = other.iDJGOIDALMN_;
			this.getItemList_ = other.getItemList_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00027325 File Offset: 0x00025525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BHJINGMAIEB Clone()
		{
			return new BHJINGMAIEB(this);
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002732D File Offset: 0x0002552D
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00027335 File Offset: 0x00025535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IDJGOIDALMN
		{
			get
			{
				return this.iDJGOIDALMN_;
			}
			set
			{
				this.iDJGOIDALMN_ = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0002733E File Offset: 0x0002553E
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00027346 File Offset: 0x00025546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GetItemList
		{
			get
			{
				return this.getItemList_;
			}
			set
			{
				this.getItemList_ = value;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0002734F File Offset: 0x0002554F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BHJINGMAIEB);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0002735D File Offset: 0x0002555D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BHJINGMAIEB other)
		{
			return other != null && (other == this || (this.IDJGOIDALMN == other.IDJGOIDALMN && this.GetItemList == other.GetItemList && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0002739C File Offset: 0x0002559C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IDJGOIDALMN != 0U)
			{
				num ^= this.IDJGOIDALMN.GetHashCode();
			}
			if (this.GetItemList != 0U)
			{
				num ^= this.GetItemList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000273F4 File Offset: 0x000255F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000273FC File Offset: 0x000255FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00027408 File Offset: 0x00025608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IDJGOIDALMN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.IDJGOIDALMN);
			}
			if (this.GetItemList != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GetItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00027464 File Offset: 0x00025664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IDJGOIDALMN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IDJGOIDALMN);
			}
			if (this.GetItemList != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GetItemList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000274BC File Offset: 0x000256BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BHJINGMAIEB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IDJGOIDALMN != 0U)
			{
				this.IDJGOIDALMN = other.IDJGOIDALMN;
			}
			if (other.GetItemList != 0U)
			{
				this.GetItemList = other.GetItemList;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0002750C File Offset: 0x0002570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00027518 File Offset: 0x00025718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GetItemList = input.ReadUInt32();
					}
				}
				else
				{
					this.IDJGOIDALMN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040005AB RID: 1451
		private static readonly MessageParser<BHJINGMAIEB> _parser = new MessageParser<BHJINGMAIEB>(() => new BHJINGMAIEB());

		// Token: 0x040005AC RID: 1452
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005AD RID: 1453
		public const int IDJGOIDALMNFieldNumber = 2;

		// Token: 0x040005AE RID: 1454
		private uint iDJGOIDALMN_;

		// Token: 0x040005AF RID: 1455
		public const int GetItemListFieldNumber = 5;

		// Token: 0x040005B0 RID: 1456
		private uint getItemList_;
	}
}
