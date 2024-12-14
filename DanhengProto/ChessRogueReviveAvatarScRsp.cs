using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200028D RID: 653
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueReviveAvatarScRsp : IMessage<ChessRogueReviveAvatarScRsp>, IMessage, IEquatable<ChessRogueReviveAvatarScRsp>, IDeepCloneable<ChessRogueReviveAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00053867 File Offset: 0x00051A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueReviveAvatarScRsp> Parser
		{
			get
			{
				return ChessRogueReviveAvatarScRsp._parser;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0005386E File Offset: 0x00051A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00053880 File Offset: 0x00051A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00053887 File Offset: 0x00051A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarScRsp()
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0005389C File Offset: 0x00051A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarScRsp(ChessRogueReviveAvatarScRsp other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000538F9 File Offset: 0x00051AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarScRsp Clone()
		{
			return new ChessRogueReviveAvatarScRsp(this);
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00053901 File Offset: 0x00051B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00053909 File Offset: 0x00051B09
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00053911 File Offset: 0x00051B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost ReviveInfo
		{
			get
			{
				return this.reviveInfo_;
			}
			set
			{
				this.reviveInfo_ = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0005391A File Offset: 0x00051B1A
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00053922 File Offset: 0x00051B22
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

		// Token: 0x06001D22 RID: 7458 RVA: 0x0005392B File Offset: 0x00051B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueReviveAvatarScRsp);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0005393C File Offset: 0x00051B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueReviveAvatarScRsp other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this.ReviveInfo, other.ReviveInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000539A0 File Offset: 0x00051BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
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

		// Token: 0x06001D25 RID: 7461 RVA: 0x00053A03 File Offset: 0x00051C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00053A0B File Offset: 0x00051C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00053A14 File Offset: 0x00051C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, ChessRogueReviveAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ReviveInfo);
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

		// Token: 0x06001D28 RID: 7464 RVA: 0x00053A80 File Offset: 0x00051C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(ChessRogueReviveAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
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

		// Token: 0x06001D29 RID: 7465 RVA: 0x00053AEC File Offset: 0x00051CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueReviveAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueAvatarReviveCost();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00053B65 File Offset: 0x00051D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00053B70 File Offset: 0x00051D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, ChessRogueReviveAvatarScRsp._repeated_baseAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.reviveInfo_ == null)
						{
							this.ReviveInfo = new RogueAvatarReviveCost();
						}
						input.ReadMessage(this.ReviveInfo);
						continue;
					}
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C2C RID: 3116
		private static readonly MessageParser<ChessRogueReviveAvatarScRsp> _parser = new MessageParser<ChessRogueReviveAvatarScRsp>(() => new ChessRogueReviveAvatarScRsp());

		// Token: 0x04000C2D RID: 3117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C2E RID: 3118
		public const int BaseAvatarIdListFieldNumber = 3;

		// Token: 0x04000C2F RID: 3119
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04000C30 RID: 3120
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C31 RID: 3121
		public const int ReviveInfoFieldNumber = 9;

		// Token: 0x04000C32 RID: 3122
		private RogueAvatarReviveCost reviveInfo_;

		// Token: 0x04000C33 RID: 3123
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000C34 RID: 3124
		private uint retcode_;
	}
}
