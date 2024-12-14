using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAB RID: 4011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterRoomCsReq : IMessage<RogueTournEnterRoomCsReq>, IMessage, IEquatable<RogueTournEnterRoomCsReq>, IDeepCloneable<RogueTournEnterRoomCsReq>, IBufferMessage
	{
		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600B2B9 RID: 45753 RVA: 0x001E032D File Offset: 0x001DE52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterRoomCsReq> Parser
		{
			get
			{
				return RogueTournEnterRoomCsReq._parser;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600B2BA RID: 45754 RVA: 0x001E0334 File Offset: 0x001DE534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600B2BB RID: 45755 RVA: 0x001E0346 File Offset: 0x001DE546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterRoomCsReq.Descriptor;
			}
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x001E034D File Offset: 0x001DE54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomCsReq()
		{
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x001E0355 File Offset: 0x001DE555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomCsReq(RogueTournEnterRoomCsReq other) : this()
		{
			this.curRoomIndex_ = other.curRoomIndex_;
			this.nextRoomType_ = other.nextRoomType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x001E0386 File Offset: 0x001DE586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRoomCsReq Clone()
		{
			return new RogueTournEnterRoomCsReq(this);
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x001E038E File Offset: 0x001DE58E
		// (set) Token: 0x0600B2C0 RID: 45760 RVA: 0x001E0396 File Offset: 0x001DE596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurRoomIndex
		{
			get
			{
				return this.curRoomIndex_;
			}
			set
			{
				this.curRoomIndex_ = value;
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600B2C1 RID: 45761 RVA: 0x001E039F File Offset: 0x001DE59F
		// (set) Token: 0x0600B2C2 RID: 45762 RVA: 0x001E03A7 File Offset: 0x001DE5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NextRoomType
		{
			get
			{
				return this.nextRoomType_;
			}
			set
			{
				this.nextRoomType_ = value;
			}
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x001E03B0 File Offset: 0x001DE5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterRoomCsReq);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x001E03BE File Offset: 0x001DE5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterRoomCsReq other)
		{
			return other != null && (other == this || (this.CurRoomIndex == other.CurRoomIndex && this.NextRoomType == other.NextRoomType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x001E03FC File Offset: 0x001DE5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoomIndex != 0U)
			{
				num ^= this.CurRoomIndex.GetHashCode();
			}
			if (this.NextRoomType != 0U)
			{
				num ^= this.NextRoomType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x001E0454 File Offset: 0x001DE654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x001E045C File Offset: 0x001DE65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x001E0468 File Offset: 0x001DE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoomIndex != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurRoomIndex);
			}
			if (this.NextRoomType != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NextRoomType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x001E04C4 File Offset: 0x001DE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoomIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurRoomIndex);
			}
			if (this.NextRoomType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextRoomType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x001E051C File Offset: 0x001DE71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoomIndex != 0U)
			{
				this.CurRoomIndex = other.CurRoomIndex;
			}
			if (other.NextRoomType != 0U)
			{
				this.NextRoomType = other.NextRoomType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x001E056C File Offset: 0x001DE76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x001E0578 File Offset: 0x001DE778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextRoomType = input.ReadUInt32();
					}
				}
				else
				{
					this.CurRoomIndex = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400489E RID: 18590
		private static readonly MessageParser<RogueTournEnterRoomCsReq> _parser = new MessageParser<RogueTournEnterRoomCsReq>(() => new RogueTournEnterRoomCsReq());

		// Token: 0x0400489F RID: 18591
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A0 RID: 18592
		public const int CurRoomIndexFieldNumber = 6;

		// Token: 0x040048A1 RID: 18593
		private uint curRoomIndex_;

		// Token: 0x040048A2 RID: 18594
		public const int NextRoomTypeFieldNumber = 9;

		// Token: 0x040048A3 RID: 18595
		private uint nextRoomType_;
	}
}
