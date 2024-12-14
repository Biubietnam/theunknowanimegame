using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200073F RID: 1855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMultiPathAvatarInfoScRsp : IMessage<GetMultiPathAvatarInfoScRsp>, IMessage, IEquatable<GetMultiPathAvatarInfoScRsp>, IDeepCloneable<GetMultiPathAvatarInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x060052E6 RID: 21222 RVA: 0x000DF31E File Offset: 0x000DD51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMultiPathAvatarInfoScRsp> Parser
		{
			get
			{
				return GetMultiPathAvatarInfoScRsp._parser;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x000DF325 File Offset: 0x000DD525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMultiPathAvatarInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x060052E8 RID: 21224 RVA: 0x000DF337 File Offset: 0x000DD537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMultiPathAvatarInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x000DF33E File Offset: 0x000DD53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoScRsp()
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x000DF368 File Offset: 0x000DD568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoScRsp(GetMultiPathAvatarInfoScRsp other) : this()
		{
			this.basicTypeIdList_ = other.basicTypeIdList_.Clone();
			this.multiPathAvatarInfoList_ = other.multiPathAvatarInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.curAvatarPath_ = other.curAvatarPath_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x000DF3CB File Offset: 0x000DD5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoScRsp Clone()
		{
			return new GetMultiPathAvatarInfoScRsp(this);
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x000DF3D3 File Offset: 0x000DD5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BasicTypeIdList
		{
			get
			{
				return this.basicTypeIdList_;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x000DF3DB File Offset: 0x000DD5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MultiPathAvatarInfo> MultiPathAvatarInfoList
		{
			get
			{
				return this.multiPathAvatarInfoList_;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x000DF3E3 File Offset: 0x000DD5E3
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x000DF3EB File Offset: 0x000DD5EB
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

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x000DF3F4 File Offset: 0x000DD5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, MultiPathAvatarType> CurAvatarPath
		{
			get
			{
				return this.curAvatarPath_;
			}
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x000DF3FC File Offset: 0x000DD5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMultiPathAvatarInfoScRsp);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x000DF40C File Offset: 0x000DD60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMultiPathAvatarInfoScRsp other)
		{
			return other != null && (other == this || (this.basicTypeIdList_.Equals(other.basicTypeIdList_) && this.multiPathAvatarInfoList_.Equals(other.multiPathAvatarInfoList_) && this.Retcode == other.Retcode && this.CurAvatarPath.Equals(other.CurAvatarPath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x000DF484 File Offset: 0x000DD684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.basicTypeIdList_.GetHashCode();
			num ^= this.multiPathAvatarInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.CurAvatarPath.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x000DF4ED File Offset: 0x000DD6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x000DF4F5 File Offset: 0x000DD6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x000DF500 File Offset: 0x000DD700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.basicTypeIdList_.WriteTo(ref output, GetMultiPathAvatarInfoScRsp._repeated_basicTypeIdList_codec);
			this.curAvatarPath_.WriteTo(ref output, GetMultiPathAvatarInfoScRsp._map_curAvatarPath_codec);
			this.multiPathAvatarInfoList_.WriteTo(ref output, GetMultiPathAvatarInfoScRsp._repeated_multiPathAvatarInfoList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x000DF570 File Offset: 0x000DD770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.basicTypeIdList_.CalculateSize(GetMultiPathAvatarInfoScRsp._repeated_basicTypeIdList_codec);
			num += this.multiPathAvatarInfoList_.CalculateSize(GetMultiPathAvatarInfoScRsp._repeated_multiPathAvatarInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.curAvatarPath_.CalculateSize(GetMultiPathAvatarInfoScRsp._map_curAvatarPath_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMultiPathAvatarInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.basicTypeIdList_.Add(other.basicTypeIdList_);
			this.multiPathAvatarInfoList_.Add(other.multiPathAvatarInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.curAvatarPath_.MergeFrom(other.curAvatarPath_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x000DF657 File Offset: 0x000DD857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x000DF660 File Offset: 0x000DD860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.basicTypeIdList_.AddEntriesFrom(ref input, GetMultiPathAvatarInfoScRsp._repeated_basicTypeIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.curAvatarPath_.AddEntriesFrom(ref input, GetMultiPathAvatarInfoScRsp._map_curAvatarPath_codec);
						continue;
					}
					if (num == 58U)
					{
						this.multiPathAvatarInfoList_.AddEntriesFrom(ref input, GetMultiPathAvatarInfoScRsp._repeated_multiPathAvatarInfoList_codec);
						continue;
					}
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400208E RID: 8334
		private static readonly MessageParser<GetMultiPathAvatarInfoScRsp> _parser = new MessageParser<GetMultiPathAvatarInfoScRsp>(() => new GetMultiPathAvatarInfoScRsp());

		// Token: 0x0400208F RID: 8335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002090 RID: 8336
		public const int BasicTypeIdListFieldNumber = 2;

		// Token: 0x04002091 RID: 8337
		private static readonly FieldCodec<uint> _repeated_basicTypeIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04002092 RID: 8338
		private readonly RepeatedField<uint> basicTypeIdList_ = new RepeatedField<uint>();

		// Token: 0x04002093 RID: 8339
		public const int MultiPathAvatarInfoListFieldNumber = 7;

		// Token: 0x04002094 RID: 8340
		private static readonly FieldCodec<MultiPathAvatarInfo> _repeated_multiPathAvatarInfoList_codec = FieldCodec.ForMessage<MultiPathAvatarInfo>(58U, MultiPathAvatarInfo.Parser);

		// Token: 0x04002095 RID: 8341
		private readonly RepeatedField<MultiPathAvatarInfo> multiPathAvatarInfoList_ = new RepeatedField<MultiPathAvatarInfo>();

		// Token: 0x04002096 RID: 8342
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002097 RID: 8343
		private uint retcode_;

		// Token: 0x04002098 RID: 8344
		public const int CurAvatarPathFieldNumber = 5;

		// Token: 0x04002099 RID: 8345
		private static readonly MapField<uint, MultiPathAvatarType>.Codec _map_curAvatarPath_codec = new MapField<uint, MultiPathAvatarType>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForEnum<MultiPathAvatarType>(16U, (MultiPathAvatarType x) => (int)x, (int x) => (MultiPathAvatarType)x, MultiPathAvatarType.None), 42U);

		// Token: 0x0400209A RID: 8346
		private readonly MapField<uint, MultiPathAvatarType> curAvatarPath_ = new MapField<uint, MultiPathAvatarType>();
	}
}
