using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AF RID: 1711
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFirstTalkNpcScRsp : IMessage<GetFirstTalkNpcScRsp>, IMessage, IEquatable<GetFirstTalkNpcScRsp>, IDeepCloneable<GetFirstTalkNpcScRsp>, IBufferMessage
	{
		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x000CFA97 File Offset: 0x000CDC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFirstTalkNpcScRsp> Parser
		{
			get
			{
				return GetFirstTalkNpcScRsp._parser;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x000CFA9E File Offset: 0x000CDC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkNpcScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x000CFAB0 File Offset: 0x000CDCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFirstTalkNpcScRsp.Descriptor;
			}
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x000CFAB7 File Offset: 0x000CDCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcScRsp()
		{
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x000CFACA File Offset: 0x000CDCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcScRsp(GetFirstTalkNpcScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.npcMeetStatusList_ = other.npcMeetStatusList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x000CFB00 File Offset: 0x000CDD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkNpcScRsp Clone()
		{
			return new GetFirstTalkNpcScRsp(this);
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x000CFB08 File Offset: 0x000CDD08
		// (set) Token: 0x06004C98 RID: 19608 RVA: 0x000CFB10 File Offset: 0x000CDD10
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x000CFB19 File Offset: 0x000CDD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FirstNpcTalkInfo> NpcMeetStatusList
		{
			get
			{
				return this.npcMeetStatusList_;
			}
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x000CFB21 File Offset: 0x000CDD21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFirstTalkNpcScRsp);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x000CFB30 File Offset: 0x000CDD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFirstTalkNpcScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.npcMeetStatusList_.Equals(other.npcMeetStatusList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x000CFB80 File Offset: 0x000CDD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.npcMeetStatusList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x000CFBCD File Offset: 0x000CDDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x000CFBD5 File Offset: 0x000CDDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x000CFBE0 File Offset: 0x000CDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.npcMeetStatusList_.WriteTo(ref output, GetFirstTalkNpcScRsp._repeated_npcMeetStatusList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x000CFC30 File Offset: 0x000CDE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.npcMeetStatusList_.CalculateSize(GetFirstTalkNpcScRsp._repeated_npcMeetStatusList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x000CFC84 File Offset: 0x000CDE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFirstTalkNpcScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.npcMeetStatusList_.Add(other.npcMeetStatusList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x000CFCD1 File Offset: 0x000CDED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x000CFCDC File Offset: 0x000CDEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.npcMeetStatusList_.AddEntriesFrom(ref input, GetFirstTalkNpcScRsp._repeated_npcMeetStatusList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E4B RID: 7755
		private static readonly MessageParser<GetFirstTalkNpcScRsp> _parser = new MessageParser<GetFirstTalkNpcScRsp>(() => new GetFirstTalkNpcScRsp());

		// Token: 0x04001E4C RID: 7756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E4D RID: 7757
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001E4E RID: 7758
		private uint retcode_;

		// Token: 0x04001E4F RID: 7759
		public const int NpcMeetStatusListFieldNumber = 13;

		// Token: 0x04001E50 RID: 7760
		private static readonly FieldCodec<FirstNpcTalkInfo> _repeated_npcMeetStatusList_codec = FieldCodec.ForMessage<FirstNpcTalkInfo>(106U, FirstNpcTalkInfo.Parser);

		// Token: 0x04001E51 RID: 7761
		private readonly RepeatedField<FirstNpcTalkInfo> npcMeetStatusList_ = new RepeatedField<FirstNpcTalkInfo>();
	}
}
