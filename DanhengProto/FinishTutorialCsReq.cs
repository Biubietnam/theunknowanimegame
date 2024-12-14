using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059F RID: 1439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTutorialCsReq : IMessage<FinishTutorialCsReq>, IMessage, IEquatable<FinishTutorialCsReq>, IDeepCloneable<FinishTutorialCsReq>, IBufferMessage
	{
		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600403B RID: 16443 RVA: 0x000AF04C File Offset: 0x000AD24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTutorialCsReq> Parser
		{
			get
			{
				return FinishTutorialCsReq._parser;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x000AF053 File Offset: 0x000AD253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTutorialCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x000AF065 File Offset: 0x000AD265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTutorialCsReq.Descriptor;
			}
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x000AF06C File Offset: 0x000AD26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialCsReq()
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x000AF074 File Offset: 0x000AD274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialCsReq(FinishTutorialCsReq other) : this()
		{
			this.tutorialId_ = other.tutorialId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x000AF099 File Offset: 0x000AD299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialCsReq Clone()
		{
			return new FinishTutorialCsReq(this);
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x000AF0A1 File Offset: 0x000AD2A1
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x000AF0A9 File Offset: 0x000AD2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TutorialId
		{
			get
			{
				return this.tutorialId_;
			}
			set
			{
				this.tutorialId_ = value;
			}
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x000AF0B2 File Offset: 0x000AD2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTutorialCsReq);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000AF0C0 File Offset: 0x000AD2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTutorialCsReq other)
		{
			return other != null && (other == this || (this.TutorialId == other.TutorialId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000AF0F0 File Offset: 0x000AD2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TutorialId != 0U)
			{
				num ^= this.TutorialId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x000AF12F File Offset: 0x000AD32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x000AF137 File Offset: 0x000AD337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x000AF140 File Offset: 0x000AD340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TutorialId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.TutorialId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x000AF174 File Offset: 0x000AD374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TutorialId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TutorialId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x000AF1B2 File Offset: 0x000AD3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTutorialCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TutorialId != 0U)
			{
				this.TutorialId = other.TutorialId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x000AF1E3 File Offset: 0x000AD3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x000AF1EC File Offset: 0x000AD3EC
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
					this.TutorialId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001984 RID: 6532
		private static readonly MessageParser<FinishTutorialCsReq> _parser = new MessageParser<FinishTutorialCsReq>(() => new FinishTutorialCsReq());

		// Token: 0x04001985 RID: 6533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001986 RID: 6534
		public const int TutorialIdFieldNumber = 5;

		// Token: 0x04001987 RID: 6535
		private uint tutorialId_;
	}
}
