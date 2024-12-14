using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FFD RID: 4093
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournReEnterRogueCocoonStageCsReq : IMessage<RogueTournReEnterRogueCocoonStageCsReq>, IMessage, IEquatable<RogueTournReEnterRogueCocoonStageCsReq>, IDeepCloneable<RogueTournReEnterRogueCocoonStageCsReq>, IBufferMessage
	{
		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x001E8C95 File Offset: 0x001E6E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournReEnterRogueCocoonStageCsReq> Parser
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageCsReq._parser;
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600B61F RID: 46623 RVA: 0x001E8C9C File Offset: 0x001E6E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600B620 RID: 46624 RVA: 0x001E8CAE File Offset: 0x001E6EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournReEnterRogueCocoonStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x001E8CB5 File Offset: 0x001E6EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageCsReq()
		{
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x001E8CBD File Offset: 0x001E6EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageCsReq(RogueTournReEnterRogueCocoonStageCsReq other) : this()
		{
			this.hODGFGACFKC_ = other.hODGFGACFKC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x001E8CE2 File Offset: 0x001E6EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReEnterRogueCocoonStageCsReq Clone()
		{
			return new RogueTournReEnterRogueCocoonStageCsReq(this);
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x001E8CEA File Offset: 0x001E6EEA
		// (set) Token: 0x0600B625 RID: 46629 RVA: 0x001E8CF2 File Offset: 0x001E6EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HODGFGACFKC
		{
			get
			{
				return this.hODGFGACFKC_;
			}
			set
			{
				this.hODGFGACFKC_ = value;
			}
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x001E8CFB File Offset: 0x001E6EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournReEnterRogueCocoonStageCsReq);
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x001E8D09 File Offset: 0x001E6F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournReEnterRogueCocoonStageCsReq other)
		{
			return other != null && (other == this || (this.HODGFGACFKC == other.HODGFGACFKC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x001E8D38 File Offset: 0x001E6F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HODGFGACFKC)
			{
				num ^= this.HODGFGACFKC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x001E8D77 File Offset: 0x001E6F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x001E8D7F File Offset: 0x001E6F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x001E8D88 File Offset: 0x001E6F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HODGFGACFKC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HODGFGACFKC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x001E8DBC File Offset: 0x001E6FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HODGFGACFKC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x001E8DEE File Offset: 0x001E6FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournReEnterRogueCocoonStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HODGFGACFKC)
			{
				this.HODGFGACFKC = other.HODGFGACFKC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x001E8E1F File Offset: 0x001E701F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x001E8E28 File Offset: 0x001E7028
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
					this.HODGFGACFKC = input.ReadBool();
				}
			}
		}

		// Token: 0x040049D6 RID: 18902
		private static readonly MessageParser<RogueTournReEnterRogueCocoonStageCsReq> _parser = new MessageParser<RogueTournReEnterRogueCocoonStageCsReq>(() => new RogueTournReEnterRogueCocoonStageCsReq());

		// Token: 0x040049D7 RID: 18903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D8 RID: 18904
		public const int HODGFGACFKCFieldNumber = 5;

		// Token: 0x040049D9 RID: 18905
		private bool hODGFGACFKC_;
	}
}
