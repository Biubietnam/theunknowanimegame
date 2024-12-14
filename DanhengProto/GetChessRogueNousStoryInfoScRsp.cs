using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200065D RID: 1629
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueNousStoryInfoScRsp : IMessage<GetChessRogueNousStoryInfoScRsp>, IMessage, IEquatable<GetChessRogueNousStoryInfoScRsp>, IDeepCloneable<GetChessRogueNousStoryInfoScRsp>, IBufferMessage
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x000C75B3 File Offset: 0x000C57B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueNousStoryInfoScRsp> Parser
		{
			get
			{
				return GetChessRogueNousStoryInfoScRsp._parser;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x000C75BA File Offset: 0x000C57BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueNousStoryInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x000C75CC File Offset: 0x000C57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueNousStoryInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x000C75D3 File Offset: 0x000C57D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoScRsp()
		{
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x000C75F4 File Offset: 0x000C57F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoScRsp(GetChessRogueNousStoryInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.chessRogueMainStoryInfo_ = other.chessRogueMainStoryInfo_.Clone();
			this.chessRogueSubStoryInfo_ = other.chessRogueSubStoryInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x000C7646 File Offset: 0x000C5846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoScRsp Clone()
		{
			return new GetChessRogueNousStoryInfoScRsp(this);
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x000C764E File Offset: 0x000C584E
		// (set) Token: 0x0600490E RID: 18702 RVA: 0x000C7656 File Offset: 0x000C5856
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

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x000C765F File Offset: 0x000C585F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueNousMainStoryInfo> ChessRogueMainStoryInfo
		{
			get
			{
				return this.chessRogueMainStoryInfo_;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x000C7667 File Offset: 0x000C5867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueNousSubStoryInfo> ChessRogueSubStoryInfo
		{
			get
			{
				return this.chessRogueSubStoryInfo_;
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x000C766F File Offset: 0x000C586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueNousStoryInfoScRsp);
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x000C7680 File Offset: 0x000C5880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueNousStoryInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.chessRogueMainStoryInfo_.Equals(other.chessRogueMainStoryInfo_) && this.chessRogueSubStoryInfo_.Equals(other.chessRogueSubStoryInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x000C76E4 File Offset: 0x000C58E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.chessRogueMainStoryInfo_.GetHashCode();
			num ^= this.chessRogueSubStoryInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x000C773F File Offset: 0x000C593F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x000C7747 File Offset: 0x000C5947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x000C7750 File Offset: 0x000C5950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chessRogueMainStoryInfo_.WriteTo(ref output, GetChessRogueNousStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.chessRogueSubStoryInfo_.WriteTo(ref output, GetChessRogueNousStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x000C77B0 File Offset: 0x000C59B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.chessRogueMainStoryInfo_.CalculateSize(GetChessRogueNousStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
			num += this.chessRogueSubStoryInfo_.CalculateSize(GetChessRogueNousStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x000C7814 File Offset: 0x000C5A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueNousStoryInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.chessRogueMainStoryInfo_.Add(other.chessRogueMainStoryInfo_);
			this.chessRogueSubStoryInfo_.Add(other.chessRogueSubStoryInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x000C7872 File Offset: 0x000C5A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x000C787C File Offset: 0x000C5A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 40U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.chessRogueSubStoryInfo_.AddEntriesFrom(ref input, GetChessRogueNousStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.chessRogueMainStoryInfo_.AddEntriesFrom(ref input, GetChessRogueNousStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
				}
			}
		}

		// Token: 0x04001D1B RID: 7451
		private static readonly MessageParser<GetChessRogueNousStoryInfoScRsp> _parser = new MessageParser<GetChessRogueNousStoryInfoScRsp>(() => new GetChessRogueNousStoryInfoScRsp());

		// Token: 0x04001D1C RID: 7452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D1D RID: 7453
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001D1E RID: 7454
		private uint retcode_;

		// Token: 0x04001D1F RID: 7455
		public const int ChessRogueMainStoryInfoFieldNumber = 2;

		// Token: 0x04001D20 RID: 7456
		private static readonly FieldCodec<ChessRogueNousMainStoryInfo> _repeated_chessRogueMainStoryInfo_codec = FieldCodec.ForMessage<ChessRogueNousMainStoryInfo>(18U, ChessRogueNousMainStoryInfo.Parser);

		// Token: 0x04001D21 RID: 7457
		private readonly RepeatedField<ChessRogueNousMainStoryInfo> chessRogueMainStoryInfo_ = new RepeatedField<ChessRogueNousMainStoryInfo>();

		// Token: 0x04001D22 RID: 7458
		public const int ChessRogueSubStoryInfoFieldNumber = 8;

		// Token: 0x04001D23 RID: 7459
		private static readonly FieldCodec<ChessRogueNousSubStoryInfo> _repeated_chessRogueSubStoryInfo_codec = FieldCodec.ForMessage<ChessRogueNousSubStoryInfo>(66U, ChessRogueNousSubStoryInfo.Parser);

		// Token: 0x04001D24 RID: 7460
		private readonly RepeatedField<ChessRogueNousSubStoryInfo> chessRogueSubStoryInfo_ = new RepeatedField<ChessRogueNousSubStoryInfo>();
	}
}
