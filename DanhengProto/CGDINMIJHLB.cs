using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000189 RID: 393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CGDINMIJHLB : IMessage<CGDINMIJHLB>, IMessage, IEquatable<CGDINMIJHLB>, IDeepCloneable<CGDINMIJHLB>, IBufferMessage
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0003280C File Offset: 0x00030A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CGDINMIJHLB> Parser
		{
			get
			{
				return CGDINMIJHLB._parser;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00032813 File Offset: 0x00030A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CGDINMIJHLBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00032825 File Offset: 0x00030A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CGDINMIJHLB.Descriptor;
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0003282C File Offset: 0x00030A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGDINMIJHLB()
		{
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00032834 File Offset: 0x00030A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGDINMIJHLB(CGDINMIJHLB other) : this()
		{
			this.iIBPNCFLANN_ = other.iIBPNCFLANN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00032859 File Offset: 0x00030A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGDINMIJHLB Clone()
		{
			return new CGDINMIJHLB(this);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00032861 File Offset: 0x00030A61
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x00032869 File Offset: 0x00030A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IIBPNCFLANN
		{
			get
			{
				return this.iIBPNCFLANN_;
			}
			set
			{
				this.iIBPNCFLANN_ = value;
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00032872 File Offset: 0x00030A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CGDINMIJHLB);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00032880 File Offset: 0x00030A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CGDINMIJHLB other)
		{
			return other != null && (other == this || (this.IIBPNCFLANN == other.IIBPNCFLANN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000328B0 File Offset: 0x00030AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IIBPNCFLANN != 0U)
			{
				num ^= this.IIBPNCFLANN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000328EF File Offset: 0x00030AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000328F7 File Offset: 0x00030AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00032900 File Offset: 0x00030B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IIBPNCFLANN != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.IIBPNCFLANN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00032934 File Offset: 0x00030B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IIBPNCFLANN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IIBPNCFLANN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00032972 File Offset: 0x00030B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CGDINMIJHLB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IIBPNCFLANN != 0U)
			{
				this.IIBPNCFLANN = other.IIBPNCFLANN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000329A3 File Offset: 0x00030BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000329AC File Offset: 0x00030BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IIBPNCFLANN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400075E RID: 1886
		private static readonly MessageParser<CGDINMIJHLB> _parser = new MessageParser<CGDINMIJHLB>(() => new CGDINMIJHLB());

		// Token: 0x0400075F RID: 1887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000760 RID: 1888
		public const int IIBPNCFLANNFieldNumber = 13;

		// Token: 0x04000761 RID: 1889
		private uint iIBPNCFLANN_;
	}
}
