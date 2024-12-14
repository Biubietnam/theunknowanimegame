using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200082B RID: 2091
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrainVisitorBehaviorScRsp : IMessage<GetTrainVisitorBehaviorScRsp>, IMessage, IEquatable<GetTrainVisitorBehaviorScRsp>, IDeepCloneable<GetTrainVisitorBehaviorScRsp>, IBufferMessage
	{
		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06005D13 RID: 23827 RVA: 0x000F71A1 File Offset: 0x000F53A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrainVisitorBehaviorScRsp> Parser
		{
			get
			{
				return GetTrainVisitorBehaviorScRsp._parser;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x000F71A8 File Offset: 0x000F53A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrainVisitorBehaviorScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06005D15 RID: 23829 RVA: 0x000F71BA File Offset: 0x000F53BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrainVisitorBehaviorScRsp.Descriptor;
			}
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x000F71C1 File Offset: 0x000F53C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorScRsp()
		{
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x000F71D4 File Offset: 0x000F53D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorScRsp(GetTrainVisitorBehaviorScRsp other) : this()
		{
			this.cGOAPKFJLBH_ = other.cGOAPKFJLBH_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x000F720A File Offset: 0x000F540A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorScRsp Clone()
		{
			return new GetTrainVisitorBehaviorScRsp(this);
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06005D19 RID: 23833 RVA: 0x000F7212 File Offset: 0x000F5412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MACIKPDHMMH> CGOAPKFJLBH
		{
			get
			{
				return this.cGOAPKFJLBH_;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x000F721A File Offset: 0x000F541A
		// (set) Token: 0x06005D1B RID: 23835 RVA: 0x000F7222 File Offset: 0x000F5422
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

		// Token: 0x06005D1C RID: 23836 RVA: 0x000F722B File Offset: 0x000F542B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrainVisitorBehaviorScRsp);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x000F723C File Offset: 0x000F543C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrainVisitorBehaviorScRsp other)
		{
			return other != null && (other == this || (this.cGOAPKFJLBH_.Equals(other.cGOAPKFJLBH_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x000F728C File Offset: 0x000F548C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cGOAPKFJLBH_.GetHashCode();
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

		// Token: 0x06005D1F RID: 23839 RVA: 0x000F72D9 File Offset: 0x000F54D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x000F72E1 File Offset: 0x000F54E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x000F72EC File Offset: 0x000F54EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.cGOAPKFJLBH_.WriteTo(ref output, GetTrainVisitorBehaviorScRsp._repeated_cGOAPKFJLBH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x000F733C File Offset: 0x000F553C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cGOAPKFJLBH_.CalculateSize(GetTrainVisitorBehaviorScRsp._repeated_cGOAPKFJLBH_codec);
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

		// Token: 0x06005D23 RID: 23843 RVA: 0x000F7390 File Offset: 0x000F5590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrainVisitorBehaviorScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.cGOAPKFJLBH_.Add(other.cGOAPKFJLBH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x000F73DD File Offset: 0x000F55DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x000F73E8 File Offset: 0x000F55E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cGOAPKFJLBH_.AddEntriesFrom(ref input, GetTrainVisitorBehaviorScRsp._repeated_cGOAPKFJLBH_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040023F6 RID: 9206
		private static readonly MessageParser<GetTrainVisitorBehaviorScRsp> _parser = new MessageParser<GetTrainVisitorBehaviorScRsp>(() => new GetTrainVisitorBehaviorScRsp());

		// Token: 0x040023F7 RID: 9207
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F8 RID: 9208
		public const int CGOAPKFJLBHFieldNumber = 9;

		// Token: 0x040023F9 RID: 9209
		private static readonly FieldCodec<MACIKPDHMMH> _repeated_cGOAPKFJLBH_codec = FieldCodec.ForMessage<MACIKPDHMMH>(74U, MACIKPDHMMH.Parser);

		// Token: 0x040023FA RID: 9210
		private readonly RepeatedField<MACIKPDHMMH> cGOAPKFJLBH_ = new RepeatedField<MACIKPDHMMH>();

		// Token: 0x040023FB RID: 9211
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040023FC RID: 9212
		private uint retcode_;
	}
}
