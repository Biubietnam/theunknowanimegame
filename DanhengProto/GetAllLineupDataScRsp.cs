using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000609 RID: 1545
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllLineupDataScRsp : IMessage<GetAllLineupDataScRsp>, IMessage, IEquatable<GetAllLineupDataScRsp>, IDeepCloneable<GetAllLineupDataScRsp>, IBufferMessage
	{
		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x000BE4E3 File Offset: 0x000BC6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllLineupDataScRsp> Parser
		{
			get
			{
				return GetAllLineupDataScRsp._parser;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x000BE4EA File Offset: 0x000BC6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllLineupDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06004555 RID: 17749 RVA: 0x000BE4FC File Offset: 0x000BC6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllLineupDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x000BE503 File Offset: 0x000BC703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataScRsp()
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000BE518 File Offset: 0x000BC718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataScRsp(GetAllLineupDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lineupList_ = other.lineupList_.Clone();
			this.curIndex_ = other.curIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x000BE565 File Offset: 0x000BC765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllLineupDataScRsp Clone()
		{
			return new GetAllLineupDataScRsp(this);
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x000BE56D File Offset: 0x000BC76D
		// (set) Token: 0x0600455A RID: 17754 RVA: 0x000BE575 File Offset: 0x000BC775
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600455B RID: 17755 RVA: 0x000BE57E File Offset: 0x000BC77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupInfo> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x000BE586 File Offset: 0x000BC786
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x000BE58E File Offset: 0x000BC78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurIndex
		{
			get
			{
				return this.curIndex_;
			}
			set
			{
				this.curIndex_ = value;
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x000BE597 File Offset: 0x000BC797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllLineupDataScRsp);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x000BE5A8 File Offset: 0x000BC7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllLineupDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.lineupList_.Equals(other.lineupList_) && this.CurIndex == other.CurIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x000BE608 File Offset: 0x000BC808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.lineupList_.GetHashCode();
			if (this.CurIndex != 0U)
			{
				num ^= this.CurIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x000BE66E File Offset: 0x000BC86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x000BE676 File Offset: 0x000BC876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x000BE680 File Offset: 0x000BC880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lineupList_.WriteTo(ref output, GetAllLineupDataScRsp._repeated_lineupList_codec);
			if (this.CurIndex != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CurIndex);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x000BE6EC File Offset: 0x000BC8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.lineupList_.CalculateSize(GetAllLineupDataScRsp._repeated_lineupList_codec);
			if (this.CurIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x000BE758 File Offset: 0x000BC958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllLineupDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.CurIndex != 0U)
			{
				this.CurIndex = other.CurIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x000BE7B9 File Offset: 0x000BC9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000BE7C4 File Offset: 0x000BC9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.CurIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.lineupList_.AddEntriesFrom(ref input, GetAllLineupDataScRsp._repeated_lineupList_codec);
				}
			}
		}

		// Token: 0x04001BCA RID: 7114
		private static readonly MessageParser<GetAllLineupDataScRsp> _parser = new MessageParser<GetAllLineupDataScRsp>(() => new GetAllLineupDataScRsp());

		// Token: 0x04001BCB RID: 7115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BCC RID: 7116
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001BCD RID: 7117
		private uint retcode_;

		// Token: 0x04001BCE RID: 7118
		public const int LineupListFieldNumber = 5;

		// Token: 0x04001BCF RID: 7119
		private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage<LineupInfo>(42U, LineupInfo.Parser);

		// Token: 0x04001BD0 RID: 7120
		private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

		// Token: 0x04001BD1 RID: 7121
		public const int CurIndexFieldNumber = 10;

		// Token: 0x04001BD2 RID: 7122
		private uint curIndex_;
	}
}
