using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D3 RID: 4819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeExpeditionRewardCsReq : IMessage<TakeExpeditionRewardCsReq>, IMessage, IEquatable<TakeExpeditionRewardCsReq>, IDeepCloneable<TakeExpeditionRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600D6F9 RID: 55033 RVA: 0x0023D568 File Offset: 0x0023B768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeExpeditionRewardCsReq> Parser
		{
			get
			{
				return TakeExpeditionRewardCsReq._parser;
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x0023D56F File Offset: 0x0023B76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeExpeditionRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600D6FB RID: 55035 RVA: 0x0023D581 File Offset: 0x0023B781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeExpeditionRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x0023D588 File Offset: 0x0023B788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardCsReq()
		{
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x0023D590 File Offset: 0x0023B790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardCsReq(TakeExpeditionRewardCsReq other) : this()
		{
			this.gLIEPFENPHH_ = other.gLIEPFENPHH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6FE RID: 55038 RVA: 0x0023D5B5 File Offset: 0x0023B7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeExpeditionRewardCsReq Clone()
		{
			return new TakeExpeditionRewardCsReq(this);
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600D6FF RID: 55039 RVA: 0x0023D5BD File Offset: 0x0023B7BD
		// (set) Token: 0x0600D700 RID: 55040 RVA: 0x0023D5C5 File Offset: 0x0023B7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GLIEPFENPHH
		{
			get
			{
				return this.gLIEPFENPHH_;
			}
			set
			{
				this.gLIEPFENPHH_ = value;
			}
		}

		// Token: 0x0600D701 RID: 55041 RVA: 0x0023D5CE File Offset: 0x0023B7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeExpeditionRewardCsReq);
		}

		// Token: 0x0600D702 RID: 55042 RVA: 0x0023D5DC File Offset: 0x0023B7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeExpeditionRewardCsReq other)
		{
			return other != null && (other == this || (this.GLIEPFENPHH == other.GLIEPFENPHH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D703 RID: 55043 RVA: 0x0023D60C File Offset: 0x0023B80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GLIEPFENPHH != 0U)
			{
				num ^= this.GLIEPFENPHH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D704 RID: 55044 RVA: 0x0023D64B File Offset: 0x0023B84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D705 RID: 55045 RVA: 0x0023D653 File Offset: 0x0023B853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D706 RID: 55046 RVA: 0x0023D65C File Offset: 0x0023B85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GLIEPFENPHH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GLIEPFENPHH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D707 RID: 55047 RVA: 0x0023D690 File Offset: 0x0023B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GLIEPFENPHH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLIEPFENPHH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x0023D6CE File Offset: 0x0023B8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeExpeditionRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GLIEPFENPHH != 0U)
			{
				this.GLIEPFENPHH = other.GLIEPFENPHH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D709 RID: 55049 RVA: 0x0023D6FF File Offset: 0x0023B8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D70A RID: 55050 RVA: 0x0023D708 File Offset: 0x0023B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GLIEPFENPHH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055D1 RID: 21969
		private static readonly MessageParser<TakeExpeditionRewardCsReq> _parser = new MessageParser<TakeExpeditionRewardCsReq>(() => new TakeExpeditionRewardCsReq());

		// Token: 0x040055D2 RID: 21970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D3 RID: 21971
		public const int GLIEPFENPHHFieldNumber = 11;

		// Token: 0x040055D4 RID: 21972
		private uint gLIEPFENPHH_;
	}
}
