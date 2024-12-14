using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010AD RID: 4269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectInclinationTextScRsp : IMessage<SelectInclinationTextScRsp>, IMessage, IEquatable<SelectInclinationTextScRsp>, IDeepCloneable<SelectInclinationTextScRsp>, IBufferMessage
	{
		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x00200B79 File Offset: 0x001FED79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectInclinationTextScRsp> Parser
		{
			get
			{
				return SelectInclinationTextScRsp._parser;
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x00200B80 File Offset: 0x001FED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectInclinationTextScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600BE56 RID: 48726 RVA: 0x00200B92 File Offset: 0x001FED92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectInclinationTextScRsp.Descriptor;
			}
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x00200B99 File Offset: 0x001FED99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextScRsp()
		{
		}

		// Token: 0x0600BE58 RID: 48728 RVA: 0x00200BA1 File Offset: 0x001FEDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextScRsp(SelectInclinationTextScRsp other) : this()
		{
			this.talkSentenceId_ = other.talkSentenceId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x00200BD2 File Offset: 0x001FEDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectInclinationTextScRsp Clone()
		{
			return new SelectInclinationTextScRsp(this);
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600BE5A RID: 48730 RVA: 0x00200BDA File Offset: 0x001FEDDA
		// (set) Token: 0x0600BE5B RID: 48731 RVA: 0x00200BE2 File Offset: 0x001FEDE2
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

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x00200BEB File Offset: 0x001FEDEB
		// (set) Token: 0x0600BE5D RID: 48733 RVA: 0x00200BF3 File Offset: 0x001FEDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x00200BFC File Offset: 0x001FEDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectInclinationTextScRsp);
		}

		// Token: 0x0600BE5F RID: 48735 RVA: 0x00200C0A File Offset: 0x001FEE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectInclinationTextScRsp other)
		{
			return other != null && (other == this || (this.TalkSentenceId == other.TalkSentenceId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE60 RID: 48736 RVA: 0x00200C48 File Offset: 0x001FEE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkSentenceId != 0U)
			{
				num ^= this.TalkSentenceId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x00200CA0 File Offset: 0x001FEEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x00200CA8 File Offset: 0x001FEEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00200CB4 File Offset: 0x001FEEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.TalkSentenceId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.TalkSentenceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x00200D10 File Offset: 0x001FEF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkSentenceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkSentenceId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x00200D68 File Offset: 0x001FEF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectInclinationTextScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkSentenceId != 0U)
			{
				this.TalkSentenceId = other.TalkSentenceId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x00200DB8 File Offset: 0x001FEFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x00200DC4 File Offset: 0x001FEFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TalkSentenceId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D57 RID: 19799
		private static readonly MessageParser<SelectInclinationTextScRsp> _parser = new MessageParser<SelectInclinationTextScRsp>(() => new SelectInclinationTextScRsp());

		// Token: 0x04004D58 RID: 19800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D59 RID: 19801
		public const int TalkSentenceIdFieldNumber = 15;

		// Token: 0x04004D5A RID: 19802
		private uint talkSentenceId_;

		// Token: 0x04004D5B RID: 19803
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004D5C RID: 19804
		private uint retcode_;
	}
}
