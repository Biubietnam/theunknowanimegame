using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B7 RID: 1719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendAssistListScRsp : IMessage<GetFriendAssistListScRsp>, IMessage, IEquatable<GetFriendAssistListScRsp>, IDeepCloneable<GetFriendAssistListScRsp>, IBufferMessage
	{
		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x000D096F File Offset: 0x000CEB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendAssistListScRsp> Parser
		{
			get
			{
				return GetFriendAssistListScRsp._parser;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x000D0976 File Offset: 0x000CEB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendAssistListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x000D0988 File Offset: 0x000CEB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendAssistListScRsp.Descriptor;
			}
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x000D098F File Offset: 0x000CEB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListScRsp()
		{
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x000D09A4 File Offset: 0x000CEBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListScRsp(GetFriendAssistListScRsp other) : this()
		{
			this.targetUid_ = other.targetUid_;
			this.retcode_ = other.retcode_;
			this.assistList_ = other.assistList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x000D09F1 File Offset: 0x000CEBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendAssistListScRsp Clone()
		{
			return new GetFriendAssistListScRsp(this);
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x000D09F9 File Offset: 0x000CEBF9
		// (set) Token: 0x06004CF3 RID: 19699 RVA: 0x000D0A01 File Offset: 0x000CEC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetUid
		{
			get
			{
				return this.targetUid_;
			}
			set
			{
				this.targetUid_ = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x000D0A0A File Offset: 0x000CEC0A
		// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x000D0A12 File Offset: 0x000CEC12
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x000D0A1B File Offset: 0x000CEC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAssistInfo> AssistList
		{
			get
			{
				return this.assistList_;
			}
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x000D0A23 File Offset: 0x000CEC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendAssistListScRsp);
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x000D0A34 File Offset: 0x000CEC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendAssistListScRsp other)
		{
			return other != null && (other == this || (this.TargetUid == other.TargetUid && this.Retcode == other.Retcode && this.assistList_.Equals(other.assistList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x000D0A94 File Offset: 0x000CEC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUid != 0U)
			{
				num ^= this.TargetUid.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.assistList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x000D0AFA File Offset: 0x000CECFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x000D0B02 File Offset: 0x000CED02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x000D0B0C File Offset: 0x000CED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assistList_.WriteTo(ref output, GetFriendAssistListScRsp._repeated_assistList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.TargetUid != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TargetUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x000D0B78 File Offset: 0x000CED78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetUid);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.assistList_.CalculateSize(GetFriendAssistListScRsp._repeated_assistList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x000D0BE4 File Offset: 0x000CEDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendAssistListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUid != 0U)
			{
				this.TargetUid = other.TargetUid;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.assistList_.Add(other.assistList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x000D0C45 File Offset: 0x000CEE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x000D0C50 File Offset: 0x000CEE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TargetUid = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.assistList_.AddEntriesFrom(ref input, GetFriendAssistListScRsp._repeated_assistList_codec);
				}
			}
		}

		// Token: 0x04001E70 RID: 7792
		private static readonly MessageParser<GetFriendAssistListScRsp> _parser = new MessageParser<GetFriendAssistListScRsp>(() => new GetFriendAssistListScRsp());

		// Token: 0x04001E71 RID: 7793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E72 RID: 7794
		public const int TargetUidFieldNumber = 11;

		// Token: 0x04001E73 RID: 7795
		private uint targetUid_;

		// Token: 0x04001E74 RID: 7796
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001E75 RID: 7797
		private uint retcode_;

		// Token: 0x04001E76 RID: 7798
		public const int AssistListFieldNumber = 5;

		// Token: 0x04001E77 RID: 7799
		private static readonly FieldCodec<PlayerAssistInfo> _repeated_assistList_codec = FieldCodec.ForMessage<PlayerAssistInfo>(42U, PlayerAssistInfo.Parser);

		// Token: 0x04001E78 RID: 7800
		private readonly RepeatedField<PlayerAssistInfo> assistList_ = new RepeatedField<PlayerAssistInfo>();
	}
}
