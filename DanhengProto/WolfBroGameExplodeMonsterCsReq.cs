using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001427 RID: 5159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameExplodeMonsterCsReq : IMessage<WolfBroGameExplodeMonsterCsReq>, IMessage, IEquatable<WolfBroGameExplodeMonsterCsReq>, IDeepCloneable<WolfBroGameExplodeMonsterCsReq>, IBufferMessage
	{
		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x00263D59 File Offset: 0x00261F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameExplodeMonsterCsReq> Parser
		{
			get
			{
				return WolfBroGameExplodeMonsterCsReq._parser;
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x0600E62C RID: 58924 RVA: 0x00263D60 File Offset: 0x00261F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameExplodeMonsterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x0600E62D RID: 58925 RVA: 0x00263D72 File Offset: 0x00261F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameExplodeMonsterCsReq.Descriptor;
			}
		}

		// Token: 0x0600E62E RID: 58926 RVA: 0x00263D79 File Offset: 0x00261F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterCsReq()
		{
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x00263D8C File Offset: 0x00261F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterCsReq(WolfBroGameExplodeMonsterCsReq other) : this()
		{
			this.assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E630 RID: 58928 RVA: 0x00263DB6 File Offset: 0x00261FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterCsReq Clone()
		{
			return new WolfBroGameExplodeMonsterCsReq(this);
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x0600E631 RID: 58929 RVA: 0x00263DBE File Offset: 0x00261FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AssistMonsterEntityIdList
		{
			get
			{
				return this.assistMonsterEntityIdList_;
			}
		}

		// Token: 0x0600E632 RID: 58930 RVA: 0x00263DC6 File Offset: 0x00261FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameExplodeMonsterCsReq);
		}

		// Token: 0x0600E633 RID: 58931 RVA: 0x00263DD4 File Offset: 0x00261FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameExplodeMonsterCsReq other)
		{
			return other != null && (other == this || (this.assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x00263E08 File Offset: 0x00262008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assistMonsterEntityIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x00263E3C File Offset: 0x0026203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x00263E44 File Offset: 0x00262044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E637 RID: 58935 RVA: 0x00263E4D File Offset: 0x0026204D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assistMonsterEntityIdList_.WriteTo(ref output, WolfBroGameExplodeMonsterCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E638 RID: 58936 RVA: 0x00263E74 File Offset: 0x00262074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assistMonsterEntityIdList_.CalculateSize(WolfBroGameExplodeMonsterCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x00263EAD File Offset: 0x002620AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameExplodeMonsterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x00263EDB File Offset: 0x002620DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x00263EE4 File Offset: 0x002620E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.assistMonsterEntityIdList_.AddEntriesFrom(ref input, WolfBroGameExplodeMonsterCsReq._repeated_assistMonsterEntityIdList_codec);
				}
			}
		}

		// Token: 0x04005B5F RID: 23391
		private static readonly MessageParser<WolfBroGameExplodeMonsterCsReq> _parser = new MessageParser<WolfBroGameExplodeMonsterCsReq>(() => new WolfBroGameExplodeMonsterCsReq());

		// Token: 0x04005B60 RID: 23392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B61 RID: 23393
		public const int AssistMonsterEntityIdListFieldNumber = 8;

		// Token: 0x04005B62 RID: 23394
		private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005B63 RID: 23395
		private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();
	}
}
