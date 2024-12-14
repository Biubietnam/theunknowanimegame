using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B9 RID: 1721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendBattleRecordDetailCsReq : IMessage<GetFriendBattleRecordDetailCsReq>, IMessage, IEquatable<GetFriendBattleRecordDetailCsReq>, IDeepCloneable<GetFriendBattleRecordDetailCsReq>, IBufferMessage
	{
		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x000D0D5C File Offset: 0x000CEF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendBattleRecordDetailCsReq> Parser
		{
			get
			{
				return GetFriendBattleRecordDetailCsReq._parser;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x000D0D63 File Offset: 0x000CEF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendBattleRecordDetailCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x000D0D75 File Offset: 0x000CEF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendBattleRecordDetailCsReq.Descriptor;
			}
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x000D0D7C File Offset: 0x000CEF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailCsReq()
		{
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x000D0D84 File Offset: 0x000CEF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailCsReq(GetFriendBattleRecordDetailCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x000D0DA9 File Offset: 0x000CEFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendBattleRecordDetailCsReq Clone()
		{
			return new GetFriendBattleRecordDetailCsReq(this);
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x000D0DB1 File Offset: 0x000CEFB1
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x000D0DB9 File Offset: 0x000CEFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x000D0DC2 File Offset: 0x000CEFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendBattleRecordDetailCsReq);
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x000D0DD0 File Offset: 0x000CEFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendBattleRecordDetailCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x000D0E00 File Offset: 0x000CF000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x000D0E3F File Offset: 0x000CF03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x000D0E47 File Offset: 0x000CF047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x000D0E50 File Offset: 0x000CF050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x000D0E84 File Offset: 0x000CF084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x000D0EC2 File Offset: 0x000CF0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendBattleRecordDetailCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x000D0EF3 File Offset: 0x000CF0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x000D0EFC File Offset: 0x000CF0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E7A RID: 7802
		private static readonly MessageParser<GetFriendBattleRecordDetailCsReq> _parser = new MessageParser<GetFriendBattleRecordDetailCsReq>(() => new GetFriendBattleRecordDetailCsReq());

		// Token: 0x04001E7B RID: 7803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E7C RID: 7804
		public const int UidFieldNumber = 13;

		// Token: 0x04001E7D RID: 7805
		private uint uid_;
	}
}
