using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A1 RID: 1441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTutorialGuideCsReq : IMessage<FinishTutorialGuideCsReq>, IMessage, IEquatable<FinishTutorialGuideCsReq>, IDeepCloneable<FinishTutorialGuideCsReq>, IBufferMessage
	{
		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x000AF2BC File Offset: 0x000AD4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTutorialGuideCsReq> Parser
		{
			get
			{
				return FinishTutorialGuideCsReq._parser;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x000AF2C3 File Offset: 0x000AD4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTutorialGuideCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x000AF2D5 File Offset: 0x000AD4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTutorialGuideCsReq.Descriptor;
			}
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x000AF2DC File Offset: 0x000AD4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideCsReq()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x000AF2E4 File Offset: 0x000AD4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideCsReq(FinishTutorialGuideCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000AF309 File Offset: 0x000AD509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialGuideCsReq Clone()
		{
			return new FinishTutorialGuideCsReq(this);
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x000AF311 File Offset: 0x000AD511
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x000AF319 File Offset: 0x000AD519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x000AF322 File Offset: 0x000AD522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTutorialGuideCsReq);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000AF330 File Offset: 0x000AD530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTutorialGuideCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000AF360 File Offset: 0x000AD560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x000AF39F File Offset: 0x000AD59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x000AF3A7 File Offset: 0x000AD5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x000AF3B0 File Offset: 0x000AD5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x000AF3E4 File Offset: 0x000AD5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x000AF422 File Offset: 0x000AD622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTutorialGuideCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x000AF453 File Offset: 0x000AD653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x000AF45C File Offset: 0x000AD65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001989 RID: 6537
		private static readonly MessageParser<FinishTutorialGuideCsReq> _parser = new MessageParser<FinishTutorialGuideCsReq>(() => new FinishTutorialGuideCsReq());

		// Token: 0x0400198A RID: 6538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400198B RID: 6539
		public const int GroupIdFieldNumber = 4;

		// Token: 0x0400198C RID: 6540
		private uint groupId_;
	}
}
