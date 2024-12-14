using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009EB RID: 2539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LCLJMJAFHOE : IMessage<LCLJMJAFHOE>, IMessage, IEquatable<LCLJMJAFHOE>, IDeepCloneable<LCLJMJAFHOE>, IBufferMessage
	{
		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x0012CA64 File Offset: 0x0012AC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LCLJMJAFHOE> Parser
		{
			get
			{
				return LCLJMJAFHOE._parser;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x0012CA6B File Offset: 0x0012AC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LCLJMJAFHOEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x0012CA7D File Offset: 0x0012AC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LCLJMJAFHOE.Descriptor;
			}
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x0012CA84 File Offset: 0x0012AC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCLJMJAFHOE()
		{
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x0012CA8C File Offset: 0x0012AC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCLJMJAFHOE(LCLJMJAFHOE other) : this()
		{
			this.gFFCKCINHHP_ = other.gFFCKCINHHP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x0012CAB1 File Offset: 0x0012ACB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCLJMJAFHOE Clone()
		{
			return new LCLJMJAFHOE(this);
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x0012CAB9 File Offset: 0x0012ACB9
		// (set) Token: 0x060070C6 RID: 28870 RVA: 0x0012CAC1 File Offset: 0x0012ACC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFFCKCINHHP
		{
			get
			{
				return this.gFFCKCINHHP_;
			}
			set
			{
				this.gFFCKCINHHP_ = value;
			}
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x0012CACA File Offset: 0x0012ACCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LCLJMJAFHOE);
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x0012CAD8 File Offset: 0x0012ACD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LCLJMJAFHOE other)
		{
			return other != null && (other == this || (this.GFFCKCINHHP == other.GFFCKCINHHP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x0012CB08 File Offset: 0x0012AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GFFCKCINHHP != 0U)
			{
				num ^= this.GFFCKCINHHP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x0012CB47 File Offset: 0x0012AD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x0012CB4F File Offset: 0x0012AD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x0012CB58 File Offset: 0x0012AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GFFCKCINHHP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GFFCKCINHHP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x0012CB8C File Offset: 0x0012AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GFFCKCINHHP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFFCKCINHHP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x0012CBCA File Offset: 0x0012ADCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LCLJMJAFHOE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GFFCKCINHHP != 0U)
			{
				this.GFFCKCINHHP = other.GFFCKCINHHP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x0012CBFB File Offset: 0x0012ADFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x0012CC04 File Offset: 0x0012AE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GFFCKCINHHP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B7A RID: 11130
		private static readonly MessageParser<LCLJMJAFHOE> _parser = new MessageParser<LCLJMJAFHOE>(() => new LCLJMJAFHOE());

		// Token: 0x04002B7B RID: 11131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B7C RID: 11132
		public const int GFFCKCINHHPFieldNumber = 1;

		// Token: 0x04002B7D RID: 11133
		private uint gFFCKCINHHP_;
	}
}
