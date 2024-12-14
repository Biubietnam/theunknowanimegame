using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000635 RID: 1589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBattleCollegeDataScRsp : IMessage<GetBattleCollegeDataScRsp>, IMessage, IEquatable<GetBattleCollegeDataScRsp>, IDeepCloneable<GetBattleCollegeDataScRsp>, IBufferMessage
	{
		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x000C3801 File Offset: 0x000C1A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBattleCollegeDataScRsp> Parser
		{
			get
			{
				return GetBattleCollegeDataScRsp._parser;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x000C3808 File Offset: 0x000C1A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBattleCollegeDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x000C381A File Offset: 0x000C1A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBattleCollegeDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x000C3821 File Offset: 0x000C1A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataScRsp()
		{
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x000C3834 File Offset: 0x000C1A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataScRsp(GetBattleCollegeDataScRsp other) : this()
		{
			this.hDDGPMMNICD_ = other.hDDGPMMNICD_;
			this.retcode_ = other.retcode_;
			this.finishedCollegeIdList_ = other.finishedCollegeIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x000C3881 File Offset: 0x000C1A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBattleCollegeDataScRsp Clone()
		{
			return new GetBattleCollegeDataScRsp(this);
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x000C3889 File Offset: 0x000C1A89
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x000C3891 File Offset: 0x000C1A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDDGPMMNICD
		{
			get
			{
				return this.hDDGPMMNICD_;
			}
			set
			{
				this.hDDGPMMNICD_ = value;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x000C389A File Offset: 0x000C1A9A
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x000C38A2 File Offset: 0x000C1AA2
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

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x000C38AB File Offset: 0x000C1AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedCollegeIdList
		{
			get
			{
				return this.finishedCollegeIdList_;
			}
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x000C38B3 File Offset: 0x000C1AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBattleCollegeDataScRsp);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x000C38C4 File Offset: 0x000C1AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBattleCollegeDataScRsp other)
		{
			return other != null && (other == this || (this.HDDGPMMNICD == other.HDDGPMMNICD && this.Retcode == other.Retcode && this.finishedCollegeIdList_.Equals(other.finishedCollegeIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x000C3924 File Offset: 0x000C1B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HDDGPMMNICD != 0U)
			{
				num ^= this.HDDGPMMNICD.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.finishedCollegeIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x000C398A File Offset: 0x000C1B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x000C3992 File Offset: 0x000C1B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x000C399C File Offset: 0x000C1B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.finishedCollegeIdList_.WriteTo(ref output, GetBattleCollegeDataScRsp._repeated_finishedCollegeIdList_codec);
			if (this.HDDGPMMNICD != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.HDDGPMMNICD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000C3A08 File Offset: 0x000C1C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HDDGPMMNICD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDDGPMMNICD);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.finishedCollegeIdList_.CalculateSize(GetBattleCollegeDataScRsp._repeated_finishedCollegeIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x000C3A74 File Offset: 0x000C1C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBattleCollegeDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HDDGPMMNICD != 0U)
			{
				this.HDDGPMMNICD = other.HDDGPMMNICD;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.finishedCollegeIdList_.Add(other.finishedCollegeIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x000C3AD5 File Offset: 0x000C1CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x000C3AE0 File Offset: 0x000C1CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_3F;
					}
					if (num == 120U)
					{
						this.HDDGPMMNICD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.finishedCollegeIdList_.AddEntriesFrom(ref input, GetBattleCollegeDataScRsp._repeated_finishedCollegeIdList_codec);
			}
		}

		// Token: 0x04001C95 RID: 7317
		private static readonly MessageParser<GetBattleCollegeDataScRsp> _parser = new MessageParser<GetBattleCollegeDataScRsp>(() => new GetBattleCollegeDataScRsp());

		// Token: 0x04001C96 RID: 7318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C97 RID: 7319
		public const int HDDGPMMNICDFieldNumber = 15;

		// Token: 0x04001C98 RID: 7320
		private uint hDDGPMMNICD_;

		// Token: 0x04001C99 RID: 7321
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001C9A RID: 7322
		private uint retcode_;

		// Token: 0x04001C9B RID: 7323
		public const int FinishedCollegeIdListFieldNumber = 10;

		// Token: 0x04001C9C RID: 7324
		private static readonly FieldCodec<uint> _repeated_finishedCollegeIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04001C9D RID: 7325
		private readonly RepeatedField<uint> finishedCollegeIdList_ = new RepeatedField<uint>();
	}
}
