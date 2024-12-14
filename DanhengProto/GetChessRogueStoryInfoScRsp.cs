using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000665 RID: 1637
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueStoryInfoScRsp : IMessage<GetChessRogueStoryInfoScRsp>, IMessage, IEquatable<GetChessRogueStoryInfoScRsp>, IDeepCloneable<GetChessRogueStoryInfoScRsp>, IBufferMessage
	{
		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x000C8243 File Offset: 0x000C6443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueStoryInfoScRsp> Parser
		{
			get
			{
				return GetChessRogueStoryInfoScRsp._parser;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x000C824A File Offset: 0x000C644A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueStoryInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x000C825C File Offset: 0x000C645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueStoryInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x000C8263 File Offset: 0x000C6463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoScRsp()
		{
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x000C8284 File Offset: 0x000C6484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoScRsp(GetChessRogueStoryInfoScRsp other) : this()
		{
			this.chessRogueMainStoryInfo_ = other.chessRogueMainStoryInfo_.Clone();
			this.chessRogueSubStoryInfo_ = other.chessRogueSubStoryInfo_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x000C82D6 File Offset: 0x000C64D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryInfoScRsp Clone()
		{
			return new GetChessRogueStoryInfoScRsp(this);
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x000C82DE File Offset: 0x000C64DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCAJFOJGLBI> ChessRogueMainStoryInfo
		{
			get
			{
				return this.chessRogueMainStoryInfo_;
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x000C82E6 File Offset: 0x000C64E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NBANNOKIGKA> ChessRogueSubStoryInfo
		{
			get
			{
				return this.chessRogueSubStoryInfo_;
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x000C82EE File Offset: 0x000C64EE
		// (set) Token: 0x06004967 RID: 18791 RVA: 0x000C82F6 File Offset: 0x000C64F6
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

		// Token: 0x06004968 RID: 18792 RVA: 0x000C82FF File Offset: 0x000C64FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueStoryInfoScRsp);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x000C8310 File Offset: 0x000C6510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueStoryInfoScRsp other)
		{
			return other != null && (other == this || (this.chessRogueMainStoryInfo_.Equals(other.chessRogueMainStoryInfo_) && this.chessRogueSubStoryInfo_.Equals(other.chessRogueSubStoryInfo_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x000C8374 File Offset: 0x000C6574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chessRogueMainStoryInfo_.GetHashCode();
			num ^= this.chessRogueSubStoryInfo_.GetHashCode();
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

		// Token: 0x0600496B RID: 18795 RVA: 0x000C83CF File Offset: 0x000C65CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x000C83D7 File Offset: 0x000C65D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x000C83E0 File Offset: 0x000C65E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.chessRogueSubStoryInfo_.WriteTo(ref output, GetChessRogueStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
			this.chessRogueMainStoryInfo_.WriteTo(ref output, GetChessRogueStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x000C8440 File Offset: 0x000C6640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chessRogueMainStoryInfo_.CalculateSize(GetChessRogueStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
			num += this.chessRogueSubStoryInfo_.CalculateSize(GetChessRogueStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
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

		// Token: 0x0600496F RID: 18799 RVA: 0x000C84A4 File Offset: 0x000C66A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueStoryInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.chessRogueMainStoryInfo_.Add(other.chessRogueMainStoryInfo_);
			this.chessRogueSubStoryInfo_.Add(other.chessRogueSubStoryInfo_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x000C8502 File Offset: 0x000C6702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x000C850C File Offset: 0x000C670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 106U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.chessRogueMainStoryInfo_.AddEntriesFrom(ref input, GetChessRogueStoryInfoScRsp._repeated_chessRogueMainStoryInfo_codec);
						}
					}
					else
					{
						this.chessRogueSubStoryInfo_.AddEntriesFrom(ref input, GetChessRogueStoryInfoScRsp._repeated_chessRogueSubStoryInfo_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D38 RID: 7480
		private static readonly MessageParser<GetChessRogueStoryInfoScRsp> _parser = new MessageParser<GetChessRogueStoryInfoScRsp>(() => new GetChessRogueStoryInfoScRsp());

		// Token: 0x04001D39 RID: 7481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D3A RID: 7482
		public const int ChessRogueMainStoryInfoFieldNumber = 14;

		// Token: 0x04001D3B RID: 7483
		private static readonly FieldCodec<CCAJFOJGLBI> _repeated_chessRogueMainStoryInfo_codec = FieldCodec.ForMessage<CCAJFOJGLBI>(114U, CCAJFOJGLBI.Parser);

		// Token: 0x04001D3C RID: 7484
		private readonly RepeatedField<CCAJFOJGLBI> chessRogueMainStoryInfo_ = new RepeatedField<CCAJFOJGLBI>();

		// Token: 0x04001D3D RID: 7485
		public const int ChessRogueSubStoryInfoFieldNumber = 13;

		// Token: 0x04001D3E RID: 7486
		private static readonly FieldCodec<NBANNOKIGKA> _repeated_chessRogueSubStoryInfo_codec = FieldCodec.ForMessage<NBANNOKIGKA>(106U, NBANNOKIGKA.Parser);

		// Token: 0x04001D3F RID: 7487
		private readonly RepeatedField<NBANNOKIGKA> chessRogueSubStoryInfo_ = new RepeatedField<NBANNOKIGKA>();

		// Token: 0x04001D40 RID: 7488
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001D41 RID: 7489
		private uint retcode_;
	}
}
