using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005EF RID: 1519
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GDLKFOJLGMG : IMessage<GDLKFOJLGMG>, IMessage, IEquatable<GDLKFOJLGMG>, IDeepCloneable<GDLKFOJLGMG>, IBufferMessage
	{
		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004435 RID: 17461 RVA: 0x000BB501 File Offset: 0x000B9701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GDLKFOJLGMG> Parser
		{
			get
			{
				return GDLKFOJLGMG._parser;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x000BB508 File Offset: 0x000B9708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GDLKFOJLGMGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x000BB51A File Offset: 0x000B971A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GDLKFOJLGMG.Descriptor;
			}
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x000BB521 File Offset: 0x000B9721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDLKFOJLGMG()
		{
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x000BB52C File Offset: 0x000B972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDLKFOJLGMG(GDLKFOJLGMG other) : this()
		{
			this.jKGBGFOPMHM_ = other.jKGBGFOPMHM_;
			this.pos_ = other.pos_;
			this.mBFKOHNGMPJ_ = other.mBFKOHNGMPJ_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000BB580 File Offset: 0x000B9780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDLKFOJLGMG Clone()
		{
			return new GDLKFOJLGMG(this);
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x000BB588 File Offset: 0x000B9788
		// (set) Token: 0x0600443C RID: 17468 RVA: 0x000BB590 File Offset: 0x000B9790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGBGFOPMHM
		{
			get
			{
				return this.jKGBGFOPMHM_;
			}
			set
			{
				this.jKGBGFOPMHM_ = value;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x000BB599 File Offset: 0x000B9799
		// (set) Token: 0x0600443E RID: 17470 RVA: 0x000BB5A1 File Offset: 0x000B97A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x000BB5AA File Offset: 0x000B97AA
		// (set) Token: 0x06004440 RID: 17472 RVA: 0x000BB5B2 File Offset: 0x000B97B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBFKOHNGMPJ
		{
			get
			{
				return this.mBFKOHNGMPJ_;
			}
			set
			{
				this.mBFKOHNGMPJ_ = value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x000BB5BB File Offset: 0x000B97BB
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x000BB5C3 File Offset: 0x000B97C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x000BB5CC File Offset: 0x000B97CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GDLKFOJLGMG);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x000BB5DC File Offset: 0x000B97DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GDLKFOJLGMG other)
		{
			return other != null && (other == this || (this.JKGBGFOPMHM == other.JKGBGFOPMHM && this.Pos == other.Pos && this.MBFKOHNGMPJ == other.MBFKOHNGMPJ && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x000BB648 File Offset: 0x000B9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JKGBGFOPMHM != 0U)
			{
				num ^= this.JKGBGFOPMHM.GetHashCode();
			}
			if (this.Pos != 0U)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.MBFKOHNGMPJ != 0U)
			{
				num ^= this.MBFKOHNGMPJ.GetHashCode();
			}
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x000BB6D2 File Offset: 0x000B98D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x000BB6DA File Offset: 0x000B98DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x000BB6E4 File Offset: 0x000B98E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Pos);
			}
			if (this.Count != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Count);
			}
			if (this.MBFKOHNGMPJ != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MBFKOHNGMPJ);
			}
			if (this.JKGBGFOPMHM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JKGBGFOPMHM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x000BB778 File Offset: 0x000B9978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JKGBGFOPMHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGBGFOPMHM);
			}
			if (this.Pos != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pos);
			}
			if (this.MBFKOHNGMPJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBFKOHNGMPJ);
			}
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x000BB800 File Offset: 0x000B9A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GDLKFOJLGMG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JKGBGFOPMHM != 0U)
			{
				this.JKGBGFOPMHM = other.JKGBGFOPMHM;
			}
			if (other.Pos != 0U)
			{
				this.Pos = other.Pos;
			}
			if (other.MBFKOHNGMPJ != 0U)
			{
				this.MBFKOHNGMPJ = other.MBFKOHNGMPJ;
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x000BB878 File Offset: 0x000B9A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x000BB884 File Offset: 0x000B9A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.Pos = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Count = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MBFKOHNGMPJ = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.JKGBGFOPMHM = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B51 RID: 6993
		private static readonly MessageParser<GDLKFOJLGMG> _parser = new MessageParser<GDLKFOJLGMG>(() => new GDLKFOJLGMG());

		// Token: 0x04001B52 RID: 6994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B53 RID: 6995
		public const int JKGBGFOPMHMFieldNumber = 15;

		// Token: 0x04001B54 RID: 6996
		private uint jKGBGFOPMHM_;

		// Token: 0x04001B55 RID: 6997
		public const int PosFieldNumber = 3;

		// Token: 0x04001B56 RID: 6998
		private uint pos_;

		// Token: 0x04001B57 RID: 6999
		public const int MBFKOHNGMPJFieldNumber = 11;

		// Token: 0x04001B58 RID: 7000
		private uint mBFKOHNGMPJ_;

		// Token: 0x04001B59 RID: 7001
		public const int CountFieldNumber = 7;

		// Token: 0x04001B5A RID: 7002
		private uint count_;
	}
}
