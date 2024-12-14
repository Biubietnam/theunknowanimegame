using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A03 RID: 2563
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveTrialActivityCsReq : IMessage<LeaveTrialActivityCsReq>, IMessage, IEquatable<LeaveTrialActivityCsReq>, IDeepCloneable<LeaveTrialActivityCsReq>, IBufferMessage
	{
		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x0012EBC8 File Offset: 0x0012CDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveTrialActivityCsReq> Parser
		{
			get
			{
				return LeaveTrialActivityCsReq._parser;
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x060071C2 RID: 29122 RVA: 0x0012EBCF File Offset: 0x0012CDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveTrialActivityCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x0012EBE1 File Offset: 0x0012CDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveTrialActivityCsReq.Descriptor;
			}
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x0012EBE8 File Offset: 0x0012CDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityCsReq()
		{
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x0012EBF0 File Offset: 0x0012CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityCsReq(LeaveTrialActivityCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x0012EC15 File Offset: 0x0012CE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveTrialActivityCsReq Clone()
		{
			return new LeaveTrialActivityCsReq(this);
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x0012EC1D File Offset: 0x0012CE1D
		// (set) Token: 0x060071C8 RID: 29128 RVA: 0x0012EC25 File Offset: 0x0012CE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x0012EC2E File Offset: 0x0012CE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveTrialActivityCsReq);
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x0012EC3C File Offset: 0x0012CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveTrialActivityCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x0012EC6C File Offset: 0x0012CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x0012ECAB File Offset: 0x0012CEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x0012ECB3 File Offset: 0x0012CEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x0012ECBC File Offset: 0x0012CEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x0012ECF0 File Offset: 0x0012CEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x0012ED2E File Offset: 0x0012CF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveTrialActivityCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x0012ED5F File Offset: 0x0012CF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x0012ED68 File Offset: 0x0012CF68
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
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002BBC RID: 11196
		private static readonly MessageParser<LeaveTrialActivityCsReq> _parser = new MessageParser<LeaveTrialActivityCsReq>(() => new LeaveTrialActivityCsReq());

		// Token: 0x04002BBD RID: 11197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BBE RID: 11198
		public const int StageIdFieldNumber = 15;

		// Token: 0x04002BBF RID: 11199
		private uint stageId_;
	}
}
