using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000885 RID: 2181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HACELJDPNIG : IMessage<HACELJDPNIG>, IMessage, IEquatable<HACELJDPNIG>, IDeepCloneable<HACELJDPNIG>, IBufferMessage
	{
		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x00100664 File Offset: 0x000FE864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HACELJDPNIG> Parser
		{
			get
			{
				return HACELJDPNIG._parser;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06006100 RID: 24832 RVA: 0x0010066B File Offset: 0x000FE86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HACELJDPNIGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x0010067D File Offset: 0x000FE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HACELJDPNIG.Descriptor;
			}
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x00100684 File Offset: 0x000FE884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HACELJDPNIG()
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x0010068C File Offset: 0x000FE88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HACELJDPNIG(HACELJDPNIG other) : this()
		{
			this.gMDKKGMAANA_ = other.gMDKKGMAANA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x001006B1 File Offset: 0x000FE8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HACELJDPNIG Clone()
		{
			return new HACELJDPNIG(this);
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x001006B9 File Offset: 0x000FE8B9
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x001006C1 File Offset: 0x000FE8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMDKKGMAANA
		{
			get
			{
				return this.gMDKKGMAANA_;
			}
			set
			{
				this.gMDKKGMAANA_ = value;
			}
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x001006CA File Offset: 0x000FE8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HACELJDPNIG);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x001006D8 File Offset: 0x000FE8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HACELJDPNIG other)
		{
			return other != null && (other == this || (this.GMDKKGMAANA == other.GMDKKGMAANA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00100708 File Offset: 0x000FE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GMDKKGMAANA != 0U)
			{
				num ^= this.GMDKKGMAANA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00100747 File Offset: 0x000FE947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x0010074F File Offset: 0x000FE94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x00100758 File Offset: 0x000FE958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GMDKKGMAANA != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GMDKKGMAANA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x0010078C File Offset: 0x000FE98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GMDKKGMAANA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMDKKGMAANA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x001007CA File Offset: 0x000FE9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HACELJDPNIG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GMDKKGMAANA != 0U)
			{
				this.GMDKKGMAANA = other.GMDKKGMAANA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x001007FB File Offset: 0x000FE9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00100804 File Offset: 0x000FEA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GMDKKGMAANA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002545 RID: 9541
		private static readonly MessageParser<HACELJDPNIG> _parser = new MessageParser<HACELJDPNIG>(() => new HACELJDPNIG());

		// Token: 0x04002546 RID: 9542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002547 RID: 9543
		public const int GMDKKGMAANAFieldNumber = 7;

		// Token: 0x04002548 RID: 9544
		private uint gMDKKGMAANA_;
	}
}
