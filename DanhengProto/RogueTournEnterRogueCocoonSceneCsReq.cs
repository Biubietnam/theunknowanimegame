using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA7 RID: 4007
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterRogueCocoonSceneCsReq : IMessage<RogueTournEnterRogueCocoonSceneCsReq>, IMessage, IEquatable<RogueTournEnterRogueCocoonSceneCsReq>, IDeepCloneable<RogueTournEnterRogueCocoonSceneCsReq>, IBufferMessage
	{
		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x001DFA3B File Offset: 0x001DDC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterRogueCocoonSceneCsReq> Parser
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneCsReq._parser;
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600B287 RID: 45703 RVA: 0x001DFA42 File Offset: 0x001DDC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x001DFA54 File Offset: 0x001DDC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneCsReq.Descriptor;
			}
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x001DFA5B File Offset: 0x001DDC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneCsReq()
		{
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x001DFA70 File Offset: 0x001DDC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneCsReq(RogueTournEnterRogueCocoonSceneCsReq other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this.nEECBBDKINB_ = other.nEECBBDKINB_;
			this.difficultyLevel_ = other.difficultyLevel_;
			this.hODGFGACFKC_ = other.hODGFGACFKC_;
			this.dKBHBBLEPOP_ = other.dKBHBBLEPOP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x001DFAD5 File Offset: 0x001DDCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterRogueCocoonSceneCsReq Clone()
		{
			return new RogueTournEnterRogueCocoonSceneCsReq(this);
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x001DFADD File Offset: 0x001DDCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GDDDBPGAIEC> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600B28D RID: 45709 RVA: 0x001DFAE5 File Offset: 0x001DDCE5
		// (set) Token: 0x0600B28E RID: 45710 RVA: 0x001DFAED File Offset: 0x001DDCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NEECBBDKINB
		{
			get
			{
				return this.nEECBBDKINB_;
			}
			set
			{
				this.nEECBBDKINB_ = value;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600B28F RID: 45711 RVA: 0x001DFAF6 File Offset: 0x001DDCF6
		// (set) Token: 0x0600B290 RID: 45712 RVA: 0x001DFAFE File Offset: 0x001DDCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DifficultyLevel
		{
			get
			{
				return this.difficultyLevel_;
			}
			set
			{
				this.difficultyLevel_ = value;
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600B291 RID: 45713 RVA: 0x001DFB07 File Offset: 0x001DDD07
		// (set) Token: 0x0600B292 RID: 45714 RVA: 0x001DFB0F File Offset: 0x001DDD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HODGFGACFKC
		{
			get
			{
				return this.hODGFGACFKC_;
			}
			set
			{
				this.hODGFGACFKC_ = value;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x001DFB18 File Offset: 0x001DDD18
		// (set) Token: 0x0600B294 RID: 45716 RVA: 0x001DFB20 File Offset: 0x001DDD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DKBHBBLEPOP
		{
			get
			{
				return this.dKBHBBLEPOP_;
			}
			set
			{
				this.dKBHBBLEPOP_ = value;
			}
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x001DFB29 File Offset: 0x001DDD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterRogueCocoonSceneCsReq);
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x001DFB38 File Offset: 0x001DDD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterRogueCocoonSceneCsReq other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && this.NEECBBDKINB == other.NEECBBDKINB && this.DifficultyLevel == other.DifficultyLevel && this.HODGFGACFKC == other.HODGFGACFKC && this.DKBHBBLEPOP == other.DKBHBBLEPOP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x001DFBB8 File Offset: 0x001DDDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			if (this.NEECBBDKINB != 0U)
			{
				num ^= this.NEECBBDKINB.GetHashCode();
			}
			if (this.DifficultyLevel != 0U)
			{
				num ^= this.DifficultyLevel.GetHashCode();
			}
			if (this.HODGFGACFKC)
			{
				num ^= this.HODGFGACFKC.GetHashCode();
			}
			if (this.DKBHBBLEPOP != 0U)
			{
				num ^= this.DKBHBBLEPOP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x001DFC50 File Offset: 0x001DDE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x001DFC58 File Offset: 0x001DDE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x001DFC64 File Offset: 0x001DDE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NEECBBDKINB != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NEECBBDKINB);
			}
			this.avatarList_.WriteTo(ref output, RogueTournEnterRogueCocoonSceneCsReq._repeated_avatarList_codec);
			if (this.HODGFGACFKC)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.HODGFGACFKC);
			}
			if (this.DifficultyLevel != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DifficultyLevel);
			}
			if (this.DKBHBBLEPOP != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.DKBHBBLEPOP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x001DFD08 File Offset: 0x001DDF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(RogueTournEnterRogueCocoonSceneCsReq._repeated_avatarList_codec);
			if (this.NEECBBDKINB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NEECBBDKINB);
			}
			if (this.DifficultyLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyLevel);
			}
			if (this.HODGFGACFKC)
			{
				num += 2;
			}
			if (this.DKBHBBLEPOP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DKBHBBLEPOP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x001DFD98 File Offset: 0x001DDF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterRogueCocoonSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.NEECBBDKINB != 0U)
			{
				this.NEECBBDKINB = other.NEECBBDKINB;
			}
			if (other.DifficultyLevel != 0U)
			{
				this.DifficultyLevel = other.DifficultyLevel;
			}
			if (other.HODGFGACFKC)
			{
				this.HODGFGACFKC = other.HODGFGACFKC;
			}
			if (other.DKBHBBLEPOP != 0U)
			{
				this.DKBHBBLEPOP = other.DKBHBBLEPOP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x001DFE21 File Offset: 0x001DE021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x001DFE2C File Offset: 0x001DE02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.NEECBBDKINB = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.avatarList_.AddEntriesFrom(ref input, RogueTournEnterRogueCocoonSceneCsReq._repeated_avatarList_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HODGFGACFKC = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.DifficultyLevel = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.DKBHBBLEPOP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004889 RID: 18569
		private static readonly MessageParser<RogueTournEnterRogueCocoonSceneCsReq> _parser = new MessageParser<RogueTournEnterRogueCocoonSceneCsReq>(() => new RogueTournEnterRogueCocoonSceneCsReq());

		// Token: 0x0400488A RID: 18570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400488B RID: 18571
		public const int AvatarListFieldNumber = 4;

		// Token: 0x0400488C RID: 18572
		private static readonly FieldCodec<GDDDBPGAIEC> _repeated_avatarList_codec = FieldCodec.ForMessage<GDDDBPGAIEC>(34U, GDDDBPGAIEC.Parser);

		// Token: 0x0400488D RID: 18573
		private readonly RepeatedField<GDDDBPGAIEC> avatarList_ = new RepeatedField<GDDDBPGAIEC>();

		// Token: 0x0400488E RID: 18574
		public const int NEECBBDKINBFieldNumber = 3;

		// Token: 0x0400488F RID: 18575
		private uint nEECBBDKINB_;

		// Token: 0x04004890 RID: 18576
		public const int DifficultyLevelFieldNumber = 11;

		// Token: 0x04004891 RID: 18577
		private uint difficultyLevel_;

		// Token: 0x04004892 RID: 18578
		public const int HODGFGACFKCFieldNumber = 9;

		// Token: 0x04004893 RID: 18579
		private bool hODGFGACFKC_;

		// Token: 0x04004894 RID: 18580
		public const int DKBHBBLEPOPFieldNumber = 15;

		// Token: 0x04004895 RID: 18581
		private uint dKBHBBLEPOP_;
	}
}
