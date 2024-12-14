using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000889 RID: 2185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HandleFriendCsReq : IMessage<HandleFriendCsReq>, IMessage, IEquatable<HandleFriendCsReq>, IDeepCloneable<HandleFriendCsReq>, IBufferMessage
	{
		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x0600612C RID: 24876 RVA: 0x00100CE0 File Offset: 0x000FEEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandleFriendCsReq> Parser
		{
			get
			{
				return HandleFriendCsReq._parser;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x00100CE7 File Offset: 0x000FEEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HandleFriendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x0600612E RID: 24878 RVA: 0x00100CF9 File Offset: 0x000FEEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandleFriendCsReq.Descriptor;
			}
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00100D00 File Offset: 0x000FEF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendCsReq()
		{
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00100D08 File Offset: 0x000FEF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendCsReq(HandleFriendCsReq other) : this()
		{
			this.isAccept_ = other.isAccept_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x00100D39 File Offset: 0x000FEF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleFriendCsReq Clone()
		{
			return new HandleFriendCsReq(this);
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x00100D41 File Offset: 0x000FEF41
		// (set) Token: 0x06006133 RID: 24883 RVA: 0x00100D49 File Offset: 0x000FEF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAccept
		{
			get
			{
				return this.isAccept_;
			}
			set
			{
				this.isAccept_ = value;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06006134 RID: 24884 RVA: 0x00100D52 File Offset: 0x000FEF52
		// (set) Token: 0x06006135 RID: 24885 RVA: 0x00100D5A File Offset: 0x000FEF5A
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

		// Token: 0x06006136 RID: 24886 RVA: 0x00100D63 File Offset: 0x000FEF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandleFriendCsReq);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00100D71 File Offset: 0x000FEF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandleFriendCsReq other)
		{
			return other != null && (other == this || (this.IsAccept == other.IsAccept && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x00100DB0 File Offset: 0x000FEFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAccept)
			{
				num ^= this.IsAccept.GetHashCode();
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

		// Token: 0x06006139 RID: 24889 RVA: 0x00100E08 File Offset: 0x000FF008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x00100E10 File Offset: 0x000FF010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x00100E1C File Offset: 0x000FF01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAccept)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAccept);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00100E78 File Offset: 0x000FF078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAccept)
			{
				num += 2;
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

		// Token: 0x0600613D RID: 24893 RVA: 0x00100EC4 File Offset: 0x000FF0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandleFriendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAccept)
			{
				this.IsAccept = other.IsAccept;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00100F14 File Offset: 0x000FF114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x00100F20 File Offset: 0x000FF120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 96U)
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
					this.IsAccept = input.ReadBool();
				}
			}
		}

		// Token: 0x04002554 RID: 9556
		private static readonly MessageParser<HandleFriendCsReq> _parser = new MessageParser<HandleFriendCsReq>(() => new HandleFriendCsReq());

		// Token: 0x04002555 RID: 9557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002556 RID: 9558
		public const int IsAcceptFieldNumber = 8;

		// Token: 0x04002557 RID: 9559
		private bool isAccept_;

		// Token: 0x04002558 RID: 9560
		public const int UidFieldNumber = 12;

		// Token: 0x04002559 RID: 9561
		private uint uid_;
	}
}
