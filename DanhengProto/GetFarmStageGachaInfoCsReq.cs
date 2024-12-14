using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000699 RID: 1689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFarmStageGachaInfoCsReq : IMessage<GetFarmStageGachaInfoCsReq>, IMessage, IEquatable<GetFarmStageGachaInfoCsReq>, IDeepCloneable<GetFarmStageGachaInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x000CD87D File Offset: 0x000CBA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFarmStageGachaInfoCsReq> Parser
		{
			get
			{
				return GetFarmStageGachaInfoCsReq._parser;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x000CD884 File Offset: 0x000CBA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x000CD896 File Offset: 0x000CBA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x000CD89D File Offset: 0x000CBA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoCsReq()
		{
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x000CD8B0 File Offset: 0x000CBAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoCsReq(GetFarmStageGachaInfoCsReq other) : this()
		{
			this.farmStageGachaIdList_ = other.farmStageGachaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x000CD8DA File Offset: 0x000CBADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoCsReq Clone()
		{
			return new GetFarmStageGachaInfoCsReq(this);
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x000CD8E2 File Offset: 0x000CBAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FarmStageGachaIdList
		{
			get
			{
				return this.farmStageGachaIdList_;
			}
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x000CD8EA File Offset: 0x000CBAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFarmStageGachaInfoCsReq);
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x000CD8F8 File Offset: 0x000CBAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFarmStageGachaInfoCsReq other)
		{
			return other != null && (other == this || (this.farmStageGachaIdList_.Equals(other.farmStageGachaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x000CD92C File Offset: 0x000CBB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.farmStageGachaIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x000CD960 File Offset: 0x000CBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x000CD968 File Offset: 0x000CBB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x000CD971 File Offset: 0x000CBB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.farmStageGachaIdList_.WriteTo(ref output, GetFarmStageGachaInfoCsReq._repeated_farmStageGachaIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x000CD998 File Offset: 0x000CBB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.farmStageGachaIdList_.CalculateSize(GetFarmStageGachaInfoCsReq._repeated_farmStageGachaIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x000CD9D1 File Offset: 0x000CBBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFarmStageGachaInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.farmStageGachaIdList_.Add(other.farmStageGachaIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x000CD9FF File Offset: 0x000CBBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000CDA08 File Offset: 0x000CBC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.farmStageGachaIdList_.AddEntriesFrom(ref input, GetFarmStageGachaInfoCsReq._repeated_farmStageGachaIdList_codec);
				}
			}
		}

		// Token: 0x04001DFA RID: 7674
		private static readonly MessageParser<GetFarmStageGachaInfoCsReq> _parser = new MessageParser<GetFarmStageGachaInfoCsReq>(() => new GetFarmStageGachaInfoCsReq());

		// Token: 0x04001DFB RID: 7675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DFC RID: 7676
		public const int FarmStageGachaIdListFieldNumber = 2;

		// Token: 0x04001DFD RID: 7677
		private static readonly FieldCodec<uint> _repeated_farmStageGachaIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04001DFE RID: 7678
		private readonly RepeatedField<uint> farmStageGachaIdList_ = new RepeatedField<uint>();
	}
}
