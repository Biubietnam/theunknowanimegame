using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000091 RID: 145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyPlacingShip : IMessage<AlleyPlacingShip>, IMessage, IEquatable<AlleyPlacingShip>, IDeepCloneable<AlleyPlacingShip>, IBufferMessage
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00011D41 File Offset: 0x0000FF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyPlacingShip> Parser
		{
			get
			{
				return AlleyPlacingShip._parser;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00011D48 File Offset: 0x0000FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyPlacingShipReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00011D5A File Offset: 0x0000FF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyPlacingShip.Descriptor;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00011D61 File Offset: 0x0000FF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingShip()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00011D74 File Offset: 0x0000FF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingShip(AlleyPlacingShip other) : this()
		{
			this.shipId_ = other.shipId_;
			this.goodsList_ = other.goodsList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00011DAA File Offset: 0x0000FFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingShip Clone()
		{
			return new AlleyPlacingShip(this);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00011DB2 File Offset: 0x0000FFB2
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00011DBA File Offset: 0x0000FFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShipId
		{
			get
			{
				return this.shipId_;
			}
			set
			{
				this.shipId_ = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00011DC3 File Offset: 0x0000FFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<INAMOOJHEAJ> GoodsList
		{
			get
			{
				return this.goodsList_;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00011DCB File Offset: 0x0000FFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyPlacingShip);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00011DDC File Offset: 0x0000FFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyPlacingShip other)
		{
			return other != null && (other == this || (this.ShipId == other.ShipId && this.goodsList_.Equals(other.goodsList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00011E2C File Offset: 0x0001002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShipId != 0U)
			{
				num ^= this.ShipId.GetHashCode();
			}
			num ^= this.goodsList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00011E79 File Offset: 0x00010079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00011E81 File Offset: 0x00010081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00011E8C File Offset: 0x0001008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShipId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ShipId);
			}
			this.goodsList_.WriteTo(ref output, AlleyPlacingShip._repeated_goodsList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00011EDC File Offset: 0x000100DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShipId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShipId);
			}
			num += this.goodsList_.CalculateSize(AlleyPlacingShip._repeated_goodsList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00011F30 File Offset: 0x00010130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyPlacingShip other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShipId != 0U)
			{
				this.ShipId = other.ShipId;
			}
			this.goodsList_.Add(other.goodsList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00011F7D File Offset: 0x0001017D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00011F88 File Offset: 0x00010188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.goodsList_.AddEntriesFrom(ref input, AlleyPlacingShip._repeated_goodsList_codec);
					}
				}
				else
				{
					this.ShipId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000253 RID: 595
		private static readonly MessageParser<AlleyPlacingShip> _parser = new MessageParser<AlleyPlacingShip>(() => new AlleyPlacingShip());

		// Token: 0x04000254 RID: 596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000255 RID: 597
		public const int ShipIdFieldNumber = 7;

		// Token: 0x04000256 RID: 598
		private uint shipId_;

		// Token: 0x04000257 RID: 599
		public const int GoodsListFieldNumber = 13;

		// Token: 0x04000258 RID: 600
		private static readonly FieldCodec<INAMOOJHEAJ> _repeated_goodsList_codec = FieldCodec.ForMessage<INAMOOJHEAJ>(106U, INAMOOJHEAJ.Parser);

		// Token: 0x04000259 RID: 601
		private readonly RepeatedField<INAMOOJHEAJ> goodsList_ = new RepeatedField<INAMOOJHEAJ>();
	}
}
