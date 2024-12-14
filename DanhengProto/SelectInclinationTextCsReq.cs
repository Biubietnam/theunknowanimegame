using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010AB RID: 4267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectInclinationTextCsReq : IMessage<SelectInclinationTextCsReq>, IMessage, IEquatable<SelectInclinationTextCsReq>, IDeepCloneable<SelectInclinationTextCsReq>, IBufferMessage
	{
		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x002008FC File Offset: 0x001FEAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectInclinationTextCsReq> Parser
		{
			get
			{
				return SelectInclinationTextCsReq._parser;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600BE40 RID: 48704 RVA: 0x00200903 File Offset: 0x001FEB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectInclinationTextCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x00200915 File Offset: 0x001FEB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectInclinationTextCsReq.Descriptor;
			}
		}

		// Token: 0x0600BE42 RID: 48706 RVA: 0x0020091C File Offset: 0x001FEB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextCsReq()
		{
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x00200924 File Offset: 0x001FEB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextCsReq(SelectInclinationTextCsReq other) : this()
		{
			this.talkSentenceId_ = other.talkSentenceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x00200949 File Offset: 0x001FEB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextCsReq Clone()
		{
			return new SelectInclinationTextCsReq(this);
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x00200951 File Offset: 0x001FEB51
		// (set) Token: 0x0600BE46 RID: 48710 RVA: 0x00200959 File Offset: 0x001FEB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalkSentenceId
		{
			get
			{
				return this.talkSentenceId_;
			}
			set
			{
				this.talkSentenceId_ = value;
			}
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x00200962 File Offset: 0x001FEB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectInclinationTextCsReq);
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x00200970 File Offset: 0x001FEB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectInclinationTextCsReq other)
		{
			return other != null && (other == this || (this.TalkSentenceId == other.TalkSentenceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x002009A0 File Offset: 0x001FEBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkSentenceId != 0U)
			{
				num ^= this.TalkSentenceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x002009DF File Offset: 0x001FEBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x002009E7 File Offset: 0x001FEBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x002009F0 File Offset: 0x001FEBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalkSentenceId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.TalkSentenceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x00200A24 File Offset: 0x001FEC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkSentenceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkSentenceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE4E RID: 48718 RVA: 0x00200A62 File Offset: 0x001FEC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectInclinationTextCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkSentenceId != 0U)
			{
				this.TalkSentenceId = other.TalkSentenceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x00200A93 File Offset: 0x001FEC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE50 RID: 48720 RVA: 0x00200A9C File Offset: 0x001FEC9C
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
					this.TalkSentenceId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D52 RID: 19794
		private static readonly MessageParser<SelectInclinationTextCsReq> _parser = new MessageParser<SelectInclinationTextCsReq>(() => new SelectInclinationTextCsReq());

		// Token: 0x04004D53 RID: 19795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D54 RID: 19796
		public const int TalkSentenceIdFieldNumber = 13;

		// Token: 0x04004D55 RID: 19797
		private uint talkSentenceId_;
	}
}
