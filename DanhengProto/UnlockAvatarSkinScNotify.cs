using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013BB RID: 5051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockAvatarSkinScNotify : IMessage<UnlockAvatarSkinScNotify>, IMessage, IEquatable<UnlockAvatarSkinScNotify>, IDeepCloneable<UnlockAvatarSkinScNotify>, IBufferMessage
	{
		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0600E131 RID: 57649 RVA: 0x00257704 File Offset: 0x00255904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockAvatarSkinScNotify> Parser
		{
			get
			{
				return UnlockAvatarSkinScNotify._parser;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0600E132 RID: 57650 RVA: 0x0025770B File Offset: 0x0025590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockAvatarSkinScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x0025771D File Offset: 0x0025591D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockAvatarSkinScNotify.Descriptor;
			}
		}

		// Token: 0x0600E134 RID: 57652 RVA: 0x00257724 File Offset: 0x00255924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarSkinScNotify()
		{
		}

		// Token: 0x0600E135 RID: 57653 RVA: 0x0025772C File Offset: 0x0025592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarSkinScNotify(UnlockAvatarSkinScNotify other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E136 RID: 57654 RVA: 0x00257751 File Offset: 0x00255951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarSkinScNotify Clone()
		{
			return new UnlockAvatarSkinScNotify(this);
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0600E137 RID: 57655 RVA: 0x00257759 File Offset: 0x00255959
		// (set) Token: 0x0600E138 RID: 57656 RVA: 0x00257761 File Offset: 0x00255961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x0600E139 RID: 57657 RVA: 0x0025776A File Offset: 0x0025596A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockAvatarSkinScNotify);
		}

		// Token: 0x0600E13A RID: 57658 RVA: 0x00257778 File Offset: 0x00255978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockAvatarSkinScNotify other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E13B RID: 57659 RVA: 0x002577A8 File Offset: 0x002559A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0U)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E13C RID: 57660 RVA: 0x002577E7 File Offset: 0x002559E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E13D RID: 57661 RVA: 0x002577EF File Offset: 0x002559EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E13E RID: 57662 RVA: 0x002577F8 File Offset: 0x002559F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x0025782C File Offset: 0x00255A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x0025786A File Offset: 0x00255A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockAvatarSkinScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0U)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E141 RID: 57665 RVA: 0x0025789B File Offset: 0x00255A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E142 RID: 57666 RVA: 0x002578A4 File Offset: 0x00255AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059A9 RID: 22953
		private static readonly MessageParser<UnlockAvatarSkinScNotify> _parser = new MessageParser<UnlockAvatarSkinScNotify>(() => new UnlockAvatarSkinScNotify());

		// Token: 0x040059AA RID: 22954
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059AB RID: 22955
		public const int SkinIdFieldNumber = 12;

		// Token: 0x040059AC RID: 22956
		private uint skinId_;
	}
}
