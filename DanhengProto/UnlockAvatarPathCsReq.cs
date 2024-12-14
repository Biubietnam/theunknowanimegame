using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B7 RID: 5047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockAvatarPathCsReq : IMessage<UnlockAvatarPathCsReq>, IMessage, IEquatable<UnlockAvatarPathCsReq>, IDeepCloneable<UnlockAvatarPathCsReq>, IBufferMessage
	{
		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x00256F69 File Offset: 0x00255169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockAvatarPathCsReq> Parser
		{
			get
			{
				return UnlockAvatarPathCsReq._parser;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0600E103 RID: 57603 RVA: 0x00256F70 File Offset: 0x00255170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockAvatarPathCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0600E104 RID: 57604 RVA: 0x00256F82 File Offset: 0x00255182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockAvatarPathCsReq.Descriptor;
			}
		}

		// Token: 0x0600E105 RID: 57605 RVA: 0x00256F89 File Offset: 0x00255189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathCsReq()
		{
		}

		// Token: 0x0600E106 RID: 57606 RVA: 0x00256F91 File Offset: 0x00255191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathCsReq(UnlockAvatarPathCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E107 RID: 57607 RVA: 0x00256FB6 File Offset: 0x002551B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathCsReq Clone()
		{
			return new UnlockAvatarPathCsReq(this);
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x00256FBE File Offset: 0x002551BE
		// (set) Token: 0x0600E109 RID: 57609 RVA: 0x00256FC6 File Offset: 0x002551C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType AvatarId
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

		// Token: 0x0600E10A RID: 57610 RVA: 0x00256FCF File Offset: 0x002551CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockAvatarPathCsReq);
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x00256FDD File Offset: 0x002551DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockAvatarPathCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x0025700C File Offset: 0x0025520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x00257051 File Offset: 0x00255251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x00257059 File Offset: 0x00255259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E10F RID: 57615 RVA: 0x00257062 File Offset: 0x00255262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E110 RID: 57616 RVA: 0x00257094 File Offset: 0x00255294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x002570D2 File Offset: 0x002552D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockAvatarPathCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != MultiPathAvatarType.None)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x00257103 File Offset: 0x00255303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E113 RID: 57619 RVA: 0x0025710C File Offset: 0x0025530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AvatarId = (MultiPathAvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005998 RID: 22936
		private static readonly MessageParser<UnlockAvatarPathCsReq> _parser = new MessageParser<UnlockAvatarPathCsReq>(() => new UnlockAvatarPathCsReq());

		// Token: 0x04005999 RID: 22937
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400599A RID: 22938
		public const int AvatarIdFieldNumber = 14;

		// Token: 0x0400599B RID: 22939
		private MultiPathAvatarType avatarId_;
	}
}
