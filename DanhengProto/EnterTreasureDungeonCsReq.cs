using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047B RID: 1147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTreasureDungeonCsReq : IMessage<EnterTreasureDungeonCsReq>, IMessage, IEquatable<EnterTreasureDungeonCsReq>, IDeepCloneable<EnterTreasureDungeonCsReq>, IBufferMessage
	{
		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x0008C8E3 File Offset: 0x0008AAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTreasureDungeonCsReq> Parser
		{
			get
			{
				return EnterTreasureDungeonCsReq._parser;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x0008C8EA File Offset: 0x0008AAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTreasureDungeonCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x0008C8FC File Offset: 0x0008AAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTreasureDungeonCsReq.Descriptor;
			}
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0008C903 File Offset: 0x0008AB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonCsReq()
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0008C916 File Offset: 0x0008AB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonCsReq(EnterTreasureDungeonCsReq other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x0008C94C File Offset: 0x0008AB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonCsReq Clone()
		{
			return new EnterTreasureDungeonCsReq(this);
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x0008C954 File Offset: 0x0008AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureDungeonAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x0008C95C File Offset: 0x0008AB5C
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x0008C964 File Offset: 0x0008AB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0008C96D File Offset: 0x0008AB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTreasureDungeonCsReq);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0008C97C File Offset: 0x0008AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTreasureDungeonCsReq other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && this.NCFAJPAMBGD == other.NCFAJPAMBGD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x0008C9CC File Offset: 0x0008ABCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0008CA19 File Offset: 0x0008AC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x0008CA21 File Offset: 0x0008AC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x0008CA2C File Offset: 0x0008AC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			this.avatarList_.WriteTo(ref output, EnterTreasureDungeonCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0008CA7C File Offset: 0x0008AC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(EnterTreasureDungeonCsReq._repeated_avatarList_codec);
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0008CAD0 File Offset: 0x0008ACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTreasureDungeonCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x0008CB1D File Offset: 0x0008AD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x0008CB28 File Offset: 0x0008AD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterTreasureDungeonCsReq._repeated_avatarList_codec);
					}
				}
				else
				{
					this.NCFAJPAMBGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001456 RID: 5206
		private static readonly MessageParser<EnterTreasureDungeonCsReq> _parser = new MessageParser<EnterTreasureDungeonCsReq>(() => new EnterTreasureDungeonCsReq());

		// Token: 0x04001457 RID: 5207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001458 RID: 5208
		public const int AvatarListFieldNumber = 11;

		// Token: 0x04001459 RID: 5209
		private static readonly FieldCodec<TreasureDungeonAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<TreasureDungeonAvatar>(90U, TreasureDungeonAvatar.Parser);

		// Token: 0x0400145A RID: 5210
		private readonly RepeatedField<TreasureDungeonAvatar> avatarList_ = new RepeatedField<TreasureDungeonAvatar>();

		// Token: 0x0400145B RID: 5211
		public const int NCFAJPAMBGDFieldNumber = 1;

		// Token: 0x0400145C RID: 5212
		private uint nCFAJPAMBGD_;
	}
}
