using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AFB RID: 2811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MNEMPJMPPJE : IMessage<MNEMPJMPPJE>, IMessage, IEquatable<MNEMPJMPPJE>, IDeepCloneable<MNEMPJMPPJE>, IBufferMessage
	{
		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06007C5C RID: 31836 RVA: 0x001493BC File Offset: 0x001475BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MNEMPJMPPJE> Parser
		{
			get
			{
				return MNEMPJMPPJE._parser;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06007C5D RID: 31837 RVA: 0x001493C3 File Offset: 0x001475C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MNEMPJMPPJEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06007C5E RID: 31838 RVA: 0x001493D5 File Offset: 0x001475D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MNEMPJMPPJE.Descriptor;
			}
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x001493DC File Offset: 0x001475DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNEMPJMPPJE()
		{
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x001493E4 File Offset: 0x001475E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNEMPJMPPJE(MNEMPJMPPJE other) : this()
		{
			this.jDAKJMIGFFB_ = other.jDAKJMIGFFB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x00149409 File Offset: 0x00147609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNEMPJMPPJE Clone()
		{
			return new MNEMPJMPPJE(this);
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x00149411 File Offset: 0x00147611
		// (set) Token: 0x06007C63 RID: 31843 RVA: 0x00149419 File Offset: 0x00147619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JDAKJMIGFFB
		{
			get
			{
				return this.jDAKJMIGFFB_;
			}
			set
			{
				this.jDAKJMIGFFB_ = value;
			}
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00149422 File Offset: 0x00147622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MNEMPJMPPJE);
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x00149430 File Offset: 0x00147630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MNEMPJMPPJE other)
		{
			return other != null && (other == this || (this.JDAKJMIGFFB == other.JDAKJMIGFFB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x00149460 File Offset: 0x00147660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JDAKJMIGFFB != 0U)
			{
				num ^= this.JDAKJMIGFFB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x0014949F File Offset: 0x0014769F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x001494A7 File Offset: 0x001476A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x001494B0 File Offset: 0x001476B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JDAKJMIGFFB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.JDAKJMIGFFB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x001494E4 File Offset: 0x001476E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JDAKJMIGFFB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JDAKJMIGFFB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x00149522 File Offset: 0x00147722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MNEMPJMPPJE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JDAKJMIGFFB != 0U)
			{
				this.JDAKJMIGFFB = other.JDAKJMIGFFB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x00149553 File Offset: 0x00147753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x0014955C File Offset: 0x0014775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.JDAKJMIGFFB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002FCF RID: 12239
		private static readonly MessageParser<MNEMPJMPPJE> _parser = new MessageParser<MNEMPJMPPJE>(() => new MNEMPJMPPJE());

		// Token: 0x04002FD0 RID: 12240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD1 RID: 12241
		public const int JDAKJMIGFFBFieldNumber = 5;

		// Token: 0x04002FD2 RID: 12242
		private uint jDAKJMIGFFB_;
	}
}
