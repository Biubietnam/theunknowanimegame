using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F5 RID: 4853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffAvatarSkinCsReq : IMessage<TakeOffAvatarSkinCsReq>, IMessage, IEquatable<TakeOffAvatarSkinCsReq>, IDeepCloneable<TakeOffAvatarSkinCsReq>, IBufferMessage
	{
		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600D88C RID: 55436 RVA: 0x00241818 File Offset: 0x0023FA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffAvatarSkinCsReq> Parser
		{
			get
			{
				return TakeOffAvatarSkinCsReq._parser;
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600D88D RID: 55437 RVA: 0x0024181F File Offset: 0x0023FA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffAvatarSkinCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600D88E RID: 55438 RVA: 0x00241831 File Offset: 0x0023FA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffAvatarSkinCsReq.Descriptor;
			}
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x00241838 File Offset: 0x0023FA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinCsReq()
		{
		}

		// Token: 0x0600D890 RID: 55440 RVA: 0x00241840 File Offset: 0x0023FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinCsReq(TakeOffAvatarSkinCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D891 RID: 55441 RVA: 0x00241865 File Offset: 0x0023FA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinCsReq Clone()
		{
			return new TakeOffAvatarSkinCsReq(this);
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600D892 RID: 55442 RVA: 0x0024186D File Offset: 0x0023FA6D
		// (set) Token: 0x0600D893 RID: 55443 RVA: 0x00241875 File Offset: 0x0023FA75
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

		// Token: 0x0600D894 RID: 55444 RVA: 0x0024187E File Offset: 0x0023FA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffAvatarSkinCsReq);
		}

		// Token: 0x0600D895 RID: 55445 RVA: 0x0024188C File Offset: 0x0023FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffAvatarSkinCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D896 RID: 55446 RVA: 0x002418BC File Offset: 0x0023FABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D897 RID: 55447 RVA: 0x002418FB File Offset: 0x0023FAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x00241903 File Offset: 0x0023FB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D899 RID: 55449 RVA: 0x0024190C File Offset: 0x0023FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x00241940 File Offset: 0x0023FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D89B RID: 55451 RVA: 0x0024197E File Offset: 0x0023FB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffAvatarSkinCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D89C RID: 55452 RVA: 0x002419AF File Offset: 0x0023FBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D89D RID: 55453 RVA: 0x002419B8 File Offset: 0x0023FBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005668 RID: 22120
		private static readonly MessageParser<TakeOffAvatarSkinCsReq> _parser = new MessageParser<TakeOffAvatarSkinCsReq>(() => new TakeOffAvatarSkinCsReq());

		// Token: 0x04005669 RID: 22121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400566A RID: 22122
		public const int AvatarIdFieldNumber = 9;

		// Token: 0x0400566B RID: 22123
		private uint avatarId_;
	}
}
