using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000371 RID: 881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteFriendCsReq : IMessage<DeleteFriendCsReq>, IMessage, IEquatable<DeleteFriendCsReq>, IDeepCloneable<DeleteFriendCsReq>, IBufferMessage
	{
		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteFriendCsReq> Parser
		{
			get
			{
				return DeleteFriendCsReq._parser;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x0006D8F7 File Offset: 0x0006BAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteFriendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x0006D909 File Offset: 0x0006BB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteFriendCsReq.Descriptor;
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0006D910 File Offset: 0x0006BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendCsReq()
		{
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0006D918 File Offset: 0x0006BB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendCsReq(DeleteFriendCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this.lEJFPAJNHDD_ = other.lEJFPAJNHDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0006D949 File Offset: 0x0006BB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendCsReq Clone()
		{
			return new DeleteFriendCsReq(this);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x0006D951 File Offset: 0x0006BB51
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x0006D959 File Offset: 0x0006BB59
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x0006D962 File Offset: 0x0006BB62
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x0006D96A File Offset: 0x0006BB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LEJFPAJNHDD
		{
			get
			{
				return this.lEJFPAJNHDD_;
			}
			set
			{
				this.lEJFPAJNHDD_ = value;
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0006D973 File Offset: 0x0006BB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteFriendCsReq);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0006D981 File Offset: 0x0006BB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteFriendCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.LEJFPAJNHDD == other.LEJFPAJNHDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0006D9C0 File Offset: 0x0006BBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.LEJFPAJNHDD != 0U)
			{
				num ^= this.LEJFPAJNHDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0006DA18 File Offset: 0x0006BC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0006DA20 File Offset: 0x0006BC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0006DA2C File Offset: 0x0006BC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Uid);
			}
			if (this.LEJFPAJNHDD != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LEJFPAJNHDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0006DA88 File Offset: 0x0006BC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.LEJFPAJNHDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LEJFPAJNHDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0006DAE0 File Offset: 0x0006BCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteFriendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.LEJFPAJNHDD != 0U)
			{
				this.LEJFPAJNHDD = other.LEJFPAJNHDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0006DB30 File Offset: 0x0006BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LEJFPAJNHDD = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FD3 RID: 4051
		private static readonly MessageParser<DeleteFriendCsReq> _parser = new MessageParser<DeleteFriendCsReq>(() => new DeleteFriendCsReq());

		// Token: 0x04000FD4 RID: 4052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FD5 RID: 4053
		public const int UidFieldNumber = 3;

		// Token: 0x04000FD6 RID: 4054
		private uint uid_;

		// Token: 0x04000FD7 RID: 4055
		public const int LEJFPAJNHDDFieldNumber = 11;

		// Token: 0x04000FD8 RID: 4056
		private uint lEJFPAJNHDD_;
	}
}
