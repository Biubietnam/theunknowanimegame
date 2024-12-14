using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD3 RID: 3027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumTargetRewardNotify : IMessage<MuseumTargetRewardNotify>, IMessage, IEquatable<MuseumTargetRewardNotify>, IDeepCloneable<MuseumTargetRewardNotify>, IBufferMessage
	{
		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x060085EE RID: 34286 RVA: 0x001618E5 File Offset: 0x0015FAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumTargetRewardNotify> Parser
		{
			get
			{
				return MuseumTargetRewardNotify._parser;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x060085EF RID: 34287 RVA: 0x001618EC File Offset: 0x0015FAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumTargetRewardNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x060085F0 RID: 34288 RVA: 0x001618FE File Offset: 0x0015FAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumTargetRewardNotify.Descriptor;
			}
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x00161905 File Offset: 0x0015FB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetRewardNotify()
		{
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x0016190D File Offset: 0x0015FB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetRewardNotify(MuseumTargetRewardNotify other) : this()
		{
			this.pHLFJPFKFOF_ = other.pHLFJPFKFOF_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x0016194A File Offset: 0x0015FB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetRewardNotify Clone()
		{
			return new MuseumTargetRewardNotify(this);
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x060085F4 RID: 34292 RVA: 0x00161952 File Offset: 0x0015FB52
		// (set) Token: 0x060085F5 RID: 34293 RVA: 0x0016195A File Offset: 0x0015FB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHLFJPFKFOF
		{
			get
			{
				return this.pHLFJPFKFOF_;
			}
			set
			{
				this.pHLFJPFKFOF_ = value;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x060085F6 RID: 34294 RVA: 0x00161963 File Offset: 0x0015FB63
		// (set) Token: 0x060085F7 RID: 34295 RVA: 0x0016196B File Offset: 0x0015FB6B
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

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x060085F8 RID: 34296 RVA: 0x00161974 File Offset: 0x0015FB74
		// (set) Token: 0x060085F9 RID: 34297 RVA: 0x0016197C File Offset: 0x0015FB7C
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

		// Token: 0x060085FA RID: 34298 RVA: 0x00161985 File Offset: 0x0015FB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumTargetRewardNotify);
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x00161994 File Offset: 0x0015FB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumTargetRewardNotify other)
		{
			return other != null && (other == this || (this.PHLFJPFKFOF == other.PHLFJPFKFOF && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085FC RID: 34300 RVA: 0x001619F0 File Offset: 0x0015FBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHLFJPFKFOF != 0U)
			{
				num ^= this.PHLFJPFKFOF.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0U)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085FD RID: 34301 RVA: 0x00161A61 File Offset: 0x0015FC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x00161A69 File Offset: 0x0015FC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00161A74 File Offset: 0x0015FC74
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
				output.WriteRawTag(64);
				output.WriteUInt32(this.ItemCount);
			}
			if (this.PHLFJPFKFOF != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PHLFJPFKFOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x00161AE8 File Offset: 0x0015FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHLFJPFKFOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHLFJPFKFOF);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x00161B58 File Offset: 0x0015FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumTargetRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHLFJPFKFOF != 0U)
			{
				this.PHLFJPFKFOF = other.PHLFJPFKFOF;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0U)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00161BBC File Offset: 0x0015FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x00161BC8 File Offset: 0x0015FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PHLFJPFKFOF = input.ReadUInt32();
						}
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

		// Token: 0x0400334D RID: 13133
		private static readonly MessageParser<MuseumTargetRewardNotify> _parser = new MessageParser<MuseumTargetRewardNotify>(() => new MuseumTargetRewardNotify());

		// Token: 0x0400334E RID: 13134
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400334F RID: 13135
		public const int PHLFJPFKFOFFieldNumber = 11;

		// Token: 0x04003350 RID: 13136
		private uint pHLFJPFKFOF_;

		// Token: 0x04003351 RID: 13137
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003352 RID: 13138
		private uint itemId_;

		// Token: 0x04003353 RID: 13139
		public const int ItemCountFieldNumber = 8;

		// Token: 0x04003354 RID: 13140
		private uint itemCount_;
	}
}
