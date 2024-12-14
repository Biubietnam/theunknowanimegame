using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000985 RID: 2437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JPPECDLFCEE : IMessage<JPPECDLFCEE>, IMessage, IEquatable<JPPECDLFCEE>, IDeepCloneable<JPPECDLFCEE>, IBufferMessage
	{
		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x00122CE7 File Offset: 0x00120EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JPPECDLFCEE> Parser
		{
			get
			{
				return JPPECDLFCEE._parser;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x00122CEE File Offset: 0x00120EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JPPECDLFCEEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06006CEB RID: 27883 RVA: 0x00122D00 File Offset: 0x00120F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JPPECDLFCEE.Descriptor;
			}
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00122D07 File Offset: 0x00120F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPPECDLFCEE()
		{
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00122D10 File Offset: 0x00120F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPPECDLFCEE(JPPECDLFCEE other) : this()
		{
			this.iOEDMMFMFJB_ = other.iOEDMMFMFJB_;
			this.bNHBCKBNKEL_ = ((other.bNHBCKBNKEL_ != null) ? other.bNHBCKBNKEL_.Clone() : null);
			this.jMCBJECBHOH_ = ((other.jMCBJECBHOH_ != null) ? other.jMCBJECBHOH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00122D78 File Offset: 0x00120F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPPECDLFCEE Clone()
		{
			return new JPPECDLFCEE(this);
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06006CEF RID: 27887 RVA: 0x00122D80 File Offset: 0x00120F80
		// (set) Token: 0x06006CF0 RID: 27888 RVA: 0x00122D88 File Offset: 0x00120F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IOEDMMFMFJB
		{
			get
			{
				return this.iOEDMMFMFJB_;
			}
			set
			{
				this.iOEDMMFMFJB_ = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06006CF1 RID: 27889 RVA: 0x00122D91 File Offset: 0x00120F91
		// (set) Token: 0x06006CF2 RID: 27890 RVA: 0x00122D99 File Offset: 0x00120F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO BNHBCKBNKEL
		{
			get
			{
				return this.bNHBCKBNKEL_;
			}
			set
			{
				this.bNHBCKBNKEL_ = value;
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06006CF3 RID: 27891 RVA: 0x00122DA2 File Offset: 0x00120FA2
		// (set) Token: 0x06006CF4 RID: 27892 RVA: 0x00122DAA File Offset: 0x00120FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LLEOAGKMAIO JMCBJECBHOH
		{
			get
			{
				return this.jMCBJECBHOH_;
			}
			set
			{
				this.jMCBJECBHOH_ = value;
			}
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00122DB3 File Offset: 0x00120FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JPPECDLFCEE);
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00122DC4 File Offset: 0x00120FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JPPECDLFCEE other)
		{
			return other != null && (other == this || (this.IOEDMMFMFJB == other.IOEDMMFMFJB && object.Equals(this.BNHBCKBNKEL, other.BNHBCKBNKEL) && object.Equals(this.JMCBJECBHOH, other.JMCBJECBHOH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00122E28 File Offset: 0x00121028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IOEDMMFMFJB)
			{
				num ^= this.IOEDMMFMFJB.GetHashCode();
			}
			if (this.bNHBCKBNKEL_ != null)
			{
				num ^= this.BNHBCKBNKEL.GetHashCode();
			}
			if (this.jMCBJECBHOH_ != null)
			{
				num ^= this.JMCBJECBHOH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00122E93 File Offset: 0x00121093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00122E9B File Offset: 0x0012109B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00122EA4 File Offset: 0x001210A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jMCBJECBHOH_ != null)
			{
				output.WriteRawTag(194, 33);
				output.WriteMessage(this.JMCBJECBHOH);
			}
			if (this.bNHBCKBNKEL_ != null)
			{
				output.WriteRawTag(210, 57);
				output.WriteMessage(this.BNHBCKBNKEL);
			}
			if (this.IOEDMMFMFJB)
			{
				output.WriteRawTag(240, 107);
				output.WriteBool(this.IOEDMMFMFJB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x00122F28 File Offset: 0x00121128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IOEDMMFMFJB)
			{
				num += 3;
			}
			if (this.bNHBCKBNKEL_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BNHBCKBNKEL);
			}
			if (this.jMCBJECBHOH_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JMCBJECBHOH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x00122F8C File Offset: 0x0012118C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JPPECDLFCEE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IOEDMMFMFJB)
			{
				this.IOEDMMFMFJB = other.IOEDMMFMFJB;
			}
			if (other.bNHBCKBNKEL_ != null)
			{
				if (this.bNHBCKBNKEL_ == null)
				{
					this.BNHBCKBNKEL = new LLEOAGKMAIO();
				}
				this.BNHBCKBNKEL.MergeFrom(other.BNHBCKBNKEL);
			}
			if (other.jMCBJECBHOH_ != null)
			{
				if (this.jMCBJECBHOH_ == null)
				{
					this.JMCBJECBHOH = new LLEOAGKMAIO();
				}
				this.JMCBJECBHOH.MergeFrom(other.JMCBJECBHOH);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x00123020 File Offset: 0x00121220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x0012302C File Offset: 0x0012122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 4290U)
				{
					if (num != 7378U)
					{
						if (num != 13808U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IOEDMMFMFJB = input.ReadBool();
						}
					}
					else
					{
						if (this.bNHBCKBNKEL_ == null)
						{
							this.BNHBCKBNKEL = new LLEOAGKMAIO();
						}
						input.ReadMessage(this.BNHBCKBNKEL);
					}
				}
				else
				{
					if (this.jMCBJECBHOH_ == null)
					{
						this.JMCBJECBHOH = new LLEOAGKMAIO();
					}
					input.ReadMessage(this.JMCBJECBHOH);
				}
			}
		}

		// Token: 0x040029C5 RID: 10693
		private static readonly MessageParser<JPPECDLFCEE> _parser = new MessageParser<JPPECDLFCEE>(() => new JPPECDLFCEE());

		// Token: 0x040029C6 RID: 10694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029C7 RID: 10695
		public const int IOEDMMFMFJBFieldNumber = 1726;

		// Token: 0x040029C8 RID: 10696
		private bool iOEDMMFMFJB_;

		// Token: 0x040029C9 RID: 10697
		public const int BNHBCKBNKELFieldNumber = 922;

		// Token: 0x040029CA RID: 10698
		private LLEOAGKMAIO bNHBCKBNKEL_;

		// Token: 0x040029CB RID: 10699
		public const int JMCBJECBHOHFieldNumber = 536;

		// Token: 0x040029CC RID: 10700
		private LLEOAGKMAIO jMCBJECBHOH_;
	}
}
