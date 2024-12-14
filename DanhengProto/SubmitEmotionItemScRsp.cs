using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F9 RID: 4601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitEmotionItemScRsp : IMessage<SubmitEmotionItemScRsp>, IMessage, IEquatable<SubmitEmotionItemScRsp>, IDeepCloneable<SubmitEmotionItemScRsp>, IBufferMessage
	{
		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600CDA6 RID: 52646 RVA: 0x00227F78 File Offset: 0x00226178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitEmotionItemScRsp> Parser
		{
			get
			{
				return SubmitEmotionItemScRsp._parser;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600CDA7 RID: 52647 RVA: 0x00227F7F File Offset: 0x0022617F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitEmotionItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600CDA8 RID: 52648 RVA: 0x00227F91 File Offset: 0x00226191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitEmotionItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600CDA9 RID: 52649 RVA: 0x00227F98 File Offset: 0x00226198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemScRsp()
		{
		}

		// Token: 0x0600CDAA RID: 52650 RVA: 0x00227FA0 File Offset: 0x002261A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemScRsp(SubmitEmotionItemScRsp other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x00227FD1 File Offset: 0x002261D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitEmotionItemScRsp Clone()
		{
			return new SubmitEmotionItemScRsp(this);
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600CDAC RID: 52652 RVA: 0x00227FD9 File Offset: 0x002261D9
		// (set) Token: 0x0600CDAD RID: 52653 RVA: 0x00227FE1 File Offset: 0x002261E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600CDAE RID: 52654 RVA: 0x00227FEA File Offset: 0x002261EA
		// (set) Token: 0x0600CDAF RID: 52655 RVA: 0x00227FF2 File Offset: 0x002261F2
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

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x00227FFB File Offset: 0x002261FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitEmotionItemScRsp);
		}

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x00228009 File Offset: 0x00226209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitEmotionItemScRsp other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x00228048 File Offset: 0x00226248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
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

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x002280A0 File Offset: 0x002262A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x002280A8 File Offset: 0x002262A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x002280B4 File Offset: 0x002262B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x00228110 File Offset: 0x00226310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
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

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x00228168 File Offset: 0x00226368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitEmotionItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x002281B8 File Offset: 0x002263B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x002281C4 File Offset: 0x002263C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ScriptId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040052EC RID: 21228
		private static readonly MessageParser<SubmitEmotionItemScRsp> _parser = new MessageParser<SubmitEmotionItemScRsp>(() => new SubmitEmotionItemScRsp());

		// Token: 0x040052ED RID: 21229
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052EE RID: 21230
		public const int ScriptIdFieldNumber = 7;

		// Token: 0x040052EF RID: 21231
		private uint scriptId_;

		// Token: 0x040052F0 RID: 21232
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040052F1 RID: 21233
		private uint retcode_;
	}
}
