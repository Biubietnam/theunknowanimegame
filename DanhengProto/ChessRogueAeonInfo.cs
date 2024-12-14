using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001DF RID: 479
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueAeonInfo : IMessage<ChessRogueAeonInfo>, IMessage, IEquatable<ChessRogueAeonInfo>, IDeepCloneable<ChessRogueAeonInfo>, IBufferMessage
	{
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0003D90F File Offset: 0x0003BB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueAeonInfo> Parser
		{
			get
			{
				return ChessRogueAeonInfo._parser;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0003D916 File Offset: 0x0003BB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0003D928 File Offset: 0x0003BB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueAeonInfo.Descriptor;
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0003D92F File Offset: 0x0003BB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo()
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0003D944 File Offset: 0x0003BB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo(ChessRogueAeonInfo other) : this()
		{
			this.gameAeonId_ = other.gameAeonId_;
			this.lAALOJHBPLO_ = other.lAALOJHBPLO_;
			this.chessAeonInfo_ = ((other.chessAeonInfo_ != null) ? other.chessAeonInfo_.Clone() : null);
			this.hEHGLEKBGBK_ = ((other.hEHGLEKBGBK_ != null) ? other.hEHGLEKBGBK_.Clone() : null);
			this.aeonIdList_ = other.aeonIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0003D9C9 File Offset: 0x0003BBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo Clone()
		{
			return new ChessRogueAeonInfo(this);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0003D9D1 File Offset: 0x0003BBD1
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0003D9D9 File Offset: 0x0003BBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameAeonId
		{
			get
			{
				return this.gameAeonId_;
			}
			set
			{
				this.gameAeonId_ = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0003D9E2 File Offset: 0x0003BBE2
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x0003D9EA File Offset: 0x0003BBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LAALOJHBPLO
		{
			get
			{
				return this.lAALOJHBPLO_;
			}
			set
			{
				this.lAALOJHBPLO_ = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0003D9F3 File Offset: 0x0003BBF3
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0003D9FB File Offset: 0x0003BBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo ChessAeonInfo
		{
			get
			{
				return this.chessAeonInfo_;
			}
			set
			{
				this.chessAeonInfo_ = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0003DA04 File Offset: 0x0003BC04
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x0003DA0C File Offset: 0x0003BC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ HEHGLEKBGBK
		{
			get
			{
				return this.hEHGLEKBGBK_;
			}
			set
			{
				this.hEHGLEKBGBK_ = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0003DA15 File Offset: 0x0003BC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AeonIdList
		{
			get
			{
				return this.aeonIdList_;
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0003DA1D File Offset: 0x0003BC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueAeonInfo);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0003DA2C File Offset: 0x0003BC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueAeonInfo other)
		{
			return other != null && (other == this || (this.GameAeonId == other.GameAeonId && this.LAALOJHBPLO == other.LAALOJHBPLO && object.Equals(this.ChessAeonInfo, other.ChessAeonInfo) && object.Equals(this.HEHGLEKBGBK, other.HEHGLEKBGBK) && this.aeonIdList_.Equals(other.aeonIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0003DAB4 File Offset: 0x0003BCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameAeonId != 0U)
			{
				num ^= this.GameAeonId.GetHashCode();
			}
			if (this.LAALOJHBPLO != 0)
			{
				num ^= this.LAALOJHBPLO.GetHashCode();
			}
			if (this.chessAeonInfo_ != null)
			{
				num ^= this.ChessAeonInfo.GetHashCode();
			}
			if (this.hEHGLEKBGBK_ != null)
			{
				num ^= this.HEHGLEKBGBK.GetHashCode();
			}
			num ^= this.aeonIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0003DB46 File Offset: 0x0003BD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0003DB4E File Offset: 0x0003BD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0003DB58 File Offset: 0x0003BD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameAeonId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAeonId);
			}
			if (this.LAALOJHBPLO != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LAALOJHBPLO);
			}
			if (this.chessAeonInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ChessAeonInfo);
			}
			if (this.hEHGLEKBGBK_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.HEHGLEKBGBK);
			}
			this.aeonIdList_.WriteTo(ref output, ChessRogueAeonInfo._repeated_aeonIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameAeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAeonId);
			}
			if (this.LAALOJHBPLO != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LAALOJHBPLO);
			}
			if (this.chessAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessAeonInfo);
			}
			if (this.hEHGLEKBGBK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HEHGLEKBGBK);
			}
			num += this.aeonIdList_.CalculateSize(ChessRogueAeonInfo._repeated_aeonIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0003DC98 File Offset: 0x0003BE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameAeonId != 0U)
			{
				this.GameAeonId = other.GameAeonId;
			}
			if (other.LAALOJHBPLO != 0)
			{
				this.LAALOJHBPLO = other.LAALOJHBPLO;
			}
			if (other.chessAeonInfo_ != null)
			{
				if (this.chessAeonInfo_ == null)
				{
					this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
				}
				this.ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
			}
			if (other.hEHGLEKBGBK_ != null)
			{
				if (this.hEHGLEKBGBK_ == null)
				{
					this.HEHGLEKBGBK = new JPEGOGNDPJJ();
				}
				this.HEHGLEKBGBK.MergeFrom(other.HEHGLEKBGBK);
			}
			this.aeonIdList_.Add(other.aeonIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0003DD51 File Offset: 0x0003BF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0003DD5C File Offset: 0x0003BF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num == 16U)
					{
						this.GameAeonId = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LAALOJHBPLO = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						if (this.chessAeonInfo_ == null)
						{
							this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
						}
						input.ReadMessage(this.ChessAeonInfo);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.hEHGLEKBGBK_ == null)
						{
							this.HEHGLEKBGBK = new JPEGOGNDPJJ();
						}
						input.ReadMessage(this.HEHGLEKBGBK);
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.aeonIdList_.AddEntriesFrom(ref input, ChessRogueAeonInfo._repeated_aeonIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000905 RID: 2309
		private static readonly MessageParser<ChessRogueAeonInfo> _parser = new MessageParser<ChessRogueAeonInfo>(() => new ChessRogueAeonInfo());

		// Token: 0x04000906 RID: 2310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000907 RID: 2311
		public const int GameAeonIdFieldNumber = 2;

		// Token: 0x04000908 RID: 2312
		private uint gameAeonId_;

		// Token: 0x04000909 RID: 2313
		public const int LAALOJHBPLOFieldNumber = 3;

		// Token: 0x0400090A RID: 2314
		private int lAALOJHBPLO_;

		// Token: 0x0400090B RID: 2315
		public const int ChessAeonInfoFieldNumber = 8;

		// Token: 0x0400090C RID: 2316
		private ChessRogueQueryAeonInfo chessAeonInfo_;

		// Token: 0x0400090D RID: 2317
		public const int HEHGLEKBGBKFieldNumber = 14;

		// Token: 0x0400090E RID: 2318
		private JPEGOGNDPJJ hEHGLEKBGBK_;

		// Token: 0x0400090F RID: 2319
		public const int AeonIdListFieldNumber = 15;

		// Token: 0x04000910 RID: 2320
		private static readonly FieldCodec<uint> _repeated_aeonIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04000911 RID: 2321
		private readonly RepeatedField<uint> aeonIdList_ = new RepeatedField<uint>();
	}
}
