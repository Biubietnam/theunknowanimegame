using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000147 RID: 327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyBpLevelCsReq : IMessage<BuyBpLevelCsReq>, IMessage, IEquatable<BuyBpLevelCsReq>, IDeepCloneable<BuyBpLevelCsReq>, IBufferMessage
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0002B568 File Offset: 0x00029768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyBpLevelCsReq> Parser
		{
			get
			{
				return BuyBpLevelCsReq._parser;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0002B56F File Offset: 0x0002976F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyBpLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0002B581 File Offset: 0x00029781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyBpLevelCsReq.Descriptor;
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002B588 File Offset: 0x00029788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelCsReq()
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002B590 File Offset: 0x00029790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelCsReq(BuyBpLevelCsReq other) : this()
		{
			this.bOBFIKDHBAG_ = other.bOBFIKDHBAG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002B5B5 File Offset: 0x000297B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyBpLevelCsReq Clone()
		{
			return new BuyBpLevelCsReq(this);
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0002B5BD File Offset: 0x000297BD
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0002B5C5 File Offset: 0x000297C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BOBFIKDHBAG
		{
			get
			{
				return this.bOBFIKDHBAG_;
			}
			set
			{
				this.bOBFIKDHBAG_ = value;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002B5CE File Offset: 0x000297CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyBpLevelCsReq);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002B5DC File Offset: 0x000297DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyBpLevelCsReq other)
		{
			return other != null && (other == this || (this.BOBFIKDHBAG == other.BOBFIKDHBAG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002B60C File Offset: 0x0002980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BOBFIKDHBAG != 0U)
			{
				num ^= this.BOBFIKDHBAG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0002B64B File Offset: 0x0002984B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0002B653 File Offset: 0x00029853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0002B65C File Offset: 0x0002985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BOBFIKDHBAG != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.BOBFIKDHBAG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0002B690 File Offset: 0x00029890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BOBFIKDHBAG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BOBFIKDHBAG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0002B6CE File Offset: 0x000298CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyBpLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BOBFIKDHBAG != 0U)
			{
				this.BOBFIKDHBAG = other.BOBFIKDHBAG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0002B6FF File Offset: 0x000298FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0002B708 File Offset: 0x00029908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BOBFIKDHBAG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000656 RID: 1622
		private static readonly MessageParser<BuyBpLevelCsReq> _parser = new MessageParser<BuyBpLevelCsReq>(() => new BuyBpLevelCsReq());

		// Token: 0x04000657 RID: 1623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000658 RID: 1624
		public const int BOBFIKDHBAGFieldNumber = 14;

		// Token: 0x04000659 RID: 1625
		private uint bOBFIKDHBAG_;
	}
}
