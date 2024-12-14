using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000857 RID: 2135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GGCPLONEAEG : IMessage<GGCPLONEAEG>, IMessage, IEquatable<GGCPLONEAEG>, IDeepCloneable<GGCPLONEAEG>, IBufferMessage
	{
		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x000FB47C File Offset: 0x000F967C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GGCPLONEAEG> Parser
		{
			get
			{
				return GGCPLONEAEG._parser;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x000FB483 File Offset: 0x000F9683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GGCPLONEAEGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x000FB495 File Offset: 0x000F9695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GGCPLONEAEG.Descriptor;
			}
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x000FB49C File Offset: 0x000F969C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGCPLONEAEG()
		{
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x000FB4A4 File Offset: 0x000F96A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGCPLONEAEG(GGCPLONEAEG other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x000FB4D5 File Offset: 0x000F96D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGCPLONEAEG Clone()
		{
			return new GGCPLONEAEG(this);
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x000FB4DD File Offset: 0x000F96DD
		// (set) Token: 0x06005EF8 RID: 24312 RVA: 0x000FB4E5 File Offset: 0x000F96E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06005EF9 RID: 24313 RVA: 0x000FB4EE File Offset: 0x000F96EE
		// (set) Token: 0x06005EFA RID: 24314 RVA: 0x000FB4F6 File Offset: 0x000F96F6
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

		// Token: 0x06005EFB RID: 24315 RVA: 0x000FB4FF File Offset: 0x000F96FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GGCPLONEAEG);
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x000FB50D File Offset: 0x000F970D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GGCPLONEAEG other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x000FB54C File Offset: 0x000F974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != 0U)
			{
				num ^= this.AvatarType.GetHashCode();
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

		// Token: 0x06005EFE RID: 24318 RVA: 0x000FB5A4 File Offset: 0x000F97A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x000FB5AC File Offset: 0x000F97AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x000FB5B8 File Offset: 0x000F97B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x000FB614 File Offset: 0x000F9814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarType);
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

		// Token: 0x06005F02 RID: 24322 RVA: 0x000FB66C File Offset: 0x000F986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GGCPLONEAEG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != 0U)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x000FB6BC File Offset: 0x000F98BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x000FB6C8 File Offset: 0x000F98C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 112U)
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
					this.AvatarType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400248C RID: 9356
		private static readonly MessageParser<GGCPLONEAEG> _parser = new MessageParser<GGCPLONEAEG>(() => new GGCPLONEAEG());

		// Token: 0x0400248D RID: 9357
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400248E RID: 9358
		public const int AvatarTypeFieldNumber = 5;

		// Token: 0x0400248F RID: 9359
		private uint avatarType_;

		// Token: 0x04002490 RID: 9360
		public const int AvatarIdFieldNumber = 14;

		// Token: 0x04002491 RID: 9361
		private uint avatarId_;
	}
}
