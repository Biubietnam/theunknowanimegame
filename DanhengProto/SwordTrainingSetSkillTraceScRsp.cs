using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200124B RID: 4683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingSetSkillTraceScRsp : IMessage<SwordTrainingSetSkillTraceScRsp>, IMessage, IEquatable<SwordTrainingSetSkillTraceScRsp>, IDeepCloneable<SwordTrainingSetSkillTraceScRsp>, IBufferMessage
	{
		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600D120 RID: 53536 RVA: 0x0022F85D File Offset: 0x0022DA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingSetSkillTraceScRsp> Parser
		{
			get
			{
				return SwordTrainingSetSkillTraceScRsp._parser;
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600D121 RID: 53537 RVA: 0x0022F864 File Offset: 0x0022DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingSetSkillTraceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600D122 RID: 53538 RVA: 0x0022F876 File Offset: 0x0022DA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingSetSkillTraceScRsp.Descriptor;
			}
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x0022F87D File Offset: 0x0022DA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceScRsp()
		{
		}

		// Token: 0x0600D124 RID: 53540 RVA: 0x0022F885 File Offset: 0x0022DA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceScRsp(SwordTrainingSetSkillTraceScRsp other) : this()
		{
			this.skillId_ = other.skillId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D125 RID: 53541 RVA: 0x0022F8B6 File Offset: 0x0022DAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceScRsp Clone()
		{
			return new SwordTrainingSetSkillTraceScRsp(this);
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600D126 RID: 53542 RVA: 0x0022F8BE File Offset: 0x0022DABE
		// (set) Token: 0x0600D127 RID: 53543 RVA: 0x0022F8C6 File Offset: 0x0022DAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600D128 RID: 53544 RVA: 0x0022F8CF File Offset: 0x0022DACF
		// (set) Token: 0x0600D129 RID: 53545 RVA: 0x0022F8D7 File Offset: 0x0022DAD7
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

		// Token: 0x0600D12A RID: 53546 RVA: 0x0022F8E0 File Offset: 0x0022DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingSetSkillTraceScRsp);
		}

		// Token: 0x0600D12B RID: 53547 RVA: 0x0022F8EE File Offset: 0x0022DAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingSetSkillTraceScRsp other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x0022F92C File Offset: 0x0022DB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
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

		// Token: 0x0600D12D RID: 53549 RVA: 0x0022F984 File Offset: 0x0022DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D12E RID: 53550 RVA: 0x0022F98C File Offset: 0x0022DB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D12F RID: 53551 RVA: 0x0022F998 File Offset: 0x0022DB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D130 RID: 53552 RVA: 0x0022F9F4 File Offset: 0x0022DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
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

		// Token: 0x0600D131 RID: 53553 RVA: 0x0022FA4C File Offset: 0x0022DC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingSetSkillTraceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D132 RID: 53554 RVA: 0x0022FA9C File Offset: 0x0022DC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D133 RID: 53555 RVA: 0x0022FAA8 File Offset: 0x0022DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053F3 RID: 21491
		private static readonly MessageParser<SwordTrainingSetSkillTraceScRsp> _parser = new MessageParser<SwordTrainingSetSkillTraceScRsp>(() => new SwordTrainingSetSkillTraceScRsp());

		// Token: 0x040053F4 RID: 21492
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053F5 RID: 21493
		public const int SkillIdFieldNumber = 3;

		// Token: 0x040053F6 RID: 21494
		private uint skillId_;

		// Token: 0x040053F7 RID: 21495
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040053F8 RID: 21496
		private uint retcode_;
	}
}
