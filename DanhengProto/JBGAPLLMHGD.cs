using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000955 RID: 2389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JBGAPLLMHGD : IMessage<JBGAPLLMHGD>, IMessage, IEquatable<JBGAPLLMHGD>, IDeepCloneable<JBGAPLLMHGD>, IBufferMessage
	{
		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x0011C7F9 File Offset: 0x0011A9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JBGAPLLMHGD> Parser
		{
			get
			{
				return JBGAPLLMHGD._parser;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x0011C800 File Offset: 0x0011AA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JBGAPLLMHGDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x0011C812 File Offset: 0x0011AA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JBGAPLLMHGD.Descriptor;
			}
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x0011C819 File Offset: 0x0011AA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBGAPLLMHGD()
		{
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x0011C821 File Offset: 0x0011AA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBGAPLLMHGD(JBGAPLLMHGD other) : this()
		{
			this.iOAPPNCJJCJ_ = other.iOAPPNCJJCJ_;
			this.kDKBJACKELD_ = other.kDKBJACKELD_;
			this.oJCPEJFHEIP_ = other.oJCPEJFHEIP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x0011C85E File Offset: 0x0011AA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBGAPLLMHGD Clone()
		{
			return new JBGAPLLMHGD(this);
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06006AAF RID: 27311 RVA: 0x0011C866 File Offset: 0x0011AA66
		// (set) Token: 0x06006AB0 RID: 27312 RVA: 0x0011C86E File Offset: 0x0011AA6E
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

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x0011C877 File Offset: 0x0011AA77
		// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x0011C87F File Offset: 0x0011AA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPNAOEBBGHG KDKBJACKELD
		{
			get
			{
				return this.kDKBJACKELD_;
			}
			set
			{
				this.kDKBJACKELD_ = value;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x0011C888 File Offset: 0x0011AA88
		// (set) Token: 0x06006AB4 RID: 27316 RVA: 0x0011C890 File Offset: 0x0011AA90
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

		// Token: 0x06006AB5 RID: 27317 RVA: 0x0011C899 File Offset: 0x0011AA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JBGAPLLMHGD);
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x0011C8A8 File Offset: 0x0011AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JBGAPLLMHGD other)
		{
			return other != null && (other == this || (this.IOAPPNCJJCJ == other.IOAPPNCJJCJ && this.KDKBJACKELD == other.KDKBJACKELD && this.OJCPEJFHEIP == other.OJCPEJFHEIP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x0011C904 File Offset: 0x0011AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IOAPPNCJJCJ != 0U)
			{
				num ^= this.IOAPPNCJJCJ.GetHashCode();
			}
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				num ^= this.KDKBJACKELD.GetHashCode();
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

		// Token: 0x06006AB8 RID: 27320 RVA: 0x0011C97B File Offset: 0x0011AB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x0011C983 File Offset: 0x0011AB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x0011C98C File Offset: 0x0011AB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IOAPPNCJJCJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.IOAPPNCJJCJ);
			}
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.KDKBJACKELD);
			}
			if (this.OJCPEJFHEIP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OJCPEJFHEIP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0011CA04 File Offset: 0x0011AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IOAPPNCJJCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IOAPPNCJJCJ);
			}
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KDKBJACKELD);
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

		// Token: 0x06006ABC RID: 27324 RVA: 0x0011CA74 File Offset: 0x0011AC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JBGAPLLMHGD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IOAPPNCJJCJ != 0U)
			{
				this.IOAPPNCJJCJ = other.IOAPPNCJJCJ;
			}
			if (other.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				this.KDKBJACKELD = other.KDKBJACKELD;
			}
			if (other.OJCPEJFHEIP != 0U)
			{
				this.OJCPEJFHEIP = other.OJCPEJFHEIP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0011CAD8 File Offset: 0x0011ACD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0011CAE4 File Offset: 0x0011ACE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
					{
						if (num != 104U)
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
						this.KDKBJACKELD = (JPNAOEBBGHG)input.ReadEnum();
					}
				}
				else
				{
					this.IOAPPNCJJCJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040028D5 RID: 10453
		private static readonly MessageParser<JBGAPLLMHGD> _parser = new MessageParser<JBGAPLLMHGD>(() => new JBGAPLLMHGD());

		// Token: 0x040028D6 RID: 10454
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D7 RID: 10455
		public const int IOAPPNCJJCJFieldNumber = 6;

		// Token: 0x040028D8 RID: 10456
		private uint iOAPPNCJJCJ_;

		// Token: 0x040028D9 RID: 10457
		public const int KDKBJACKELDFieldNumber = 8;

		// Token: 0x040028DA RID: 10458
		private JPNAOEBBGHG kDKBJACKELD_;

		// Token: 0x040028DB RID: 10459
		public const int OJCPEJFHEIPFieldNumber = 13;

		// Token: 0x040028DC RID: 10460
		private uint oJCPEJFHEIP_;
	}
}
