using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000675 RID: 1653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurChallengeScRsp : IMessage<GetCurChallengeScRsp>, IMessage, IEquatable<GetCurChallengeScRsp>, IDeepCloneable<GetCurChallengeScRsp>, IBufferMessage
	{
		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06004A10 RID: 18960 RVA: 0x000C9BD7 File Offset: 0x000C7DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurChallengeScRsp> Parser
		{
			get
			{
				return GetCurChallengeScRsp._parser;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x000C9BDE File Offset: 0x000C7DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x000C9BF0 File Offset: 0x000C7DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x000C9BF7 File Offset: 0x000C7DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeScRsp()
		{
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x000C9C0C File Offset: 0x000C7E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeScRsp(GetCurChallengeScRsp other) : this()
		{
			this.lineupList_ = other.lineupList_.Clone();
			this.retcode_ = other.retcode_;
			this.curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x000C9C69 File Offset: 0x000C7E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeScRsp Clone()
		{
			return new GetCurChallengeScRsp(this);
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06004A16 RID: 18966 RVA: 0x000C9C71 File Offset: 0x000C7E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupInfo> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x000C9C79 File Offset: 0x000C7E79
		// (set) Token: 0x06004A18 RID: 18968 RVA: 0x000C9C81 File Offset: 0x000C7E81
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

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x000C9C8A File Offset: 0x000C7E8A
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x000C9C92 File Offset: 0x000C7E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge CurChallenge
		{
			get
			{
				return this.curChallenge_;
			}
			set
			{
				this.curChallenge_ = value;
			}
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x000C9C9B File Offset: 0x000C7E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurChallengeScRsp);
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x000C9CAC File Offset: 0x000C7EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurChallengeScRsp other)
		{
			return other != null && (other == this || (this.lineupList_.Equals(other.lineupList_) && this.Retcode == other.Retcode && object.Equals(this.CurChallenge, other.CurChallenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x000C9D10 File Offset: 0x000C7F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lineupList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.curChallenge_ != null)
			{
				num ^= this.CurChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x000C9D73 File Offset: 0x000C7F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x000C9D7B File Offset: 0x000C7F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x000C9D84 File Offset: 0x000C7F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lineupList_.WriteTo(ref output, GetCurChallengeScRsp._repeated_lineupList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.curChallenge_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CurChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x000C9DF0 File Offset: 0x000C7FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lineupList_.CalculateSize(GetCurChallengeScRsp._repeated_lineupList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.curChallenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurChallenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x000C9E5C File Offset: 0x000C805C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.curChallenge_ != null)
			{
				if (this.curChallenge_ == null)
				{
					this.CurChallenge = new CurChallenge();
				}
				this.CurChallenge.MergeFrom(other.CurChallenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x000C9ED5 File Offset: 0x000C80D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x000C9EE0 File Offset: 0x000C80E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 72U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.curChallenge_ == null)
							{
								this.CurChallenge = new CurChallenge();
							}
							input.ReadMessage(this.CurChallenge);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.lineupList_.AddEntriesFrom(ref input, GetCurChallengeScRsp._repeated_lineupList_codec);
				}
			}
		}

		// Token: 0x04001D6E RID: 7534
		private static readonly MessageParser<GetCurChallengeScRsp> _parser = new MessageParser<GetCurChallengeScRsp>(() => new GetCurChallengeScRsp());

		// Token: 0x04001D6F RID: 7535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D70 RID: 7536
		public const int LineupListFieldNumber = 1;

		// Token: 0x04001D71 RID: 7537
		private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage<LineupInfo>(10U, LineupInfo.Parser);

		// Token: 0x04001D72 RID: 7538
		private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

		// Token: 0x04001D73 RID: 7539
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04001D74 RID: 7540
		private uint retcode_;

		// Token: 0x04001D75 RID: 7541
		public const int CurChallengeFieldNumber = 11;

		// Token: 0x04001D76 RID: 7542
		private CurChallenge curChallenge_;
	}
}
