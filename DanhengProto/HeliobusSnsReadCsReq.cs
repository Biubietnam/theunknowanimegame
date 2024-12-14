using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D3 RID: 2259
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsReadCsReq : IMessage<HeliobusSnsReadCsReq>, IMessage, IEquatable<HeliobusSnsReadCsReq>, IDeepCloneable<HeliobusSnsReadCsReq>, IBufferMessage
	{
		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x060064BB RID: 25787 RVA: 0x0010D98C File Offset: 0x0010BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsReadCsReq> Parser
		{
			get
			{
				return HeliobusSnsReadCsReq._parser;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x0010D993 File Offset: 0x0010BB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsReadCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x0010D9A5 File Offset: 0x0010BBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsReadCsReq.Descriptor;
			}
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x0010D9AC File Offset: 0x0010BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadCsReq()
		{
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x0010D9B4 File Offset: 0x0010BBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadCsReq(HeliobusSnsReadCsReq other) : this()
		{
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x0010D9D9 File Offset: 0x0010BBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsReadCsReq Clone()
		{
			return new HeliobusSnsReadCsReq(this);
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x0010D9E1 File Offset: 0x0010BBE1
		// (set) Token: 0x060064C2 RID: 25794 RVA: 0x0010D9E9 File Offset: 0x0010BBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALAOMAOBNFG
		{
			get
			{
				return this.aLAOMAOBNFG_;
			}
			set
			{
				this.aLAOMAOBNFG_ = value;
			}
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x0010D9F2 File Offset: 0x0010BBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsReadCsReq);
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x0010DA00 File Offset: 0x0010BC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsReadCsReq other)
		{
			return other != null && (other == this || (this.ALAOMAOBNFG == other.ALAOMAOBNFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x0010DA30 File Offset: 0x0010BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ALAOMAOBNFG != 0U)
			{
				num ^= this.ALAOMAOBNFG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0010DA6F File Offset: 0x0010BC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x0010DA77 File Offset: 0x0010BC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x0010DA80 File Offset: 0x0010BC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x0010DAB4 File Offset: 0x0010BCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ALAOMAOBNFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALAOMAOBNFG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x0010DAF2 File Offset: 0x0010BCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsReadCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ALAOMAOBNFG != 0U)
			{
				this.ALAOMAOBNFG = other.ALAOMAOBNFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x0010DB23 File Offset: 0x0010BD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x0010DB2C File Offset: 0x0010BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ALAOMAOBNFG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026C8 RID: 9928
		private static readonly MessageParser<HeliobusSnsReadCsReq> _parser = new MessageParser<HeliobusSnsReadCsReq>(() => new HeliobusSnsReadCsReq());

		// Token: 0x040026C9 RID: 9929
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CA RID: 9930
		public const int ALAOMAOBNFGFieldNumber = 4;

		// Token: 0x040026CB RID: 9931
		private uint aLAOMAOBNFG_;
	}
}
