using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047F RID: 1151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTrialActivityStageCsReq : IMessage<EnterTrialActivityStageCsReq>, IMessage, IEquatable<EnterTrialActivityStageCsReq>, IDeepCloneable<EnterTrialActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x0008CFD0 File Offset: 0x0008B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTrialActivityStageCsReq> Parser
		{
			get
			{
				return EnterTrialActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003346 RID: 13126 RVA: 0x0008CFD7 File Offset: 0x0008B1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTrialActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x0008CFE9 File Offset: 0x0008B1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTrialActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0008CFF0 File Offset: 0x0008B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageCsReq()
		{
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0008CFF8 File Offset: 0x0008B1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageCsReq(EnterTrialActivityStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0008D01D File Offset: 0x0008B21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageCsReq Clone()
		{
			return new EnterTrialActivityStageCsReq(this);
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x0008D025 File Offset: 0x0008B225
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x0008D02D File Offset: 0x0008B22D
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

		// Token: 0x0600334D RID: 13133 RVA: 0x0008D036 File Offset: 0x0008B236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTrialActivityStageCsReq);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0008D044 File Offset: 0x0008B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTrialActivityStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0008D074 File Offset: 0x0008B274
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

		// Token: 0x06003350 RID: 13136 RVA: 0x0008D0B3 File Offset: 0x0008B2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0008D0BB File Offset: 0x0008B2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x0008D0C4 File Offset: 0x0008B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x0008D0F8 File Offset: 0x0008B2F8
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

		// Token: 0x06003354 RID: 13140 RVA: 0x0008D136 File Offset: 0x0008B336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTrialActivityStageCsReq other)
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

		// Token: 0x06003355 RID: 13141 RVA: 0x0008D167 File Offset: 0x0008B367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x0008D170 File Offset: 0x0008B370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001465 RID: 5221
		private static readonly MessageParser<EnterTrialActivityStageCsReq> _parser = new MessageParser<EnterTrialActivityStageCsReq>(() => new EnterTrialActivityStageCsReq());

		// Token: 0x04001466 RID: 5222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001467 RID: 5223
		public const int StageIdFieldNumber = 7;

		// Token: 0x04001468 RID: 5224
		private uint stageId_;
	}
}
