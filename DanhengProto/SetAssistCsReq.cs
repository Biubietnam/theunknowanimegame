using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CD RID: 4301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAssistCsReq : IMessage<SetAssistCsReq>, IMessage, IEquatable<SetAssistCsReq>, IDeepCloneable<SetAssistCsReq>, IBufferMessage
	{
		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600BFC9 RID: 49097 RVA: 0x00204520 File Offset: 0x00202720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAssistCsReq> Parser
		{
			get
			{
				return SetAssistCsReq._parser;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600BFCA RID: 49098 RVA: 0x00204527 File Offset: 0x00202727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAssistCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x00204539 File Offset: 0x00202739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAssistCsReq.Descriptor;
			}
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x00204540 File Offset: 0x00202740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistCsReq()
		{
		}

		// Token: 0x0600BFCD RID: 49101 RVA: 0x00204548 File Offset: 0x00202748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistCsReq(SetAssistCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x00204579 File Offset: 0x00202779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistCsReq Clone()
		{
			return new SetAssistCsReq(this);
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x00204581 File Offset: 0x00202781
		// (set) Token: 0x0600BFD0 RID: 49104 RVA: 0x00204589 File Offset: 0x00202789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x00204592 File Offset: 0x00202792
		// (set) Token: 0x0600BFD2 RID: 49106 RVA: 0x0020459A File Offset: 0x0020279A
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

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x002045A3 File Offset: 0x002027A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAssistCsReq);
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x002045B1 File Offset: 0x002027B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAssistCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x002045F0 File Offset: 0x002027F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
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

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x00204648 File Offset: 0x00202848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x00204650 File Offset: 0x00202850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x0020465C File Offset: 0x0020285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Uid);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x002046B8 File Offset: 0x002028B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
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

		// Token: 0x0600BFDA RID: 49114 RVA: 0x00204710 File Offset: 0x00202910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAssistCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x00204760 File Offset: 0x00202960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x0020476C File Offset: 0x0020296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DD6 RID: 19926
		private static readonly MessageParser<SetAssistCsReq> _parser = new MessageParser<SetAssistCsReq>(() => new SetAssistCsReq());

		// Token: 0x04004DD7 RID: 19927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD8 RID: 19928
		public const int AvatarIdFieldNumber = 11;

		// Token: 0x04004DD9 RID: 19929
		private uint avatarId_;

		// Token: 0x04004DDA RID: 19930
		public const int UidFieldNumber = 5;

		// Token: 0x04004DDB RID: 19931
		private uint uid_;
	}
}
