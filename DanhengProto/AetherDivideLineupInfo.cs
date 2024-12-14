using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000055 RID: 85
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideLineupInfo : IMessage<AetherDivideLineupInfo>, IMessage, IEquatable<AetherDivideLineupInfo>, IDeepCloneable<AetherDivideLineupInfo>, IBufferMessage
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000B085 File Offset: 0x00009285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideLineupInfo> Parser
		{
			get
			{
				return AetherDivideLineupInfo._parser;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000B08C File Offset: 0x0000928C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideLineupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000B09E File Offset: 0x0000929E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideLineupInfo.Descriptor;
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B0A5 File Offset: 0x000092A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo()
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo(AetherDivideLineupInfo other) : this()
		{
			this.aetherAvatarList_ = other.aetherAvatarList_.Clone();
			this.slot_ = other.slot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000B0EE File Offset: 0x000092EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo Clone()
		{
			return new AetherDivideLineupInfo(this);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000B0F6 File Offset: 0x000092F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AetherAvatarList
		{
			get
			{
				return this.aetherAvatarList_;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000B0FE File Offset: 0x000092FE
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000B106 File Offset: 0x00009306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B10F File Offset: 0x0000930F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideLineupInfo);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000B120 File Offset: 0x00009320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideLineupInfo other)
		{
			return other != null && (other == this || (this.aetherAvatarList_.Equals(other.aetherAvatarList_) && this.Slot == other.Slot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000B170 File Offset: 0x00009370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aetherAvatarList_.GetHashCode();
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000B1BD File Offset: 0x000093BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000B1C5 File Offset: 0x000093C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000B1D0 File Offset: 0x000093D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Slot);
			}
			this.aetherAvatarList_.WriteTo(ref output, AetherDivideLineupInfo._repeated_aetherAvatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000B220 File Offset: 0x00009420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aetherAvatarList_.CalculateSize(AetherDivideLineupInfo._repeated_aetherAvatarList_codec);
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000B274 File Offset: 0x00009474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideLineupInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.aetherAvatarList_.Add(other.aetherAvatarList_);
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000B2C1 File Offset: 0x000094C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000B2CC File Offset: 0x000094CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aetherAvatarList_.AddEntriesFrom(ref input, AetherDivideLineupInfo._repeated_aetherAvatarList_codec);
					}
				}
				else
				{
					this.Slot = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000157 RID: 343
		private static readonly MessageParser<AetherDivideLineupInfo> _parser = new MessageParser<AetherDivideLineupInfo>(() => new AetherDivideLineupInfo());

		// Token: 0x04000158 RID: 344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000159 RID: 345
		public const int AetherAvatarListFieldNumber = 13;

		// Token: 0x0400015A RID: 346
		private static readonly FieldCodec<uint> _repeated_aetherAvatarList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x0400015B RID: 347
		private readonly RepeatedField<uint> aetherAvatarList_ = new RepeatedField<uint>();

		// Token: 0x0400015C RID: 348
		public const int SlotFieldNumber = 8;

		// Token: 0x0400015D RID: 349
		private uint slot_;
	}
}
