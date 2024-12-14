using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200069B RID: 1691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFarmStageGachaInfoScRsp : IMessage<GetFarmStageGachaInfoScRsp>, IMessage, IEquatable<GetFarmStageGachaInfoScRsp>, IDeepCloneable<GetFarmStageGachaInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x000CDB1B File Offset: 0x000CBD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFarmStageGachaInfoScRsp> Parser
		{
			get
			{
				return GetFarmStageGachaInfoScRsp._parser;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x000CDB22 File Offset: 0x000CBD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x000CDB34 File Offset: 0x000CBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFarmStageGachaInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x000CDB3B File Offset: 0x000CBD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoScRsp()
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x000CDB4E File Offset: 0x000CBD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoScRsp(GetFarmStageGachaInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.farmStageGachaInfoList_ = other.farmStageGachaInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x000CDB84 File Offset: 0x000CBD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFarmStageGachaInfoScRsp Clone()
		{
			return new GetFarmStageGachaInfoScRsp(this);
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x000CDB8C File Offset: 0x000CBD8C
		// (set) Token: 0x06004BBF RID: 19391 RVA: 0x000CDB94 File Offset: 0x000CBD94
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

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x000CDB9D File Offset: 0x000CBD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FarmStageGachaInfo> FarmStageGachaInfoList
		{
			get
			{
				return this.farmStageGachaInfoList_;
			}
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x000CDBA5 File Offset: 0x000CBDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFarmStageGachaInfoScRsp);
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x000CDBB4 File Offset: 0x000CBDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFarmStageGachaInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.farmStageGachaInfoList_.Equals(other.farmStageGachaInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x000CDC04 File Offset: 0x000CBE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.farmStageGachaInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x000CDC51 File Offset: 0x000CBE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000CDC59 File Offset: 0x000CBE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000CDC64 File Offset: 0x000CBE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.farmStageGachaInfoList_.WriteTo(ref output, GetFarmStageGachaInfoScRsp._repeated_farmStageGachaInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x000CDCB4 File Offset: 0x000CBEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.farmStageGachaInfoList_.CalculateSize(GetFarmStageGachaInfoScRsp._repeated_farmStageGachaInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x000CDD08 File Offset: 0x000CBF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFarmStageGachaInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.farmStageGachaInfoList_.Add(other.farmStageGachaInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x000CDD55 File Offset: 0x000CBF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x000CDD60 File Offset: 0x000CBF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.farmStageGachaInfoList_.AddEntriesFrom(ref input, GetFarmStageGachaInfoScRsp._repeated_farmStageGachaInfoList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E00 RID: 7680
		private static readonly MessageParser<GetFarmStageGachaInfoScRsp> _parser = new MessageParser<GetFarmStageGachaInfoScRsp>(() => new GetFarmStageGachaInfoScRsp());

		// Token: 0x04001E01 RID: 7681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E02 RID: 7682
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001E03 RID: 7683
		private uint retcode_;

		// Token: 0x04001E04 RID: 7684
		public const int FarmStageGachaInfoListFieldNumber = 10;

		// Token: 0x04001E05 RID: 7685
		private static readonly FieldCodec<FarmStageGachaInfo> _repeated_farmStageGachaInfoList_codec = FieldCodec.ForMessage<FarmStageGachaInfo>(82U, FarmStageGachaInfo.Parser);

		// Token: 0x04001E06 RID: 7686
		private readonly RepeatedField<FarmStageGachaInfo> farmStageGachaInfoList_ = new RepeatedField<FarmStageGachaInfo>();
	}
}
