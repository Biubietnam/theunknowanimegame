using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A93 RID: 2707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkRelicFilterPlanScRsp : IMessage<MarkRelicFilterPlanScRsp>, IMessage, IEquatable<MarkRelicFilterPlanScRsp>, IDeepCloneable<MarkRelicFilterPlanScRsp>, IBufferMessage
	{
		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06007804 RID: 30724 RVA: 0x0013E24D File Offset: 0x0013C44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkRelicFilterPlanScRsp> Parser
		{
			get
			{
				return MarkRelicFilterPlanScRsp._parser;
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x0013E254 File Offset: 0x0013C454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x0013E266 File Offset: 0x0013C466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkRelicFilterPlanScRsp.Descriptor;
			}
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0013E26D File Offset: 0x0013C46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanScRsp()
		{
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x0013E280 File Offset: 0x0013C480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanScRsp(MarkRelicFilterPlanScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.slotIndexList_ = other.slotIndexList_.Clone();
			this.isMark_ = other.isMark_;
			this.isBatchOp_ = other.isBatchOp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x0013E2D9 File Offset: 0x0013C4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanScRsp Clone()
		{
			return new MarkRelicFilterPlanScRsp(this);
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x0013E2E1 File Offset: 0x0013C4E1
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x0013E2E9 File Offset: 0x0013C4E9
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

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x0013E2F2 File Offset: 0x0013C4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SlotIndexList
		{
			get
			{
				return this.slotIndexList_;
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x0600780D RID: 30733 RVA: 0x0013E2FA File Offset: 0x0013C4FA
		// (set) Token: 0x0600780E RID: 30734 RVA: 0x0013E302 File Offset: 0x0013C502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMark
		{
			get
			{
				return this.isMark_;
			}
			set
			{
				this.isMark_ = value;
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x0013E30B File Offset: 0x0013C50B
		// (set) Token: 0x06007810 RID: 30736 RVA: 0x0013E313 File Offset: 0x0013C513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBatchOp
		{
			get
			{
				return this.isBatchOp_;
			}
			set
			{
				this.isBatchOp_ = value;
			}
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x0013E31C File Offset: 0x0013C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkRelicFilterPlanScRsp);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x0013E32C File Offset: 0x0013C52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkRelicFilterPlanScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.slotIndexList_.Equals(other.slotIndexList_) && this.IsMark == other.IsMark && this.IsBatchOp == other.IsBatchOp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x0013E39C File Offset: 0x0013C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.slotIndexList_.GetHashCode();
			if (this.IsMark)
			{
				num ^= this.IsMark.GetHashCode();
			}
			if (this.IsBatchOp)
			{
				num ^= this.IsBatchOp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x0013E41B File Offset: 0x0013C61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x0013E423 File Offset: 0x0013C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x0013E42C File Offset: 0x0013C62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.slotIndexList_.WriteTo(ref output, MarkRelicFilterPlanScRsp._repeated_slotIndexList_codec);
			if (this.IsMark)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsMark);
			}
			if (this.IsBatchOp)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsBatchOp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x0013E4B4 File Offset: 0x0013C6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.slotIndexList_.CalculateSize(MarkRelicFilterPlanScRsp._repeated_slotIndexList_codec);
			if (this.IsMark)
			{
				num += 2;
			}
			if (this.IsBatchOp)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x0013E520 File Offset: 0x0013C720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkRelicFilterPlanScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.slotIndexList_.Add(other.slotIndexList_);
			if (other.IsMark)
			{
				this.IsMark = other.IsMark;
			}
			if (other.IsBatchOp)
			{
				this.IsBatchOp = other.IsBatchOp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x0013E595 File Offset: 0x0013C795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x0013E5A0 File Offset: 0x0013C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_43;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_43;
					}
					if (num == 64U)
					{
						this.IsMark = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.IsBatchOp = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_43:
				this.slotIndexList_.AddEntriesFrom(ref input, MarkRelicFilterPlanScRsp._repeated_slotIndexList_codec);
			}
		}

		// Token: 0x04002E0E RID: 11790
		private static readonly MessageParser<MarkRelicFilterPlanScRsp> _parser = new MessageParser<MarkRelicFilterPlanScRsp>(() => new MarkRelicFilterPlanScRsp());

		// Token: 0x04002E0F RID: 11791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E10 RID: 11792
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002E11 RID: 11793
		private uint retcode_;

		// Token: 0x04002E12 RID: 11794
		public const int SlotIndexListFieldNumber = 3;

		// Token: 0x04002E13 RID: 11795
		private static readonly FieldCodec<uint> _repeated_slotIndexList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002E14 RID: 11796
		private readonly RepeatedField<uint> slotIndexList_ = new RepeatedField<uint>();

		// Token: 0x04002E15 RID: 11797
		public const int IsMarkFieldNumber = 8;

		// Token: 0x04002E16 RID: 11798
		private bool isMark_;

		// Token: 0x04002E17 RID: 11799
		public const int IsBatchOpFieldNumber = 9;

		// Token: 0x04002E18 RID: 11800
		private bool isBatchOp_;
	}
}
