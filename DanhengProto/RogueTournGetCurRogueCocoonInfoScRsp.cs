using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FCB RID: 4043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetCurRogueCocoonInfoScRsp : IMessage<RogueTournGetCurRogueCocoonInfoScRsp>, IMessage, IEquatable<RogueTournGetCurRogueCocoonInfoScRsp>, IDeepCloneable<RogueTournGetCurRogueCocoonInfoScRsp>, IBufferMessage
	{
		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600B417 RID: 46103 RVA: 0x001E35D3 File Offset: 0x001E17D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetCurRogueCocoonInfoScRsp> Parser
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoScRsp._parser;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600B418 RID: 46104 RVA: 0x001E35DA File Offset: 0x001E17DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600B419 RID: 46105 RVA: 0x001E35EC File Offset: 0x001E17EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x001E35F3 File Offset: 0x001E17F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoScRsp()
		{
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x001E35FC File Offset: 0x001E17FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoScRsp(RogueTournGetCurRogueCocoonInfoScRsp other) : this()
		{
			this.dKBHBBLEPOP_ = other.dKBHBBLEPOP_;
			this.retcode_ = other.retcode_;
			this.nEECBBDKINB_ = other.nEECBBDKINB_;
			this.difficultyLevel_ = other.difficultyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x001E3650 File Offset: 0x001E1850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoScRsp Clone()
		{
			return new RogueTournGetCurRogueCocoonInfoScRsp(this);
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600B41D RID: 46109 RVA: 0x001E3658 File Offset: 0x001E1858
		// (set) Token: 0x0600B41E RID: 46110 RVA: 0x001E3660 File Offset: 0x001E1860
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

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600B41F RID: 46111 RVA: 0x001E3669 File Offset: 0x001E1869
		// (set) Token: 0x0600B420 RID: 46112 RVA: 0x001E3671 File Offset: 0x001E1871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600B421 RID: 46113 RVA: 0x001E367A File Offset: 0x001E187A
		// (set) Token: 0x0600B422 RID: 46114 RVA: 0x001E3682 File Offset: 0x001E1882
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

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600B423 RID: 46115 RVA: 0x001E368B File Offset: 0x001E188B
		// (set) Token: 0x0600B424 RID: 46116 RVA: 0x001E3693 File Offset: 0x001E1893
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

		// Token: 0x0600B425 RID: 46117 RVA: 0x001E369C File Offset: 0x001E189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetCurRogueCocoonInfoScRsp);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x001E36AC File Offset: 0x001E18AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetCurRogueCocoonInfoScRsp other)
		{
			return other != null && (other == this || (this.DKBHBBLEPOP == other.DKBHBBLEPOP && this.Retcode == other.Retcode && this.NEECBBDKINB == other.NEECBBDKINB && this.DifficultyLevel == other.DifficultyLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x001E3718 File Offset: 0x001E1918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DKBHBBLEPOP != 0U)
			{
				num ^= this.DKBHBBLEPOP.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NEECBBDKINB != 0U)
			{
				num ^= this.NEECBBDKINB.GetHashCode();
			}
			if (this.DifficultyLevel != 0U)
			{
				num ^= this.DifficultyLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x001E37A2 File Offset: 0x001E19A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x001E37AA File Offset: 0x001E19AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x001E37B4 File Offset: 0x001E19B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DifficultyLevel != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DifficultyLevel);
			}
			if (this.NEECBBDKINB != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.NEECBBDKINB);
			}
			if (this.DKBHBBLEPOP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DKBHBBLEPOP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x001E3848 File Offset: 0x001E1A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DKBHBBLEPOP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DKBHBBLEPOP);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NEECBBDKINB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NEECBBDKINB);
			}
			if (this.DifficultyLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B42C RID: 46124 RVA: 0x001E38D0 File Offset: 0x001E1AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetCurRogueCocoonInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DKBHBBLEPOP != 0U)
			{
				this.DKBHBBLEPOP = other.DKBHBBLEPOP;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NEECBBDKINB != 0U)
			{
				this.NEECBBDKINB = other.NEECBBDKINB;
			}
			if (other.DifficultyLevel != 0U)
			{
				this.DifficultyLevel = other.DifficultyLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B42D RID: 46125 RVA: 0x001E3948 File Offset: 0x001E1B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x001E3954 File Offset: 0x001E1B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.DifficultyLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.NEECBBDKINB = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.DKBHBBLEPOP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004908 RID: 18696
		private static readonly MessageParser<RogueTournGetCurRogueCocoonInfoScRsp> _parser = new MessageParser<RogueTournGetCurRogueCocoonInfoScRsp>(() => new RogueTournGetCurRogueCocoonInfoScRsp());

		// Token: 0x04004909 RID: 18697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400490A RID: 18698
		public const int DKBHBBLEPOPFieldNumber = 14;

		// Token: 0x0400490B RID: 18699
		private uint dKBHBBLEPOP_;

		// Token: 0x0400490C RID: 18700
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400490D RID: 18701
		private uint retcode_;

		// Token: 0x0400490E RID: 18702
		public const int NEECBBDKINBFieldNumber = 11;

		// Token: 0x0400490F RID: 18703
		private uint nEECBBDKINB_;

		// Token: 0x04004910 RID: 18704
		public const int DifficultyLevelFieldNumber = 8;

		// Token: 0x04004911 RID: 18705
		private uint difficultyLevel_;
	}
}
