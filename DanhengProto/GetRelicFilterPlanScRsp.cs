using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000797 RID: 1943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRelicFilterPlanScRsp : IMessage<GetRelicFilterPlanScRsp>, IMessage, IEquatable<GetRelicFilterPlanScRsp>, IDeepCloneable<GetRelicFilterPlanScRsp>, IBufferMessage
	{
		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x000E87F7 File Offset: 0x000E69F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRelicFilterPlanScRsp> Parser
		{
			get
			{
				return GetRelicFilterPlanScRsp._parser;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060056BF RID: 22207 RVA: 0x000E87FE File Offset: 0x000E69FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x000E8810 File Offset: 0x000E6A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRelicFilterPlanScRsp.Descriptor;
			}
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x000E8817 File Offset: 0x000E6A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanScRsp()
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x000E882A File Offset: 0x000E6A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanScRsp(GetRelicFilterPlanScRsp other) : this()
		{
			this.relicFilterPlanList_ = other.relicFilterPlanList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x000E8860 File Offset: 0x000E6A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRelicFilterPlanScRsp Clone()
		{
			return new GetRelicFilterPlanScRsp(this);
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x000E8868 File Offset: 0x000E6A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicFilterPlan> RelicFilterPlanList
		{
			get
			{
				return this.relicFilterPlanList_;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x060056C5 RID: 22213 RVA: 0x000E8870 File Offset: 0x000E6A70
		// (set) Token: 0x060056C6 RID: 22214 RVA: 0x000E8878 File Offset: 0x000E6A78
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

		// Token: 0x060056C7 RID: 22215 RVA: 0x000E8881 File Offset: 0x000E6A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRelicFilterPlanScRsp);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x000E8890 File Offset: 0x000E6A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRelicFilterPlanScRsp other)
		{
			return other != null && (other == this || (this.relicFilterPlanList_.Equals(other.relicFilterPlanList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x000E88E0 File Offset: 0x000E6AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.relicFilterPlanList_.GetHashCode();
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

		// Token: 0x060056CA RID: 22218 RVA: 0x000E892D File Offset: 0x000E6B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x000E8935 File Offset: 0x000E6B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x000E8940 File Offset: 0x000E6B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.relicFilterPlanList_.WriteTo(ref output, GetRelicFilterPlanScRsp._repeated_relicFilterPlanList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x000E8990 File Offset: 0x000E6B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.relicFilterPlanList_.CalculateSize(GetRelicFilterPlanScRsp._repeated_relicFilterPlanList_codec);
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

		// Token: 0x060056CE RID: 22222 RVA: 0x000E89E4 File Offset: 0x000E6BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRelicFilterPlanScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.relicFilterPlanList_.Add(other.relicFilterPlanList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x000E8A31 File Offset: 0x000E6C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x000E8A3C File Offset: 0x000E6C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.relicFilterPlanList_.AddEntriesFrom(ref input, GetRelicFilterPlanScRsp._repeated_relicFilterPlanList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021EE RID: 8686
		private static readonly MessageParser<GetRelicFilterPlanScRsp> _parser = new MessageParser<GetRelicFilterPlanScRsp>(() => new GetRelicFilterPlanScRsp());

		// Token: 0x040021EF RID: 8687
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021F0 RID: 8688
		public const int RelicFilterPlanListFieldNumber = 14;

		// Token: 0x040021F1 RID: 8689
		private static readonly FieldCodec<RelicFilterPlan> _repeated_relicFilterPlanList_codec = FieldCodec.ForMessage<RelicFilterPlan>(114U, RelicFilterPlan.Parser);

		// Token: 0x040021F2 RID: 8690
		private readonly RepeatedField<RelicFilterPlan> relicFilterPlanList_ = new RepeatedField<RelicFilterPlan>();

		// Token: 0x040021F3 RID: 8691
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040021F4 RID: 8692
		private uint retcode_;
	}
}
