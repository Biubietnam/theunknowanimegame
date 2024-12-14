using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000829 RID: 2089
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrainVisitorBehaviorCsReq : IMessage<GetTrainVisitorBehaviorCsReq>, IMessage, IEquatable<GetTrainVisitorBehaviorCsReq>, IDeepCloneable<GetTrainVisitorBehaviorCsReq>, IBufferMessage
	{
		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06005CFF RID: 23807 RVA: 0x000F6F1C File Offset: 0x000F511C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrainVisitorBehaviorCsReq> Parser
		{
			get
			{
				return GetTrainVisitorBehaviorCsReq._parser;
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x000F6F23 File Offset: 0x000F5123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrainVisitorBehaviorCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x000F6F35 File Offset: 0x000F5135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrainVisitorBehaviorCsReq.Descriptor;
			}
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x000F6F3C File Offset: 0x000F513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorCsReq()
		{
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x000F6F4F File Offset: 0x000F514F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorCsReq(GetTrainVisitorBehaviorCsReq other) : this()
		{
			this.pLAGANNGMAI_ = other.pLAGANNGMAI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x000F6F79 File Offset: 0x000F5179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorBehaviorCsReq Clone()
		{
			return new GetTrainVisitorBehaviorCsReq(this);
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x000F6F81 File Offset: 0x000F5181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PLAGANNGMAI
		{
			get
			{
				return this.pLAGANNGMAI_;
			}
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x000F6F89 File Offset: 0x000F5189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrainVisitorBehaviorCsReq);
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x000F6F97 File Offset: 0x000F5197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrainVisitorBehaviorCsReq other)
		{
			return other != null && (other == this || (this.pLAGANNGMAI_.Equals(other.pLAGANNGMAI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x000F6FCC File Offset: 0x000F51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pLAGANNGMAI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x000F7000 File Offset: 0x000F5200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x000F7008 File Offset: 0x000F5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x000F7011 File Offset: 0x000F5211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pLAGANNGMAI_.WriteTo(ref output, GetTrainVisitorBehaviorCsReq._repeated_pLAGANNGMAI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x000F7038 File Offset: 0x000F5238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pLAGANNGMAI_.CalculateSize(GetTrainVisitorBehaviorCsReq._repeated_pLAGANNGMAI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x000F7071 File Offset: 0x000F5271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrainVisitorBehaviorCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.pLAGANNGMAI_.Add(other.pLAGANNGMAI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x000F709F File Offset: 0x000F529F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x000F70A8 File Offset: 0x000F52A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pLAGANNGMAI_.AddEntriesFrom(ref input, GetTrainVisitorBehaviorCsReq._repeated_pLAGANNGMAI_codec);
				}
			}
		}

		// Token: 0x040023F0 RID: 9200
		private static readonly MessageParser<GetTrainVisitorBehaviorCsReq> _parser = new MessageParser<GetTrainVisitorBehaviorCsReq>(() => new GetTrainVisitorBehaviorCsReq());

		// Token: 0x040023F1 RID: 9201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F2 RID: 9202
		public const int PLAGANNGMAIFieldNumber = 9;

		// Token: 0x040023F3 RID: 9203
		private static readonly FieldCodec<uint> _repeated_pLAGANNGMAI_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040023F4 RID: 9204
		private readonly RepeatedField<uint> pLAGANNGMAI_ = new RepeatedField<uint>();
	}
}
