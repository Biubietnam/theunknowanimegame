using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000061 RID: 97
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideSpiritExpUpCsReq : IMessage<AetherDivideSpiritExpUpCsReq>, IMessage, IEquatable<AetherDivideSpiritExpUpCsReq>, IDeepCloneable<AetherDivideSpiritExpUpCsReq>, IBufferMessage
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000C135 File Offset: 0x0000A335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideSpiritExpUpCsReq> Parser
		{
			get
			{
				return AetherDivideSpiritExpUpCsReq._parser;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000C13C File Offset: 0x0000A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritExpUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000C14E File Offset: 0x0000A34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideSpiritExpUpCsReq.Descriptor;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000C155 File Offset: 0x0000A355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpCsReq()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000C15D File Offset: 0x0000A35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpCsReq(AetherDivideSpiritExpUpCsReq other) : this()
		{
			this.eBNHBIPAEMP_ = other.eBNHBIPAEMP_;
			this.aetherAvatarId_ = other.aetherAvatarId_;
			this.nPGOMLFGBJM_ = other.nPGOMLFGBJM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000C19A File Offset: 0x0000A39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritExpUpCsReq Clone()
		{
			return new AetherDivideSpiritExpUpCsReq(this);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000C1A2 File Offset: 0x0000A3A2
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EBNHBIPAEMP
		{
			get
			{
				return this.eBNHBIPAEMP_;
			}
			set
			{
				this.eBNHBIPAEMP_ = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000C1B3 File Offset: 0x0000A3B3
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000C1BB File Offset: 0x0000A3BB
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NPGOMLFGBJM
		{
			get
			{
				return this.nPGOMLFGBJM_;
			}
			set
			{
				this.nPGOMLFGBJM_ = value;
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000C1D5 File Offset: 0x0000A3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideSpiritExpUpCsReq);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideSpiritExpUpCsReq other)
		{
			return other != null && (other == this || (this.EBNHBIPAEMP == other.EBNHBIPAEMP && this.AetherAvatarId == other.AetherAvatarId && this.NPGOMLFGBJM == other.NPGOMLFGBJM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000C240 File Offset: 0x0000A440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EBNHBIPAEMP != 0U)
			{
				num ^= this.EBNHBIPAEMP.GetHashCode();
			}
			if (this.AetherAvatarId != 0U)
			{
				num ^= this.AetherAvatarId.GetHashCode();
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num ^= this.NPGOMLFGBJM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000C2B1 File Offset: 0x0000A4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000C2B9 File Offset: 0x0000A4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AetherAvatarId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AetherAvatarId);
			}
			if (this.EBNHBIPAEMP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.EBNHBIPAEMP);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NPGOMLFGBJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000C33C File Offset: 0x0000A53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EBNHBIPAEMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EBNHBIPAEMP);
			}
			if (this.AetherAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AetherAvatarId);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NPGOMLFGBJM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideSpiritExpUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EBNHBIPAEMP != 0U)
			{
				this.EBNHBIPAEMP = other.EBNHBIPAEMP;
			}
			if (other.AetherAvatarId != 0U)
			{
				this.AetherAvatarId = other.AetherAvatarId;
			}
			if (other.NPGOMLFGBJM != 0U)
			{
				this.NPGOMLFGBJM = other.NPGOMLFGBJM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C410 File Offset: 0x0000A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C41C File Offset: 0x0000A61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NPGOMLFGBJM = input.ReadUInt32();
						}
					}
					else
					{
						this.EBNHBIPAEMP = input.ReadUInt32();
					}
				}
				else
				{
					this.AetherAvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400017A RID: 378
		private static readonly MessageParser<AetherDivideSpiritExpUpCsReq> _parser = new MessageParser<AetherDivideSpiritExpUpCsReq>(() => new AetherDivideSpiritExpUpCsReq());

		// Token: 0x0400017B RID: 379
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400017C RID: 380
		public const int EBNHBIPAEMPFieldNumber = 11;

		// Token: 0x0400017D RID: 381
		private uint eBNHBIPAEMP_;

		// Token: 0x0400017E RID: 382
		public const int AetherAvatarIdFieldNumber = 7;

		// Token: 0x0400017F RID: 383
		private uint aetherAvatarId_;

		// Token: 0x04000180 RID: 384
		public const int NPGOMLFGBJMFieldNumber = 15;

		// Token: 0x04000181 RID: 385
		private uint nPGOMLFGBJM_;
	}
}
