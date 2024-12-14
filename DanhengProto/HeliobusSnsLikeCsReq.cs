using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008CB RID: 2251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsLikeCsReq : IMessage<HeliobusSnsLikeCsReq>, IMessage, IEquatable<HeliobusSnsLikeCsReq>, IDeepCloneable<HeliobusSnsLikeCsReq>, IBufferMessage
	{
		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x0010CBB0 File Offset: 0x0010ADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsLikeCsReq> Parser
		{
			get
			{
				return HeliobusSnsLikeCsReq._parser;
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x0600645E RID: 25694 RVA: 0x0010CBB7 File Offset: 0x0010ADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsLikeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x0010CBC9 File Offset: 0x0010ADC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsLikeCsReq.Descriptor;
			}
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x0010CBD0 File Offset: 0x0010ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeCsReq()
		{
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x0010CBD8 File Offset: 0x0010ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeCsReq(HeliobusSnsLikeCsReq other) : this()
		{
			this.aLAOMAOBNFG_ = other.aLAOMAOBNFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x0010CBFD File Offset: 0x0010ADFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsLikeCsReq Clone()
		{
			return new HeliobusSnsLikeCsReq(this);
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06006463 RID: 25699 RVA: 0x0010CC05 File Offset: 0x0010AE05
		// (set) Token: 0x06006464 RID: 25700 RVA: 0x0010CC0D File Offset: 0x0010AE0D
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

		// Token: 0x06006465 RID: 25701 RVA: 0x0010CC16 File Offset: 0x0010AE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsLikeCsReq);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x0010CC24 File Offset: 0x0010AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsLikeCsReq other)
		{
			return other != null && (other == this || (this.ALAOMAOBNFG == other.ALAOMAOBNFG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x0010CC54 File Offset: 0x0010AE54
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

		// Token: 0x06006468 RID: 25704 RVA: 0x0010CC93 File Offset: 0x0010AE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x0010CC9B File Offset: 0x0010AE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x0010CCA4 File Offset: 0x0010AEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALAOMAOBNFG != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ALAOMAOBNFG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x0010CCD8 File Offset: 0x0010AED8
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

		// Token: 0x0600646C RID: 25708 RVA: 0x0010CD16 File Offset: 0x0010AF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsLikeCsReq other)
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

		// Token: 0x0600646D RID: 25709 RVA: 0x0010CD47 File Offset: 0x0010AF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0010CD50 File Offset: 0x0010AF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ALAOMAOBNFG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026AA RID: 9898
		private static readonly MessageParser<HeliobusSnsLikeCsReq> _parser = new MessageParser<HeliobusSnsLikeCsReq>(() => new HeliobusSnsLikeCsReq());

		// Token: 0x040026AB RID: 9899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026AC RID: 9900
		public const int ALAOMAOBNFGFieldNumber = 15;

		// Token: 0x040026AD RID: 9901
		private uint aLAOMAOBNFG_;
	}
}
