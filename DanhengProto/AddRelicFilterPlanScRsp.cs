using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000049 RID: 73
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddRelicFilterPlanScRsp : IMessage<AddRelicFilterPlanScRsp>, IMessage, IEquatable<AddRelicFilterPlanScRsp>, IDeepCloneable<AddRelicFilterPlanScRsp>, IBufferMessage
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00009141 File Offset: 0x00007341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddRelicFilterPlanScRsp> Parser
		{
			get
			{
				return AddRelicFilterPlanScRsp._parser;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00009148 File Offset: 0x00007348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000915A File Offset: 0x0000735A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRelicFilterPlanScRsp.Descriptor;
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00009161 File Offset: 0x00007361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanScRsp()
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000916C File Offset: 0x0000736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanScRsp(AddRelicFilterPlanScRsp other) : this()
		{
			this.plan_ = ((other.plan_ != null) ? other.plan_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000091B8 File Offset: 0x000073B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanScRsp Clone()
		{
			return new AddRelicFilterPlanScRsp(this);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000091C0 File Offset: 0x000073C0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000091C8 File Offset: 0x000073C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlan Plan
		{
			get
			{
				return this.plan_;
			}
			set
			{
				this.plan_ = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000091D1 File Offset: 0x000073D1
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000091D9 File Offset: 0x000073D9
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

		// Token: 0x060002EB RID: 747 RVA: 0x000091E2 File Offset: 0x000073E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRelicFilterPlanScRsp);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000091F0 File Offset: 0x000073F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddRelicFilterPlanScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Plan, other.Plan) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009240 File Offset: 0x00007440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.plan_ != null)
			{
				num ^= this.Plan.GetHashCode();
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

		// Token: 0x060002EE RID: 750 RVA: 0x00009295 File Offset: 0x00007495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000929D File Offset: 0x0000749D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000092A8 File Offset: 0x000074A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.plan_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Plan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00009304 File Offset: 0x00007504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.plan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Plan);
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0000935C File Offset: 0x0000755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddRelicFilterPlanScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.plan_ != null)
			{
				if (this.plan_ == null)
				{
					this.Plan = new RelicFilterPlan();
				}
				this.Plan.MergeFrom(other.Plan);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000093C4 File Offset: 0x000075C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000093D0 File Offset: 0x000075D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.plan_ == null)
						{
							this.Plan = new RelicFilterPlan();
						}
						input.ReadMessage(this.Plan);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly MessageParser<AddRelicFilterPlanScRsp> _parser = new MessageParser<AddRelicFilterPlanScRsp>(() => new AddRelicFilterPlanScRsp());

		// Token: 0x0400010A RID: 266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400010B RID: 267
		public const int PlanFieldNumber = 11;

		// Token: 0x0400010C RID: 268
		private RelicFilterPlan plan_;

		// Token: 0x0400010D RID: 269
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400010E RID: 270
		private uint retcode_;
	}
}
