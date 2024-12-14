using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D8D RID: 3469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReEnterLastElementStageCsReq : IMessage<ReEnterLastElementStageCsReq>, IMessage, IEquatable<ReEnterLastElementStageCsReq>, IDeepCloneable<ReEnterLastElementStageCsReq>, IBufferMessage
	{
		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x0019C074 File Offset: 0x0019A274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReEnterLastElementStageCsReq> Parser
		{
			get
			{
				return ReEnterLastElementStageCsReq._parser;
			}
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06009AE2 RID: 39650 RVA: 0x0019C07B File Offset: 0x0019A27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReEnterLastElementStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x0019C08D File Offset: 0x0019A28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReEnterLastElementStageCsReq.Descriptor;
			}
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x0019C094 File Offset: 0x0019A294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageCsReq()
		{
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x0019C09C File Offset: 0x0019A29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageCsReq(ReEnterLastElementStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x0019C0C1 File Offset: 0x0019A2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageCsReq Clone()
		{
			return new ReEnterLastElementStageCsReq(this);
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06009AE7 RID: 39655 RVA: 0x0019C0C9 File Offset: 0x0019A2C9
		// (set) Token: 0x06009AE8 RID: 39656 RVA: 0x0019C0D1 File Offset: 0x0019A2D1
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

		// Token: 0x06009AE9 RID: 39657 RVA: 0x0019C0DA File Offset: 0x0019A2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReEnterLastElementStageCsReq);
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x0019C0E8 File Offset: 0x0019A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReEnterLastElementStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x0019C118 File Offset: 0x0019A318
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

		// Token: 0x06009AEC RID: 39660 RVA: 0x0019C157 File Offset: 0x0019A357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x0019C15F File Offset: 0x0019A35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x0019C168 File Offset: 0x0019A368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x0019C19C File Offset: 0x0019A39C
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

		// Token: 0x06009AF0 RID: 39664 RVA: 0x0019C1DA File Offset: 0x0019A3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReEnterLastElementStageCsReq other)
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

		// Token: 0x06009AF1 RID: 39665 RVA: 0x0019C20B File Offset: 0x0019A40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x0019C214 File Offset: 0x0019A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003C19 RID: 15385
		private static readonly MessageParser<ReEnterLastElementStageCsReq> _parser = new MessageParser<ReEnterLastElementStageCsReq>(() => new ReEnterLastElementStageCsReq());

		// Token: 0x04003C1A RID: 15386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1B RID: 15387
		public const int StageIdFieldNumber = 10;

		// Token: 0x04003C1C RID: 15388
		private uint stageId_;
	}
}
