using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C9 RID: 969
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DOGNBLOFDOL : IMessage<DOGNBLOFDOL>, IMessage, IEquatable<DOGNBLOFDOL>, IDeepCloneable<DOGNBLOFDOL>, IBufferMessage
	{
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00078634 File Offset: 0x00076834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DOGNBLOFDOL> Parser
		{
			get
			{
				return DOGNBLOFDOL._parser;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0007863B File Offset: 0x0007683B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DOGNBLOFDOLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x0007864D File Offset: 0x0007684D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DOGNBLOFDOL.Descriptor;
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00078654 File Offset: 0x00076854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DOGNBLOFDOL()
		{
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0007865C File Offset: 0x0007685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DOGNBLOFDOL(DOGNBLOFDOL other) : this()
		{
			this.fHIIAIICGPP_ = other.fHIIAIICGPP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00078681 File Offset: 0x00076881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DOGNBLOFDOL Clone()
		{
			return new DOGNBLOFDOL(this);
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x00078689 File Offset: 0x00076889
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x00078691 File Offset: 0x00076891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FHIIAIICGPP
		{
			get
			{
				return this.fHIIAIICGPP_;
			}
			set
			{
				this.fHIIAIICGPP_ = value;
			}
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0007869A File Offset: 0x0007689A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DOGNBLOFDOL);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000786A8 File Offset: 0x000768A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DOGNBLOFDOL other)
		{
			return other != null && (other == this || (this.FHIIAIICGPP == other.FHIIAIICGPP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000786D8 File Offset: 0x000768D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FHIIAIICGPP != 0U)
			{
				num ^= this.FHIIAIICGPP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00078717 File Offset: 0x00076917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x0007871F File Offset: 0x0007691F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00078728 File Offset: 0x00076928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FHIIAIICGPP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FHIIAIICGPP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0007875C File Offset: 0x0007695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FHIIAIICGPP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FHIIAIICGPP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0007879A File Offset: 0x0007699A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DOGNBLOFDOL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FHIIAIICGPP != 0U)
			{
				this.FHIIAIICGPP = other.FHIIAIICGPP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000787CB File Offset: 0x000769CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000787D4 File Offset: 0x000769D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FHIIAIICGPP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001189 RID: 4489
		private static readonly MessageParser<DOGNBLOFDOL> _parser = new MessageParser<DOGNBLOFDOL>(() => new DOGNBLOFDOL());

		// Token: 0x0400118A RID: 4490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400118B RID: 4491
		public const int FHIIAIICGPPFieldNumber = 10;

		// Token: 0x0400118C RID: 4492
		private uint fHIIAIICGPP_;
	}
}
