using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A81 RID: 2689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkAvatarCsReq : IMessage<MarkAvatarCsReq>, IMessage, IEquatable<MarkAvatarCsReq>, IDeepCloneable<MarkAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06007730 RID: 30512 RVA: 0x0013C388 File Offset: 0x0013A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkAvatarCsReq> Parser
		{
			get
			{
				return MarkAvatarCsReq._parser;
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06007731 RID: 30513 RVA: 0x0013C38F File Offset: 0x0013A58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x0013C3A1 File Offset: 0x0013A5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x0013C3A8 File Offset: 0x0013A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarCsReq()
		{
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x0013C3B0 File Offset: 0x0013A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarCsReq(MarkAvatarCsReq other) : this()
		{
			this.isMarked_ = other.isMarked_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x0013C3E1 File Offset: 0x0013A5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarCsReq Clone()
		{
			return new MarkAvatarCsReq(this);
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x0013C3E9 File Offset: 0x0013A5E9
		// (set) Token: 0x06007737 RID: 30519 RVA: 0x0013C3F1 File Offset: 0x0013A5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x0013C3FA File Offset: 0x0013A5FA
		// (set) Token: 0x06007739 RID: 30521 RVA: 0x0013C402 File Offset: 0x0013A602
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

		// Token: 0x0600773A RID: 30522 RVA: 0x0013C40B File Offset: 0x0013A60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkAvatarCsReq);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x0013C419 File Offset: 0x0013A619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkAvatarCsReq other)
		{
			return other != null && (other == this || (this.IsMarked == other.IsMarked && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x0013C458 File Offset: 0x0013A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x0013C4B0 File Offset: 0x0013A6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x0013C4B8 File Offset: 0x0013A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x0013C4C4 File Offset: 0x0013A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.IsMarked)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsMarked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x0013C520 File Offset: 0x0013A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsMarked)
			{
				num += 2;
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x0013C56C File Offset: 0x0013A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x0013C5BC File Offset: 0x0013A7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x0013C5C8 File Offset: 0x0013A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsMarked = input.ReadBool();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DC8 RID: 11720
		private static readonly MessageParser<MarkAvatarCsReq> _parser = new MessageParser<MarkAvatarCsReq>(() => new MarkAvatarCsReq());

		// Token: 0x04002DC9 RID: 11721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DCA RID: 11722
		public const int IsMarkedFieldNumber = 10;

		// Token: 0x04002DCB RID: 11723
		private bool isMarked_;

		// Token: 0x04002DCC RID: 11724
		public const int AvatarIdFieldNumber = 5;

		// Token: 0x04002DCD RID: 11725
		private uint avatarId_;
	}
}
