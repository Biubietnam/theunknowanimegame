using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200035D RID: 861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DBIACBDCPHE : IMessage<DBIACBDCPHE>, IMessage, IEquatable<DBIACBDCPHE>, IDeepCloneable<DBIACBDCPHE>, IBufferMessage
	{
		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0006BE6E File Offset: 0x0006A06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DBIACBDCPHE> Parser
		{
			get
			{
				return DBIACBDCPHE._parser;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x0006BE75 File Offset: 0x0006A075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DBIACBDCPHEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0006BE87 File Offset: 0x0006A087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DBIACBDCPHE.Descriptor;
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0006BE8E File Offset: 0x0006A08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DBIACBDCPHE()
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0006BE96 File Offset: 0x0006A096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DBIACBDCPHE(DBIACBDCPHE other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0006BEAF File Offset: 0x0006A0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DBIACBDCPHE Clone()
		{
			return new DBIACBDCPHE(this);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0006BEB7 File Offset: 0x0006A0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DBIACBDCPHE);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0006BEC5 File Offset: 0x0006A0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DBIACBDCPHE other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0006BEE4 File Offset: 0x0006A0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0006BF0A File Offset: 0x0006A10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0006BF12 File Offset: 0x0006A112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0006BF1B File Offset: 0x0006A11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0006BF34 File Offset: 0x0006A134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0006BF5A File Offset: 0x0006A15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DBIACBDCPHE other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x0006BF77 File Offset: 0x0006A177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0006BF80 File Offset: 0x0006A180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F94 RID: 3988
		private static readonly MessageParser<DBIACBDCPHE> _parser = new MessageParser<DBIACBDCPHE>(() => new DBIACBDCPHE());

		// Token: 0x04000F95 RID: 3989
		private UnknownFieldSet _unknownFields;
	}
}
