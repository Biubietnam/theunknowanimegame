using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000319 RID: 793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeItemCsReq : IMessage<ComposeItemCsReq>, IMessage, IEquatable<ComposeItemCsReq>, IDeepCloneable<ComposeItemCsReq>, IBufferMessage
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x00064F13 File Offset: 0x00063113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeItemCsReq> Parser
		{
			get
			{
				return ComposeItemCsReq._parser;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x00064F1A File Offset: 0x0006311A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x00064F2C File Offset: 0x0006312C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00064F33 File Offset: 0x00063133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemCsReq()
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00064F3C File Offset: 0x0006313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemCsReq(ComposeItemCsReq other) : this()
		{
			this.count_ = other.count_;
			this.composeId_ = other.composeId_;
			this.composeItemList_ = ((other.composeItemList_ != null) ? other.composeItemList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00064F94 File Offset: 0x00063194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemCsReq Clone()
		{
			return new ComposeItemCsReq(this);
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x00064F9C File Offset: 0x0006319C
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x00064FA4 File Offset: 0x000631A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x00064FAD File Offset: 0x000631AD
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x00064FB5 File Offset: 0x000631B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ComposeId
		{
			get
			{
				return this.composeId_;
			}
			set
			{
				this.composeId_ = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x00064FBE File Offset: 0x000631BE
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00064FC6 File Offset: 0x000631C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData ComposeItemList
		{
			get
			{
				return this.composeItemList_;
			}
			set
			{
				this.composeItemList_ = value;
			}
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00064FCF File Offset: 0x000631CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeItemCsReq);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00064FE0 File Offset: 0x000631E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeItemCsReq other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ComposeId == other.ComposeId && object.Equals(this.ComposeItemList, other.ComposeItemList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00065040 File Offset: 0x00063240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ComposeId != 0U)
			{
				num ^= this.ComposeId.GetHashCode();
			}
			if (this.composeItemList_ != null)
			{
				num ^= this.ComposeItemList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000650AE File Offset: 0x000632AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000650B6 File Offset: 0x000632B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000650C0 File Offset: 0x000632C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.composeItemList_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ComposeItemList);
			}
			if (this.Count != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Count);
			}
			if (this.ComposeId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ComposeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00065138 File Offset: 0x00063338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this.ComposeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ComposeId);
			}
			if (this.composeItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ComposeItemList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000651A8 File Offset: 0x000633A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			if (other.ComposeId != 0U)
			{
				this.ComposeId = other.ComposeId;
			}
			if (other.composeItemList_ != null)
			{
				if (this.composeItemList_ == null)
				{
					this.ComposeItemList = new ItemCostData();
				}
				this.ComposeItemList.MergeFrom(other.ComposeItemList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00065224 File Offset: 0x00063424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00065230 File Offset: 0x00063430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 32U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ComposeId = input.ReadUInt32();
						}
					}
					else
					{
						this.Count = input.ReadUInt32();
					}
				}
				else
				{
					if (this.composeItemList_ == null)
					{
						this.ComposeItemList = new ItemCostData();
					}
					input.ReadMessage(this.ComposeItemList);
				}
			}
		}

		// Token: 0x04000E97 RID: 3735
		private static readonly MessageParser<ComposeItemCsReq> _parser = new MessageParser<ComposeItemCsReq>(() => new ComposeItemCsReq());

		// Token: 0x04000E98 RID: 3736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E99 RID: 3737
		public const int CountFieldNumber = 4;

		// Token: 0x04000E9A RID: 3738
		private uint count_;

		// Token: 0x04000E9B RID: 3739
		public const int ComposeIdFieldNumber = 10;

		// Token: 0x04000E9C RID: 3740
		private uint composeId_;

		// Token: 0x04000E9D RID: 3741
		public const int ComposeItemListFieldNumber = 1;

		// Token: 0x04000E9E RID: 3742
		private ItemCostData composeItemList_;
	}
}
