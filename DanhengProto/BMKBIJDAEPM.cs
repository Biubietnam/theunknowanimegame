using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000135 RID: 309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BMKBIJDAEPM : IMessage<BMKBIJDAEPM>, IMessage, IEquatable<BMKBIJDAEPM>, IDeepCloneable<BMKBIJDAEPM>, IBufferMessage
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00029758 File Offset: 0x00027958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BMKBIJDAEPM> Parser
		{
			get
			{
				return BMKBIJDAEPM._parser;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0002975F File Offset: 0x0002795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BMKBIJDAEPMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00029771 File Offset: 0x00027971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BMKBIJDAEPM.Descriptor;
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00029778 File Offset: 0x00027978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMKBIJDAEPM()
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00029780 File Offset: 0x00027980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMKBIJDAEPM(BMKBIJDAEPM other) : this()
		{
			this.iOAPPNCJJCJ_ = other.iOAPPNCJJCJ_;
			this.itemId_ = other.itemId_;
			this.oJCPEJFHEIP_ = other.oJCPEJFHEIP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000297BD File Offset: 0x000279BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMKBIJDAEPM Clone()
		{
			return new BMKBIJDAEPM(this);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000297C5 File Offset: 0x000279C5
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x000297CD File Offset: 0x000279CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IOAPPNCJJCJ
		{
			get
			{
				return this.iOAPPNCJJCJ_;
			}
			set
			{
				this.iOAPPNCJJCJ_ = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x000297D6 File Offset: 0x000279D6
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000297DE File Offset: 0x000279DE
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x000297E7 File Offset: 0x000279E7
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000297EF File Offset: 0x000279EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJCPEJFHEIP
		{
			get
			{
				return this.oJCPEJFHEIP_;
			}
			set
			{
				this.oJCPEJFHEIP_ = value;
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000297F8 File Offset: 0x000279F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BMKBIJDAEPM);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00029808 File Offset: 0x00027A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BMKBIJDAEPM other)
		{
			return other != null && (other == this || (this.IOAPPNCJJCJ == other.IOAPPNCJJCJ && this.ItemId == other.ItemId && this.OJCPEJFHEIP == other.OJCPEJFHEIP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00029864 File Offset: 0x00027A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IOAPPNCJJCJ != 0U)
			{
				num ^= this.IOAPPNCJJCJ.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.OJCPEJFHEIP != 0U)
			{
				num ^= this.OJCPEJFHEIP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000298D5 File Offset: 0x00027AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000298DD File Offset: 0x00027ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000298E8 File Offset: 0x00027AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ItemId);
			}
			if (this.IOAPPNCJJCJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.IOAPPNCJJCJ);
			}
			if (this.OJCPEJFHEIP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.OJCPEJFHEIP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0002995C File Offset: 0x00027B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IOAPPNCJJCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IOAPPNCJJCJ);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.OJCPEJFHEIP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJCPEJFHEIP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000299CC File Offset: 0x00027BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BMKBIJDAEPM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IOAPPNCJJCJ != 0U)
			{
				this.IOAPPNCJJCJ = other.IOAPPNCJJCJ;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.OJCPEJFHEIP != 0U)
			{
				this.OJCPEJFHEIP = other.OJCPEJFHEIP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00029A30 File Offset: 0x00027C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00029A3C File Offset: 0x00027C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OJCPEJFHEIP = input.ReadUInt32();
						}
					}
					else
					{
						this.IOAPPNCJJCJ = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000605 RID: 1541
		private static readonly MessageParser<BMKBIJDAEPM> _parser = new MessageParser<BMKBIJDAEPM>(() => new BMKBIJDAEPM());

		// Token: 0x04000606 RID: 1542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000607 RID: 1543
		public const int IOAPPNCJJCJFieldNumber = 12;

		// Token: 0x04000608 RID: 1544
		private uint iOAPPNCJJCJ_;

		// Token: 0x04000609 RID: 1545
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400060A RID: 1546
		private uint itemId_;

		// Token: 0x0400060B RID: 1547
		public const int OJCPEJFHEIPFieldNumber = 14;

		// Token: 0x0400060C RID: 1548
		private uint oJCPEJFHEIP_;
	}
}
