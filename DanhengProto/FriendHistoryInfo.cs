using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C5 RID: 1477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendHistoryInfo : IMessage<FriendHistoryInfo>, IMessage, IEquatable<FriendHistoryInfo>, IDeepCloneable<FriendHistoryInfo>, IBufferMessage
	{
		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x000B3760 File Offset: 0x000B1960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendHistoryInfo> Parser
		{
			get
			{
				return FriendHistoryInfo._parser;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x000B3767 File Offset: 0x000B1967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendHistoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x000B3779 File Offset: 0x000B1979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendHistoryInfo.Descriptor;
			}
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x000B3780 File Offset: 0x000B1980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendHistoryInfo()
		{
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x000B3788 File Offset: 0x000B1988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendHistoryInfo(FriendHistoryInfo other) : this()
		{
			this.lastSendTime_ = other.lastSendTime_;
			this.contactId_ = other.contactId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000B37B9 File Offset: 0x000B19B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendHistoryInfo Clone()
		{
			return new FriendHistoryInfo(this);
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x000B37C1 File Offset: 0x000B19C1
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x000B37C9 File Offset: 0x000B19C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastSendTime
		{
			get
			{
				return this.lastSendTime_;
			}
			set
			{
				this.lastSendTime_ = value;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x000B37D2 File Offset: 0x000B19D2
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x000B37DA File Offset: 0x000B19DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContactId
		{
			get
			{
				return this.contactId_;
			}
			set
			{
				this.contactId_ = value;
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000B37E3 File Offset: 0x000B19E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendHistoryInfo);
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x000B37F1 File Offset: 0x000B19F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendHistoryInfo other)
		{
			return other != null && (other == this || (this.LastSendTime == other.LastSendTime && this.ContactId == other.ContactId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000B3830 File Offset: 0x000B1A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LastSendTime != 0L)
			{
				num ^= this.LastSendTime.GetHashCode();
			}
			if (this.ContactId != 0U)
			{
				num ^= this.ContactId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000B3888 File Offset: 0x000B1A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000B3890 File Offset: 0x000B1A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x000B389C File Offset: 0x000B1A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastSendTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LastSendTime);
			}
			if (this.ContactId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ContactId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x000B38F8 File Offset: 0x000B1AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LastSendTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastSendTime);
			}
			if (this.ContactId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContactId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000B3950 File Offset: 0x000B1B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendHistoryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LastSendTime != 0L)
			{
				this.LastSendTime = other.LastSendTime;
			}
			if (other.ContactId != 0U)
			{
				this.ContactId = other.ContactId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000B39A0 File Offset: 0x000B1BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x000B39AC File Offset: 0x000B1BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ContactId = input.ReadUInt32();
					}
				}
				else
				{
					this.LastSendTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04001A2B RID: 6699
		private static readonly MessageParser<FriendHistoryInfo> _parser = new MessageParser<FriendHistoryInfo>(() => new FriendHistoryInfo());

		// Token: 0x04001A2C RID: 6700
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A2D RID: 6701
		public const int LastSendTimeFieldNumber = 3;

		// Token: 0x04001A2E RID: 6702
		private long lastSendTime_;

		// Token: 0x04001A2F RID: 6703
		public const int ContactIdFieldNumber = 13;

		// Token: 0x04001A30 RID: 6704
		private uint contactId_;
	}
}
