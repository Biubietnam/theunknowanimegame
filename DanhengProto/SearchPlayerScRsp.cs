using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001093 RID: 4243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SearchPlayerScRsp : IMessage<SearchPlayerScRsp>, IMessage, IEquatable<SearchPlayerScRsp>, IDeepCloneable<SearchPlayerScRsp>, IBufferMessage
	{
		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x001FDF6F File Offset: 0x001FC16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SearchPlayerScRsp> Parser
		{
			get
			{
				return SearchPlayerScRsp._parser;
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600BD35 RID: 48437 RVA: 0x001FDF76 File Offset: 0x001FC176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchPlayerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x001FDF88 File Offset: 0x001FC188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SearchPlayerScRsp.Descriptor;
			}
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x001FDF8F File Offset: 0x001FC18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerScRsp()
		{
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x001FDFB0 File Offset: 0x001FC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerScRsp(SearchPlayerScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.simpleInfoList_ = other.simpleInfoList_.Clone();
			this.resultUidList_ = other.resultUidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x001FE002 File Offset: 0x001FC202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SearchPlayerScRsp Clone()
		{
			return new SearchPlayerScRsp(this);
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600BD3A RID: 48442 RVA: 0x001FE00A File Offset: 0x001FC20A
		// (set) Token: 0x0600BD3B RID: 48443 RVA: 0x001FE012 File Offset: 0x001FC212
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

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600BD3C RID: 48444 RVA: 0x001FE01B File Offset: 0x001FC21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSimpleInfo> SimpleInfoList
		{
			get
			{
				return this.simpleInfoList_;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600BD3D RID: 48445 RVA: 0x001FE023 File Offset: 0x001FC223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ResultUidList
		{
			get
			{
				return this.resultUidList_;
			}
		}

		// Token: 0x0600BD3E RID: 48446 RVA: 0x001FE02B File Offset: 0x001FC22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SearchPlayerScRsp);
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x001FE03C File Offset: 0x001FC23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SearchPlayerScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.simpleInfoList_.Equals(other.simpleInfoList_) && this.resultUidList_.Equals(other.resultUidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x001FE0A0 File Offset: 0x001FC2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.simpleInfoList_.GetHashCode();
			num ^= this.resultUidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD41 RID: 48449 RVA: 0x001FE0FB File Offset: 0x001FC2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD42 RID: 48450 RVA: 0x001FE103 File Offset: 0x001FC303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD43 RID: 48451 RVA: 0x001FE10C File Offset: 0x001FC30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.resultUidList_.WriteTo(ref output, SearchPlayerScRsp._repeated_resultUidList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.simpleInfoList_.WriteTo(ref output, SearchPlayerScRsp._repeated_simpleInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD44 RID: 48452 RVA: 0x001FE16C File Offset: 0x001FC36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.simpleInfoList_.CalculateSize(SearchPlayerScRsp._repeated_simpleInfoList_codec);
			num += this.resultUidList_.CalculateSize(SearchPlayerScRsp._repeated_resultUidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x001FE1D0 File Offset: 0x001FC3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SearchPlayerScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.simpleInfoList_.Add(other.simpleInfoList_);
			this.resultUidList_.Add(other.resultUidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x001FE22E File Offset: 0x001FC42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x001FE238 File Offset: 0x001FC438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.resultUidList_.AddEntriesFrom(ref input, SearchPlayerScRsp._repeated_resultUidList_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						this.simpleInfoList_.AddEntriesFrom(ref input, SearchPlayerScRsp._repeated_simpleInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CEF RID: 19695
		private static readonly MessageParser<SearchPlayerScRsp> _parser = new MessageParser<SearchPlayerScRsp>(() => new SearchPlayerScRsp());

		// Token: 0x04004CF0 RID: 19696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CF1 RID: 19697
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04004CF2 RID: 19698
		private uint retcode_;

		// Token: 0x04004CF3 RID: 19699
		public const int SimpleInfoListFieldNumber = 12;

		// Token: 0x04004CF4 RID: 19700
		private static readonly FieldCodec<PlayerSimpleInfo> _repeated_simpleInfoList_codec = FieldCodec.ForMessage<PlayerSimpleInfo>(98U, PlayerSimpleInfo.Parser);

		// Token: 0x04004CF5 RID: 19701
		private readonly RepeatedField<PlayerSimpleInfo> simpleInfoList_ = new RepeatedField<PlayerSimpleInfo>();

		// Token: 0x04004CF6 RID: 19702
		public const int ResultUidListFieldNumber = 1;

		// Token: 0x04004CF7 RID: 19703
		private static readonly FieldCodec<uint> _repeated_resultUidList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04004CF8 RID: 19704
		private readonly RepeatedField<uint> resultUidList_ = new RepeatedField<uint>();
	}
}
