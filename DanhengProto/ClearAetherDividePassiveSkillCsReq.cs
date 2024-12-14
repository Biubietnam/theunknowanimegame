using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D1 RID: 721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClearAetherDividePassiveSkillCsReq : IMessage<ClearAetherDividePassiveSkillCsReq>, IMessage, IEquatable<ClearAetherDividePassiveSkillCsReq>, IDeepCloneable<ClearAetherDividePassiveSkillCsReq>, IBufferMessage
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0005B59D File Offset: 0x0005979D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClearAetherDividePassiveSkillCsReq> Parser
		{
			get
			{
				return ClearAetherDividePassiveSkillCsReq._parser;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0005B5A4 File Offset: 0x000597A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClearAetherDividePassiveSkillCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0005B5B6 File Offset: 0x000597B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearAetherDividePassiveSkillCsReq.Descriptor;
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0005B5BD File Offset: 0x000597BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillCsReq()
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0005B5C5 File Offset: 0x000597C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillCsReq(ClearAetherDividePassiveSkillCsReq other) : this()
		{
			this.aetherAvatarId_ = other.aetherAvatarId_;
			this.slot_ = other.slot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0005B5F6 File Offset: 0x000597F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillCsReq Clone()
		{
			return new ClearAetherDividePassiveSkillCsReq(this);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0005B5FE File Offset: 0x000597FE
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0005B606 File Offset: 0x00059806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AetherAvatarId
		{
			get
			{
				return this.aetherAvatarId_;
			}
			set
			{
				this.aetherAvatarId_ = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0005B60F File Offset: 0x0005980F
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0005B617 File Offset: 0x00059817
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

		// Token: 0x06002022 RID: 8226 RVA: 0x0005B620 File Offset: 0x00059820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClearAetherDividePassiveSkillCsReq);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0005B62E File Offset: 0x0005982E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClearAetherDividePassiveSkillCsReq other)
		{
			return other != null && (other == this || (this.AetherAvatarId == other.AetherAvatarId && this.Slot == other.Slot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0005B66C File Offset: 0x0005986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AetherAvatarId != 0U)
			{
				num ^= this.AetherAvatarId.GetHashCode();
			}
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

		// Token: 0x06002025 RID: 8229 RVA: 0x0005B6C4 File Offset: 0x000598C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0005B6CC File Offset: 0x000598CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0005B6D8 File Offset: 0x000598D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Slot);
			}
			if (this.AetherAvatarId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AetherAvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0005B734 File Offset: 0x00059934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AetherAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AetherAvatarId);
			}
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

		// Token: 0x06002029 RID: 8233 RVA: 0x0005B78C File Offset: 0x0005998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClearAetherDividePassiveSkillCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AetherAvatarId != 0U)
			{
				this.AetherAvatarId = other.AetherAvatarId;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0005B7DC File Offset: 0x000599DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0005B7E8 File Offset: 0x000599E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AetherAvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.Slot = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D49 RID: 3401
		private static readonly MessageParser<ClearAetherDividePassiveSkillCsReq> _parser = new MessageParser<ClearAetherDividePassiveSkillCsReq>(() => new ClearAetherDividePassiveSkillCsReq());

		// Token: 0x04000D4A RID: 3402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D4B RID: 3403
		public const int AetherAvatarIdFieldNumber = 15;

		// Token: 0x04000D4C RID: 3404
		private uint aetherAvatarId_;

		// Token: 0x04000D4D RID: 3405
		public const int SlotFieldNumber = 2;

		// Token: 0x04000D4E RID: 3406
		private uint slot_;
	}
}
