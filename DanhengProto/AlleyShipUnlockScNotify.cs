using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000095 RID: 149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyShipUnlockScNotify : IMessage<AlleyShipUnlockScNotify>, IMessage, IEquatable<AlleyShipUnlockScNotify>, IDeepCloneable<AlleyShipUnlockScNotify>, IBufferMessage
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00012344 File Offset: 0x00010544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyShipUnlockScNotify> Parser
		{
			get
			{
				return AlleyShipUnlockScNotify._parser;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001234B File Offset: 0x0001054B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyShipUnlockScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001235D File Offset: 0x0001055D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyShipUnlockScNotify.Descriptor;
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00012364 File Offset: 0x00010564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUnlockScNotify()
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001236C File Offset: 0x0001056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUnlockScNotify(AlleyShipUnlockScNotify other) : this()
		{
			this.lGPGIHKJFPA_ = other.lGPGIHKJFPA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00012391 File Offset: 0x00010591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipUnlockScNotify Clone()
		{
			return new AlleyShipUnlockScNotify(this);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00012399 File Offset: 0x00010599
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x000123A1 File Offset: 0x000105A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGPGIHKJFPA
		{
			get
			{
				return this.lGPGIHKJFPA_;
			}
			set
			{
				this.lGPGIHKJFPA_ = value;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000123AA File Offset: 0x000105AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyShipUnlockScNotify);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000123B8 File Offset: 0x000105B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyShipUnlockScNotify other)
		{
			return other != null && (other == this || (this.LGPGIHKJFPA == other.LGPGIHKJFPA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000123E8 File Offset: 0x000105E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LGPGIHKJFPA != 0U)
			{
				num ^= this.LGPGIHKJFPA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00012427 File Offset: 0x00010627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001242F File Offset: 0x0001062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00012438 File Offset: 0x00010638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LGPGIHKJFPA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LGPGIHKJFPA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001246C File Offset: 0x0001066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LGPGIHKJFPA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGPGIHKJFPA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000124AA File Offset: 0x000106AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyShipUnlockScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LGPGIHKJFPA != 0U)
			{
				this.LGPGIHKJFPA = other.LGPGIHKJFPA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000124DB File Offset: 0x000106DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000124E4 File Offset: 0x000106E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LGPGIHKJFPA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000260 RID: 608
		private static readonly MessageParser<AlleyShipUnlockScNotify> _parser = new MessageParser<AlleyShipUnlockScNotify>(() => new AlleyShipUnlockScNotify());

		// Token: 0x04000261 RID: 609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000262 RID: 610
		public const int LGPGIHKJFPAFieldNumber = 12;

		// Token: 0x04000263 RID: 611
		private uint lGPGIHKJFPA_;
	}
}
