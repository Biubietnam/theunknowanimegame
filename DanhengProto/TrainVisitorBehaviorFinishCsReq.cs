using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001361 RID: 4961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrainVisitorBehaviorFinishCsReq : IMessage<TrainVisitorBehaviorFinishCsReq>, IMessage, IEquatable<TrainVisitorBehaviorFinishCsReq>, IDeepCloneable<TrainVisitorBehaviorFinishCsReq>, IBufferMessage
	{
		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600DD58 RID: 56664 RVA: 0x0024D398 File Offset: 0x0024B598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrainVisitorBehaviorFinishCsReq> Parser
		{
			get
			{
				return TrainVisitorBehaviorFinishCsReq._parser;
			}
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600DD59 RID: 56665 RVA: 0x0024D39F File Offset: 0x0024B59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrainVisitorBehaviorFinishCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600DD5A RID: 56666 RVA: 0x0024D3B1 File Offset: 0x0024B5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrainVisitorBehaviorFinishCsReq.Descriptor;
			}
		}

		// Token: 0x0600DD5B RID: 56667 RVA: 0x0024D3B8 File Offset: 0x0024B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishCsReq()
		{
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x0024D3C0 File Offset: 0x0024B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishCsReq(TrainVisitorBehaviorFinishCsReq other) : this()
		{
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x0024D3E5 File Offset: 0x0024B5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishCsReq Clone()
		{
			return new TrainVisitorBehaviorFinishCsReq(this);
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600DD5E RID: 56670 RVA: 0x0024D3ED File Offset: 0x0024B5ED
		// (set) Token: 0x0600DD5F RID: 56671 RVA: 0x0024D3F5 File Offset: 0x0024B5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x0024D3FE File Offset: 0x0024B5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrainVisitorBehaviorFinishCsReq);
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x0024D40C File Offset: 0x0024B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrainVisitorBehaviorFinishCsReq other)
		{
			return other != null && (other == this || (this.DJLKCHKMNMI == other.DJLKCHKMNMI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x0024D43C File Offset: 0x0024B63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x0024D47B File Offset: 0x0024B67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x0024D483 File Offset: 0x0024B683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD65 RID: 56677 RVA: 0x0024D48C File Offset: 0x0024B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD66 RID: 56678 RVA: 0x0024D4C0 File Offset: 0x0024B6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x0024D4FE File Offset: 0x0024B6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrainVisitorBehaviorFinishCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD68 RID: 56680 RVA: 0x0024D52F File Offset: 0x0024B72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD69 RID: 56681 RVA: 0x0024D538 File Offset: 0x0024B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DJLKCHKMNMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400580A RID: 22538
		private static readonly MessageParser<TrainVisitorBehaviorFinishCsReq> _parser = new MessageParser<TrainVisitorBehaviorFinishCsReq>(() => new TrainVisitorBehaviorFinishCsReq());

		// Token: 0x0400580B RID: 22539
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400580C RID: 22540
		public const int DJLKCHKMNMIFieldNumber = 3;

		// Token: 0x0400580D RID: 22541
		private uint dJLKCHKMNMI_;
	}
}
