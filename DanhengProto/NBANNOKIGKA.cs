using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BFD RID: 3069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NBANNOKIGKA : IMessage<NBANNOKIGKA>, IMessage, IEquatable<NBANNOKIGKA>, IDeepCloneable<NBANNOKIGKA>, IBufferMessage
	{
		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x060087DD RID: 34781 RVA: 0x00166D00 File Offset: 0x00164F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NBANNOKIGKA> Parser
		{
			get
			{
				return NBANNOKIGKA._parser;
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x060087DE RID: 34782 RVA: 0x00166D07 File Offset: 0x00164F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NBANNOKIGKAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x060087DF RID: 34783 RVA: 0x00166D19 File Offset: 0x00164F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NBANNOKIGKA.Descriptor;
			}
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00166D20 File Offset: 0x00164F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBANNOKIGKA()
		{
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x00166D28 File Offset: 0x00164F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBANNOKIGKA(NBANNOKIGKA other) : this()
		{
			this.fKMGINNCBOG_ = other.fKMGINNCBOG_;
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00166D59 File Offset: 0x00164F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBANNOKIGKA Clone()
		{
			return new NBANNOKIGKA(this);
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x060087E3 RID: 34787 RVA: 0x00166D61 File Offset: 0x00164F61
		// (set) Token: 0x060087E4 RID: 34788 RVA: 0x00166D69 File Offset: 0x00164F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FKMGINNCBOG
		{
			get
			{
				return this.fKMGINNCBOG_;
			}
			set
			{
				this.fKMGINNCBOG_ = value;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x060087E5 RID: 34789 RVA: 0x00166D72 File Offset: 0x00164F72
		// (set) Token: 0x060087E6 RID: 34790 RVA: 0x00166D7A File Offset: 0x00164F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LONLLBIHMID
		{
			get
			{
				return this.lONLLBIHMID_;
			}
			set
			{
				this.lONLLBIHMID_ = value;
			}
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00166D83 File Offset: 0x00164F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NBANNOKIGKA);
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00166D91 File Offset: 0x00164F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NBANNOKIGKA other)
		{
			return other != null && (other == this || (this.FKMGINNCBOG == other.FKMGINNCBOG && this.LONLLBIHMID == other.LONLLBIHMID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x00166DD0 File Offset: 0x00164FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FKMGINNCBOG != 0U)
			{
				num ^= this.FKMGINNCBOG.GetHashCode();
			}
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x00166E28 File Offset: 0x00165028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x00166E30 File Offset: 0x00165030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x00166E3C File Offset: 0x0016503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this.FKMGINNCBOG != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.FKMGINNCBOG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x00166E98 File Offset: 0x00165098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FKMGINNCBOG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FKMGINNCBOG);
			}
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00166EF0 File Offset: 0x001650F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NBANNOKIGKA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FKMGINNCBOG != 0U)
			{
				this.FKMGINNCBOG = other.FKMGINNCBOG;
			}
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x00166F40 File Offset: 0x00165140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x00166F4C File Offset: 0x0016514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FKMGINNCBOG = input.ReadUInt32();
					}
				}
				else
				{
					this.LONLLBIHMID = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400341D RID: 13341
		private static readonly MessageParser<NBANNOKIGKA> _parser = new MessageParser<NBANNOKIGKA>(() => new NBANNOKIGKA());

		// Token: 0x0400341E RID: 13342
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400341F RID: 13343
		public const int FKMGINNCBOGFieldNumber = 11;

		// Token: 0x04003420 RID: 13344
		private uint fKMGINNCBOG_;

		// Token: 0x04003421 RID: 13345
		public const int LONLLBIHMIDFieldNumber = 3;

		// Token: 0x04003422 RID: 13346
		private uint lONLLBIHMID_;
	}
}
