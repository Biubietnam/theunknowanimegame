using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A9 RID: 169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ApplyFriendCsReq : IMessage<ApplyFriendCsReq>, IMessage, IEquatable<ApplyFriendCsReq>, IDeepCloneable<ApplyFriendCsReq>, IBufferMessage
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00014B0D File Offset: 0x00012D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ApplyFriendCsReq> Parser
		{
			get
			{
				return ApplyFriendCsReq._parser;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00014B14 File Offset: 0x00012D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ApplyFriendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00014B26 File Offset: 0x00012D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyFriendCsReq.Descriptor;
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00014B2D File Offset: 0x00012D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendCsReq()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00014B35 File Offset: 0x00012D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendCsReq(ApplyFriendCsReq other) : this()
		{
			this.source_ = other.source_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00014B66 File Offset: 0x00012D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendCsReq Clone()
		{
			return new ApplyFriendCsReq(this);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00014B6E File Offset: 0x00012D6E
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00014B76 File Offset: 0x00012D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySource Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00014B7F File Offset: 0x00012D7F
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00014B87 File Offset: 0x00012D87
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

		// Token: 0x06000754 RID: 1876 RVA: 0x00014B90 File Offset: 0x00012D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyFriendCsReq);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00014B9E File Offset: 0x00012D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyFriendCsReq other)
		{
			return other != null && (other == this || (this.Source == other.Source && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00014BDC File Offset: 0x00012DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Source != FriendApplySource.None)
			{
				num ^= this.Source.GetHashCode();
			}
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

		// Token: 0x06000757 RID: 1879 RVA: 0x00014C3A File Offset: 0x00012E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00014C42 File Offset: 0x00012E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00014C4C File Offset: 0x00012E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Source != FriendApplySource.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Source);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00014CA8 File Offset: 0x00012EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Source != FriendApplySource.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
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

		// Token: 0x0600075B RID: 1883 RVA: 0x00014D00 File Offset: 0x00012F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyFriendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Source != FriendApplySource.None)
			{
				this.Source = other.Source;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00014D50 File Offset: 0x00012F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00014D5C File Offset: 0x00012F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.Source = (FriendApplySource)input.ReadEnum();
				}
			}
		}

		// Token: 0x040002B7 RID: 695
		private static readonly MessageParser<ApplyFriendCsReq> _parser = new MessageParser<ApplyFriendCsReq>(() => new ApplyFriendCsReq());

		// Token: 0x040002B8 RID: 696
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002B9 RID: 697
		public const int SourceFieldNumber = 4;

		// Token: 0x040002BA RID: 698
		private FriendApplySource source_;

		// Token: 0x040002BB RID: 699
		public const int UidFieldNumber = 7;

		// Token: 0x040002BC RID: 700
		private uint uid_;
	}
}
