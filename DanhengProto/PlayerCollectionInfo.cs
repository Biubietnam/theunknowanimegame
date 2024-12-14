using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB3 RID: 3251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerCollectionInfo : IMessage<PlayerCollectionInfo>, IMessage, IEquatable<PlayerCollectionInfo>, IDeepCloneable<PlayerCollectionInfo>, IBufferMessage
	{
		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x0017DCDB File Offset: 0x0017BEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerCollectionInfo> Parser
		{
			get
			{
				return PlayerCollectionInfo._parser;
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x0017DCE2 File Offset: 0x0017BEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerCollectionInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x06009088 RID: 37000 RVA: 0x0017DCF4 File Offset: 0x0017BEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCollectionInfo.Descriptor;
			}
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0017DCFB File Offset: 0x0017BEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCollectionInfo()
		{
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0017DD04 File Offset: 0x0017BF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCollectionInfo(PlayerCollectionInfo other) : this()
		{
			this.gIJPKEENIAO_ = other.gIJPKEENIAO_;
			this.oJCGAOPENDG_ = other.oJCGAOPENDG_;
			this.jLEAIIHKNJB_ = other.jLEAIIHKNJB_;
			this.hMMOBNAFHJC_ = other.hMMOBNAFHJC_;
			this.eFGAAHCDEFK_ = other.eFGAAHCDEFK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x0017DD64 File Offset: 0x0017BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCollectionInfo Clone()
		{
			return new PlayerCollectionInfo(this);
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600908C RID: 37004 RVA: 0x0017DD6C File Offset: 0x0017BF6C
		// (set) Token: 0x0600908D RID: 37005 RVA: 0x0017DD74 File Offset: 0x0017BF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GIJPKEENIAO
		{
			get
			{
				return this.gIJPKEENIAO_;
			}
			set
			{
				this.gIJPKEENIAO_ = value;
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600908E RID: 37006 RVA: 0x0017DD7D File Offset: 0x0017BF7D
		// (set) Token: 0x0600908F RID: 37007 RVA: 0x0017DD85 File Offset: 0x0017BF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJCGAOPENDG
		{
			get
			{
				return this.oJCGAOPENDG_;
			}
			set
			{
				this.oJCGAOPENDG_ = value;
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x06009090 RID: 37008 RVA: 0x0017DD8E File Offset: 0x0017BF8E
		// (set) Token: 0x06009091 RID: 37009 RVA: 0x0017DD96 File Offset: 0x0017BF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JLEAIIHKNJB
		{
			get
			{
				return this.jLEAIIHKNJB_;
			}
			set
			{
				this.jLEAIIHKNJB_ = value;
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x06009092 RID: 37010 RVA: 0x0017DD9F File Offset: 0x0017BF9F
		// (set) Token: 0x06009093 RID: 37011 RVA: 0x0017DDA7 File Offset: 0x0017BFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HMMOBNAFHJC
		{
			get
			{
				return this.hMMOBNAFHJC_;
			}
			set
			{
				this.hMMOBNAFHJC_ = value;
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06009094 RID: 37012 RVA: 0x0017DDB0 File Offset: 0x0017BFB0
		// (set) Token: 0x06009095 RID: 37013 RVA: 0x0017DDB8 File Offset: 0x0017BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EFGAAHCDEFK
		{
			get
			{
				return this.eFGAAHCDEFK_;
			}
			set
			{
				this.eFGAAHCDEFK_ = value;
			}
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x0017DDC1 File Offset: 0x0017BFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCollectionInfo);
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0017DDD0 File Offset: 0x0017BFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCollectionInfo other)
		{
			return other != null && (other == this || (this.GIJPKEENIAO == other.GIJPKEENIAO && this.OJCGAOPENDG == other.OJCGAOPENDG && this.JLEAIIHKNJB == other.JLEAIIHKNJB && this.HMMOBNAFHJC == other.HMMOBNAFHJC && this.EFGAAHCDEFK == other.EFGAAHCDEFK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0017DE4C File Offset: 0x0017C04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GIJPKEENIAO != 0U)
			{
				num ^= this.GIJPKEENIAO.GetHashCode();
			}
			if (this.OJCGAOPENDG != 0U)
			{
				num ^= this.OJCGAOPENDG.GetHashCode();
			}
			if (this.JLEAIIHKNJB != 0U)
			{
				num ^= this.JLEAIIHKNJB.GetHashCode();
			}
			if (this.HMMOBNAFHJC != 0U)
			{
				num ^= this.HMMOBNAFHJC.GetHashCode();
			}
			if (this.EFGAAHCDEFK != 0U)
			{
				num ^= this.EFGAAHCDEFK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009099 RID: 37017 RVA: 0x0017DEEF File Offset: 0x0017C0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600909A RID: 37018 RVA: 0x0017DEF7 File Offset: 0x0017C0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600909B RID: 37019 RVA: 0x0017DF00 File Offset: 0x0017C100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HMMOBNAFHJC != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.HMMOBNAFHJC);
			}
			if (this.OJCGAOPENDG != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OJCGAOPENDG);
			}
			if (this.GIJPKEENIAO != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GIJPKEENIAO);
			}
			if (this.EFGAAHCDEFK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EFGAAHCDEFK);
			}
			if (this.JLEAIIHKNJB != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JLEAIIHKNJB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x0017DFB0 File Offset: 0x0017C1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GIJPKEENIAO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GIJPKEENIAO);
			}
			if (this.OJCGAOPENDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJCGAOPENDG);
			}
			if (this.JLEAIIHKNJB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JLEAIIHKNJB);
			}
			if (this.HMMOBNAFHJC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HMMOBNAFHJC);
			}
			if (this.EFGAAHCDEFK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EFGAAHCDEFK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0017E050 File Offset: 0x0017C250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerCollectionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GIJPKEENIAO != 0U)
			{
				this.GIJPKEENIAO = other.GIJPKEENIAO;
			}
			if (other.OJCGAOPENDG != 0U)
			{
				this.OJCGAOPENDG = other.OJCGAOPENDG;
			}
			if (other.JLEAIIHKNJB != 0U)
			{
				this.JLEAIIHKNJB = other.JLEAIIHKNJB;
			}
			if (other.HMMOBNAFHJC != 0U)
			{
				this.HMMOBNAFHJC = other.HMMOBNAFHJC;
			}
			if (other.EFGAAHCDEFK != 0U)
			{
				this.EFGAAHCDEFK = other.EFGAAHCDEFK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x0017E0DC File Offset: 0x0017C2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x0017E0E8 File Offset: 0x0017C2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.HMMOBNAFHJC = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.OJCGAOPENDG = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.GIJPKEENIAO = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EFGAAHCDEFK = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.JLEAIIHKNJB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003790 RID: 14224
		private static readonly MessageParser<PlayerCollectionInfo> _parser = new MessageParser<PlayerCollectionInfo>(() => new PlayerCollectionInfo());

		// Token: 0x04003791 RID: 14225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003792 RID: 14226
		public const int GIJPKEENIAOFieldNumber = 13;

		// Token: 0x04003793 RID: 14227
		private uint gIJPKEENIAO_;

		// Token: 0x04003794 RID: 14228
		public const int OJCGAOPENDGFieldNumber = 8;

		// Token: 0x04003795 RID: 14229
		private uint oJCGAOPENDG_;

		// Token: 0x04003796 RID: 14230
		public const int JLEAIIHKNJBFieldNumber = 15;

		// Token: 0x04003797 RID: 14231
		private uint jLEAIIHKNJB_;

		// Token: 0x04003798 RID: 14232
		public const int HMMOBNAFHJCFieldNumber = 7;

		// Token: 0x04003799 RID: 14233
		private uint hMMOBNAFHJC_;

		// Token: 0x0400379A RID: 14234
		public const int EFGAAHCDEFKFieldNumber = 14;

		// Token: 0x0400379B RID: 14235
		private uint eFGAAHCDEFK_;
	}
}
