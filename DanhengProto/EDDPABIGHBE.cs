using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003F1 RID: 1009
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EDDPABIGHBE : IMessage<EDDPABIGHBE>, IMessage, IEquatable<EDDPABIGHBE>, IDeepCloneable<EDDPABIGHBE>, IBufferMessage
	{
		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x0007C51D File Offset: 0x0007A71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EDDPABIGHBE> Parser
		{
			get
			{
				return EDDPABIGHBE._parser;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x0007C524 File Offset: 0x0007A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EDDPABIGHBEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x0007C536 File Offset: 0x0007A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EDDPABIGHBE.Descriptor;
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0007C53D File Offset: 0x0007A73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE()
		{
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0007C545 File Offset: 0x0007A745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE(EDDPABIGHBE other) : this()
		{
			this.bEOHFMDHHBI_ = other.bEOHFMDHHBI_;
			this.aCKCFBDNIPK_ = other.aCKCFBDNIPK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0007C576 File Offset: 0x0007A776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE Clone()
		{
			return new EDDPABIGHBE(this);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x0007C57E File Offset: 0x0007A77E
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x0007C586 File Offset: 0x0007A786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong BEOHFMDHHBI
		{
			get
			{
				return this.bEOHFMDHHBI_;
			}
			set
			{
				this.bEOHFMDHHBI_ = value;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x0007C58F File Offset: 0x0007A78F
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x0007C597 File Offset: 0x0007A797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightGameMode ACKCFBDNIPK
		{
			get
			{
				return this.aCKCFBDNIPK_;
			}
			set
			{
				this.aCKCFBDNIPK_ = value;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0007C5A0 File Offset: 0x0007A7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EDDPABIGHBE);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0007C5AE File Offset: 0x0007A7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EDDPABIGHBE other)
		{
			return other != null && (other == this || (this.BEOHFMDHHBI == other.BEOHFMDHHBI && this.ACKCFBDNIPK == other.ACKCFBDNIPK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BEOHFMDHHBI != 0UL)
			{
				num ^= this.BEOHFMDHHBI.GetHashCode();
			}
			if (this.ACKCFBDNIPK != FightGameMode.None)
			{
				num ^= this.ACKCFBDNIPK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0007C64A File Offset: 0x0007A84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0007C652 File Offset: 0x0007A852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0007C65C File Offset: 0x0007A85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BEOHFMDHHBI != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.BEOHFMDHHBI);
			}
			if (this.ACKCFBDNIPK != FightGameMode.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ACKCFBDNIPK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0007C6B4 File Offset: 0x0007A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BEOHFMDHHBI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.BEOHFMDHHBI);
			}
			if (this.ACKCFBDNIPK != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ACKCFBDNIPK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0007C70C File Offset: 0x0007A90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EDDPABIGHBE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BEOHFMDHHBI != 0UL)
			{
				this.BEOHFMDHHBI = other.BEOHFMDHHBI;
			}
			if (other.ACKCFBDNIPK != FightGameMode.None)
			{
				this.ACKCFBDNIPK = other.ACKCFBDNIPK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0007C75C File Offset: 0x0007A95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0007C768 File Offset: 0x0007A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ACKCFBDNIPK = (FightGameMode)input.ReadEnum();
					}
				}
				else
				{
					this.BEOHFMDHHBI = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001215 RID: 4629
		private static readonly MessageParser<EDDPABIGHBE> _parser = new MessageParser<EDDPABIGHBE>(() => new EDDPABIGHBE());

		// Token: 0x04001216 RID: 4630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001217 RID: 4631
		public const int BEOHFMDHHBIFieldNumber = 1;

		// Token: 0x04001218 RID: 4632
		private ulong bEOHFMDHHBI_;

		// Token: 0x04001219 RID: 4633
		public const int ACKCFBDNIPKFieldNumber = 2;

		// Token: 0x0400121A RID: 4634
		private FightGameMode aCKCFBDNIPK_;
	}
}
