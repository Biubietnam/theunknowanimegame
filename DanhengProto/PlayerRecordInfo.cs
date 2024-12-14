using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CCD RID: 3277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerRecordInfo : IMessage<PlayerRecordInfo>, IMessage, IEquatable<PlayerRecordInfo>, IDeepCloneable<PlayerRecordInfo>, IBufferMessage
	{
		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x00183958 File Offset: 0x00181B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerRecordInfo> Parser
		{
			get
			{
				return PlayerRecordInfo._parser;
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x0018395F File Offset: 0x00181B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerRecordInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x00183971 File Offset: 0x00181B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRecordInfo.Descriptor;
			}
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x00183978 File Offset: 0x00181B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecordInfo()
		{
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x00183980 File Offset: 0x00181B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecordInfo(PlayerRecordInfo other) : this()
		{
			this.hEFKKIANPJE_ = other.hEFKKIANPJE_;
			this.collectionInfo_ = ((other.collectionInfo_ != null) ? other.collectionInfo_.Clone() : null);
			this.mBBDPBOOEAP_ = other.mBBDPBOOEAP_;
			this.iNNBJJFDEBD_ = other.iNNBJJFDEBD_;
			this.hMHGEDPFEBA_ = other.hMHGEDPFEBA_;
			this.jIOMBOMGDHP_ = other.jIOMBOMGDHP_;
			this.jEMLCOOOBOO_ = other.jEMLCOOOBOO_;
			this.kNJPGKKOEDD_ = other.kNJPGKKOEDD_;
			this.fABJGCEEABG_ = other.fABJGCEEABG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x00183A20 File Offset: 0x00181C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecordInfo Clone()
		{
			return new PlayerRecordInfo(this);
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x00183A28 File Offset: 0x00181C28
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x00183A30 File Offset: 0x00181C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HEFKKIANPJE
		{
			get
			{
				return this.hEFKKIANPJE_;
			}
			set
			{
				this.hEFKKIANPJE_ = value;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x00183A39 File Offset: 0x00181C39
		// (set) Token: 0x0600922B RID: 37419 RVA: 0x00183A41 File Offset: 0x00181C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCollectionInfo CollectionInfo
		{
			get
			{
				return this.collectionInfo_;
			}
			set
			{
				this.collectionInfo_ = value;
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600922C RID: 37420 RVA: 0x00183A4A File Offset: 0x00181C4A
		// (set) Token: 0x0600922D RID: 37421 RVA: 0x00183A52 File Offset: 0x00181C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBBDPBOOEAP
		{
			get
			{
				return this.mBBDPBOOEAP_;
			}
			set
			{
				this.mBBDPBOOEAP_ = value;
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600922E RID: 37422 RVA: 0x00183A5B File Offset: 0x00181C5B
		// (set) Token: 0x0600922F RID: 37423 RVA: 0x00183A63 File Offset: 0x00181C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint INNBJJFDEBD
		{
			get
			{
				return this.iNNBJJFDEBD_;
			}
			set
			{
				this.iNNBJJFDEBD_ = value;
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06009230 RID: 37424 RVA: 0x00183A6C File Offset: 0x00181C6C
		// (set) Token: 0x06009231 RID: 37425 RVA: 0x00183A74 File Offset: 0x00181C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HMHGEDPFEBA
		{
			get
			{
				return this.hMHGEDPFEBA_;
			}
			set
			{
				this.hMHGEDPFEBA_ = value;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06009232 RID: 37426 RVA: 0x00183A7D File Offset: 0x00181C7D
		// (set) Token: 0x06009233 RID: 37427 RVA: 0x00183A85 File Offset: 0x00181C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIOMBOMGDHP
		{
			get
			{
				return this.jIOMBOMGDHP_;
			}
			set
			{
				this.jIOMBOMGDHP_ = value;
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06009234 RID: 37428 RVA: 0x00183A8E File Offset: 0x00181C8E
		// (set) Token: 0x06009235 RID: 37429 RVA: 0x00183A96 File Offset: 0x00181C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JEMLCOOOBOO
		{
			get
			{
				return this.jEMLCOOOBOO_;
			}
			set
			{
				this.jEMLCOOOBOO_ = value;
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x06009236 RID: 37430 RVA: 0x00183A9F File Offset: 0x00181C9F
		// (set) Token: 0x06009237 RID: 37431 RVA: 0x00183AA7 File Offset: 0x00181CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KNJPGKKOEDD
		{
			get
			{
				return this.kNJPGKKOEDD_;
			}
			set
			{
				this.kNJPGKKOEDD_ = value;
			}
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06009238 RID: 37432 RVA: 0x00183AB0 File Offset: 0x00181CB0
		// (set) Token: 0x06009239 RID: 37433 RVA: 0x00183AB8 File Offset: 0x00181CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FABJGCEEABG
		{
			get
			{
				return this.fABJGCEEABG_;
			}
			set
			{
				this.fABJGCEEABG_ = value;
			}
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00183AC1 File Offset: 0x00181CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRecordInfo);
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00183AD0 File Offset: 0x00181CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRecordInfo other)
		{
			return other != null && (other == this || (this.HEFKKIANPJE == other.HEFKKIANPJE && object.Equals(this.CollectionInfo, other.CollectionInfo) && this.MBBDPBOOEAP == other.MBBDPBOOEAP && this.INNBJJFDEBD == other.INNBJJFDEBD && this.HMHGEDPFEBA == other.HMHGEDPFEBA && this.JIOMBOMGDHP == other.JIOMBOMGDHP && this.JEMLCOOOBOO == other.JEMLCOOOBOO && this.KNJPGKKOEDD == other.KNJPGKKOEDD && this.FABJGCEEABG == other.FABJGCEEABG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00183B90 File Offset: 0x00181D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HEFKKIANPJE != 0U)
			{
				num ^= this.HEFKKIANPJE.GetHashCode();
			}
			if (this.collectionInfo_ != null)
			{
				num ^= this.CollectionInfo.GetHashCode();
			}
			if (this.MBBDPBOOEAP != 0U)
			{
				num ^= this.MBBDPBOOEAP.GetHashCode();
			}
			if (this.INNBJJFDEBD != 0U)
			{
				num ^= this.INNBJJFDEBD.GetHashCode();
			}
			if (this.HMHGEDPFEBA != 0U)
			{
				num ^= this.HMHGEDPFEBA.GetHashCode();
			}
			if (this.JIOMBOMGDHP != 0U)
			{
				num ^= this.JIOMBOMGDHP.GetHashCode();
			}
			if (this.JEMLCOOOBOO != 0U)
			{
				num ^= this.JEMLCOOOBOO.GetHashCode();
			}
			if (this.KNJPGKKOEDD != 0U)
			{
				num ^= this.KNJPGKKOEDD.GetHashCode();
			}
			if (this.FABJGCEEABG != 0U)
			{
				num ^= this.FABJGCEEABG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00183C94 File Offset: 0x00181E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x00183C9C File Offset: 0x00181E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x00183CA8 File Offset: 0x00181EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FABJGCEEABG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FABJGCEEABG);
			}
			if (this.JEMLCOOOBOO != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.JEMLCOOOBOO);
			}
			if (this.HMHGEDPFEBA != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HMHGEDPFEBA);
			}
			if (this.JIOMBOMGDHP != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.JIOMBOMGDHP);
			}
			if (this.collectionInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CollectionInfo);
			}
			if (this.HEFKKIANPJE != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HEFKKIANPJE);
			}
			if (this.INNBJJFDEBD != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.INNBJJFDEBD);
			}
			if (this.MBBDPBOOEAP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MBBDPBOOEAP);
			}
			if (this.KNJPGKKOEDD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.KNJPGKKOEDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00183DC8 File Offset: 0x00181FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HEFKKIANPJE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HEFKKIANPJE);
			}
			if (this.collectionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CollectionInfo);
			}
			if (this.MBBDPBOOEAP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBBDPBOOEAP);
			}
			if (this.INNBJJFDEBD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.INNBJJFDEBD);
			}
			if (this.HMHGEDPFEBA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HMHGEDPFEBA);
			}
			if (this.JIOMBOMGDHP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIOMBOMGDHP);
			}
			if (this.JEMLCOOOBOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JEMLCOOOBOO);
			}
			if (this.KNJPGKKOEDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KNJPGKKOEDD);
			}
			if (this.FABJGCEEABG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FABJGCEEABG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00183EC8 File Offset: 0x001820C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRecordInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HEFKKIANPJE != 0U)
			{
				this.HEFKKIANPJE = other.HEFKKIANPJE;
			}
			if (other.collectionInfo_ != null)
			{
				if (this.collectionInfo_ == null)
				{
					this.CollectionInfo = new PlayerCollectionInfo();
				}
				this.CollectionInfo.MergeFrom(other.CollectionInfo);
			}
			if (other.MBBDPBOOEAP != 0U)
			{
				this.MBBDPBOOEAP = other.MBBDPBOOEAP;
			}
			if (other.INNBJJFDEBD != 0U)
			{
				this.INNBJJFDEBD = other.INNBJJFDEBD;
			}
			if (other.HMHGEDPFEBA != 0U)
			{
				this.HMHGEDPFEBA = other.HMHGEDPFEBA;
			}
			if (other.JIOMBOMGDHP != 0U)
			{
				this.JIOMBOMGDHP = other.JIOMBOMGDHP;
			}
			if (other.JEMLCOOOBOO != 0U)
			{
				this.JEMLCOOOBOO = other.JEMLCOOOBOO;
			}
			if (other.KNJPGKKOEDD != 0U)
			{
				this.KNJPGKKOEDD = other.KNJPGKKOEDD;
			}
			if (other.FABJGCEEABG != 0U)
			{
				this.FABJGCEEABG = other.FABJGCEEABG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00183FBC File Offset: 0x001821BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00183FC8 File Offset: 0x001821C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.FABJGCEEABG = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.JEMLCOOOBOO = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.HMHGEDPFEBA = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.JIOMBOMGDHP = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						if (this.collectionInfo_ == null)
						{
							this.CollectionInfo = new PlayerCollectionInfo();
						}
						input.ReadMessage(this.CollectionInfo);
						continue;
					}
					if (num == 80U)
					{
						this.HEFKKIANPJE = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.INNBJJFDEBD = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MBBDPBOOEAP = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.KNJPGKKOEDD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003862 RID: 14434
		private static readonly MessageParser<PlayerRecordInfo> _parser = new MessageParser<PlayerRecordInfo>(() => new PlayerRecordInfo());

		// Token: 0x04003863 RID: 14435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003864 RID: 14436
		public const int HEFKKIANPJEFieldNumber = 10;

		// Token: 0x04003865 RID: 14437
		private uint hEFKKIANPJE_;

		// Token: 0x04003866 RID: 14438
		public const int CollectionInfoFieldNumber = 9;

		// Token: 0x04003867 RID: 14439
		private PlayerCollectionInfo collectionInfo_;

		// Token: 0x04003868 RID: 14440
		public const int MBBDPBOOEAPFieldNumber = 13;

		// Token: 0x04003869 RID: 14441
		private uint mBBDPBOOEAP_;

		// Token: 0x0400386A RID: 14442
		public const int INNBJJFDEBDFieldNumber = 12;

		// Token: 0x0400386B RID: 14443
		private uint iNNBJJFDEBD_;

		// Token: 0x0400386C RID: 14444
		public const int HMHGEDPFEBAFieldNumber = 6;

		// Token: 0x0400386D RID: 14445
		private uint hMHGEDPFEBA_;

		// Token: 0x0400386E RID: 14446
		public const int JIOMBOMGDHPFieldNumber = 8;

		// Token: 0x0400386F RID: 14447
		private uint jIOMBOMGDHP_;

		// Token: 0x04003870 RID: 14448
		public const int JEMLCOOOBOOFieldNumber = 4;

		// Token: 0x04003871 RID: 14449
		private uint jEMLCOOOBOO_;

		// Token: 0x04003872 RID: 14450
		public const int KNJPGKKOEDDFieldNumber = 14;

		// Token: 0x04003873 RID: 14451
		private uint kNJPGKKOEDD_;

		// Token: 0x04003874 RID: 14452
		public const int FABJGCEEABGFieldNumber = 2;

		// Token: 0x04003875 RID: 14453
		private uint fABJGCEEABG_;
	}
}
